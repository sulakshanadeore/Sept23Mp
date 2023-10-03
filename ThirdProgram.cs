using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    class Test
    {
        public static void SayGoodMorning()
        {
            Console.WriteLine("Good Morning");
        }

        public static int CalculateAge(DateTime birthdate) {
                        int age=DateTime.Now.Year - birthdate.Year;
            return age; 
              }

    }

    internal class ThirdProgram
    {
        //signature ----static int (int,int)
        public  static int AddNos(int n1,int n2) 
        {
            int ans = n1 + n2;
            return ans; 
        }
        //signature static void(int,int)
                public static void SubtractNos(int n1,int n2)
        {
       }
       public static void Greet()
        {
            //Called
            Console.WriteLine("Good day");
        }
         static void Main(string[] args)
        {
            int t = ThirdProgram.AddNos(10, 10);
            Console.WriteLine(  t);

            Console.WriteLine("Enter birthdate");
            DateTime bdate = Convert.ToDateTime(Console.ReadLine());
            int personAge=Test.CalculateAge(bdate);
            Console.WriteLine($"The  age of person whose  {bdate} ={personAge} years");


            //Calling
            //Under Tools Menu---> code Snippet Manager
            //LoopExamplesSimple();
            Greet();//Main is calling greet
         
            Test.SayGoodMorning();//Main is calling the saygoodmorning() from the test class


            Console.ReadLine();
        }

        private static void LoopExamplesSimple()
        {
            int j = 11;
            for (int i = 1; i < j; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("-------------------------");
            j = 1;
            do
            {
                Console.WriteLine(j);
                j++;
            }
            while (j < 11);
            Console.WriteLine("---------");
            j = 1;
            while (j < 11)
            {
                Console.WriteLine(j);
                j++;

            }
        }
    }
}
