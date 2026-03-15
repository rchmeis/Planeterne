using System;
using System.Collections.Generic;
using System.Text;

namespace Planeterne
{
    internal class Planet
    {
        public string Name { get; set; }
        public int Diameter { get; set; }
        public double RotationPeriod { get; set; }
        public int Moons { get; set; }
        public double DistanceSun { get; set; }
        public int SurfaceTemp { get; set; }
        public Planet(string name, int diameter, double rotationPeriod, int moons, double distanceSun, int surfaceTemp)
        {
            Name = name;
            Diameter = diameter;
            RotationPeriod = rotationPeriod;
            Moons = moons;
            DistanceSun = distanceSun;
            SurfaceTemp = surfaceTemp;
        }
       
        public override string ToString()
        {
            return $"Name: {Name} \nDiameter: {Diameter}km \nRotation Period: {RotationPeriod} \nNumber of Moons: {Moons} \nDistance From Sun: {DistanceSun} \nSurface Temperature: {SurfaceTemp}°C";
        }
    }
}
