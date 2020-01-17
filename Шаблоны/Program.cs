using System;
using Шаблоны.Models;
using Шаблоны.MoveTypes;

namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Car auto = new Car(4, "Volvo", new PetrolMove());
            auto.Move();
            auto.Movable = new ElectricMove();
            auto.Move();

            Console.ReadLine();
        }
    }
}
