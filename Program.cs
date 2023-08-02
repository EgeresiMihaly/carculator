using System;

namespace carculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            char op;

            if (args.Length == 0)
            {
                Console.WriteLine("Az első szám:");
                x = int.Parse(Console.ReadLine());

                Console.WriteLine("A második szám:");
                y = int.Parse(Console.ReadLine());

                Console.WriteLine("A művelet (+, -, *, /):");
                op = Convert.ToChar(Console.ReadLine());
            }
            else
            {
                if (args.Length != 3)
                {
                    Console.WriteLine("Túl sok / kevés a paraméter");
                    return;
                }
                else
                {
                    x = int.Parse(args[0]);
                    y = int.Parse(args[1]);
                    op = Convert.ToChar(args[2]);
                }
            }

            int result = 0;
            switch (op)
            {
                case '+':
                    result = x + y;
                    break;
                case '-':
                    result = x - y;
                    break;
                case '*':
                    result = x * y;
                    break;
                case '/':
                    if (y != 0)
                    {
                        result = x / y;
                    }
                    else
                    {
                        Console.WriteLine("Hiba: Nullával való osztás nem lehetséges!");
                        return;
                    }
                    break;
                default:
                    Console.WriteLine("Érvénytelen művelet!");
                    return;
            }

            Console.WriteLine("Eredmény: " + result);
            Console.ReadKey();
        }
    }
}
