using AbstractFactory.Interfaces;

namespace AbstractFactory
{
    public class VIPPourcentReduction : IPourcentReduction
    {
        public decimal Pourcentage => 15m;
    }
}