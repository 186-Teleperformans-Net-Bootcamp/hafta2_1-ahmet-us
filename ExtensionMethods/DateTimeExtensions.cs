using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public static class DateTimeExtensions
    {

        public static void Ago(this DateTime datetime)
        {


            var timeDifference = DateTime.Now.Subtract(datetime);
            string daysDifference = timeDifference.Days != 0 ? $"{timeDifference.Days} days" : "";
            string hoursDifference = timeDifference.Hours != 0 ? $"{timeDifference.Hours} hours" : "";
            string minutesDifference = timeDifference.Minutes != 0 ? $"{timeDifference.Minutes} minutes" : "";
            string secondsDifference = timeDifference.Seconds != 0 ? $"{timeDifference.Seconds} seconds" : "";

            //string result = timeDifference.ToString();
            var result = $"{daysDifference} {hoursDifference} {minutesDifference} {secondsDifference} ago";
            Console.WriteLine(result);
        }
    }
}
