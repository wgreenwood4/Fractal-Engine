using FractalEngine.Core.Computation;
using FractalEngine.Core.Fractals;
using System.Numerics;

namespace FractalEngine.Cli
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxIterations = 200;
            double bailoutRadius = 2.0;

            IFractal mandelbrot = new MandelbrotFractal(maxIterations, bailoutRadius);

            /*
            Console.WriteLine($"Max Iterations: {maxIterations}");
            Console.WriteLine($"Bailout Radius: {bailoutRadius}");
            Console.WriteLine($"Test Point: {testPoint.ToString()}");
            Console.WriteLine($"-----------------------------------------");
            Console.WriteLine($"Iterations: {iterations}");
            if (iterations < maxIterations)
            {
                Console.WriteLine("DIVERGED -> NOT IN MANDELBROT SET");
            }
            else
            {
                Console.WriteLine("CONTAINED -> IN MANDELBROT SET");
            }
            */

            int width = 140;
            int height = 70;
            double min = -1 * bailoutRadius;
            double max = bailoutRadius;

            Console.WriteLine();

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    double re = min + ((double)j / width) * (max - min);
                    double im = min + ((double)i / height) * (max - min);
                    Complex pt = new Complex(re, im);

                    int iterations = mandelbrot.GetIterationCount(pt);

                    if (iterations < maxIterations)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("*");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}