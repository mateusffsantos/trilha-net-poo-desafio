using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Nokia");
Smartphone nokia = new Nokia(numero: "99999999", modelo: "Nokia T10", imei: "123123123", memoria: 12);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Waze");

Console.WriteLine("\n");

Console.WriteLine("Iphone");
Smartphone iphone = new Iphone(numero: "88888888", modelo: "Iphone 17", imei: "456456456", memoria: 64);
iphone.Ligar();
iphone.InstalarAplicativo("Instagram");