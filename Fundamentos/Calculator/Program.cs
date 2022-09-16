using Enums.Calculator;
using Structs.Calculator;

internal class Program
{
    private static void Main(string[] args)
    {
        Menu();
    }

    private static void Menu()
    {
        Console.Clear();
        short opcaoEscolhida = LerOpcaoMenu();

        switch (opcaoEscolhida)
        {
            case (int)EOperacoes.Soma: new Operacao().Somar(); Menu(); break;
            case (int)EOperacoes.Subtracao: new Operacao().Subtrair(); Menu(); break;
            case (int)EOperacoes.Divisao: new Operacao().Dividir(); Menu(); break;
            case (int)EOperacoes.Multiplicacao: new Operacao().Multiplicar(); Menu(); break;
            case 0: System.Environment.Exit(0); break;
            default: Menu(); break;
        }
    }

    private static short LerOpcaoMenu()
    {
        Console.WriteLine("\nDigite o número da operação que deseja realizar:");

        foreach(EOperacoes operacao in Enum.GetValues(typeof(EOperacoes)))
        {
            Console.WriteLine($"[{(int)operacao}] --> {operacao}");
        }
        Console.WriteLine("[0] --> Sair da Calculadora");
        Console.WriteLine("");

        return short.Parse(Console.ReadLine());
    }
}