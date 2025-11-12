Aprozar apr1 = new Aprozar("Aprozar1", "saaa@gmail.com");
Produs p1 = new ProdusLaBucata("oua", 1000, 5, 0);
Produs p3 = new ProdusLaBucata("paine", 500, 10,1000 );
Produs p2 = new ProdusLaKg("mere", 10, 3, "kg");
Produs p4 = new ProdusLaKg("Cartofi", 1000, 8, "kg");
apr1.AddProdus(p1);
apr1.AddProdus(p2);
apr1.AddProdus(p3);
apr1.AddProdus(p4);
apr1.AddProdus(p1);
apr1.Afisare();



