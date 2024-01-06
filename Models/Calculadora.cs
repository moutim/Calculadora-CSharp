using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora_CSharp.Models
{
    public class Calculadora
    {
        public void Iniciar()
        {
            Console.WriteLine("Digite a opção desejada para realizar uma operação: ");
            Console.WriteLine($"\n 1 - Somar \n 2 - Subtrair \n" + 
            "3 - Dividir \n 4 - Multiplicar \n 5 - Potência \n 6 - Raíz quadrada ");

            int opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Somar();
                    break;
                case 2:
                    Subtrair();
                    break;
                case 3:
                    Dividir();
                    break;
                case 4:
                    Multiplicar();
                    break;
                case 5:
                    Potencia();
                    break;
                case 6:
                    RaizQuadrada();
                    break;
                default:
                    Console.WriteLine("Digite uma opção válida!");
                    Iniciar();
                    break;
            }
        }
        public void Somar()
        {
            Console.Clear();

            Console.WriteLine("Operação de soma! \n Digite o primeiro número: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{a} + {b} = {a + b}");
        }

        public void Subtrair()
        {
            Console.Clear();

            Console.WriteLine("Operação de subtrair! \n Digite o primeiro número: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{a} - {b} = {a - b}");
        }

        public void Dividir()
        {
            Console.Clear();

            Console.WriteLine("Operação de dividir! \n Digite o primeiro número: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{a} X {b} = {a / b}");
        }

        public void Multiplicar()
        {
            Console.Clear();

            Console.WriteLine("Operação de multiplicar! \n Digite o primeiro número: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{a} * {b} = {a * b}");
        }

        public void Potencia()
        {
            Console.Clear();

            Console.WriteLine("Operação de potência! \n Digite o primeiro número: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            int b = Convert.ToInt32(Console.ReadLine());

            double pot = Math.Pow(a, b);

            Console.WriteLine($"{a} ^ {b} = {pot}");
        }

        public void RaizQuadrada()
        {
            Console.Clear();

            Console.WriteLine("Operação de raíz quadrada! \n Digite um número: ");
            int a = Convert.ToInt32(Console.ReadLine());

            double raiz = Math.Sqrt(a);

            Console.WriteLine($"Raíz quadrada de {a} = {raiz}");
        }
    }
}