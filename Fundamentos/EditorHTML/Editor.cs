using System;
using System.Text;

namespace EditorHTML{
  public static class Editor
  {
    public static void Show()
    {
      Console.Clear();
      Console.BackgroundColor = ConsoleColor.White;
      Console.ForegroundColor = ConsoleColor.Black;
      Console.Clear();
      Console.WriteLine("MODO EDIÇÃO (aperte ESC para finalizar a edição)");
      Console.WriteLine("=========================================================");
      Start();
    }

    private static void Start()
    {
      var text = new StringBuilder();

      do {
        text.Append(Console.ReadLine());
        text.Append(Environment.NewLine);
      } while (Console.ReadKey().Key != ConsoleKey.Escape);

      Console.WriteLine("==========================================================");
      Console.WriteLine("Escolha: [1] SALVAR COMO ARQUIVO  - [2] APENAS VISUALIZAR");
      int choice = int.Parse(Console.ReadLine());

      switch (choice)
      {
        case 1: SaveIntoFile(text.ToString()); break;
        case 2: Viewer.Show(text.ToString()); break;
        default: Menu.Show(); break;
      }
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
    }

    static string SetFilePath()
    {
      Console.WriteLine("Digite o nome do arquivo:");
      string fileName = Console.ReadLine();
      return $"./myFiles/{fileName}.txt";
    }
  }
}