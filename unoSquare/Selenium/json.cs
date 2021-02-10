using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace unoSquare.Selenium
{
    public class Search
    {
        public string url { get; set; }
        public string env { get; set; }
        public string search1 { get; set; }
        public string search2 { get; set; }
    }

    public class Example
    {
        public IList<Search> searches { get; set; }
    }


    public class Startup
    {
        private IConfiguration _config;

        public Startup(IConfiguration config)
        {
            _config = config;
        }     
    }

}
