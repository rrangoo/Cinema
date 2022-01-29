

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

        public override string ToString()
        {
            return isFree ? "0" : "X";
        }
    }
}
