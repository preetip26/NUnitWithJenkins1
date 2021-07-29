using System;

namespace ToBeTested
{
    public class Program
    {
        static string name;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the name: ");
            name = Console.ReadLine();
        }
        public int Add(int x, int y)
        {
            return x + y;
        }
        public void SayHello(string who)
        {
            Console.WriteLine("Hello "+who);
        }
    }
    
}
