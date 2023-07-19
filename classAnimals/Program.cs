using System;

namespace AppName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            animals dog = new animals();
            Console.WriteLine(dog.CountLeg + dog.countLeg);
            // dog.CountLeg = 50; private set nên không sửa đc
        }
    }
}
