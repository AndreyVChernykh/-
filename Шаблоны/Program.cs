using System;
using Шаблоны.Models;
using Шаблоны.MoveTypes;

namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var petrol = new Petrol();
            var electric = new Electric();
            Car auto = new Car(4, "Volvo", petrol);
            auto.Move();
            petrol.Filling();
            auto.Movable = electric;
            auto.Move();
            electric.Filling();

            Console.ReadLine();
        }
    }
}
