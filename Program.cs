using DesafioPOO.Models;

Console.WriteLine("nokia");
Smartphone nokia = new Nokia(numero: "12356", modelo: "Modelo 1", imei: "111111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("whats");


Console.WriteLine("iphone");
Smartphone iphone = new Iphone(numero: "12356", modelo: "Modelo 2", imei: "111111111", memoria: 64);
iphone.Ligar();
iphone.InstalarAplicativo("whats");