using System;
using Шаблоны.Interfaces;

namespace Шаблоны.MoveTypes
{
    class PetrolMove : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Перемещение на бензине");
        }
    }
}
