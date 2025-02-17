namespace Builder
{
    public abstract class PizzaBuilder
    {
        public Pizza Pizza { get; private set; }

        public PizzaBuilder(string nom)
        {
            Pizza = new Pizza(nom);
        }

        public abstract void AjouterIngredients();
        public abstract void AjouterBase();
    }
}