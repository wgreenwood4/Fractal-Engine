using System.Numerics;

namespace FractalEngine.Core.Fractals
{
    public class JuliaFractal : Fractal
    {
        private readonly Complex _c;

        public JuliaFractal(Complex c, int maxIterations, double bailoutRadius) :
            base(maxIterations, bailoutRadius)
        {
            _c = c;
        }

        public override Complex SetZ(Complex point)
        {
            return point;
        }

        public override Complex SetC(Complex point)
        {
            return _c;
        }

        public override Complex SequenceRule(Complex z, Complex c)
        {
            return (z * z) + c;
        }
    }
}
