using System.Numerics;

namespace FractalEngine.Core.Fractals
{
    internal class JuliaFractal
    {
        public readonly Complex _c;
        public JuliaFractal(Complex c) => _c = c;
        public Complex IterationRule(Complex z)
        {
            return Complex.Add(Complex.Multiply(z,z), _c);
        }
    }
}