class Exercises
{
    static void Main()
    {
        string opcion;

        do
        {
            Console.WriteLine("Menú:\n" +
                "1. Elevar al cuadrado si es positivo.\n" +
                "2. Devolver doble o triple según el mayor.\n" +
                "3. Calcular raíz cuadrada o cuadrado.\n" +
                "4. Calcular perímetro del círculo.\n" +
                "5. Mostrar día de la semana laborable.\n" +
                "6. Calcular impuesto anual.\n" +
                "7. Calcular residuo de la división.\n" +
                "8. Sumar números pares.\n" +
                "9. Restar fracciones.\n" +
                "10. Mostrar longitud de palabra.\n" +
                "11. Calcular promedio de cuatro números.\n" +
                "12. Encontrar el número más pequeño de cinco.\n" +
                "13. Contar vocales en una palabra.\n" +
                "14. Calcular el factorial de un número.\n" +
                "15. Verificar si un número está en el rango 10-20.\n" +
                "Escriba 'exit' o 'Q' para salir.\n");
            opcion = Console.ReadLine();

            try
            {
                switch (opcion)
                {
                    case "1":
                        Console.Write("Ingrese un número: ");
                        double numero1 = Convert.ToDouble(Console.ReadLine());
                        if (numero1 >= 0)
                        {
                            double resultado1 = Math.Pow(numero1, 2);
                            Console.WriteLine("El cuadrado del número es: " + resultado1);
                        }
                        else
                        {
                            Console.WriteLine("El número ingresado no es positivo.");
                        }
                        break;

                    case "2":
                        Console.Write("Ingrese el primer número: ");
                        double num1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Ingrese el segundo número: ");
                        double num2 = Convert.ToDouble(Console.ReadLine());
                        double resultado2 = (num1 > num2) ? num1 * 2 : num2 * 3;
                        Console.WriteLine("El resultado es: " + resultado2);
                        break;

                    case "3":
                        Console.Write("Ingrese un número: ");
                        double numero2 = Convert.ToDouble(Console.ReadLine());
                        if (numero2 >= 0)
                        {
                            double raizCuadrada = Math.Sqrt(numero2);
                            Console.WriteLine("La raíz cuadrada del número es: " + raizCuadrada);
                        }
                        else
                        {
                            double cuadrado = Math.Pow(numero2, 2);
                            Console.WriteLine("El cuadrado del número es: " + cuadrado);
                        }
                        break;

                    case "4":
                        Console.Write("Ingrese el radio del círculo: ");
                        double radio = Convert.ToDouble(Console.ReadLine());
                        if (radio >= 0)
                        {
                            double perimetro = 2 * Math.PI * radio;
                            Console.WriteLine("El perímetro del círculo es: " + perimetro);
                        }
                        else
                        {
                            Console.WriteLine("El radio ingresado no es válido.");
                        }
                        break;

                    case "5":
                        Console.Write("Ingrese un número del 1 al 7: ");
                        int dia = Convert.ToInt32(Console.ReadLine());
                        string[] diasLaborables = { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes" };
                        if (dia >= 1 && dia <= 7)
                        {
                            if (dia >= 1 && dia <= 5)
                            {
                                Console.WriteLine("Día laborable: " + diasLaborables[dia - 1]);
                            }
                            else
                            {
                                Console.WriteLine("Día no laborable.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Número fuera de rango.");
                        }
                        break;

                    case "6":
                        Console.Write("Ingrese su salario anual: ");
                        double salario = Convert.ToDouble(Console.ReadLine());
                        if (salario > 12000)
                        {
                            double impuesto = 0.15 * (salario - 12000);
                            Console.WriteLine("Impuesto a pagar: " + impuesto);
                        }
                        else
                        {
                            Console.WriteLine("No debe pagar impuestos.");
                        }
                        break;

                    case "7":
                        Console.Write("Ingrese el primer número: ");
                        double num3 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Ingrese el segundo número: ");
                        double num4 = Convert.ToDouble(Console.ReadLine());
                        double residuo = num3 % num4;
                        Console.WriteLine("El residuo de la división es: " + residuo);
                        break;

                    case "8":
                        int sumaPares = 0;
                        for (int i = 1; i <= 50; i++)
                        {
                            if (i % 2 == 0)
                            {
                                sumaPares += i;
                            }
                        }
                        Console.WriteLine("La suma de los números pares entre 1 y 50 es: " + sumaPares);
                        break;

                    case "9":
                        Console.Write("Ingrese el numerador de la primera fracción: ");
                        int numerador1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Ingrese el denominador de la primera fracción: ");
                        int denominador1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Ingrese el numerador de la segunda fracción: ");
                        int numerador2 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Ingrese el denominador de la segunda fracción: ");
                        int denominador2 = Convert.ToInt32(Console.ReadLine());

                        if (denominador1 == 0 || denominador2 == 0)
                        {
                            Console.WriteLine("El denominador no puede ser cero.");
                        }
                        else
                        {
                            double resultado9 = (double)(numerador1 * denominador2 - numerador2 * denominador1) / (denominador1 * denominador2);
                            Console.WriteLine("La diferencia de las fracciones es: " + resultado9);
                        }
                        break;

                    case "10":
                        Console.Write("Ingrese una palabra: ");
                        string palabra = Console.ReadLine();
                        int longitud = palabra.Length;
                        Console.WriteLine("La longitud de la palabra es: " + longitud);
                        break;

                    case "11":
                        double suma = 0;
                        for (int i = 0; i < 4; i++)
                        {
                            Console.Write("Ingrese el número " + (i + 1) + ": ");
                            double num = Convert.ToDouble(Console.ReadLine());
                            suma += num;
                        }
                        double promedio = suma / 4;
                        Console.WriteLine("El promedio de los cuatro números es: " + promedio);
                        break;

                    case "12":
                        double menor = double.MaxValue;
                        for (int i = 0; i < 5; i++)
                        {
                            Console.Write("Ingrese el número " + (i + 1) + ": ");
                            double num = Convert.ToDouble(Console.ReadLine());
                            if (num < menor)
                            {
                                menor = num;
                            }
                        }
                        Console.WriteLine("El número más pequeño es: " + menor);
                        break;

                    case "13":
                        Console.Write("Ingrese una palabra: ");
                        string palabra2 = Console.ReadLine();
                        int conteoVocales = 0;
                        foreach (char letra in palabra2)
                        {
                            char letraMin = Char.ToLower(letra);
                            if (letraMin == 'a' || letraMin == 'e' || letraMin == 'i' || letraMin == 'o' || letraMin == 'u')
                            {
                                conteoVocales++;
                            }
                        }
                        Console.WriteLine("Número de vocales en la palabra: " + conteoVocales);
                        break;

                    case "14":
                        Console.Write("Ingrese un número: ");
                        int numeroFactorial = Convert.ToInt32(Console.ReadLine());
                        if (numeroFactorial < 0)
                        {
                            Console.WriteLine("No se puede calcular el factorial de un número negativo.");
                        }
                        else
                        {
                            int factorial = 1;
                            for (int i = 2; i <= numeroFactorial; i++)
                            {
                                factorial *= i;
                            }
                            Console.WriteLine("El factorial de " + numeroFactorial + " es: " + factorial);
                        }
                        break;

                    case "15":
                        Console.Write("Ingrese un número: ");
                        int numeroRango = Convert.ToInt32(Console.ReadLine());
                        if (numeroRango >= 10 && numeroRango <= 20)
                        {
                            Console.WriteLine("El número está en el rango de 10 a 20.");
                        }
                        else
                        {
                            Console.WriteLine("El número está fuera del rango de 10 a 20.");
                        }
                        break;

                    case "exit":
                    case "q":
                    case "Q":
                        Console.WriteLine("Saliendo del programa.");
                        break;

                    default:
                        Console.WriteLine("Opción no válida. Por favor, ingrese una opción válida del 1 al 15 o 'exit' para salir.");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Ingrese un formato de número válido.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error: El número es demasiado grande o demasiado pequeño para ser procesado.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
        while (opcion != "exit" && opcion != "q" && opcion != "Q");
    }
}