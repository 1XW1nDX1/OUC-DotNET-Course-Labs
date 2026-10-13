using System;
using System.Collections.Generic;

namespace Console1
{
    internal class ConsoleProgram
    {
        void Exp1(double d)
        {
            double x = x = 4 + d;
            double y = 10 + d;

            Console.WriteLine($"运行结果为：{(x++ < y) && (--y == x)}，此时x={x}，y={y}");
        }

        void Exp2(double d)
        {
            double x = 4 + d;
            double y = 10 + d;

            Console.WriteLine($"运行结果为：{(++x < y) || (y-- == x)}，此时x={x}，y={y}");
        }

        static void Main(string[] args)
        {
            double d = 8.0;

            var p= new ConsoleProgram();
            p.Exp1(d);
            p.Exp2(d);

            return;
        }
    }
}
