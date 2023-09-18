using DatabaseLayer.Models;

using var context = new DatabaseContext();

var list = context.Tables.ToList();

Console.ReadLine();