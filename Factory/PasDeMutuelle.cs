namespace Factory
{
    public class PasDeMutuelle : Mutuelle
    {
        public override decimal GetPourcentageRemboursementMedecinTraitant() => 0m;
    }
}