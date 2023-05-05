// See https://aka.ms/new-console-template for more information

using AppFinanciero.Infraestructura.Datos.Contextos;

Console.WriteLine("Creando la DB si no existe...");
TiendaContexto db = new TiendaContexto();
db.Database.EnsureCreated();
Console.WriteLine("Listo!!!!!");
Console.ReadKey();