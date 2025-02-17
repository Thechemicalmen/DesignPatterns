namespace Decorator
{
    public class PersonneWrapper(Personne personne)
    {
        public string Nom
        {
            get => personne.Nom;
            set => personne.Nom = value;
        }

        public DateTime DateInscription { get; set; }
        public string NomComplet => $"{personne.Prenom} {personne.Nom}";
    }
}