using ConsoleApp2;

Invoice invoice = new Invoice(5, "g", "gg", "ggg", 6);

Console.WriteLine(invoice.PDV());
Console.WriteLine(invoice.WithoutPDV());
