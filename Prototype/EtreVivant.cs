namespace Prototype
{
    public abstract record EtreVivant
    {
        public string Nom { get; set; } = string.Empty;
        //public abstract EtreVivant Clone(bool deepClone);
    }
}