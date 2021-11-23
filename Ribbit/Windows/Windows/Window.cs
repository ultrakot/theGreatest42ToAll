using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows
{
    class Window
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Guid Id { get; set; }

        public Window(double x, double y)
        {
            X = x;
            Y = y;
            Id= Guid.NewGuid();
        }

        public override string ToString()
        {
            return $"ID: {Id} | X:{X:00.000} | Y:{Y:00.000}";
        }
    }
}
