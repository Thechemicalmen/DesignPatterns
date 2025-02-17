namespace Bridge
{
    public abstract class Abonnement(IReduction? reduction)
    {
        protected readonly IReduction? reduction = reduction;

        public abstract int GetPrice();
    }
}