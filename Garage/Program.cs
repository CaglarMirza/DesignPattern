using Garage;





IAuto auto = new Auto();

IAuto autoopties = new Radio(new Trekhaak(new Auto()));


Console.WriteLine("Auto prijs :" + auto.GetPrijs());

Console.WriteLine("Auto prijs met opties :" + autoopties.GetPrijs());







