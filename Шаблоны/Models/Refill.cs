using System;

namespace Шаблоны.Models
{
    abstract class Refill
    {
        public void Filling()
        {
            OpenTank();
            Fill();
            CloseTank();
        }
        protected abstract void Fill();
        protected virtual void CloseTank()
        {
            Console.WriteLine("Закрыть бак");
        }
        protected virtual void OpenTank()
        {
            Console.WriteLine("Открыть бак");
        }
    }
}