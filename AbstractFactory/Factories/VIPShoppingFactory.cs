using AbstractFactory.Interfaces;

namespace AbstractFactory.Factories
{
    public class VIPShoppingFactory : IVIPShoppingFactory
    {
        public IPrioriteCommande GetPriorite() => new VIPPrioriteCommande();
        public IPourcentReduction GetReduction() => new VIPPourcentReduction();
    }
}