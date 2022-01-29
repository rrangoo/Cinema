using System;
using Cinema.Optional;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("___Cinema simulator 2000___\n");
            Console.Write("Задайте пароль для администратора: ");
            string password = Console.ReadLine();

            Reader reader = new Reader(password);

            Console.Write("Задайте количество денег на балансе (от 1 до 10000): ");
            int balance = reader.NextInt(1, 10000);

            Console.Clear();

            Logic logic = new Logic(reader, balance);
            logic.Start();
        }
    }
}
