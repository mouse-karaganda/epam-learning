using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal wolf = new Animal("Wolf", 15);
            wolf.Eat();

            Bird eagle = new Bird("Eagle", 4);
            eagle.Eat();
            eagle.Fly();
            eagle.Sound();

            Bird falcon = new Bird("Falcon", 8.5);
            falcon.Eat();
            falcon.Feed();
            falcon.Eat();

            Console.ReadLine();
        }
    }
}
