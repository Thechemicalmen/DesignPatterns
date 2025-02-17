namespace Bridge
{
    public class AbonnementPremium : Abonnement
    {
        public AbonnementPremium(IReduction? reduction) : base(reduction)
        {
        }

        public override int GetPrice() => 50 - (reduction is null ? 0 : reduction.Reduction);
    }
}