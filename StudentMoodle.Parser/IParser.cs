using System;
using System.Collections.Generic;

namespace StudentMoodle.Parser
{
    internal interface IParser
    {
        Uri GenerateCoursePageLinkFromName(string courseName);

        List<string> GetCourseNotesDownloadLinksById(int courseId);

        IEnumerable<Uri> GetCourseNotesDownloadLinksByName(string courseName);

        IEnumerable<CourseCreator> GetCoursesData();

        IEnumerable<string> GetHtmlOfTagContainingKeyword(string tagName, string keyword);

        Uri GetProfileLink();

        void NavigatePage(Uri linkToavigate);
    }
}