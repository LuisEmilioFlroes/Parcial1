using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int numeroSecreto = random.Next(1, 101);
        int intentos = 0;

        Console.WriteLine("¡Adivina el número secreto!");

        while (true)
        {
            Console.Write("Introduce un número entre 1 y 100: ");
            int numeroUsuario;
            if (!int.TryParse(Console.ReadLine(), out numeroUsuario) || numeroUsuario < 1 || numeroUsuario > 100)
            {
                Console.WriteLine("Por favor, introduce un número válido entre 1 y 100.");
                continue;
            }

            intentos++;

            if (numeroUsuario == numeroSecreto)
            {
                Console.WriteLine($"¡Felicidades! Adivinaste el número secreto en un total de {intentos} intentos.");
                break;
            }
            else if (numeroUsuario < numeroSecreto)
            {
                Console.WriteLine("El número secreto es mayor.");
            }
            else
            {
                Console.WriteLine("El número secreto es menor.");
            }
        }
    }
}
