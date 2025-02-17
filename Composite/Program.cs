using Composite;

var root = new DirectoryElement("root");
var subFolder1 = new DirectoryElement("folder1");
var subFolder2 = new DirectoryElement("folder2");

var file1 = new FileElement("file1");
var file2 = new FileElement("file2");
var file3 = new FileElement("file3");
var file4 = new FileElement("file4");

root.AddElement(subFolder1);
subFolder1.AddElement(subFolder2);

subFolder1.AddElement(file1);
subFolder1.AddElement(file2);
root.AddElement(file3);
subFolder2.AddElement(file4);

Console.WriteLine($"Root count : {root.GetCount()}");
Console.WriteLine($"SubFolder 1 count : {subFolder1.GetCount()}");
Console.WriteLine($"SubFolder 2 count : {subFolder2.GetCount()}");
Console.WriteLine($"File 1 count : {file1.GetCount()}");