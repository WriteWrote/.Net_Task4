using System;

namespace Task4_3.AppCore
{
    public class Antenna
    {
        private String _name;
        private Int32 _power;
        private Double _height;

        public Antenna(string name, int power, double height)
        {
            _name = name;
            _power = power;
            _height = height;
        }

        public virtual Double Quality()
        {
            return _power + 0.5 * _height;
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public int Power
        {
            get => _power;
            set => _power = value;
        }

        public double Height
        {
            get => _height;
            set => _height = value;
        }

        public override string ToString()
        {
            return "Name: " + _name +
                   " Power: " + _power +
                   " Height: " + _height +
                   " Quality: " + Quality();
        }
    }
}