namespace Composite
{
    public abstract class FileSystemElement
    {
        public abstract int GetCount();

        public string Name { get; }

        public FileSystemElement(string name)
        {
            Name = name;
        }
    }
}