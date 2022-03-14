using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_DZ_OOP_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Player vasiliy = new Player("Васян", 100, 5);

            vasiliy.ShowInfo();
        }
    }

    class Player
    {
        public string Name;
        public int Health;
        public int Damage;

        public Player(string name, int health, int damage)
        {
            Name = name;
            Health = health;
            Damage = damage;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Имя игрока - " + Name + "\nЕго жизни - " + Health + "\nЕго урон - " + Damage);
        }
    }
}
