namespace Builder
{
    public class Pizza
    {
        public string Nom { get; set; }
        public List<string> Ingredients { get; set; }

        public Pizza(string nom)
        {
            Nom = nom;
            Ingredients = [];
        }

        public void AjouterIngredient(string ingredient)
        {
            Ingredients.Add(ingredient);
        }

        public override string ToString()
        {
            return $"Pizza {Nom}, ingrédients: {string.Join(",", Ingredients)}";
        }
    }
}