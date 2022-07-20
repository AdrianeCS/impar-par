Console.WriteLine("Tabela impar ou par");

Console.WriteLine("obs: azul indica impar e vermelho para par");

int n1;

Console.Write("digite o número...:");
n1 = Convert.ToInt32(Console.ReadLine());

if(n1 %2==0)
{
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("par");
}

else
{Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("impar");}