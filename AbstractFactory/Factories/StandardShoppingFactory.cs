using AbstractFactory.Interfaces;

namespace AbstractFactory.Factories
{
    public class StandardShoppingFactory : IVIPShoppingFactory
    {
        public IPrioriteCommande GetPriorite() => new StandardPrioriteCommande();
        public IPourcentReduction GetReduction() => new StandardPourcentReduction();
    }
}