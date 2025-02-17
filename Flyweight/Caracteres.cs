namespace Flyweight
{
    public abstract class Caractere(char caractere) : ICaractere
    {
        public void Ecrire(ConsoleColor color)
        {
            var original = Console.ForegroundColor;

            Console.ForegroundColor = color;
            Console.Write(caractere);
            Console.ForegroundColor = original;
        }
    }
    public class CaractereA : Caractere
    {
        public CaractereA() : base('a')
        {
        }
    }
    public class CaractereB : Caractere
    {
        public CaractereB() : base('b')
        {
        }
    }
    public class CaractereC : Caractere
    {
        public CaractereC() : base('c')
        {
        }
    }
}