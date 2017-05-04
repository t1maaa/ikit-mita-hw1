using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProgCat.Model;

namespace ProgCat
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("!Зоомагазин электронных котов!");

            Console.WriteLine("Введите возраст кота:");
            int age = SetAge();
            
            var cat = new Cat(age);

            while (true)
            {
                CatMenu(cat);
            }
        }

        public static int SetAge()
        {
            int age = -1;
            do
            {
                try
                {
                    age = Convert.ToInt32(Console.ReadLine());
                    if (age <= 0)
                    {
                        throw new Exception("Неверный возраст!");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message + "\nЕще раз: ");
                    
                }

            } while (age <= 0);
            
            return age;
        }

        public static string SetName()
        {
            string name = Console.ReadLine();
            return name;
        }

        public static void CatMenu(Cat cat)
        {
            var menu = -1;
            Console.ResetColor();
            Console.Clear();
            Console.WriteLine("1. Покормить кота");
            Console.WriteLine("2. Наказать кота");

            if ((String.IsNullOrEmpty(cat.Name)))
            {
                Console.WriteLine("3. Дать имя коту");
                Console.WriteLine("\nИмя: -");
            }
            else
            {
                Console.WriteLine("\nИмя: {0}", cat.Name);
            }
            Console.WriteLine("Возраст: {0}", cat.Age);

            switch (cat.Color())
            {
                case "Red":
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case "Yellow":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case "Green":
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case "White":
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }

            Console.WriteLine("Здоровье: {0}", cat.Health);

            menu = (Console.ReadKey(true).KeyChar); 

            switch ( menu)
            {
                case '1':
                    cat.Feed();
                    break;
                case '2':
                    cat.Punish();
                    break;
                case '3':
                    Console.ResetColor();
                    Console.WriteLine("\nВведите имя кота: ");
                    cat.Name = SetName();
                    break;

                    
            }
        }
    }
}
