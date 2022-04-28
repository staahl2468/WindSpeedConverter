using System;

namespace VejrApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool Loop = true;
            ConsoleKey Choice;
            double Answer;
            do
            {
                Choice = Menu.Choose();
                Menu.ConvertChoice(Choice);
            } while (Loop);
        }
    }
}
