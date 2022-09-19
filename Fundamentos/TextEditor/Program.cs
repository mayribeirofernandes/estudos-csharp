using System;
using System.IO;

namespace TextEditor
{
  class Program
  {
    static void Main(string[] args)
    {
      Menu();
    }

    static void Menu()
    {
      Console.Clear();
      Console.WriteLine("O que deseja fazer?");
      Console.WriteLine("1 - Abrir arquivo");
      Console.WriteLine("2 - Criar novo arquivo");
      Console.WriteLine("0 - Sair");
      short choice = short.Parse(Console.ReadLine());
      
      switch (choice)
      {
        case 0: System.Environment.Exit(0); break;
        case 1: ReadFile(); break;
        case 2: NewFile(); break;
        default: Menu(); break;
      }

    }

    static void BackToMenu()
    {
      Console.WriteLine("\nVoltar ao menu? [S] Sim - [N] Não");
      char choice = char.Parse(Console.ReadLine().ToLower());
      if (choice == 'n')
        System.Environment.Exit(0);
      else
        Menu();
    }

    static string SetFilePath()
    {
      Console.WriteLine("Digite o nome do arquivo:");
      string fileName = Console.ReadLine();
      return $"./myFiles/{fileName}.txt";
    }

    static void ReadFile()
    {
      Console.WriteLine("\nAbrindo arquivo...");
      string filePath = SetFilePath();

      using(var file = new StreamReader(filePath))
      {
        string text = file.ReadToEnd();
        Console.WriteLine(text);
        BackToMenu();
      }
    }

    static void NewFile()
    {
      Console.WriteLine("\nCriando novo arquivo...");
      string text = WritingTextFile();
      SaveIntoFile(text);
    }

    static string WritingTextFile()
    {
      Console.WriteLine("\nDigite o texto abaixo do tracejado!");
      Console.WriteLine("Aperte ESC para encerrar a edição.");
      Console.WriteLine("--------------------------------");

      string text = "";

      do
      {
        text += Console.ReadLine();
        text += Environment.NewLine;
      }
      while(Console.ReadKey().Key != ConsoleKey.Escape);
      return text;
    }

    static void SaveIntoFile(string text)
    {
      Console.Clear();
      string filePath = SetFilePath();

      using(var file = new StreamWriter(filePath))
      {
        file.Write(text);
      }

      Console.WriteLine($"Arquivo salvo com sucesso em: {filePath}");
      BackToMenu();
    }
  }
}
