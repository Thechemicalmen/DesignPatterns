namespace Prototype
{
    public record Personne : EtreVivant
    {
        public Personne(string nom)
        {
            Nom = nom;
        }
        /*public override EtreVivant Clone(bool deepClone = false)
        {
            return (EtreVivant)MemberwiseClone();
        }*/
    }
}