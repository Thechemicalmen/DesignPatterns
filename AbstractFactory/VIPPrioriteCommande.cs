using AbstractFactory.Interfaces;

namespace AbstractFactory
{
    public class VIPPrioriteCommande : IPrioriteCommande
    {
        public int Priorite => 1;
    }
}