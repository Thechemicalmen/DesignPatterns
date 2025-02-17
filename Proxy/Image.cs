namespace Proxy
{
    public class Image : IImage
    {
        private readonly string _filename;
        private byte[] _data;

        public Image(string filename)
        {
            _filename = filename;
            _data = [];
            Thread.Sleep(1000);
        }

        public void DisplayImage()
        {
            Console.WriteLine("Affichage de l'image - Implémentation");
        }
    }
}