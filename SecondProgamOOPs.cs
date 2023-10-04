using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsDemo
{
    //maintainabitlity --we write one class in one file
    internal class SecondProgamOOPs
    {
        static void Main(string[] args)
        {

            Person p = new Person();//() construct the object called p of type Person
            //           p.InternalMethodUtilityBox();
            //p.UseChargerPublic();
            p.AcceptPersonDetails();
            p.ShowPersonDetails();
            Console.WriteLine("---------------------");
            Person p1=new Person();
            p1.AcceptPersonDetails();
            p1.ShowPersonDetails();
            Console.WriteLine("---------------------");
            Person p2=new Person();
            p2.AcceptPersonDetails();
            p2.ShowPersonDetails();

       
            Console.Read();

        }
    }
}
