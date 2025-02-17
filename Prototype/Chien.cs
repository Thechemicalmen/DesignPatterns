namespace Prototype
{
    public record Chien : EtreVivant
    {
        public Personne Proprietaire { get; private set; }

        public Chien(string nom, Personne proprietaire)
        {
            Nom = nom;
            Proprietaire = proprietaire;
        }
        /*public override EtreVivant Clone(bool deepClone = false)
        {
            if (deepClone)
            {
                var chien = (Chien)MemberwiseClone();
                chien.Proprietaire = (Personne)Proprietaire.Clone(true);
                return chien;
            }
            return (EtreVivant)MemberwiseClone();
        }*/
    }
}