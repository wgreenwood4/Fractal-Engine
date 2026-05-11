using System.Numerics;

namespace FractalEngine.Core.Fractals
{
    internal class MandelbrotFractal
    {
        public readonly Complex _z0 = Complex.Zero;
        public Complex IterationRule(Complex z, Complex c)
        {
            return Complex.Add(Complex.Multiply(z,z), c);
        }
    }
}
