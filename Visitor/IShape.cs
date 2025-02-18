namespace Visitor
{
    public interface IVisitor
    {
        void Visit(IShape shape);
    }

    public interface IShape
    {
        void Accept(IVisitor visitor);
    }

    public class Shape : IShape
    {
        public void Accept(IVisitor visitor) => visitor.Visit(this);
    }

    public class Square : Shape
    {
        public double Size { get; set; }
    }

    public class Circle : Shape
    {
        public double Radius { get; set; }
    }

    public class AreaVisitor : IVisitor
    {
        public void Visit(IShape shape)
        {
            if (shape is Square square)
            {
                var area = square.Size * square.Size;
                Console.WriteLine($"La forme est un carré de {square.Size}cm de côté et sa surface est {area}cm²");
            }
            else if (shape is Circle circle)
            {
                var area = Math.PI * circle.Radius * circle.Radius;
                Console.WriteLine($"La forme est un cercle de {circle.Radius}cm de rayon et sa surface est {area:#.##}cm²");
            }
        }
    }
}