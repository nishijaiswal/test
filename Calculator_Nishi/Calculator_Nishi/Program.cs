using System;

namespace Calculator_Nishi
{
    class Program
    {
        static void Main(string[] args)
        {
           


            while(true)
            {
                

                Console.WriteLine("Choose:\n1.Add\n2.Subtract\n3.Multiply\n4.Divide\n5.Exit");
                int ch = int.Parse(Console.ReadLine());

                if (ch == 5)
                    break;

                Console.WriteLine("Enter the values:");
                Console.Write("x:");
                float x = float.Parse(Console.ReadLine());
                Console.Write("y:");
                float y = float.Parse(Console.ReadLine());

                
                if (ch == 1)
                    Console.WriteLine(x + " + "+y + " = " + (x + y));
                else if (ch == 2)
                    Console.WriteLine(x + " - "+y + " = " + (x - y));
                else if (ch == 3)
                    Console.WriteLine(x + " * "+y + " = " + (x * y));
                else if (ch == 4)
                    Console.WriteLine(x + " / "+y + " = " + (x / y));
                else
                    Console.WriteLine("wrong choice.....Try again");

            }

        }
    }
}
