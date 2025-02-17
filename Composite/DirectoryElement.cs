namespace Composite
{
    public class DirectoryElement : FileSystemElement
    {
        private List<FileSystemElement> _elements = [];
        public IEnumerable<FileSystemElement> Elements => _elements;

        public DirectoryElement(string name) : base(name)
        {

        }

        public void AddElement(FileSystemElement element) => _elements.Add(element);
        public void RemoveElement(string name) => _elements.RemoveAll(e => e.Name.Equals(name));

        public override int GetCount() => Elements.Sum(e => e.GetCount());
    }
}