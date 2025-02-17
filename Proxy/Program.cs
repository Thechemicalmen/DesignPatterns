using Proxy;

Console.WriteLine($"Début : {DateTime.UtcNow:HH:mm:ss:fff}");
var image = new Image(@"C:\dir\monimage.png");
Console.WriteLine($"Fin : {DateTime.UtcNow:HH:mm:ss:fff}");

Lazy<Image> imageProxy2 = new(() => new(@"C:\dir\monimage.png"));
Console.WriteLine($"Fin : {DateTime.UtcNow:HH:mm:ss:fff}");

Console.WriteLine($"Début : {DateTime.UtcNow:HH:mm:ss:fff}");
var imageProxy = new ImageProxy(@"C:\dir\monimage.png");
Console.WriteLine($"Fin : {DateTime.UtcNow:HH:mm:ss:fff}");

Console.WriteLine($"Début : {DateTime.UtcNow:HH:mm:ss:fff}");
imageProxy2.Value.DisplayImage();
Console.WriteLine($"Fin : {DateTime.UtcNow:HH:mm:ss:fff}");