using System.IO;

namespace Bridge.Format
{
    public abstract class ImageFormat
    {
        protected string Display = "This is an ImageFormat.";

        public void Draw(TextWriter writer)
        {
            writer.WriteLine(Display);
        }
    }

    public class SVG : ImageFormat
    {
        public SVG()
        {
            Display = "Display as SVG format.";
        }
    }

    public class BMP : ImageFormat
    {
        public BMP()
        {
            Display = "Formatted as BMP.";
        }
    }

    public class PNG : ImageFormat
    {
        public PNG()
        {
            Display = "This is a PNG image.";
        }
    }

    public class JPG : ImageFormat
    {
        public JPG()
        {
            Display = "The ever popular JPG/JPEG.";
        }
    }
}