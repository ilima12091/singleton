using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton<Greeter>.Instance.SayHiToTheWorld();
            if(Singleton<Greeter>.Instance.Equals(Singleton<Greeter>.Instance))
            {
                Console.WriteLine("son iguales");
            }
        }
    }
}
