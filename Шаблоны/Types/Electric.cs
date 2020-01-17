using System;
using Шаблоны.Interfaces;
using Шаблоны.Models;

namespace Шаблоны.MoveTypes
{
    class Electric : Refill, IMovable
    { 
        protected override void Fill()
        {
            Console.WriteLine("Подзарядка");
        }

        public void Move()
        {
            Console.WriteLine("Перемещение на электричестве");
        }
    }
}
