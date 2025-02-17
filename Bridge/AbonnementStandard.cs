namespace Bridge
{
    public class AbonnementStandard : Abonnement
    {
        public AbonnementStandard(IReduction? reduction) : base(reduction)
        {
        }

        public override int GetPrice() => 20 - (reduction is null ? 0 : reduction.Reduction);
    }
}