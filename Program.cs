using DesafioPOO.Models;


Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero:"123456789", modelo:"Modelo sport", imei:"0", memoria: 1);
Nokia nokia2 = new Nokia(numero:"123456789", modelo:"Modelo sport", imei:"0", memoria: 1);

nokia.Ligar();
nokia.InstalarAplicativo("Instagram");

nokia2.Ligar();
nokia2.InstalarAplicativo("Uber");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone: ");
Smartphone iphone = new Iphone(numero:"123456789", modelo:"Modelo sport", imei:"0", memoria: 1);
Iphone iphone2 = new Iphone(numero:"123456789", modelo:"Modelo sport", imei:"0", memoria: 1);

iphone.Ligar();
iphone.InstalarAplicativo("Tinder");

iphone2.Ligar();
iphone2.InstalarAplicativo("YT music");



