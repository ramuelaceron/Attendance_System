using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Attendance_System
{
    internal class ReportFunction
    {
        public static string BN1CalStatus(DateTime time)
        {
            int menu = 0;
            DateTime calTime = Attendance.BN1Cal2();
            string calStatus = AttendanceFunction.StudentStatus(calTime, menu);

            return calStatus;
        }
        public static string BN1CwtsStatus(DateTime time)
        {
            int menu = 1;
            DateTime cwtsTime = Attendance.BN1Cwts2();
            string cwtsStatus = AttendanceFunction.StudentStatus(cwtsTime, menu);

            return cwtsStatus;
        }
        public static string BN1PhysicsStatus(DateTime time)
        {
            int menu = 2;
            DateTime physicsTime = Attendance.BN1Physics();
            string physicsStatus = AttendanceFunction.StudentStatus(physicsTime, menu);

            return physicsStatus;
        }
        public static string BN1PathfitStatus(DateTime time)
        {
            int menu = 3;
            DateTime pathfitTime = Attendance.BN1Pathfit();
            string pathfitStatus = AttendanceFunction.StudentStatus(pathfitTime, menu);

            return pathfitStatus;
        }
        public static string BN1PurposiveStatus(DateTime time)
        {
            int menu = 4;
            DateTime purposiveTime = Attendance.BN1Purposive();
            string mathStatus = AttendanceFunction.StudentStatus(purposiveTime, menu);

            return mathStatus;
        }
        public static string BN1DiscreteStatus(DateTime time)
        {
            int menu = 5;
            DateTime scienceTime = Attendance.BN1Discrete();
            string scienceStatus = AttendanceFunction.StudentStatus(scienceTime, menu);

            return scienceStatus;
        }
        public static string BN1StatsStatus(DateTime time)
        {
            int menu = 6;
            DateTime statsTime = Attendance.BN1Stats();
            string statsStatus = AttendanceFunction.StudentStatus(statsTime, menu);

            return statsStatus;
        }
        public static string BN1DProgrammingStatus(DateTime time)
        {
            int menu = 7;
            DateTime programmingTime = Attendance.BN1Programming();
            string programmingStatus = AttendanceFunction.StudentStatus(programmingTime, menu);

            return programmingStatus;
        }
        public static string BN1DHardwareStatus(DateTime time)
        {
            int menu = 8;
            DateTime hardwareTime = Attendance.BN1Hardware();
            string hardwareStatus = AttendanceFunction.StudentStatus(hardwareTime, menu);

            return hardwareStatus;
        }
        public static string BN2CalStatus(DateTime time)
        {
            int menu = 0;
            DateTime calTime = Attendance.BN2Cal2();
            string calStatus = AttendanceFunction.StudentStatus(calTime, menu);

            return calStatus;
        }
        public static string BN2CwtsStatus(DateTime time)
        {
            int menu = 1;
            DateTime cwtsTime = Attendance.BN2Cwts2();
            string cwtsStatus = AttendanceFunction.StudentStatus(cwtsTime, menu);

            return cwtsStatus;
        }
        public static string BN2PhysicsStatus(DateTime time)
        {
            int menu = 2;
            DateTime physicsTime = Attendance.BN2Physics();
            string physicsStatus = AttendanceFunction.StudentStatus(physicsTime, menu);

            return physicsStatus;
        }
        public static string BN2PathfitStatus(DateTime time)
        {
            int menu = 3;
            DateTime pathfitTime = Attendance.BN2Pathfit();
            string pathfitStatus = AttendanceFunction.StudentStatus(pathfitTime, menu);

            return pathfitStatus;
        }
        public static string BN2PurposiveStatus(DateTime time)
        {
            int menu = 4;
            DateTime purposiveTime = Attendance.BN2Purposive();
            string purposiveStatus = AttendanceFunction.StudentStatus(purposiveTime, menu);

            return purposiveStatus;
        }
        public static string BN2DiscreteStatus(DateTime time)
        {
            int menu = 5;
            DateTime discreteTime = Attendance.BN2Discrete();
            string discreteStatus = AttendanceFunction.StudentStatus(discreteTime, menu);

            return discreteStatus;
        }
        public static string BN2StatsStatus(DateTime time)
        {
            int menu = 6;
            DateTime statsTime = Attendance.BN2Stats();
            string statsStatus = AttendanceFunction.StudentStatus(statsTime, menu);

            return statsStatus;
        }
        public static string BN2DProgrammingStatus(DateTime time)
        {
            int menu = 7;
            DateTime programmingTime = Attendance.BN2Programming();
            string programmingStatus = AttendanceFunction.StudentStatus(programmingTime, menu);

            return programmingStatus;
        }
        public static string BN2DHardwareStatus(DateTime time)
        {
            int menu = 8;
            DateTime hardwareTime = Attendance.BN2Hardware();
            string hardwareStatus = AttendanceFunction.StudentStatus(hardwareTime, menu);

            return hardwareStatus;
        }
    }
}
