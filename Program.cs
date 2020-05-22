using System;

namespace IMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calcule o índice de massa corporal de uma pessoa (IMC), peso de 80kg e altura de 2m.");
            int P=80;
            int A=2;
            double resultado=Math.Pow(A, 2);
            double resultado2=P / resultado;
            Console.ReadKey();
            Console.WriteLine($"IMC: {resultado2} kg/m²");
        }
    }
}
