using System;


namespace Lab01
{
    class Program
    {
        static void Main(string[] args)
        {
            string n, l, id,g ;
            
            Console.WriteLine("Please Enter Input :");
            Console.Write("Neme:");
            n = Console.ReadLine();
            Console.Write("Lastneme:");
            l = Console.ReadLine();
            Console.Write("ID:");
            id = Console.ReadLine();
            Console.Write("GPA:");
            g = Console.ReadLine();

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Output:");
            Console.WriteLine("Neme         :{0}",n);
            Console.WriteLine("LastNeme     :{0}",l);
            Console.WriteLine("ID           :{0}",id);
            Console.WriteLine("GPA          :{0:F2}",g);

            Console.ReadKey();
        }
    }
}
