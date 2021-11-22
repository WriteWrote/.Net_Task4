using System;

namespace Task4_3.AppCore
{
    public class BetterAntenna : Antenna
    {
        private Double _emissivity;

        public BetterAntenna(string name, int power, double height, double emissivity) : base(name, power, height)
        {
            _emissivity = emissivity;
        }

        public override Double Quality()
        {
            return base.Quality() - 0.1 * _emissivity;
        }

        public override string ToString()
        {
            return base.ToString() + " Emissivity: " + _emissivity;
        }
    }
}