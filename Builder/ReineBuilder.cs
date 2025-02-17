namespace Builder
{
    public class ReineBuilder : PizzaBuilder
    {
        public ReineBuilder() : base("Reine")
        {

        }

        public override void AjouterBase()
        {
            Pizza.AjouterIngredient("Sauce tomate");
        }
        public override void AjouterIngredients()
        {
            Pizza.AjouterIngredient("Jambon");
            Pizza.AjouterIngredient("Champignons");
            Pizza.AjouterIngredient("Emmental");
        }
    }
}