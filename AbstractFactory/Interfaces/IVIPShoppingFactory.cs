namespace AbstractFactory.Interfaces
{
    public interface IVIPShoppingFactory
    {
        IPourcentReduction GetReduction();
        IPrioriteCommande GetPriorite();
    }
}