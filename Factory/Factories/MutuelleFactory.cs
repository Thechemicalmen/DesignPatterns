namespace Factory.Factories
{
    public abstract class MutuelleFactory
    {
        public abstract Mutuelle GetMutuelle(Patient p);
       /* {
            if (string.IsNullOrEmpty(p.NumeroMutuelle))
                return new PasDeMutuelle();
            if (p.NumeroMutuelle.StartsWith("003"))
                return new LesOisillonsMutuelle();
            return new LeopardMutuelle();
        }*/
    }
}