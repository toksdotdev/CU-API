using System.Net;
using StudentMoodle.Parser;

namespace StudentMoodle.Watcher
{
    public class MoodleWatcher
    {
        private readonly MoodleParser _parser;

        public MoodleWatcher(Cookie userCookie)
        {
            _parser = new MoodleParser();

            MoodleParser.SetCookie(userCookie);
        }

        public MoodleWatcher(CookieCollection userCookies)
        {
            _parser = new MoodleParser();

            MoodleParser.SetCookie(userCookies);
        }

        public void Watch()
        {
            //run cron job
        }
    }
}