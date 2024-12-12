using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

// Instanciando a entidade Nokia
Smartphone nokia = new Nokia("5566654", "Modelo C", "11111111", 32);
nokia.Ligar();
nokia.InstalarAplicativo("Facebook");
nokia.ReceberLigacao();

Console.WriteLine("\n");

// Instanciando a entidade Iphone
Smartphone iphone = new Iphone("32312312", "Modelo X", "4344333333", 64);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Whatsapp");