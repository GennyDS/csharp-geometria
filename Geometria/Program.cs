using Geometria;

Console.WriteLine("inserisci la base del rettangolo");
int BaseRettangolo= int.Parse(Console.ReadLine());

Console.WriteLine("inserisci l'altezza del rettangolo");
int AltezzaRettangolo = int.Parse(Console.ReadLine());

Rettangolo Rettangolo1 = new Rettangolo ( BaseRettangolo, AltezzaRettangolo);

Rettangolo1.CalcoloArea(BaseRettangolo, AltezzaRettangolo);
Rettangolo1.CalcoloPerimetro(BaseRettangolo, AltezzaRettangolo);
Rettangolo1.StampaRettangolo();