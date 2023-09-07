/*Conditionals
Console.WriteLine("Escribe un número: ");
int num = int.Parse(Console.ReadLine());
if (num > 0) Console.WriteLine("Positivo ");
else if (num < 0) Console.WriteLine("Negativo");
else Console.WriteLine("Es Cero ");*/
/*Operators*/

class Program
{
    static void Main()
    {
        // Solicitar el primer número
        Console.Write("Ingresa el primer número: ");
        double num_1 = ObtenerNumero();

        // Solicitar el segundo número
        Console.Write("Ingresa el segundo número: ");
        double num_2 = ObtenerNumero();

        // Realizar cálculos
        double suma = num_1 + num_2;
        double resta = num_1 - num_2;
        double multiplicacion = num_1 * num_2;

        // Verificar si el segundo número es 0 para evitar la división por cero
        double division = 0;
        if (num_2 != 0)
        {
            division = num_1 / num_2;
        }

        
        Console.WriteLine($"Suma: {suma}");
        Console.WriteLine($"Resta: {resta}");
        Console.WriteLine($"Multiplicación: {multiplicacion}");

        if (num_2 != 0)
        {
            Console.WriteLine($"División: {division}");
        }
        else
        {
            Console.WriteLine("No se puede dividir por cero.");
        }
    }

    // Función para obtener un número válido desde la entrada del usuario
    static double ObtenerNumero()
    {
        double numero;
        while (!double.TryParse(Console.ReadLine(), out numero))
        {
            Console.Write("Entrada inválida. Ingresa un número válido: ");
        }
        return numero;
    }
}
/*End Operators*/
