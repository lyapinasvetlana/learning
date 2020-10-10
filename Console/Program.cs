
using System;
using Vs.Calculator;
namespace Vs.Vers{
    class Program
    {
        static void Main(string[] args)
        {   int x=10;
            int y=x+2;

            Console.WriteLine("x+y={0}", Calc.Sum(x,y));
            Console.WriteLine(Calc.ToJson(100,200));
        }
    }

}

