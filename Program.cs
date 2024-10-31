using DesafioPOO.Models;

Console.Clear();
Console.WriteLine("SmartPhone Nokia:");
Smartphone nokia = new Nokia("27991921563", "SK21A", "101222251", 128);
nokia.Ligar();
nokia.InstalarAplicativo("WhatSapp");

Console.WriteLine("\n");

Console.WriteLine("SmartPhone iPhone:");
Smartphone iphone = new Iphone("27991921563", "STJ21KL", "1012222978", 256);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");

