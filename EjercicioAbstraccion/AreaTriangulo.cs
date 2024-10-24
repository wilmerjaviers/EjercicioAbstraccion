using EjercicioAbstraccion;

public class AreaTriangulo : FormulaMatematica
{
    private double baseTriangulo;
    private double altura;

    public AreaTriangulo(double baseTriangulo, double altura)
    {
        this.baseTriangulo = baseTriangulo;
        this.altura = altura;
    }

    public override double Calcular()
    {
        return (baseTriangulo * altura) / 2;
    }

    public override void Imprimir()
    {
        Console.WriteLine($"El área del triángulo es: {Calcular()} unidades cuadradas");
    }
}
