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
            Console.WriteLine("4. Выход.");

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

        public void BuyTicket(Entities.Cinema cinema, Reader reader, ref int balance)
        {
            Console.Clear();
            Console.WriteLine("___Cinema simulator 2000___\n");

            Console.WriteLine(cinema.Tickets());

            if (!cinema.IsPossible())
            {
                Console.WriteLine("Извините, все места заняты.\n");

                Console.Write("\nЧтобы вернутся, нажмите любую клавишу. . .");
                Console.ReadKey();
            }
            else
            {
                Console.Write("Введите ряд: ");
                int row = reader.NextInt(1, cinema.GetRows());

                Console.Write("Введите место: ");
                int col = reader.NextInt(1, cinema.GetCols());

                if (cinema.GetSit(row, col).GetFree())
                { 
                    if (cinema.GetSit(row, col).GetCost() > balance)
                    {
                        Console.WriteLine("Недостаточно средств!");
                    }
                    else
                    {
                        Console.WriteLine("Вы успешно купили билет.");
                        cinema.GetSit(row, col).Take();
                        balance -= cinema.GetSit(row, col).GetCost();
                    }
                    Console.Write("\nЧтобы вернутся, нажмите любую клавишу. . .");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Это место занято.");

                    Console.Write("\nЧтобы вернутся, нажмите любую клавишу. . .");
                    Console.ReadKey();
                }
            }
            
            
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
