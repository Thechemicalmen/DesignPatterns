namespace Iterator
{
    public class Personne
    {
        public string Nom { get; set; }
    }

    public interface IPersonneAlphabetIterator
    {
        Personne Current { get; }
        bool MoveNext();
    }

    public class PersonneAlphabetIterator : IPersonneAlphabetIterator
    {
        private List<Personne> _copy;
        private int _current;

        public PersonneAlphabetIterator(PersonneCollection collection)
        {
            _copy = collection.ToList();
            _copy.Sort((p1, p2) => string.Compare(p1.Nom, p2.Nom));
            _current = -1;
        }

        public Personne Current
        {
            get
            {
                if (_copy.Count > _current)
                    return _copy[_current];
                return default!;
            }
        }

        public bool MoveNext()
        {
            if (_copy.Count > _current + 1)
            {
                _current++;
                return true;
            }
            return false;
        }
    }

    public class PersonneCollection : List<Personne>
    {
        public IPersonneAlphabetIterator GetIterator() => new PersonneAlphabetIterator(this);
    }
}