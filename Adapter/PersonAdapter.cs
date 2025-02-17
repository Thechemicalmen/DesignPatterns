namespace Adapter
{
    public class PersonAdapter(ExternalPersonAPIService service) : IPersonAdapter
    {
        public Person GetPerson()
        {
            var externalPerson = service.GetPerson();
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