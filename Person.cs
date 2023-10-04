using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsDemo//House
{
    //access specifier-class internal
   internal  class Person
    {
        //private
        internal static int personId=0;
        private double _salary;
        private string _firstname;
        private int _deptno;
        public void ShowPersonDetails()
        {
            personId = personId + 1;
            Console.WriteLine($" Personid allotted to you = {personId}");
            Console.WriteLine(_salary);
            Console.WriteLine(_firstname);
            Console.WriteLine(_deptno);
        }


        public void AcceptPersonDetails() 
        {
            Console.WriteLine("Enter person salary");
            _salary=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine( "enter name");
            _firstname=Console.ReadLine();
            Console.WriteLine(  "enter deptno");
            _deptno=Convert.ToInt32(Console.ReadLine());        

        }




        //private void PrivateMethodForPersonExampleMobile() {
        //    Console.WriteLine("This is a private method");
        //}
        //public void UseChargerPublic() {
        //    PrivateMethodForPersonExampleMobile();
        //    Console.WriteLine("This is a public method");
        //}

        //internal void InternalMethodUtilityBox() {
        //    PrivateMethodForPersonExampleMobile();
        //    Console.WriteLine(  "Thsi is internal method");
        //}

    }
}
