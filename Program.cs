// See https://aka.ms/new-console-template for more information
Console.WriteLine("Digite a distância em milhas:");
double milhas = double.Parse(Console.ReadLine()!);

double km = milhas * 1.609;
Console.WriteLine($"A distância em quilômetros é: {km} km");    