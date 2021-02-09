using System;

namespace ConsoleApp32
{
    class Program
    {
        delegate int MyDelegat(int i, int n);

        static void Main(string[] args)
        {

            MyDelegat a = (x, y) => x + y;
            MyDelegat s = (x, y) => x - y;
            MyDelegat m = (x, y) => x * y;
            MyDelegat d = (x, y) => x / y;


            int add = a(12, 23);

            int sub = s(15, 10);

            int mul = m(2, 3);

            int del = d(4, 2);

            Console.WriteLine("Додавання {0} Віднімання {1} Множення {2} Розподіл {3}", add, sub, mul, del);
            Console.ReadKey();
        }
    }
}
