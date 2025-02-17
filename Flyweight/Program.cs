using Flyweight;

string s = "abccba";

var provider = new CaractereProvider();

var a = provider.GetCaractere(s[0]);
a?.Ecrire(ConsoleColor.Blue);
var b = provider.GetCaractere(s[1]);
b?.Ecrire(ConsoleColor.White);
var c = provider.GetCaractere(s[2]);
c?.Ecrire(ConsoleColor.Red);
var d = provider.GetCaractere(s[3]);
d?.Ecrire();
var e = provider.GetCaractere(s[4]);
e?.Ecrire();
var f = provider.GetCaractere(s[5]);
f?.Ecrire();