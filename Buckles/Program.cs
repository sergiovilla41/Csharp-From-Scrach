class BK
{
    static void Main()
    {
        Console.Write("Ingrese  el número calcular: ");
        int n = Convert.ToInt32(Console.ReadLine());

        if (n <= 0)
        {
            Console.WriteLine("Por favor, ingrese un número válido mayor que cero.");
            return;
        }

        long a = 0; // Primer término de la serie
        long b = 1; // Segundo término de la serie

        Console.WriteLine("Serie de Fibonacci:");

        // Mostrar los primeros n términos de la serie de Fibonacci
        for (int i = 0; i < n; i++)
        {
            Console.Write(a + " ");

            long temp = a;
            a = b;
            b = temp + b;
        }

        Console.WriteLine();
    }
}