using System.Numerics;

namespace FractalEngine.Core.Rendering
{
    public class Viewport()
    {
        private int _width { get; }
        private int _height { get; }
        private Complex _center { get; }
        private double _planeWidth { get; }

        private double _minRe { get; }
        private double _maxRe { get; }
        private double _minIm { get; }
        private double _maxIm { get; }

        public Viewport(
            int width,
            int height,
            Complex center,
            double planeWidth
            ) : this()
        {
            _width = width;
            _height = height;
            _center = center;
            _planeWidth = planeWidth;

            _minRe = _center.Real - (_planeWidth / 2);
            _maxRe = _center.Real + (_planeWidth / 2);
            _minIm = _center.Imaginary - (_planeWidth / 2);
            _maxIm = _center.Imaginary + (_planeWidth / 2);
        }

        public Complex PixelToPoint(double real, double imaginary)
        {
            double re = _minRe + (real / _width) * (_maxRe - _minRe);
            double im = _minIm + (imaginary / _height) * (_maxIm - _minIm);
            return new Complex(re, im);
        }
    }
}
