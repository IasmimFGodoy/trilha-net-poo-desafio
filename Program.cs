using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia("123456", "111111111", "Modelo 1", 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone");
Smartphone iphone = new Iphone("4987", "222222222", "Modelo 2", 128);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");