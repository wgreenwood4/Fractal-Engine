using System.Numerics;

namespace FractalEngine.Core.Fractals
{
    public class JuliaFractal : IFractal
    {
        private readonly Complex _c;
        private readonly int _maxIterations;
        private readonly double _bailoutRadius;

        public JuliaFractal(Complex c, int maxIterations, double bailoutRadius)
        {
            _c = c;
            _maxIterations = maxIterations;
            _bailoutRadius = bailoutRadius;
        }

        public int GetIterationCount(Complex z)
        {
            int iterations = 0;
            while (z.Magnitude < _bailoutRadius && iterations < _maxIterations)
            {
                z = (z * z) + _c;
                iterations++;
            }
            return iterations;
        }
    }
}
