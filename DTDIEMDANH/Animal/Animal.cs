using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    abstract class Animal
    {
        public virtual void eat()
        {

        }
        public virtual void makesound()
        {

        }
    }
    class Cat : Animal
    {
        public override void eat()
        {
            Console.WriteLine("Cat is eating!");
        }
        public override void makesound()
        {
            Console.WriteLine("Meow Meow!");
        }
        public void run()
        {
            Console.WriteLine("Cat is running!");
        }
    }

    class Bird : Animal
    {
        public override void eat()
        {
            Console.WriteLine("Bird is eating!");
        }
        public override void makesound()
        {
            Console.WriteLine("%&$&#");
        }
        public void fly()
        {
            Console.WriteLine("Bird is running!");
        }
    }
    class main
    {
        static void Main(string[] args)
        {
            Cat c_46 = new Cat();
            Bird b_46 = new Bird();
            c_46.eat();
            c_46.makesound();
            c_46.run();

            b_46.eat();
            b_46.makesound();
            b_46.fly();
        }
    }

}
