using System;
public class intergerTest
{
    static void Main(string[] args)
    {
        int a = 10, b = 20, x = 5, y = 2;
        int f1, f2, f3, f4, f5, f6, f7, f8, f9, f10;
        f1 = a + b;
        f2 = x - b;
        f3 = x * b;
        f4 = y / a;
        f5 = b % y;
        f6 = y + 10 % x;
        f7 = a / 3 * 5;
        f8 = 9 / 2 * a;
        f9 = y % 8;
        f10 = 100 * x + y % 2 - a;
        Console.WriteLine("result :\n1={0}\n2={1}\n3={2}\n4={3}\n5={4}\n6={5}\n7={6}\n8={7}\n9={8}\n10={9}", f1, f2, f3, f4, f5, f6, f7, f8, f9, f10);
    }
}
