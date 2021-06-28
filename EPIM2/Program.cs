using System;
using System.Numerics;
using System.Linq;
using System.Text;


namespace EPIM2
{
   
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger res;

            try
            {

                Console.WriteLine("First numb: ");
                BigInteger a = BigInteger.Parse(Console.ReadLine());
                Console.WriteLine("Action (*, /, +, -) ");
                char z = Convert.ToChar(Console.ReadLine());
             
                if (z == '+' || z == '-' || z == '/' || z == '*')
                {
                    Console.WriteLine("Second numb: ");
                    BigInteger b = BigInteger.Parse(Console.ReadLine());

                    if (z == '+')
                    {
                        res = a + b;
                        Console.WriteLine("Res: " + res);
                    }
                    if (z == '-')
                    {
                        res = a - b;
                        Console.WriteLine("Res: " + res);
                    }

                    if (z == '*')
                    {
                        res = a * b;
                        Console.WriteLine("Res: " + res);
                    }
                    if (z == '/')
                    {
                        res = a / b;
                        Console.WriteLine("Res: " + res);
                    }

                }
                else { Console.WriteLine("Wrong action");
                    
                }
            }
            catch { Console.WriteLine("Error!");}
        }
    }
}
