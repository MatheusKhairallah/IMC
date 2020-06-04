using System;

namespace IMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva um número que represente o peso e a altura de uma pessoa, assim será feito o IMC dela.");
            Console.Write("Peso:");
            double P=Convert.ToDouble(Console.ReadLine());
            Console.Write("Altura:");
            double A=Convert.ToDouble(Console.ReadLine());
            
            double resultado=Math.Pow(A, 2);
            double resultado2=P / resultado;
            Console.Clear();
            Console.WriteLine($"O IMC desta pessoa é: {resultado2} kg/m²");
        }
    }
}
