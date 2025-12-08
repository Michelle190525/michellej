using System;

public class Program
{
    public static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8; // para tildes en consola

        // -------- Círculo --------
        Circulo c = new Circulo(5);
        Console.WriteLine("===== Círculo =====");
        Console.WriteLine("Área: " + c.CalcularArea());
        Console.WriteLine("Perímetro: " + c.CalcularPerimetro());

        // -------- Rectángulo --------
        Rectangulo r = new Rectangulo(4, 6);
        Console.WriteLine("\n===== Rectángulo =====");
        Console.WriteLine("Área: " + r.CalcularArea());
        Console.WriteLine("Perímetro: " + r.CalcularPerimetro());
    }
}

public class Circulo
{
    private double radio;

    public Circulo(double r)
    {
        radio = r;
    }

    public double CalcularArea() => Math.PI * radio * radio;

    public double CalcularPerimetro() => 2 * Math.PI * radio;
}

public class Rectangulo
{
    private double largo;
    private double ancho;

    public Rectangulo(double l, double a)
    {
        largo = l;
        ancho = a;
    }

    public double CalcularArea() => largo * ancho;

    public double CalcularPerimetro() => 2 * (largo + ancho);
}
