using Soldaten;

Bataljon bataljon1 = new Bataljon();
Compagne compagne = new Compagne();
Peloton peloton = new Peloton();

Soldat soldat = new Soldat();

peloton.Add(soldat);
compagne.Add(soldat);



peloton.TrekTenStrijde();
bataljon1.TrekTenStrijde(); //!!
compagne.TrekTenStrijde();



