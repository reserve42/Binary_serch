using System;

int min = 1;
int max = 100;
int guess;
string response = "";

Console.WriteLine("Pense em um número entre 1 e 100.");
Console.WriteLine("Eu vou tentar adivinhar.");

while (response != "c")
{
    guess = (min + max) / 2;
    Console.WriteLine($"Eu acho que é {guess}. Está correto (c), maior (m) ou menor (l)?");
#pragma warning disable CS8602 // dereference of a possibly null reference.
    response = Console.ReadLine().ToLower();
#pragma warning restore CS8602 // dereference of a possibly null reference.

    if (response == "m")
    {
        min = guess + 1;
    }
    else if (response == "l")
    {
        max = guess - 1;
    }
    else if (response == "c")
    {
        Console.WriteLine($"Eu acertei! O número é {guess}.");
    }
    else
    {
        Console.WriteLine("Resposta inválida. Por favor, responda com 'c', 'm' ou 'l'.");
    }
}
