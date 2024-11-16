using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Attendance_System
{
    internal class Menu
    {
        static List<string> Subject = new List<string>();
        private static void UsersSubjects()
        {
            Subject.Add("Calculus 2");
            Subject.Add("CWTS 2");
            Subject.Add("Physics");
            Subject.Add("Pathfit 2");
            Subject.Add("Purposive Communication");
            Subject.Add("Discrete Mathematics");
            Subject.Add("Engineering Data Analysis");
            Subject.Add("Object Oriented Programming");
            Subject.Add("Computer Hardware Fundamentals");
        }
        public static void Show(string user, string day)
        {
            UsersSubjects();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Select actions below");
            if (day == "wednesday")
            {
                for (int y = 0; y < 2; y++)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"  Enter {y} to select {Subject[y]} for attendance");
                }
                for (int X = 0; X < 2; X++)
                {
                    int selectedMenu = InputMenu();
                    Attendance.TimeStorage(selectedMenu);
                }
            }
            else if (day == "thursday")
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"  Enter {2} to select {Subject[2]} for attendance");
                int selectedMenu = InputMenu();
                Attendance.TimeStorage(selectedMenu);
            }
            else if (day == "friday")
            {
                for (int a = 3; a < 7; a++)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"  Enter {a} to select {Subject[a]} for attendance");
                }
                for (int X = 0; X < 4; X++)
                {
                    int selectedMenu = InputMenu();
                    Attendance.TimeStorage(selectedMenu);
                }
            }
            else if (day == "saturday")
            {
                for (int b = 7; b < 9; b++)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"  Enter {b} to select {Subject[b]} for attendance");
                }
                for (int X = 0; X < 2; X++)
                {
                    int selectedMenu = InputMenu();
                    Attendance.TimeStorage(selectedMenu);
                }
            }
            else
            {
                Console.WriteLine("There are no subjects scheduled");
            }
        }
        public static int InputMenu()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\nInput menu to select: ");
            int selectedMenu = Convert.ToInt32(Console.ReadLine());

            return selectedMenu;
        }
    }
}
