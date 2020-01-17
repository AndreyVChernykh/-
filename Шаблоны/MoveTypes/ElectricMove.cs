using System;
using Шаблоны.Interfaces;

namespace Шаблоны.MoveTypes
{
    class ElectricMove : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Перемещение на электричестве");
        }
    }
}
