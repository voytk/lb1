using System;

namespace ConsoleApp31
{
    class Program
    {
        delegate int Anonim(int x, int y, int w);
        static void Main(string[] args)
        {
            Anonim a = delegate (int x, int y, int w) { return (x + y + w) / 3; };
            Console.WriteLine(a(2, 3, 4));
            Console.ReadKey();
        }
    }
}
