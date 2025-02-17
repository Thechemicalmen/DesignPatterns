using AbstractFactory.Interfaces;

namespace AbstractFactory
{
    public class ShoppingCart(IVIPShoppingFactory factory)
    {
        public void PasserCommande()
        {
            var priorite = factory.GetPriorite().Priorite;
            var pourcent = factory.GetReduction().Pourcentage;

            Console.WriteLine($"Priorite = {priorite}");
            Console.WriteLine($"Pourcent = {pourcent}");
        }
    }
}