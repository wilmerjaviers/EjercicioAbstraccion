using EjercicioAbstraccion;

public class PerimetroCirculo : FormulaMatematica
{
    private double radio;

    public PerimetroCirculo(double radio)
    {
        this.radio = radio;
    }

    public override double Calcular()
    {
        return 2 * Math.PI * radio;
    }

    public override void Imprimir()
    {
        Console.WriteLine($"El perímetro del círculo es: {Calcular():F2} unidades");
    }
}

