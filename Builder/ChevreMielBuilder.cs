namespace Builder
{
    public class ChevreMielBuilder : PizzaBuilder
    {
        public ChevreMielBuilder() : base("Chèvre miel")
        {

        }

        public override void AjouterBase()
        {
            Pizza.AjouterIngredient("Crème fraîche");
        }
        public override void AjouterIngredients()
        {
            Pizza.AjouterIngredient("Fromage de chèvre");
            Pizza.AjouterIngredient("Miel");
            Pizza.AjouterIngredient("Olives");
        }
    }
}