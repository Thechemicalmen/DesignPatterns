using Visitor;

var square = new Square { Size = 10 };
var circle = new Circle { Radius = 5 };

var visitor = new AreaVisitor();

visitor.Visit(square);
visitor.Visit(circle);

square.Accept(visitor);
circle.Accept(visitor);