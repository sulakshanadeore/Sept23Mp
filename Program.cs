using System;


//Logical collection of interrelated classes,structures and enums.
namespace CSharpBasics
{
    ////entity
    //struct Book
    //{
    //    int bookid,string bookname,decimal price;
    //    acceptbookdetails()
    //    {


    //    }
    
    //}


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Todays date ={DateTime.Now}");

            Console.WriteLine("Enter birthdate");
            DateTime birthdate=Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine(birthdate);
            Console.WriteLine(birthdate.Year);
            Console.WriteLine(birthdate.Month);


            //DateTime joiningDate = new DateTime(2023, 10, 03);
            //Console.WriteLine(joiningDate);

            //bool IsEmployee;
            //Console.WriteLine("enter a boolean value, true for yes, false for no: R u a employee");
            //IsEmployee = Convert.ToBoolean(Console.ReadLine());
            //Console.WriteLine(IsEmployee);


            //string empname;
            //Console.WriteLine("enter name");
            //empname=Console.ReadLine(); 
            //Console.WriteLine(empname);
            //Console.WriteLine("Enter a character");
            //char c1=Convert.ToChar(Console.ReadLine());
            //Console.WriteLine(c1);

          //  Console.WriteLine("Enter First Number");
            //1 byte--8 bits
            //     int firstno =Convert.ToInt32(Console.ReadLine());
          //  short firstno
            //Single firstno =Convert.ToSingle(Console.ReadLine());
           // Double firstno= Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Enter second number");
            //int secondno= Convert.ToInt32(Console.ReadLine());
            //            float secondno= Convert.ToSingle(Console.ReadLine());
           // Double secondno = Convert.ToDouble(Console.ReadLine());
            //int,float,decimal,string,char,datetime,bool
            //struct,enum
            //whenever you use struct/enum , its value stored on the stack,
            //everything else is stored on the heap.-ie object of class-heap
            //double ans = firstno + secondno;
            //Console.WriteLine($"The answer of {firstno} + {secondno}={ans}");
            Console.ReadLine();





        }
    }
}
