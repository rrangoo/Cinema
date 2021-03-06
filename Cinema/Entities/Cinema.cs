
namespace Cinema.Entities
{
    public class Cinema
    {
        Sit[,] sits;

        public Cinema(int rows, int cols)
        {
            sits = new Sit[rows, cols];
        }

        public int GetRows()
        {
            return sits.GetLength(0);
        }

        public int GetCols()
        {
            return sits.GetLength(1);
        }

        public void Init(int[,] prices)
        {
            for (int i = 0; i < prices.GetLength(0); i++)
            {
                for (int j = 0; j < prices.GetLength(1); j++)
                {
                    sits[i, j] = new Sit(prices[i, j]);
                }
            }
        }

        public Sit GetSit(int row, int col)
        {
            return sits[row - 1, col - 1];
        }

        public string GetBoughtSits()
        {
            string res = "Доступные места (0 - свободно, X - выкуплено):\n";

            for (int i = 0; i < sits.GetLength(0); i++)
            {
                for (int j = 0; j < sits.GetLength(1); j++)
                {
                    res += sits[i, j].ToString() + " ";
                }
                res += "\n";
            }

            return res;
        }

        public string Tickets()
        {
            string res = "Доступные места (X - выкуплено):\n";

            for (int i = 0; i < sits.GetLength(0); i++)
            {
                for (int j = 0; j < sits.GetLength(1); j++)
                {
                    if (sits[i, j].GetFree())
                    {
                        res += sits[i, j].GetCost() + " ";
                    }
                    else
                    {
                        res += sits[i, j].ToString() + " ";
                    }
                }
                res += "\n";
            }

            return res;
        }

        public bool IsPossible()
        {
            for (int i = 0; i < sits.GetLength(0); i++)
            {
                for (int j = 0; j < sits.GetLength(1); j++)
                {
                    if (sits[i, j].GetFree())
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public override string ToString()
        {
            string res = $"Размер зала:\n{sits.GetLength(0)} {sits.GetLength(1)}\n\n" +
                $"Стоимость билетов в зале:\n";

            for (int i = 0; i < sits.GetLength(0); i++)
            {
                for (int j = 0; j < sits.GetLength(1); j++)
                {
                    res += sits[i, j].GetCost() + " ";
                }
                res += "\n";
            }

            return res;
        }
    }
}
