using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AstroTest.Pages
{
    class DeviceInfo
    {

        public string siteName = "Amazon";
        public string productName { get; set; }
        public string price { get; set; }
        public string productUrl { get; set; }

        public static explicit operator DeviceInfo(string v)
        {
            throw new NotImplementedException();
        }
    }
}
