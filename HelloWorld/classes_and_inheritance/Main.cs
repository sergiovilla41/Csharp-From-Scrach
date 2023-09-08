class Principal
{
    static void Main()
    {
        Console.WriteLine("Elija una opción:");
        Console.WriteLine("1. Calcular área y perímetro de un rectángulo.");
        Console.WriteLine("2. Calcular área y perímetro de un cuadrado.");
        Console.Write("Opción: ");

        int opcion = Convert.ToInt32(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                Console.Write("Ingrese la base del rectángulo: ");
                double baseRectangulo = Convert.ToDouble(Console.ReadLine());

                Console.Write("Ingrese la altura del rectángulo: ");
                double alturaRectangulo = Convert.ToDouble(Console.ReadLine());

                Rectangulo miRectangulo = new Rectangulo(baseRectangulo, alturaRectangulo);

                double areaRectangulo = miRectangulo.CalcularArea();
                double perimetroRectangulo = miRectangulo.CalcularPerimetro();

                Console.WriteLine("Área del rectángulo: " + areaRectangulo);
                Console.WriteLine("Perímetro del rectángulo: " + perimetroRectangulo);
                break;

            case 2:
                Console.Write("Ingrese el lado del cuadrado: ");
                double ladoCuadrado = Convert.ToDouble(Console.ReadLine());

                Cuadrado miCuadrado = new Cuadrado(ladoCuadrado);

                double areaCuadrado = miCuadrado.CalcularArea();
                double perimetroCuadrado = miCuadrado.CalcularPerimetro();

                Console.WriteLine("Área del cuadrado: " + areaCuadrado);
                Console.WriteLine("Perímetro del cuadrado: " + perimetroCuadrado);
                break;

            default:
                Console.WriteLine("Opción no válida.");
                break;
        }
    }
}