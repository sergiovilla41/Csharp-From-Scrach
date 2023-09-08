class Rectangulo
{
    // Propiedades para la base y la altura del rectángulo
    public double Base { get; set; }
    public double Altura { get; set; }

    // Constructor que recibe la base y la altura como parámetros
    public Rectangulo(double baseRectangulo, double alturaRectangulo)
    {
        Base = baseRectangulo;
        Altura = alturaRectangulo;
    }

    // Método para calcular el área del rectángulo
    public double CalcularArea()
    {
        return Base * Altura;
    }

    // Método para calcular el perímetro del rectángulo
    public double CalcularPerimetro()
    {
        return 2 * (Base + Altura);
    }
}

class Cuadrado : Rectangulo
{
    // Constructor que recibe el lado del cuadrado como parámetro
    public Cuadrado(double lado) : base(lado, lado)
    {
    }
}