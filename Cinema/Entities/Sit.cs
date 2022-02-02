

namespace Cinema.Entities
{
    public class Sit
    {
        bool isFree;
        int cost;

        public Sit(int cost)
        {
            isFree = true;
            this.cost = cost;
        }

        public int GetCost()
        {
            return cost;
        }

        public bool GetFree()
        {
            return isFree;
        }

        public void Take()
        {
            isFree = false;
        }

        public override string ToString()
        {
            return isFree ? "0" : "X";
        }
    }
}
