using System;

namespace Structs.Calculator
{
    public struct Operacao
    {
        public string DescricaoOperacao;
        public float Valor1;
        public float Valor2;
        public float ResultadoOperacao;

        public void LerEntradasNumericas()
        {
            Console.WriteLine($"\nInforme o primeiro valor:");
            Valor1 = float.Parse(Console.ReadLine());
            Console.WriteLine($"\nInforme o segundo valor:");
            Valor2 = float.Parse(Console.ReadLine());
        }

        public void ImprimirResultado()
        {
            Console.WriteLine($"\nO resultado da {DescricaoOperacao} é: {ResultadoOperacao}");
            Console.WriteLine("Aperte qualquer tecla para voltar ao Menu...");
            Console.ReadKey();
        }

        public void Somar()
        {
            DescricaoOperacao = "soma";
            LerEntradasNumericas();
            ResultadoOperacao = Valor1 + Valor2;
            ImprimirResultado();
        }

        public void Subtrair()
        {
            DescricaoOperacao = "subtração";
            LerEntradasNumericas();
            ResultadoOperacao = Valor1 - Valor2;
            ImprimirResultado();
        }

        public void Dividir()
        {
            DescricaoOperacao = "divisão";
            LerEntradasNumericas();
            if (Valor2 == 0)
            {
                Console.WriteLine("ATENÇÃO: Não é possível divisão por zero!");
                ResultadoOperacao = 0;
            }
            else
            {
                ResultadoOperacao = Valor1 / Valor2;
            }
            ImprimirResultado();
        }

        public void Multiplicar()
        {
            DescricaoOperacao = "multiplicação";
            LerEntradasNumericas();
            ResultadoOperacao = Valor1 * Valor2;
            ImprimirResultado();
        }
    }
}

