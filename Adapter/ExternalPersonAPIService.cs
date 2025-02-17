namespace Adapter
{
    public class ExternalPersonAPIService
    {
        public PersonExternal GetPerson() => new() { ID = 1, FullName = "VANDEMERT Florian" };
    }
}