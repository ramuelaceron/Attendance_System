using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Attendance_System
{
    internal class AttendanceFunction
    {
        static List<DateTime> StartTime = new List<DateTime>();
        static List<DateTime> EndTime = new List<DateTime>();
        public static void ScheduleTime()
        {
            StartTime.Add(DateTime.Parse("10:30:00 am"));
            StartTime.Add(DateTime.Parse("14:00:00 pm"));
            StartTime.Add(DateTime.Parse("14:30:00 pm"));
            StartTime.Add(DateTime.Parse("09:00:00 am"));
            StartTime.Add(DateTime.Parse("11:00:00 am"));
            StartTime.Add(DateTime.Parse("14:00:00 pm"));
            StartTime.Add(DateTime.Parse("17:00:00 pm"));
            StartTime.Add(DateTime.Parse("08:00:00 am"));
            StartTime.Add(DateTime.Parse("14:00:00 pm"));

            EndTime.Add(DateTime.Parse("13:30:00 pm"));
            EndTime.Add(DateTime.Parse("17:00:00 pm"));
            EndTime.Add(DateTime.Parse("16:00:00 pm"));
            EndTime.Add(DateTime.Parse("11:00:00 am"));
            EndTime.Add(DateTime.Parse("13:00:00 pm"));
            EndTime.Add(DateTime.Parse("17:00:00 pm"));
            EndTime.Add(DateTime.Parse("20:00:00 pm"));
            EndTime.Add(DateTime.Parse("13:00:00 pm"));
            EndTime.Add(DateTime.Parse("20:00:00 pm"));
        }

        public static string StudentStatus(DateTime time, int i)
        {
            ScheduleTime();

            string status = "";
            if (time > EndTime[i])
            {
                Console.ForegroundColor = ConsoleColor.Red;
                status = "Absent";
            }
            else if (time > StartTime[i] && time < EndTime[i])
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                status = "Late";
            }
            else if (time <= StartTime[i])
            {
                Console.ForegroundColor = ConsoleColor.Green;
                status = "Present";
            }
            return status;
        }
    }
}
