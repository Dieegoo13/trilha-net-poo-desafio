using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "12345", modelo: "modelo 1", imei: "1111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp", "Nokia");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Nokia(numero: "5627", modelo: "modelo 2", imei: "2222222", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram", "Iphone");