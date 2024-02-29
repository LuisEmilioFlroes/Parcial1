using System;

class Program
{
    static void Main(string[] args)
    {
        int numero;

        // Solicita al usuario un número entero positivo
        do
        {
            Console.Write("Ingrese un número entero positivo: ");
        } while (!int.TryParse(Console.ReadLine(), out numero) || numero < 0);

        // Menú y operaciones
        while (true)
        {
            Console.WriteLine("\nMenú:");
            Console.WriteLine("1. Calcular el factorial del número.");
            Console.WriteLine("2. Calcular la raíz cuadrada del número.");
            Console.WriteLine("3. Salir del programa.");
            Console.Write("Elija una opción: ");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Console.WriteLine($"El factorial de {numero} es: {Factorial(numero)}");
                    break;
                case "2":
                    Console.WriteLine($"La raíz cuadrada de {numero} es: {Math.Sqrt(numero)}");
                    break;
                case "3":
                    Console.WriteLine("¡Adiós!");
                    return;
                default:
                    Console.WriteLine("Opción no válida. Por favor, elija una opción válida.");
                    break;
            }
        }
    }

    // Calcula el factorial de un número
    static long Factorial(int n)
    {
        if (n == 0)
            return 1;
        else
            return n * Factorial(n - 1);
    }
}