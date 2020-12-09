using System;
using System.Globalization;

namespace Andreev_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double result = Math.Sqrt((58.0 * 15 + 4) / 15 -
                                      Math.Pow((56.0 * 24 + 7) / 24, 1 / 5.0) /
                                      (0.8 * Math.Sqrt(0.474)) +
                                      (2.0 * 9 + 1) / 9 * ((3.0 * 3 + 2) / 3)) /
                            Math.Pow((8.0 * 4 + 3) / 4 * (3.0 / 5), 1 / 3.0) -
                            Math.Pow(Math.Pow(1 / 0.13, 3), 1 / 5.0) * ((4.0 * 13 + 7) / 13);

            Console.WriteLine(result);
        }
    }
}