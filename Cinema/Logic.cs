using System;
using Cinema.Optional;

namespace Cinema
{
    public class Logic
    {
        Entities.Cinema cinema;
        Reader reader;
        Menu menu;
        int balance;

        public Logic(Reader reader, int balance)
        {
            this.balance = balance;
            this.reader = reader;
            menu = new Menu();
            cinema = CreateCinema();
        }

        private Entities.Cinema CreateCinema()
        {
            Console.WriteLine("___Cinema simulator 2000___\n");

            Console.Write("Введите количество рядов: ");
            int rows = reader.NextInt(1, 1000);

            Console.Write("Введите количество мест в одном ряду: ");
            int cols = reader.NextInt(1, 1000);

            Entities.Cinema cinema = new Entities.Cinema(rows, cols);

            Console.Clear();
            Console.WriteLine("___Cinema simulator 2000___\n");

            Console.WriteLine("Введите матрицу цен: ");

            int[,] prices = reader.NextMatrix(1, 1000, rows, cols);

            while (prices == null)
            {
                Console.WriteLine($"Ошибка ввода!\nВы должны ввести матрицу {rows} на {cols},\n" +
                    $"где каждый элемент - это целое число от 1 до 1000:");
                prices = reader.NextMatrix(1, 1000, rows, cols);
            }

            cinema.Init(prices);

            return cinema;
        }

        public void Start()
        {
            bool isExit = false;
            while (!isExit)
            {
                Console.Clear();
                Console.WriteLine("___Cinema simulator 2000___\n");
                menu.Print();

                int choose = reader.NextInt(1, 5);

                switch (choose)
                {
                    case 1:
                        menu.ShowPrices(cinema);
                        break;
                    case 2:
                        break;
                    case 3:
                        menu.ShowBoughtSits(cinema);
                        break;
                    case 4:
                        break;
                    case 5:
                        menu.Exit(ref isExit);
                        break;
                }
            }
        }
    }
}
