using System;
using OOPAssignment.Enums;
using OOPAssignment.Interfaces;
using OOPAssignment.Structs;

namespace OOPAssignment.Entities
{
    public class Car : ICarCommand, Interfaces.IObservable<CarInfo>
    {
        public Guid Id;
        public Coordinates Coordinates;
        private Interfaces.IObserver<CarInfo> Observer;
        public Direction Direction { get; set; }
        public ISurface Surface { get; set; }

        public Car(Coordinates coordinates, Direction direction, ISurface surface)
        {
            Surface = surface;
            Direction = direction;
            Coordinates = coordinates;
            Id = Guid.NewGuid();
        }

        public void Attach(Interfaces.IObserver<CarInfo> observer)
        {
            Observer = observer;
            Notify();
        }

        public void Notify()
        {
            Coordinates _coordinates = new() { X = Coordinates.X, Y = Coordinates.Y };
            CarInfo _info = new CarInfo(Id, _coordinates);
            Observer.Update(_info);
        }

        public void Move(MovementFactor mF)
        {
            //Koordinatları değişkene atama
            mF = new() { XFactor = (int)Coordinates.X, YFactor = (int)Coordinates.Y };

            //N y+ & S y- & W x- & E x+
            if (Direction == Direction.N)
                mF.YFactor++;
            else if (Direction == Direction.S)
                mF.YFactor--;
            else if (Direction == Direction.W)
                mF.XFactor--;
            else if (Direction == Direction.E)
                mF.XFactor++;
            else
                throw new Exception("Hareket Edilemedi.");

            Coordinates = new Coordinates { X = mF.XFactor, Y = mF.YFactor };

            Notify();
        }

        public void TurnLeft()
        {
            //N>W - S>E - W>S - E>N
            if (Direction == Direction.N)
                Direction = Direction.W;
            else if (Direction == Direction.S)
                Direction = Direction.E;
            else if (Direction == Direction.W)
                Direction = Direction.S;
            else if (Direction == Direction.E)
                Direction = Direction.N;
            else
                throw new Exception("Sola dönülemedi.");
            //CarInfo'da Direction tutulmadığı için Notify yok
        }

        public void TurnRight()
        {
            //N>E - S>W - W>N - E>S
            if (Direction == Direction.N)
                Direction = Direction.E;
            else if (Direction == Direction.S)
                Direction = Direction.W;
            else if (Direction == Direction.W)
                Direction = Direction.N;
            else if (Direction == Direction.E)
                Direction = Direction.S;
            else
                throw new Exception("Sağa dönülemedi.");
            //CarInfo'da Direction tutulmadığı için Notify yok
        }
    }
}