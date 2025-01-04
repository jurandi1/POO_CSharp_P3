using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;
using System.Globalization;

internal class Program
{
    static double Pi = 3.14;

    private static void Main(string[] args)
    {
        //        Problema exemplo
        //Fazer um programa para ler um valor numérico qualquer, e daí mostrar
        //quanto seria o valor de uma circunferência e do volume de uma esfera
        //para um raio daquele valor. Informar também o valor de PI com duas
        //casas decimais.

        Console.Write("Entre o valor do raio: ");
        double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double circ = Circunferencia(raio);
        double volume = Volume(raio);

        Console.WriteLine("Circuferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("Valor de PI: " + Pi.ToString("F2", CultureInfo.InvariantCulture)); 
    }

    static double Circunferencia(double r)
    {
        return 2.0 * Pi * r; 
    }

    static double Volume(double r)
    {
        return 4.0 / 3.0 * Pi * Math.Pow(r, 3.0);
    }

}