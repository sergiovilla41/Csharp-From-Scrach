

class Formas
{
    static void Main()
    {
        try
        {
            Console.Write("Ingrese el radio del círculo: ");
            double radio = Convert.ToDouble(Console.ReadLine());

            Circulo miCirculo = new Circulo(radio);

            double area = miCirculo.CalcularArea();
            double perimetro = miCirculo.CalcularPerimetro();

            Console.WriteLine("El área del círculo es: " + area);
            Console.WriteLine("El perímetro del círculo es: " + perimetro);
        }
        catch (FormatException)
        {
            Console.WriteLine("El valor ingresado no es válido. Debe ser un número.");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
// Definición de la clase abstracta Figura
abstract class Figura
{
    // Método abstracto para calcular el área
    public abstract double CalcularArea();

    // Método abstracto para calcular el perímetro
    public abstract double CalcularPerimetro();
}

// Definición de la clase Circulo que hereda de Figura
class Circulo : Figura
{
    // Radio del círculo
    private double radio;

    // Constructor que recibe el radio del círculo como parámetro
    public Circulo(double radio)
    {
        if (radio <= 0)
        {
            throw new ArgumentException("El radio debe ser un número positivo.");
        }

        this.radio = radio;
    }

    // Implementación del método para calcular el área del círculo
    public override double CalcularArea()
    {
        return Math.PI * Math.Pow(radio, 2);
    }

    // Implementación del método para calcular el perímetro del círculo
    public override double CalcularPerimetro()
    {
        return 2 * Math.PI * radio;
    }
}

