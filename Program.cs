using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;
using System.Globalization;
using POO_CSharp_P3;

internal class Program
{

    private static void Main(string[] args)
    {
        //        Problema exemplo
        //Fazer um programa para ler um valor numérico qualquer, e daí mostrar
        //quanto seria o valor de uma circunferência e do volume de uma esfera
        //para um raio daquele valor. Informar também o valor de PI com duas
        //casas decimais.


        Console.Write("Entre o valor do raio: ");
        double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double circ = Calculadora.Circunferencia(raio);
        double volume = Calculadora.Volume(raio);

        Console.WriteLine("Circuferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("Valor de PI: " + Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture)); 
    }

}