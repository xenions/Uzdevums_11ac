Console.WriteLine("Ievadiet cukura cenu");
double cukura_c = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Ievadiet abolu cenu");
double abolu_c = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ievadiet cukura daudzumu");
double cukura_d = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Ievadiet abolu daudzumu");
double abolu_d = Convert.ToDouble(Console.ReadLine());

double cena = cukura_c*cukura_d+abolu_c*abolu_d;
Console.WriteLine("Ievarijuma izmaksas = " + cena);