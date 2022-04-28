using System;

namespace VejrApp
{
    internal class Formler
    {
        public static void MpS(double value)
        {
            Console.WriteLine($"Km/t: {value * 3.6}");
            Console.WriteLine($"Mph: {value / 0.45}");
            Console.WriteLine($"Knots: {value * 1.94384449}");
        }

        public static void KmT(double value)
        {
            Console.WriteLine($"M/s: {value / 3.6}");
            Console.WriteLine($"Mph: {value * 0.621371192}");
            Console.WriteLine($"Knots: {value * 0.54}");
        }

        public static void MpH(double value)
        {
            Console.WriteLine($"M/s: {value * 0.44704}");
            Console.WriteLine($"Km/t: {value / 0.621371192}");
            Console.WriteLine($"Knots: {value * 0.868976242}");
        }

        public static void Knot(double value)
        {
            Console.WriteLine($"M/s: {value * 0.514444444}");
            Console.WriteLine($"Km/t: {value / 0.54}");
            Console.WriteLine($"Mph: {value / 0.868976242}");
        }
    }
}