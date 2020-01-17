using Шаблоны.Interfaces;

namespace Шаблоны.Models
{
    class Car
    {
        protected int _passengers; // кол-во пассажиров
        protected string _model; // модель автомобиля

        public Car(int num, string model, IMovable mov)
        {
            _passengers = num;
            _model = model;
            Movable = mov;
        }
        public IMovable Movable { private get; set; }
        public void Move()
        {
            Movable.Move();
        }
    }
}
