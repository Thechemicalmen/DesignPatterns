namespace Flyweight
{
    public class CaractereProvider
    {
        private Dictionary<char, ICaractere> _cache = [];

        public ICaractere? GetCaractere(char c)
        {
            if (_cache.TryGetValue(c, out var caractere))
            {
                Console.WriteLine($"Récupération d'une instance existance de {c}");
                return caractere;
            }
            Console.WriteLine($"Création d'une instance de {c}");
            ICaractere? result = c switch
            {
                'a' => new CaractereA(),
                'b' => new CaractereB(),
                'c' => new CaractereC(),
                _ => null
            };
            if (result is not null)
                _cache.Add(c, result);
            return result;
        }
    }
}