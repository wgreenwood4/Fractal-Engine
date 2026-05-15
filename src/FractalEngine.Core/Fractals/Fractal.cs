using System.Drawing;
using System.Numerics;

namespace FractalEngine.Core.Fractals
{
    public abstract class Fractal
    {
        public int MaxIterations { get; }
        public double BailoutRadius { get; }

        public Fractal(int maxIterations, double bailoutRadius)
        {
            MaxIterations = maxIterations;
            BailoutRadius = bailoutRadius;
        }

        public abstract Complex SetZ(Complex point);

        public abstract Complex SetC(Complex point);

        public abstract Complex SequenceRule(Complex z, Complex c);

        public int GetIterationCount(Complex point)
        {
            int iterations = 0;
            Complex z = SetZ(point);
            Complex c = SetC(point);

            while(z.Magnitude < BailoutRadius && iterations < MaxIterations)
            {
                z = SequenceRule(z, c);
                iterations++;
            }

            return iterations;
        }
    }
}
