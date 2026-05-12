using System.Numerics;

namespace FractalEngine.Core.Fractals
{
    public class MandelbrotFractal : IFractal
    {
        private readonly int _maxIterations;
        private readonly double _bailoutRadius;

        public MandelbrotFractal(int maxIterations, double bailoutRadius)
        {
            _maxIterations = maxIterations;
            _bailoutRadius = bailoutRadius;
        }

        public int GetIterationCount(Complex c)
        {
            int iterations = 0;
            Complex z = Complex.Zero;
            while (z.Magnitude < _bailoutRadius && iterations < _maxIterations)
            {
                z = (z * z) + c;
                iterations++;
            }
            return iterations;
        }
    }
}
