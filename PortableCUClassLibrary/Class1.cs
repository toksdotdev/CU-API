using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using v = System.Net;

namespace PortableCUClassLibrary
{
    public class Login
    {
        public Login()
        {
            v.WebRequest k = v.WebRequest.CreateHttp(new Uri("10.0.0.32"));
        }
    }

    public class DataExtractor
    {
    }
}