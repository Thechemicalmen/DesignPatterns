namespace Adapter
{
    public class ExternalPersonAdapter : ExternalPersonAPIService, IPersonAdapter
    {
        public new Person GetPerson()
        {
            var externalPerson = base.GetPerson();
            var names = externalPerson.FullName.Split(' ');
            return new Person
            {
                ID = externalPerson.ID,
                LastName = names[0],
                Name = names[1]
            };
        }
    }
}