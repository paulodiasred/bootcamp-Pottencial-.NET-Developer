using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "31984652332", modelo: "Modelo 1", imei: "777777777", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "31976542233", modelo: "Modelo 2", imei: "333333333", memoria: 64);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");