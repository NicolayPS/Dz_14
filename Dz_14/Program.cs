using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Мурка","");
            cat.ShowInfo();
            Dog dog = new Dog("Шарик","");
            dog.ShowInfo();
            Console.ReadKey();
        }
    }
}
