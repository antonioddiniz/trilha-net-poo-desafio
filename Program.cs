using DesafioPOO.Models;



Iphone ip1 = new Iphone("numeroiphone", "Iphone 15","12345",128);
Nokia nk1 = new Nokia("numeronokia", "N95","54321", 64);

Console.WriteLine($"Modelo:{ip1.Modelo} Número:{ip1.Numero} IMEI:{ip1.IMEI} Memoria:{ip1.Memoria}");
Console.WriteLine($"Modelo:{nk1.Modelo} Número:{nk1.Numero} IMEI:{nk1.IMEI} Memoria:{nk1.Memoria}");

ip1.InstalarAplicativo("Uber");



//string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria



// TODO: Realizar os testes com as classes Nokia e Iphone