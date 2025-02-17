namespace Factory
{
    public class LesOisillonsMutuelle : Mutuelle
    {
        public override decimal GetPourcentageRemboursementMedecinTraitant() => 100m;
    }
}