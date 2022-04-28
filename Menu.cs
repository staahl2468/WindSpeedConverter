namespace VejrApp
{
    internal class Menu
    {
        static string? ValueName;
        public static ConsoleKey Choose()
        {
            bool temp = true;
            ConsoleKeyInfo cho;
            do
            {
                Console.WriteLine("Hvilken enhed skal konverteres?");
                Console.WriteLine("A: m/s");
                Console.WriteLine("B: Km/t");
                Console.WriteLine("C: Km/t");
                Console.WriteLine("D: Km/t");
                Console.WriteLine("Q: for at lukke programmet");

                cho = Console.ReadKey();
                if (!(cho.Key == ConsoleKey.A) && !(cho.Key == ConsoleKey.B) && !(cho.Key == ConsoleKey.C) && !(cho.Key == ConsoleKey.D) && !(cho.Key == ConsoleKey.Q))
                {
                    temp = true;
                    Console.Clear();
                    Console.WriteLine("Forkert Input!");
                }
                else if (cho.Key == ConsoleKey.Q)
                {
                    Environment.Exit(0);
                }
                else
                {
                    if (cho.Key == ConsoleKey.A)
                    {
                        ValueName = "m/s";
                    }
                    if (cho.Key == ConsoleKey.B)
                    {
                        ValueName = "Km/t";
                    }
                    if (cho.Key == ConsoleKey.C)
                    {
                        ValueName = "Mph";
                    }
                    if (cho.Key == ConsoleKey.D)
                    {
                        ValueName = "Knots";
                    }
                    temp = false;
                }
            } while (temp);
            return cho.Key;
        }
        public static void ConvertChoice(ConsoleKey choice)
        {
            bool temp = true;
            Console.Clear();
            do
            {
                Console.WriteLine($"Angiv antal {ValueName}:");
                if (double.TryParse(Console.ReadLine(), out double Value))
                {
                    switch (choice)
                    {
                        case ConsoleKey.A:
                            Formler.MpS(Value);
                            temp = false;
                            Console.ReadKey();
                            Console.Clear();
                            break;

                        case ConsoleKey.B:
                            Formler.KmT(Value);
                            temp = false;
                            Console.ReadKey();
                            Console.Clear();
                            break;

                        case ConsoleKey.C:
                            Formler.MpH(Value);
                            temp = false;
                            Console.ReadKey();
                            Console.Clear();
                            break;

                        case ConsoleKey.D:
                            Formler.Knot(Value);
                            temp = false;
                            Console.ReadKey();
                            Console.Clear();
                            break;
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Forkert input!");
                }
            } while (temp);

        }
    }
}