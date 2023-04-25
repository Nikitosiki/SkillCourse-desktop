using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillCourse.handlers
{
    public static class DateHandler
    {
        public static string GetTimeDifferenceString(DateTime lastLogin)
        {
            return GetTimeDifferenceString(DateTime.Now - lastLogin);
        }

        public static string GetTimeDifferenceString(TimeSpan timeDifference)
        {
            int days = timeDifference.Days;
            int hours = timeDifference.Hours;
            int minutes = timeDifference.Minutes;

            //string result = "Last seen ";
            string result;
            if (days > 30)
            {
                result = "ago";
                return result;
            }
            if (days > 0)
            {
                result = $"{days} {(days == 1 ? "day" : "days")} ";
                result += $"{hours} {(hours == 1 ? "hour" : "hours")} ";
                return result;
            }
            if (hours > 0)
            {
                result = $"{hours} {(hours == 1 ? "hour" : "hours")} ";
                result += $"{minutes} {(minutes == 1 ? "minute" : "minutes")} ";
                return result;
            }
            if (minutes > 5)
            {
                result = $"{minutes} {(minutes == 1 ? "minute" : "minutes")} ";
                return result;
            }
            else
            {
                result = "just now";
            }

            return result;
        }
    }
}
