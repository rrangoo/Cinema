using System;

namespace Cinema.Optional
{
    public class Reader
    {
        string password;

        public Reader(string password)
        {
            this.password = password;
        }

        public int NextInt(int min, int max)
        {
            string inputLine = Console.ReadLine();

            int number;

            while (!int.TryParse(inputLine, out number) ||
                number < min ||
                number > max)
            {
                Console.WriteLine($"Пожалуста введите целое число от {min} до {max}!");
                inputLine = Console.ReadLine();
            }

            return number;
        }

        public int[,] NextMatrix(int min, int max, int rows, int cols)
        {
            int[,] prices = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                string[] lines = Console.ReadLine().Split();

                if (lines.Length != cols)
                    return null;

                for (int j = 0; j < cols; j++)
                {
                    if (!int.TryParse(lines[j], out prices[i, j]) ||
                        prices[i, j] < min ||
                        prices[i, j] > max)
                    {
                        return null;
                    }
                }
            }
            return prices;
        }

        public bool ReadPassword()
        {
            string inputLine = Console.ReadLine();

            return inputLine.Equals(password);
        }
    }
}
