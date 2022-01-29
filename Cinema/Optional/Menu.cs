using System;

namespace Cinema.Optional
{
    public class Menu
    {
        public void Print()
        {
            Console.WriteLine("1. Показать цены на места.");
            Console.WriteLine("2. Купить билет.");
            Console.WriteLine("3. Показать занятые места.");
            Console.WriteLine("4. Права администратора.");
            Console.WriteLine("5. Выход.");

            Console.Write("\nВведите число: ");
        }

        public void ShowPrices(Entities.Cinema cinema)
        {
            Console.Clear();
            Console.WriteLine("___Cinema simulator 2000___\n");

            Console.WriteLine(cinema);

            Console.Write("\nЧтобы вернутся, нажмите любую клавишу. . .");
            Console.ReadKey();
        }

        public void ShowBoughtSits(Entities.Cinema cinema)
        {
            Console.Clear();
            Console.WriteLine("___Cinema simulator 2000___\n");

            Console.WriteLine(cinema.GetBoughtSits());

            Console.Write("\nЧтобы вернутся, нажмите любую клавишу. . .");
            Console.ReadKey();
        }

        public void Exit(ref bool exitBool)
        {
            exitBool = true;
        }
    }
}
