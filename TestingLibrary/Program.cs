using PortableCUClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestingLibrary
{
    internal class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            //WebRequest k = System.Net.WebRequest.CreateHttp(new Uri("http://10.0.3.32"));
            //var a = k.GetResponse();
            //byte[] buffer = new byte[1000];
            //var responseStream = a.GetResponseStream();
            //if (responseStream != null) Console.WriteLine(responseStream.Read(buffer, 0, 250).);
            Console.ReadLine();
        }

        private const string COURSE_LINK_TEMPLATE = "/course/view.php?id=";

        private const string RESOURCES_LINK_TEMPLATE = "/mod/resource/view.php?id=";
        private const string USER_PROFILE_LINK_TEMPLATE = "/user/profile.php?id=";

        private static readonly WebBrowser WebBrowser = new WebBrowser();
        private string _serverName;

        /// <summary>
        /// Create the API Object
        /// </summary>
        public Program()
        {
            WebBrowser.Navigated += _webBrowser_Navigated;
        }

        /// <summary>
        /// Generates the course page link of a particular <code>course</code>
        /// </summary>
        /// <param name="courseName">Name of course to generate page id for</param>
        /// <returns>Uri of the <code>courseName</code> general page</returns>
        public Uri GenerateCoursePageLinkFromName(string courseName)
        {
            return new Uri(string.Format("{0}{1}{2}",
                _serverName,
                COURSE_LINK_TEMPLATE,
                GetCoursesData().Where(cd => cd.Name.Equals(courseName))));
        }

        /// <summary>
        /// Generates a valid
        /// </summary>
        /// <param name="courseId"></param>
        public void GetCourseNotesDownloadLinksById(int courseId)
        {
            //navigate to the course page
            NavigatePage(
                    new Uri(
                        string.Format("{0}{1}{2}",
                            WebBrowser.Url.Host,
                            RESOURCES_LINK_TEMPLATE,
                            courseId
                        )));

            GetHtmlAttributeDataCollectionFromString("a", "href", RESOURCES_LINK_TEMPLATE);
        }

        /// <summary>
        /// Retrieves all the course material download link for a particular course name
        /// </summary>
        /// <param name="courseName">Course for which lecture contants are retrieved</param>
        /// <returns>Collection of course material download links for a specific course</returns>
        public IEnumerable<Uri> GetCourseNotesDownloadLinksByName(string courseName)
        {
            var course = GetCoursesData().FirstOrDefault(cd => cd.Name.Equals(courseName));

            //navigate to the course page
            if (course != null)
                NavigatePage(
                    new Uri(
                        string.Format("{0}{1}{2}",
                            WebBrowser.Url.Host,
                            RESOURCES_LINK_TEMPLATE,
                            course.Id
                        )));

            return GetHtmlAttributeDataCollectionFromString("a", "href", RESOURCES_LINK_TEMPLATE).Cast<Uri>();
        }

        /// <summary>
        /// Gets the list of all the courses data {id and name}
        /// </summary>
        /// <returns>List of all courses Id</returns>
        private static IEnumerable<Course> GetCoursesData()
        {
            //Navigate to user profile page
            NavigatePage(GetProfileLink());

            //Get all the course link
            var coursesLinks = GetHtmlAttributeDataCollectionFromString("a", "href", "&amp;course");

            //get course id from profile link for each course
            var coursesId = coursesLinks.Select(text => Convert.ToInt32(text.Split(';')[1].Split('=')[1])).ToList();

            //get course name and creates a an object containing full course details
            var coursesData = (from id in coursesId
                               let data = GetHtmlOfTagContainingKeyword(WebBrowser.Document, "a", id.ToString()).FirstOrDefault()
                               where data != null
                               select new Course
                               {
                                   Id = id,
                                   Name = data.Substring(data.IndexOf("\">", StringComparison.Ordinal) + 2).Split('-')[0]
                               }).ToList();

            return coursesData;
        }

        /// <summary>
        ///Get the html attribute data that contains the specified search string from web document
        /// </summary>
        /// <param name="tagName">tag to extract data from</param>
        /// <param name="attribute">Attribute to get data </param>
        /// <param name="searchString"></param>
        /// <returns></returns>
        private static List<string> GetHtmlAttributeDataCollectionFromString(
            string tagName, string attribute, string searchString)
        {
            var attributeDataCollection = GetHtmlAttributesFromTag(tagName, attribute);

            return attributeDataCollection.Where(data => data.Contains(searchString)).ToList();
        }

        /// <summary>
        ///Get the attribute data collection from a given tag
        /// </summary>
        /// <param name="tagName">Tag to extract data from</param>
        /// <param name="attribute">Attribute to get data</param>
        /// <returns>Gets the data of a particular attribute from the given tag</returns>
        private static IEnumerable<string> GetHtmlAttributesFromTag(
            string tagName, string attribute = "href")
        {
            if (WebBrowser.Document == null) return null;

            var add = WebBrowser.Document.GetElementsByTagName(tagName);

            return (from HtmlElement element in add select element.GetAttribute(attribute)).ToList();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="document"></param>
        /// <param name="tagName"></param>
        /// <param name="keyword"></param>
        /// <returns></returns>
        private static IEnumerable<string> GetHtmlOfTagContainingKeyword(
            HtmlDocument document, string tagName, string keyword)
        {
            var collection = document.GetElementsByTagName(tagName);

            return (from object htmlElement in collection
                    where htmlElement.ToString().Contains(keyword)
                    select htmlElement.ToString()).ToList();
        }

        /// <summary>
        /// Gets profile link from 10.0.0.32 :to go to profile page
        /// </summary>
        /// <returns>User profile page url</returns>
        private static Uri GetProfileLink()
        {
            var link = GetHtmlAttributeDataCollectionFromString("a", "href", USER_PROFILE_LINK_TEMPLATE);

            return new Uri(link[0]);
        }

        private static void NavigatePage(Uri linkToavigate)
        {
            if (!WebBrowser.Url.Equals(linkToavigate))
                WebBrowser.Navigate(linkToavigate);
        }

        private void _webBrowser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            _serverName = e.Url.Host;
        }

        /// <summary>
        /// Gets the course Id for a particular course
        /// </summary>
        /// <param name="courseName">ame of course to retrieve Id for</param>
        /// <returns>Id of <code>courseName</code></returns>
        private int GetCourseId(string courseName)
        {
            return (from course in GetCoursesData()
                    where course.Name.Equals(courseName)
                    select course.Id).FirstOrDefault();
        }
    }
}