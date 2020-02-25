using System;

namespace Hello
{
    class Program
    {
        private const string Value = "Siema2";

        static void Main(string[] args)
        {
            while (true)
            {
            setName();
            setAge();
            Setting();
            }
            
        }

        private static void setName()
        {
            Console.Write("Podaj imię: ");
            string name = Console.ReadLine();
        }

        private static void setAge()
        {
            Console.WriteLine("Podaj wiek: ");
            int age;
            bool parse = int.TryParse(Console.ReadLine(), out age);
            if (parse == false)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Nie ściemniaj");
            }
            else if (age > 18)
            {
                Console.WriteLine("Browarek ?");
            }
            else
            {
                Console.WriteLine("Mleczko ?");
            }
        }

        private static void Setting()
        {   Console.ReadKey();
            Console.ResetColor();
            Console.Clear();
            
        }
    }
}
