namespace Factory.Factories
{
    public class LesOisillionsMutuelleFactory : MutuelleFactory
    {
        public override Mutuelle GetMutuelle(Patient p)
        {
            return new LesOisillonsMutuelle();
        }
    }
}