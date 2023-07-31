using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppAssignment19_Part1
{
    public delegate int ArithmeticOperation(int num1, int num2);
    class Program
    {
        static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        static int Sub(int num1, int num2)
        {
            return num1 - num2;
        }
        static int Mul(int num1, int num2)
        {
            return num1 * num2;
        }
        static int Div(int num1, int num2)
        {
            if (num2 == 0)
            {
                Console.WriteLine("Divided by Zero not possible here");
            }
            return num1 / num2;

        }


        static void Main(string[] args)
        {
            ArithmeticOperation AddDel = new ArithmeticOperation(Add);
            ArithmeticOperation SubDEl = new ArithmeticOperation(Sub);
            ArithmeticOperation MulDel = new ArithmeticOperation(Mul);
            ArithmeticOperation DivDel = new ArithmeticOperation(Div);


            Console.WriteLine("Arithmentic Operations");
            Console.WriteLine("1.Addition");
            Console.WriteLine("2.Subtraction");
            Console.WriteLine("3.Multiplication");
            Console.WriteLine("4.Division");
            Console.WriteLine("Enter Your Choice");
            int choice = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter First Number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            int num2 = int.Parse(Console.ReadLine());

            try
            {
                int result = 0;
                switch (choice)
                {
                    case 1:
                        {
                            result = Add(num1, num2);
                            Console.WriteLine($"{num1}+{num2}=" + result);
                            break;
                        }
                    case 2:
                        {
                            result = Sub(num1, num2);
                            Console.WriteLine($"{num1}-{num2}=" + result);
                            break;
                        }
                    case 3:
                        {
                            result = Mul(num1, num2);
                            Console.WriteLine($"{num1}*{num2}=" + result);
                            break;
                        }
                    case 4:
                        {
                            result = Div(num1, num2);
                            Console.WriteLine($"{num1}/{num2}=" + result);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid Choice");
                            break;
                        }

                }
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format Error " + e.Message);
               
            }
            Console.ReadKey();
        }
    }
}
            
                
 