using System;
namespace variableProperties
{
    class Program
    {
        static void Main(string[] args)
        {
             double x,y,z;
            Console.WriteLine("Input distance from sun :");
            x = Console.Read();
            const double lightSpeed = 186000d;   
            Console.WriteLine("Light speed = {0} Mile Per second", lightSpeed);
            const double mileTokm = 1.609344;
            z = 93000000 * 1.609344;
            y = x / z;
            Console.WriteLine("Light speed = {0} km Per second", lightSpeed*mileTokm);
            Console.WriteLine("SunDistance = {0} km", x);
            double SunToEarthTimeOfLight = x / lightSpeed;  
            Console.WriteLine("SunTimeOfLight = {0} seconds", SunToEarthTimeOfLight);
            Console.WriteLine("SunTimeOfLight = {0} minutes", SunToEarthTimeOfLight/60d);
            Console.WriteLine("distance from sun = {0} AU",y);
            Console.ReadKey();
        }
    }
}
