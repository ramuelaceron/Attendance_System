using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Attendance_System
{
    internal class Attendance
    {
        static List<DateTime> userTime = new List<DateTime>();
        public static void TimeStorage(int menu)
        {
            Console.Write("Enter Arriving Time (HH:MM): ");
            DateTime time = DateTime.Parse(Console.ReadLine());

            while (true)
            {
                switch (menu)
                {
                    case 0:
                        userTime.Add(time);
                        break;
                    case 1:
                        userTime.Add(time);
                        break;
                    case 2:
                        userTime.Add(time);
                        break;
                    case 3:
                        userTime.Add(time);
                        break;
                    case 4:
                        userTime.Add(time);
                        break;
                    case 5:
                        userTime.Add(time);
                        break;
                    case 6:
                        userTime.Add(time);
                        break;
                    case 7:
                        userTime.Add(time);
                        break;
                    case 8:
                        userTime.Add(time);
                        break;
                    default:
                        break;
                }
                Console.WriteLine($"Data added successfully!");

                string result = AttendanceFunction.StudentStatus(time, menu);
                Console.WriteLine("\t\t\t\t\t\tStatus: " + result);

                if (userTime.Count == 18)
                {
                    Console.ReadLine();
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n\t\t\t\t\t\tCollected User Data:");

                    // Loop through the list and print each data point
                    foreach (DateTime data in userTime)
                    {
                        Console.WriteLine("\t\t\t\t\t\t" + data);
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Press Enter to see Attendance Report, Input N/n if not: ");
                    string userchoice = Console.ReadLine();

                    if (userchoice == "N" || userchoice == "n")
                    {
                        Console.WriteLine("Thank you!");
                    }
                    else
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.White;
                        Report.AttendanceReport(menu, time);
                        break;
                    }
                }
                else
                {
                    break;
                }
            }
        }

        public static DateTime BN1Cal2()
        {
            DateTime calTime = userTime[0];
            return calTime;
        }
        public static DateTime BN1Cwts2()
        {
            DateTime cwtsTime = userTime[1];
            return cwtsTime;
        }
        public static DateTime BN2Cal2()
        {
            DateTime calTime = userTime[2];
            return calTime;
        }
        public static DateTime BN2Cwts2()
        {
            DateTime cwtsTime = userTime[3];
            return cwtsTime;
        }
        public static DateTime BN1Physics()
        {
            DateTime physicsTime = userTime[4];
            return physicsTime;
        }
        public static DateTime BN2Physics()
        {
            DateTime physicsTime = userTime[5];
            return physicsTime;
        }
        public static DateTime BN1Pathfit()
        {
            DateTime pathfitTime = userTime[6];
            return pathfitTime;
        }
        public static DateTime BN1Purposive()
        {
            DateTime puposiveTime = userTime[7];
            return puposiveTime;
        }
        public static DateTime BN1Discrete()
        {
            DateTime discreteTime = userTime[8];
            return discreteTime;
        }
        public static DateTime BN1Stats()
        {
            DateTime statsTime = userTime[9];
            return statsTime;
        }
        public static DateTime BN2Pathfit()
        {
            DateTime pathfitTime = userTime[10];
            return pathfitTime;
        }
        public static DateTime BN2Purposive()
        {
            DateTime puposiveTime = userTime[11];
            return puposiveTime;
        }
        public static DateTime BN2Discrete()
        {
            DateTime discreteTime = userTime[12];
            return discreteTime;
        }
        public static DateTime BN2Stats()
        {
            DateTime statsTime = userTime[13];
            return statsTime;
        }
        public static DateTime BN1Programming()
        {
            DateTime programmingTime = userTime[14];
            return programmingTime;
        }
        public static DateTime BN1Hardware()
        {
            DateTime hardwareTime = userTime[15];
            return hardwareTime;
        }
        public static DateTime BN2Programming()
        {
            DateTime programmingTime = userTime[16];
            return programmingTime;
        }
        public static DateTime BN2Hardware()
        {
            DateTime hardwareTime = userTime[17];
            return hardwareTime;
        }
    }
}
