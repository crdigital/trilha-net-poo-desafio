using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia:");
Nokia nokia = new Nokia(numero:"1234567",modelo:"Modelo 2180",imei:"1111111111",memoria:128);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Iphone iphone = new Iphone(numero:"2345",modelo:"Modelo Iphone 15",imei:"2222222222",memoria:256);
iphone.Ligar();
iphone.InstalarAplicativo("WhatsApp");