using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericFunkc
{
    public class Car: IComparable<Car>
    {
        public int Id { get; set; }
        public string Regno { get; set; }
        public string Make { get; set; }

        public int Speed { get; set; }

        private int _counter = 0;

        public Car(string regno, string make, int speed)
        {
            Id = _counter++;
            Regno = regno;
            Make = make;
            Speed = speed;

        }

        public override string ToString()
        {
            return $"{{{nameof(Id)}={Id.ToString()}, {nameof(Regno)}={Regno}, {nameof(Make)}={Make}, {nameof(Speed)}={Speed.ToString()}}}";
        }

        public int CompareTo(Car? other)
        {
            if (other == null) return 1 ;
            if (this == other) return 0 ;
            if (this.Speed == other.Speed) 
                return 0;
            else if (Speed > other.Speed)
                return 1 ;
            else
                return -1 ;

        }
    }
}
