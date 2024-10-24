using EjercicioAbstraccion;

class Program
{
    static void Main(string[] args)
    {
        int opcion;
        do
        {
            Console.WriteLine("\n=== MENÚ DE FÓRMULAS MATEMÁTICAS ===");
            Console.WriteLine("1. Calcular área de un triángulo");
            Console.WriteLine("2. Convertir metros a kilómetros");
            Console.WriteLine("3. Calcular perímetro de un círculo");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione una opción: ");

            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    CalcularAreaTriangulo();
                    break;
                case 2:
                    ConvertirMetrosAKilometros();
                    break;
                case 3:
                    CalcularPerimetroCirculo();
                    break;
                case 4:
                    Console.WriteLine("¡Hasta luego!");
                    break;
                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }
        } while (opcion != 4);
    }

    static void CalcularAreaTriangulo()
    {
        Console.Write("Ingrese la base del triángulo: ");
        double baseTriangulo = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese la altura del triángulo: ");
        double altura = Convert.ToDouble(Console.ReadLine());

        FormulaMatematica triangulo = new AreaTriangulo(baseTriangulo, altura);
        triangulo.Imprimir();
    }

    static void ConvertirMetrosAKilometros()
    {
        Console.Write("Ingrese la cantidad de metros: ");
        double metros = Convert.ToDouble(Console.ReadLine());

        FormulaMatematica conversion = new ConversionMetrosKilometros(metros);
        conversion.Imprimir();
    }

    static void CalcularPerimetroCirculo()
    {
        Console.Write("Ingrese el radio del círculo: ");
        double radio = Convert.ToDouble(Console.ReadLine());

        FormulaMatematica circulo = new PerimetroCirculo(radio);
        circulo.Imprimir();
    }
}