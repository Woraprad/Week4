using System;


namespace Lab01
{
    class Operators
    {
        static void Main()
        {
            int x;
            Console.Write("Input number 0-9 :");
            x = Console.Read();
            Random random = new Random();
            int randomNumber = random.Next(0, 9);
            Console.WriteLine("Random Number :{0}",randomNumber);

            bool a = x > randomNumber;
            Console.WriteLine("Input number > Random Number ={0}", a);
            
            Console.ReadKey();
        }
    }
    
}
