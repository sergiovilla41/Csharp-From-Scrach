// See https://aka.ms/new-console-template for more information
namespace HelloWorld
{
    class Program
    {
        static void Main()
        {
            string nombre = "";
            DateTime fechaNacimiento = DateTime.MinValue;

           //Nombre
            while (string.IsNullOrEmpty(nombre) || ContieneNumeros(nombre))
            {
                Console.Write("Ingresa tu nombre : ");
                nombre = Console.ReadLine().Trim();

                if (string.IsNullOrEmpty(nombre))
                {
                    Console.WriteLine("El nombre no puede estar vacío. Por favor, inténtalo de nuevo.");
                }
                else if (ContieneNumeros(nombre))
                {
                    Console.WriteLine("El nombre no puede contener números. Por favor, inténtalo de nuevo.");
                }
            }

            //  fecha de nacimiento
            while (fechaNacimiento == DateTime.MinValue)
            {
                Console.Write("Ingresa tu fecha de nacimiento (dd-mm-aa): ");
                if (DateTime.TryParse(Console.ReadLine(), out fechaNacimiento))
                {
                    // Verificar la fecha de nacimiento 
                    if (fechaNacimiento > DateTime.Now)
                    {
                        Console.WriteLine("La fecha de nacimiento no puede ser mayor a la fecha actual. Por favor, inténtalo de nuevo.");
                        fechaNacimiento = DateTime.MinValue;
                    }
                }
                else
                {
                    Console.WriteLine("Formato de fecha incorrecto. Por favor, ingresa una fecha válida (dd-mm-aa).");
                }
            }

            // edad
            int edad = DateTime.Now.Year - fechaNacimiento.Year;

            // Verificar si ya ha pasado el cumpleaños de este año
            if (DateTime.Now.Month < fechaNacimiento.Month || (DateTime.Now.Month == fechaNacimiento.Month && DateTime.Now.Day < fechaNacimiento.Day))
            {
                edad--;
            }

            // Mostrar el resultado
            Console.WriteLine($"Hola, {nombre}!");
            Console.WriteLine($"Tu fecha de nacimiento es: {fechaNacimiento}.");
            Console.WriteLine($"Tu edad es: {edad} años.");
            Console.ReadLine();

        }
        static bool ContieneNumeros(string cadena)
        {
            foreach (char c in cadena)
            {
                if (char.IsDigit(c))
                {
                    return true;
                }
            }
            return false;
        }

    }
}