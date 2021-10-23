using System;
using System.Collections.Generic;
using OOPAssignment.Interfaces;
using OOPAssignment.Structs;
using System.Linq;

namespace OOPAssignment.Entities
{
    public class Surface : ISurface, ICollidableSurface, Interfaces.IObserver<CarInfo>
    {
        public long Width { get; set; }

        public long Height { get; set; }

        private List<CarInfo> ObservableCars = new List<CarInfo>();

        public Surface(long width, long height)
        {
            Width = width;
            Height = height;
        }

        public List<CarInfo> GetObservables()
        {
            List<CarInfo> _infos = new List<CarInfo>();
            _infos.AddRange(ObservableCars);
            return _infos;
        }

        public bool IsCoordinatesEmpty(Coordinates coordinates)
        {
            // Listede ayný konuma ait araç var mý?
            var _car = ObservableCars
                .FirstOrDefault(x => x.Coordinates.X == coordinates.X && x.Coordinates.Y == coordinates.Y);
            //var _car = ObservableCars
            //    .Any(x => x.Coordinates.X == coordinates.X && x.Coordinates.Y == coordinates.Y);

            // _car var mý
            if (_car is not null)
                return false;
            else
                return true;
        }

        public bool IsCoordinatesInBounds(Coordinates coordinates)
        {
            // Araç sýnýrlar içinde mi?
            bool status = false;
            // 0<X<Width & 0<Y<Height
            if ((coordinates.X >= 0 && coordinates.X <= Width) && (coordinates.Y >= 0 && coordinates.Y <= Height))
                status = true;

            return status;
        }

        public void Update(CarInfo provider)
        {
            var _car = ObservableCars.FirstOrDefault(x => x.CarId == provider.CarId);

            Coordinates _coordinates = provider.Coordinates;
            // sýnýr kontrolü
            if (IsCoordinatesInBounds(_coordinates) == false)
                throw new Exception("Araç sýnýrlar dýþýnda.");
            // konum kontrolü
            if (IsCoordinatesEmpty(_coordinates) == false)
            {
                // konumdaki aracýn id'si ile providerdaki id farklý mý?
                var car = ObservableCars
                    .FirstOrDefault(x => x.CarId != provider.CarId
                    && x.Coordinates.X == provider.Coordinates.X
                    && x.Coordinates.Y == provider.Coordinates.Y);

                if (car is not null)
                    throw new Exception("Konumda idsi farklý araç bulunuyor.");
            }
            // arac varsa güncelleme yap
            else if (_car is not null)
            {
                _car = provider;
            }
            //arac yoksa yeni arac ekle
            else
                ObservableCars.Add(provider);
        }
    }
}