using System.Numerics;

namespace FractalEngine.Core.Fractals
{
    public class MandelbrotFractal : Fractal
    {
        public MandelbrotFractal(int maxIterations, double bailoutRadius) :
            base(maxIterations, bailoutRadius)
        {
        }

        public override Complex SetZ(Complex point)
        {
            return Complex.Zero;
        }

        public override Complex SetC(Complex point)
        {
            return point;
        }

        public override Complex SequenceRule(Complex z, Complex c)
        {
            return (z * z) + c;
        }
    }
}
