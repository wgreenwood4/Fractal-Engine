using FractalEngine.Core.Fractals;
using FractalEngine.Core.Rendering;
using System.Numerics;

namespace FractalEngine.Cli
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxIterations = 200;
            double bailoutRadius = 2.0;

            Fractal mandelbrot = new MandelbrotFractal(maxIterations, bailoutRadius);
            Fractal julia = new JuliaFractal(
                new Complex(-0.8, 0.156),
                maxIterations,
                bailoutRadius
            );

            int width = 140;
            int height = 70;
            Complex center = new Complex(0.0, 0.0);
            double planeWidth = 3.5;
            Viewport viewport = new Viewport(
                width,
                height,
                center,
                planeWidth
            );

            Console.WriteLine();

            Complex pt;
            string shades = " .:-=+*#%@";

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    pt = viewport.PixelToPoint(j, i);

                    int iterations = julia.GetIterationCount(pt);

                    int index = (iterations * (shades.Length - 1)) / maxIterations;
                    Console.Write(shades[index]);
                }
                Console.WriteLine();
            }
        }
    }
}