using System;
using Шаблоны.Interfaces;
using Шаблоны.Models;

namespace Шаблоны.MoveTypes
{
    class Petrol : Refill, IMovable
    {
        protected override void Fill()
        {
            Console.WriteLine("Заправка");
        }

        public void Move()
        {
            Console.WriteLine("Перемещение на бензине");
        }
    }
}
