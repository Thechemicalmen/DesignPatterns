namespace Composite
{
    public class FileElement : FileSystemElement
    {
        public FileElement(string name) : base(name)
        {

        }

        public override int GetCount() => 1;
    }
}