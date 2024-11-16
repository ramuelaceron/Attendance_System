using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Attendance_System
{
    internal class Report
    {
        static List<string> Status = new List<string>();
        public static void AttendanceReport(int menu, DateTime time)
        {
            Status.Add(ReportFunction.BN1CalStatus(time));
            Status.Add(ReportFunction.BN1CwtsStatus(time));
            Status.Add(ReportFunction.BN1PhysicsStatus(time));
            Status.Add(ReportFunction.BN1PathfitStatus(time));
            Status.Add(ReportFunction.BN1PurposiveStatus(time));
            Status.Add(ReportFunction.BN1DiscreteStatus(time));
            Status.Add(ReportFunction.BN1StatsStatus(time));
            Status.Add(ReportFunction.BN1DProgrammingStatus(time));
            Status.Add(ReportFunction.BN1DHardwareStatus(time));
            Status.Add(ReportFunction.BN2CalStatus(time));
            Status.Add(ReportFunction.BN2CwtsStatus(time));
            Status.Add(ReportFunction.BN2PhysicsStatus(time));
            Status.Add(ReportFunction.BN2PathfitStatus(time));
            Status.Add(ReportFunction.BN2PurposiveStatus(time));
            Status.Add(ReportFunction.BN2DiscreteStatus(time));
            Status.Add(ReportFunction.BN2StatsStatus(time));
            Status.Add(ReportFunction.BN2DProgrammingStatus(time));
            Status.Add(ReportFunction.BN2DHardwareStatus(time));

            DataTable table = new DataTable("MyDataTable");
            table.Columns.Add("Subjects", typeof(string));
            table.Columns.Add("2024-00001-BN-0", typeof(string));
            table.Columns.Add("2024-00002-BN-0", typeof(string));


            // Add some data rows
            table.Rows.Add("Calculus 2", Status[0], Status[9]);
            table.Rows.Add("CWTS 2", Status[1], Status[10]);
            table.Rows.Add("Physics", Status[2], Status[11]);
            table.Rows.Add("PATHFIT 2", Status[3], Status[12]);
            table.Rows.Add("Purposive Communication", Status[4], Status[13]);
            table.Rows.Add("Discrete Mathematics", Status[5], Status[14]);
            table.Rows.Add("Engineering Data Analysis", Status[6], Status[15]);
            table.Rows.Add("Object Oriented Programming", Status[7], Status[16]);
            table.Rows.Add("Computer Hardware Fundamentals", Status[8], Status[17]);


            Console.WriteLine(" ********************* Student Attendance Report ********************* ");
            Console.WriteLine("-" + new string('-', 70));
            Console.Write("{0, -30} {1, -22} {2, -20}", "Subjects", "2024-00001-BN-0", "2024-00002-BN-0");
            Console.WriteLine("\n-" + new string('-', 70));

            foreach (DataRow row in table.Rows)
            {
                Console.WriteLine("{0, -35} {1, -20} {2, -20}",
                        row["Subjects"], row["2024-00001-BN-0"], row["2024-00002-BN-0"]);
            }
            Console.WriteLine("-" + new string('-', 70));
        }
    }
}
