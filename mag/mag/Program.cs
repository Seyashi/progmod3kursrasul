using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mag
{
    class Mage
    {
        public string Name;
        public int Age;
        public int ManaLevel;
        public int HP;


        public void Attack()
        {
            Console.WriteLine($"{Name}Attack!Ожирение 3 степени!");
        }
        public void Heal()
        {
            Console.WriteLine($"{Name}Heal!Пойду покушаю хот-дог у Абидат");
        }
    }
    internal class Program
    {
        static void Main (string[] args)
        {
            Mage Artur = new Mage { Name = "Artur: "};
            Mage Halil = new Mage { Name = "Halil: "};

            Artur.Attack();
            Halil.Heal();

            Console.ReadLine();
        }
    }
   }
