using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvgReviewByCountry
{
    public static class IpAddressResolver
    {
        //Dummy IP resolver method, simulates taking an ip and returning what country it's from
        public static string Resolve(string ipAddress)
        {
            if (ipAddress == "123.123.123.123")
                return "Germany";
            else if (ipAddress == "123.123.123.124")
                return "United States";
            return "";
        }
    }
}
