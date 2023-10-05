using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace ArraysDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //first way
            int[] marks = { 10, 10, 20, 21 };
            int[] marks3;
            int arrsize=marks.Length;
            for (int i = 0; i < arrsize; i++)
            {
                Console.WriteLine(marks[i]);
            }
            Console.WriteLine("---------------");
            //second way
            int[] marks1 = new int[4] { 100, 110, 120, 121 };
            int[] marks2 = new int[4];
            //     marks2[0] = 31;
            for (int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine(marks1[i]);
            }
            Console.WriteLine("===============");
            //Third way
            Array a = Array.CreateInstance(typeof(int), 4);
            a.SetValue(1000, 0);
            //   object o=a.GetValue(0);
            int v = (int)a.GetValue(0);
            Console.WriteLine($"The value at index 0={v}");
            Console.WriteLine("*********************");
            int[] oneD = { 19, 20, 21, 22 };
            PrintFirstValue(oneD);

            int[,] twoD = { { 10, 20 }, { 30, 40 } };
            PrintFirstValue(twoD);
            int[,,] Td = new int[2, 2, 3] {
                                { {1,2, 3 }, { 4, 5, 6 } },
                                { { 7, 8, 9 }, { 10, 11, 12 } }
            };
            PrintFirstValue(Td);
            //int[,,] td1 = new int[1, 2, 2] {
            //            { {1,2 },{ 3,4} }
            //};

            //int[,,] td2 = new int[2, 2, 2] {
            //{ { 1,2},{3,4 } },
            //{ {5,6 },{7,8 } }
            //};
            // //first 2 means --2 rows
            ////second 2 means--2 sets of elements
            ////thrid 2 means ---2 values
            Console.WriteLine("---------------------");
            int[] arr = new int[] {10,11,23,34,-10,-110,0 };
            foreach (int i in arr) {
                Console.WriteLine(i);
            }
            Console.WriteLine("-----------");
            string[] names = new string[] {"Amit","Sumit","Suma","Roma","Komal" };
            
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Object array");
            object[] obj = new object[] {1,"Suma",'A',45.55f,3433.34d };
            foreach (var item in obj) {
                Console.WriteLine(item);
            }

            //Implicitly typed local variable-2.0 framework
            //cannot be reinstantiated by giving different types and also cannot be used 
            //as parameter type
            var p = "Hello";
            Console.WriteLine(p);
            var i = 67.8755d;
            var d1 = new DateTime(2023, 04, 10);
            //Framework---3.5 and above
            //can be reinstantiated by giving different types and also can be used 
            //as parameter type
            dynamic myd = "Hello";

            Console.WriteLine(myd);//Hello
            myd = 4566;
            Console.WriteLine(myd);//4566




            Console.Read();

        }


        

        static void PrintFirstValue(Array a) 
        {
            Console.WriteLine(a.Rank);
            int[] indexers=new int[a.Rank];//by default 0 index value will be considered
            

            
            Console.WriteLine($"First Value={a.GetValue(indexers)}");
        
        }

    }
}
