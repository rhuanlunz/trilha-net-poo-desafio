using DesafioPOO.Models;

// Teste da classe Nokia
var nokia = new Nokia("+55 27 99999-9999", "Nokia 8.3 5G", "987654321012345", 64);

nokia.Ligar();

nokia.ReceberLigacao();

nokia.InstalarAplicativo("Nokia Snake Adventure");

// Teste da classe Iphone
var iphone = new Iphone("+55 27 97777-7777", "iPhone 13 Pro", "0123456789012345", 256);

iphone.Ligar();

iphone.ReceberLigacao();

iphone.InstalarAplicativo("Bubble Pop Frenzy");