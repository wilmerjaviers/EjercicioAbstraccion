using EjercicioAbstraccion;

public class ConversionMetrosKilometros : FormulaMatematica
{
    private double metros;

    public ConversionMetrosKilometros(double metros)
    {
        this.metros = metros;
    }

    public override double Calcular()
    {
        return metros / 1000;
    }

    public override void Imprimir()
    {
        Console.WriteLine($"{metros} metros equivalen a {Calcular()} kilómetros");
    }
}
