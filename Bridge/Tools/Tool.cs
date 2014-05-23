using System.IO;
using Bridge.Format;

namespace Bridge.Tools
{
    public class Tool
    {
        protected ImageFormat Format;

        public Tool(ImageFormat format)
        {
            Format = format;
        }

        public void Save(TextWriter writer)
        {
            var type = GetType();
            writer.Write("This is a {0}. ", type.Name);
            Format.Draw(writer);
        }
    }

    public class Line : Tool {
        public Line(ImageFormat format) : base(format)
        {
        }
    }
    
    public class Rectangle : Tool {
        public Rectangle(ImageFormat format) : base(format)
        {
        }
    }
    
    public class Ellipse : Tool {
        public Ellipse(ImageFormat format) : base(format)
        {
        }
    }
}