using System;
using System.Drawing;
using Builder.Enumerations;

namespace Builder
{
    public class Car
    {
        public Wheels Wheels { get; set; }

        public Color Color { get; set; }

        public Dashboard Dashboard { get; set; }

        public Engine Engine { get; set; }

        public Fuel Fuel { get; set; }

        public bool ESP { get; set; }

        public override string ToString()
        {
            return string.Format("Wheels: {1}{0}Color: {2}{0}Dashboard: {3}{0}Engine: {4}{0}Fuel: {5}{0}ESP: {6}",
                Environment.NewLine, Wheels, Color, Dashboard, Engine, Fuel, ESP);
        }
    }
}