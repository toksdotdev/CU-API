using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using HtmlDocument = System.Windows.Forms.HtmlDocument;

namespace Notify.Classes
{
    internal class TestingClass
    {
        //private const string HOST = "10.0.0.32";
        private bool htmlDownloaded = true;

        #region VARIABLE DECLARATION

        private const string COURSE_LINK_TEMPLATE = "/course/view.php?id=";

        private const string RESOURCES_LINK_TEMPLATE = "/mod/resource/view.php?id=";
        private const string USER_PROFILE_LINK_TEMPLATE = "/user/profile.php?id=";

        public readonly WebBrowser Browser;
        private string _serverName;

        #endregion VARIABLE DECLARATION

        /// <summary>
        /// Create the API Object
        /// </summary>
        public TestingClass()
        {
            Browser = new WebBrowser();

            Browser.Navigated += _webBrowser_Navigated;
            Browser.DocumentCompleted += Browser_DocumentCompleted;
            Browser.Navigating += Browser_Navigating;
            InternetSetCookie("http://10.0.3.32", "MoodleSession", "29n3fh832cvrs0bqve3qhhsia5");
            InternetSetCookie("http://10.0.3.32", "MOODLEID1", "%2507%2522%25CC%25E0_%25F3%25D5%25DF%25FDpX%25E4l%2519%2525%2521p%2508");
        }

        [DllImport("wininet.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool InternetSetCookie(string url, string name, string data);

        private void Browser_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            htmlDownloaded = false;
        }

        private void Browser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            htmlDownloaded = true;
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
                            Browser.Url.Host,
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
                            Browser.Url.Host,
                            RESOURCES_LINK_TEMPLATE,
                            course.Id
                        )));

            return GetHtmlAttributeDataCollectionFromString("a", "href", RESOURCES_LINK_TEMPLATE).Cast<Uri>();
        }

        /// <summary>
        /// Gets the list of all the courses data {id and name}
        /// </summary>
        /// <returns>List of all courses Id</returns>
        public IEnumerable<Course> GetCoursesData()
        {
            //Navigate to user profile page

            var profileLink = GetProfileLink();

            Browser.Navigate(profileLink);

            var coursesData = new List<Course>();

            while (htmlDownloaded)
            {
                //Get all the course link
                var coursesLinks = GetHtmlAttributeDataCollectionFromString("a", "href", "&amp;course");

                string link = "";

                foreach (var coursesLink in coursesLinks)
                {
                    link += coursesLink + "\n";
                }

                MessageBox.Show(link);

                //get course id from profile link for each course
                var coursesId = coursesLinks.Select(text => Convert.ToInt32(text.Split(';')[1].Split('=')[1])).ToList();

                string dd = "";
                foreach (var id in coursesId)
                {
                    var data = GetHtmlOfTagContainingKeyword("a", "&amp;course=" + id).FirstOrDefault();
                    if (data != null)
                        coursesData.Add(
                            new Course(id)
                            {
                                Name = data.Split('-')[0].Trim(),
                                Id = id
                            });
                    dd += data.Split('-')[0].Trim() + "\n";
                }
                MessageBox.Show(dd);
                break;
            }

            return coursesData;
        }

        /// <summary>
        ///Get the html attribute data that contains the specified search string from web document
        /// </summary>
        /// <param name="tagName">tag to extract data from</param>
        /// <param name="attribute">Attribute to get data </param>
        /// <param name="searchString"></param>
        /// <returns></returns>
        private List<string> GetHtmlAttributeDataCollectionFromString(
            string tagName, string attribute, string searchString)
        {
            var attributeDataCollection = GetHtmlAttributeFromTag(tagName, attribute);

            return attributeDataCollection.Where(data => data.Contains(searchString)
                && !data.Contains(searchString + "=1")).ToList();
        }

        /// <summary>
        ///Get the attribute data collection from a given tag
        /// </summary>
        /// <param name="tagName">Tag to extract data from</param>
        /// <param name="attribute">Attribute to get data</param>
        /// <returns>Gets the html of particular attribute from the given tag</returns>
        private IEnumerable<string> GetHtmlAttributeFromTag(
            string tagName, string attribute = "href")
        {
            if (Browser.Document == null) return null;

            var doc = new HtmlAgilityPack.HtmlDocument();
            var documentBody = Browser.Document.Body;

            if (documentBody != null) doc.Load(new StringReader(documentBody.OuterHtml));

            var hrefList = doc.DocumentNode.SelectNodes("//" + tagName)
                              .Select(p => p.GetAttributeValue(attribute, "not found"))
                              .ToList();

            return hrefList;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="tagName"></param>
        /// <param name="keyword"></param>
        /// <returns></returns>
        private IEnumerable<string> GetHtmlOfTagContainingKeyword(string tagName, string keyword)
        {
            if (Browser.Document == null) return null;

            var doc = new HtmlAgilityPack.HtmlDocument();
            var documentBody = Browser.Document.Body;

            if (documentBody != null) doc.Load(new StringReader(documentBody.OuterHtml));

            var hrefList = doc.DocumentNode.SelectNodes("//" + tagName)
                              .Where(p => p.GetAttributeValue("href", "not found").Contains(keyword))
                              .Select(cd => cd.InnerHtml)
                              .ToList();

            return hrefList;
        }

        /// <summary>
        /// Gets profile link from 10.0.0.32 :to go to profile page
        /// </summary>
        /// <returns>User profile page url</returns>
        public Uri GetProfileLink()
        {
            var link = GetHtmlAttributeDataCollectionFromString("a", "href", USER_PROFILE_LINK_TEMPLATE);

            return new Uri(link[0]);
        }

        /// <summary>
        /// Navigate to new page, but makes sure browser doesnt navigate to page that is already open
        /// </summary>
        /// <param name="linkToavigate">ink to navigate to</param>
        public void NavigatePage(Uri linkToavigate)
        {
            //if (Browser != null && !Browser.Url.Equals(null))
            Browser.Navigate(linkToavigate);
        }

        /// <summary>
        /// Web browser has successfully navigated to new page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _webBrowser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            _serverName = e.Url.Host;

            //MessageBox.Show(Browser.DocumentText);
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