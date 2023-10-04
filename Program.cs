using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsDemo
{
    internal class Program
    {
        static void swapNos(ref int i,ref int j)
        {            int temp = i;
             i = j; j = temp;
              Console.WriteLine($"Now the value of i={i}");
            Console.WriteLine($"Now the value of j={j}");
        }

        static int CalculateValues(int i, int j, out int subans, out int divans)
        {
          int  addans = i + j;
            if (j != 0)
            {
                subans = i - j;
                divans = i / j;
            }
            else
            {
                subans = 0;
                divans = 0;
            }
            return addans;


        }

                static void Calculate(int i, int j,out int addans,out int subans,out int divans)
        {
            addans = i + j;
            if (j != 0)
            {
                subans = i - j;
                divans = i / j;
            }
            else
            {
                subans = 0;
                divans = 0;
            }
           }
              static void Main(string[] args)
        {  //BoxingUnboxing();
            int a=10, b=20;
            swapNos(ref a, ref b);
            Console.WriteLine($"Now the value of a={a}");
            Console.WriteLine($"Now the value of b={b}");
            int addanswer;
            Calculate(a, b, out  addanswer, out int subanswer, out int divanswer);
            Console.WriteLine( addanswer);
            Console.WriteLine(  subanswer);
            Console.WriteLine(  divanswer);
            Console.WriteLine(  "-------------------");
            addanswer=CalculateValues(a, b, out int subans, out int divsionans);
            Console.WriteLine( addanswer);
            Console.WriteLine( divsionans);
            Console.WriteLine(  subans);

            Console.Read();



        }

        private static void BoxingUnboxing()
        {
            //Boxing & Unboxing
            int counter = 10;
            float i;
            double d1;
            decimal d2;
            object o;
            //Boxing
            //(10)
            o = counter;//bigger type is holding the value of smaller type
                        //no data loss
                        //value type(int,float,double,decimal--struct/enums)
                        //only value types can be boxed 
                        //Boxing means putting smaller type into bigger type.
            Console.WriteLine("The data type of o=" + o.GetType());
            //Unboxing means bringing it to its original type, by casting it.
            counter = (int)o;
            int a = counter + 100;
            Console.WriteLine($"The addition ={a}");
            Console.WriteLine("--------------");

            string s = "Hello";
            Console.WriteLine(s);
            o = s;
            Console.WriteLine(o);
            Console.WriteLine(s);
            //Casting
            string s1 = (string)o;
            Console.WriteLine(s1);



            //object ---- biggest in the hierarchy of data types
            //all data types inherit from object
            //int,float etc are struct.
            //Struct/enum we call it value types. and value types on stack.
            //everything else is reference type.
            //reference type are stored on the heap
        }
    }
}
