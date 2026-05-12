using System.Numerics;

namespace FractalEngine.Core.Fractals
{
    public interface IFractal
    {
        public int GetIterationCount(Complex z);
    }
}
