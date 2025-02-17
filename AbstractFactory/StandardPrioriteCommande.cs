using AbstractFactory.Interfaces;

namespace AbstractFactory
{
    public class StandardPrioriteCommande : IPrioriteCommande
    {
        public int Priorite => 0;
    }
}