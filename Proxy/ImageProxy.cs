namespace Proxy
{
    public class ImageProxy : IImage
    {
        private readonly string _filename;

        public ImageProxy(string filename)
        {
            _filename = filename;
        }

        public void DisplayImage()
        {
            var image = new Image(_filename);
            Console.WriteLine("Affichage de l'image - Proxy");
        }
    }
}