using DesafioPOO.Models;

Console.WriteLine("Teste do Nokia:");
Nokia nokiacell = new Nokia("10291203","model-1", "000099999", 64);
nokiacell.Ligar();
nokiacell.InstalarAplicativo("Tik tok");

Console.WriteLine("Teste do Iphone: ");
Iphone iphonecell = new Iphone("12340512","model-2","0000001111",124);
iphonecell.Ligar();
iphonecell.InstalarAplicativo("Instagram");