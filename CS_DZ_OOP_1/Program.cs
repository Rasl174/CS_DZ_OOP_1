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
        private string _name;
        private int _health;
        private int _damage;

        public Player(string name, int health, int damage)
        {
            _name = name;
            _health = health;
            _damage = damage;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Имя игрока - " + _name + "\nЕго жизни - " + _health + "\nЕго урон - " + _damage);
        }
    }
}
