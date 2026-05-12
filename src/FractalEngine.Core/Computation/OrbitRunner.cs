using FractalEngine.Core.Fractals;
using System.Numerics;

namespace FractalEngine.Core.Computation
{
    public class OrbitRunner
    {
        private readonly IFractal _fractal;
        private readonly Complex _point;

        public OrbitRunner(IFractal fractal, Complex point)
        {
            _fractal = fractal;
            _point = point;
        }

        public int GetIterationCount()
        {
            return _fractal.GetIterationCount(_point);
        }
    }
}
