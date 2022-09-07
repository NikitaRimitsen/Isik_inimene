// See https://aka.ms/new-console-template for more information

using Isik_inimene;

Opilane opilane = new Opilane(Isik.sugu_.Mees, "Nikita Rimitsen", 2004, "Tallinna Tööstusharidus keskus", "TARpv20", "Noorem tarkvaraarendus", 60);
Tootaja tootaja = new Tootaja(Isik.sugu_.Naine, "Valentina Zinaidovna", 1967, "Tallinna Tööstusharidus keskus", "Tallinna Tööstusharidus keskus amet", 1500);
opilane.print();
tootaja.print();