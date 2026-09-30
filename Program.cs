// See https://aka.ms/new-console-template for more information
Console.WriteLine("Witaj ja!");
Console.WriteLine("Twe imie: ");
string tmp = Console.ReadLine();
Console.WriteLine("Witaj "+tmp+"\nIle masz lat: ");
tmp = Console.ReadLine();
double age;
if(double.TryParse(tmp, out age))
{
    Console.WriteLine("za dziesięć lat będziesz miał(a) "+(age + 10)+" lat!");
}
else
{
    Console.WriteLine("Nie wiek");
    return;
}
