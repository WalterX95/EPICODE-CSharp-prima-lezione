using Epicode_Classi;

Console.WriteLine("Classe Atleta.cs");

Atleta atleta1 = new Atleta("Matteo","Battilocchio","Maschio",15);

Atleta atleta2 = new Atleta("Walter", "Antonelli", "Maschio", 12);

atleta1.GetInfo();
Console.WriteLine("     ");
atleta2.GetInfo();

Console.WriteLine("Classe Dipendente.cs");

Dipendente dipendente1 = new Dipendente("Franscesco", "Lupi", "Maschio", "Umbrerella Corporation");

Dipendente dipendente2 = new Dipendente("Martina", "Corta", "Femmina", "Microsoft Corporation");

dipendente1.GetInfoDip();
Console.WriteLine("     ");
dipendente2.GetInfoDip();

Console.WriteLine("Classe Animale.cs");

Animale animale1 = new Animale("Giugi", "Cane", "Bianco");

Animale animale2 = new Animale("Pippo", "Gatto", "Nero");

animale1.GetInfoAnimale();
Console.WriteLine("     ");
animale2.GetInfoAnimale();

Console.WriteLine("Classe Veicolo.cs");

Veicolo veicolo1 = new Veicolo("Ford", 4, "Rossa", "EJK456");

Veicolo veicolo2 = new Veicolo("Ferrari", 4, "Bianca", "EJK456ZZX");

veicolo1.GetInfoVeicolo();
Console.WriteLine("     ");
veicolo2.GetInfoVeicolo();