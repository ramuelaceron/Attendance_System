namespace Student_Attendance_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int a = 0; a < 4; a++)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(".________________________________________________________________.");
                Console.WriteLine("|                                                                |");
                Console.WriteLine("| ************* BSCPE 1-1 STUDENT ATTENDANCE SYSTEM ************ |");
                Console.WriteLine("| SCHEDULE:                                                      |");
                Console.WriteLine("|     WEDNESDAY                                                  |");
                Console.WriteLine("|        Calculus 2                       :  10:30AM – 13:30PM   |");
                Console.WriteLine("|        CWTS 2                           :  14:00AM – 17:00PM   |");
                Console.WriteLine("|     THURSDAY                                                   |");
                Console.WriteLine("|        Physics                          :  14:30PM – 20:00PM   |");
                Console.WriteLine("|     FRIDAY                                                     |");
                Console.WriteLine("|        PATHFIT 2                        :   9:00AM – 11:00AM   |");
                Console.WriteLine("|        Purposive Communication          :  11:00AM – 13:00PM   |");
                Console.WriteLine("|        Discrete Mathematics             :  14:00PM – 17:00PM   |");
                Console.WriteLine("|        Engineering Data Analysis        :  17:00PM – 20:00PM   |");
                Console.WriteLine("|     SATURDAY                                                   |");
                Console.WriteLine("|        Object Oriented Programming      :   8:00AM – 13:00PM   |");
                Console.WriteLine("|        Computer Hardware Fundamentals   :  14:00PM – 20:00PM   |");
                Console.WriteLine("|________________________________________________________________|");

                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\nInput day today: ");
                string inputday = Console.ReadLine();

                string day = inputday.ToLower();

                for (int i = 0; i < 2; i++)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\nEnter your student number: ");
                    string userinput = Console.ReadLine();

                    if (Account.Login(userinput))
                    {
                        Menu.Show(userinput, day);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Press Enter to continue...");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Failed");
                    }
                }
            }
        }
    }
}
