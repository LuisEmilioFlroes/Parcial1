using System;

class Program
{
    static double Calcular(double num1, double num2, char operador)
    {
        switch (operador)
        {
            case '+':
                return num1 + num2;
            case '-':
                return num1 - num2;
            case '*':
                return num1 * num2;
            case '/':
                if (num2 != 0)
                    return num1 / num2;
                else
                    throw new DivideByZeroException("No es posible dividir por cero.");
            default:
                throw new ArgumentException("El operadorno es válido.");
        }
    }

    static void Main(string[] args)
    {
        try
        {
            Console.Write("Introduce el primer número entero: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Introduce el segundo número entero: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Introduce el operador matemático (+, -, *, /): ");
            char operador = Convert.ToChar(Console.ReadLine());

            double resultado = Calcular(num1, num2, operador);
            Console.WriteLine("El resultado es: " + resultado);
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Debes ingresar números enteros válidos.");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
