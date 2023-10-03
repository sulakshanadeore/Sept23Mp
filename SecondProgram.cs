using System;

using System.Drawing;


namespace CSharpBasics
{
    //named constants
    enum Marks
    {
        verybad,
        bad,
        good,
        average,
        excellent
    }

    internal class SecondProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Second main");
            Console.WriteLine("enter marks");
            int m=Convert.ToInt32(Console.ReadLine());
            Marks priority;
            if (m < 35)
            {
                priority = Marks.verybad;
            }
            else if (m > 35 && m < 50)
            {
                priority = Marks.average;
            }
            else if (m > 50)
            {
                priority = Marks.good;
            }

            else { priority = Marks.excellent; }
            switch (priority)
            {
                case Marks.verybad:
                    Console.WriteLine( "Marks are very bad");
                    break;
                case Marks.bad:
                    Console.WriteLine("Marks are very bad");
                    break;
                case Marks.good:
                    Console.WriteLine("Marks are very good");
                    break;
                case Marks.average:
                    Console.WriteLine("Marks are very average");
                    break;
                case Marks.excellent:
                    Console.WriteLine("Marks are very excellent");
                    break;
                
            }





            //Console.WriteLine("Enter a color");
            //string s=Console.ReadLine();
            //switch (s)
            //{
            //    case "Red":
            //        Console.WriteLine("its red");
            //        break;
            //    case "White":
            //        Console.WriteLine("its white");
            //        break;
            //    case "Green":
            //        Console.WriteLine("its green");
            //        break;

            //    default:
            //        break;
            //}

            Console.ReadLine();
        }

        private static void FindDayOfWeek()
        {
            Console.WriteLine("Enter  a date");
            DateTime dt = Convert.ToDateTime(Console.ReadLine());
            switch (dt.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    Console.WriteLine($"The day is  {dt.DayOfWeek}");
                    break;
                case DayOfWeek.Tuesday:
                    Console.WriteLine($"The day is  {dt.DayOfWeek}");
                    break;
                case DayOfWeek.Wednesday:
                    Console.WriteLine($"The day is  {dt.DayOfWeek}");
                    break;
                case DayOfWeek.Friday:
                    Console.WriteLine($"The day is  {dt.DayOfWeek}");
                    break;
                case DayOfWeek.Thursday:
                    Console.WriteLine($"The day is  {dt.DayOfWeek}");
                    break;
                case DayOfWeek.Saturday:
                    Console.WriteLine($"The day is  {dt.DayOfWeek}");
                    break;
                case DayOfWeek.Sunday:
                    Console.WriteLine($"The day is  {dt.DayOfWeek}");
                    break;
                default:
                    Console.WriteLine("Its not 1 or 2");
                    break;
            }
        }

        private static void NumberIsGreaterthan0()
        {
            Console.WriteLine("Enter  a number");
            int no1 = Convert.ToInt32(Console.ReadLine());
            if (no1 < 0)
            {
                Console.WriteLine("Number smaller than 0");
                Console.WriteLine($"number is {no1}");
            }
            else if (no1 > 0 && no1 <= 10)
            {
                Console.WriteLine("Number is in range of 1 to 10");
            }
            else
            {
                Console.WriteLine("Negative input or zero");
                Console.WriteLine($"number is {no1}");
            }
        }
    }
}
