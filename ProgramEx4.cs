using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX4POOMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a base do triângulo: ");

            Double baseValor = Double.Parse(Console.ReadLine());



            Console.Write("Digite a altura do triângulo: ");

            Double alturaValor = Double.Parse(Console.ReadLine());



            Triangulo meuTriangulo = new Triangulo(baseValor, alturaValor);

            Double area = meuTriangulo.CalcularArea();



            Console.WriteLine("A área do triângulo é: {0}", area);
        }
    }
}
