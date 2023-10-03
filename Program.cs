using System;

//assembly---multiple parts 
namespace FirstDemo
{

     class Program
    {
        static void Main(string[] args)
        {
            //Ctrl + s
            //Writeline method -- (parenthesis(parameters))

            //Write----string-"", int--direct,decimal--d,float -f
            //Console.Write("Hello,World");
            //Console.Write("Hello India");
            //Console.Write("Hello All");
            //Console.WriteLine(1222);
            //Console.WriteLine(1222342.455d);
            //Console.WriteLine(12.345f);
            //Console.WriteLine('A');
            //Console.WriteLine(DateTime.Today);
            //Console.WriteLine(true);
            //Console.WriteLine(false);   
            //ctrl KC---comment
            //ctrl KU
            int cnt=9;
            Console.WriteLine($"The value of cnt= {cnt}");
            float v = default(float);
            Console.WriteLine($"The value of v={v}");   
            string name=default(string);    
            Console.WriteLine(name);

            Console.Read();
        }
    }
}
