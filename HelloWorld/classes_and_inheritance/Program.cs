class Rectangulo
{
    
    public double Base { get; set; }

    
    public double Altura { get; set; }

    
    public Rectangulo(double baseRectangulo, double alturaRectangulo)
    {
        Base = baseRectangulo;
        Altura = alturaRectangulo;
    }

 
    public double CalcularArea()
    {
        return Base * Altura;
    }


    public double CalcularPerimetro()
    {
        return 2 * (Base + Altura);
    }
}

class Program
{
    static void Main()
    {
       
        Console.Write("Ingrese la base del rectángulo: ");
        double baseRectangulo = Convert.ToDouble(Console.ReadLine());

        
        Console.Write("Ingrese la altura del rectángulo: ");
        double alturaRectangulo = Convert.ToDouble(Console.ReadLine());

       
        Rectangulo miRectangulo = new Rectangulo(baseRectangulo, alturaRectangulo);

        
        double area = miRectangulo.CalcularArea();
        Console.WriteLine("Área del rectángulo: " + area);

        
        double perimetro = miRectangulo.CalcularPerimetro();
        Console.WriteLine("Perímetro del rectángulo: " + perimetro);
    }
}