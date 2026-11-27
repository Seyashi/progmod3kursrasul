
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public virtual string Speak()
        {
            return "Animal sound";
        }
    }
    //производный класс Dog
    public class Dog : Animal
    {
        public override string Speak()
        {
            return "Woof!";
        }
    }
    //производный класс Cat
    public class Cat : Animal
    {
        public override string Speak()
        {
            {
                return "Meow!";

            }
        }
    }
}