using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" please enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine("Hello" + name);

            Console.WriteLine("how many hours did you sleep?");
            int hoursofsleep = Convert.ToInt32(Console.ReadLine());

            if (hoursofsleep < 6)
            {
                Console.WriteLine("u must be feeling tierd");
            }
            else 
            {
                Console.WriteLine("u must be feeling enthusastic");
            }
        }
    }
}
