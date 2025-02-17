namespace Builder
{
    public class BorneDeVente
    {
        public void PreparerPizza(PizzaBuilder builder)
        {
            builder.AjouterBase();
            builder.AjouterIngredients();
        }
    }
}