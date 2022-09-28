using System;
using System.Text.RegularExpressions;

namespace EditorHTML{
  public static class Viewer
  {
    public static void Show(string text)
    {
      Console.Clear();
      Console.BackgroundColor = ConsoleColor.Black;
      Console.ForegroundColor = ConsoleColor.White;
      Console.Clear();
      Console.WriteLine("MODO VISUALIZAÇÃO (aperte qualquer tecla para sair)");
      Console.WriteLine("===================================================");
      Console.WriteLine(" ");
      Replace(text);
      Console.ReadKey();
      Menu.Show();
    }

    private static void Replace(string text)
    {
      var strong = new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>");
      var words = text.Split(' ');

      for (var i = 0; i < words.Length; i++)
      {
        if (strong.IsMatch(words[i]))
        {
          Console.ForegroundColor = ConsoleColor.Magenta;
          Console.Write(
            words[i].Substring(
              words[i].IndexOf('>') + 1,
              (
                (words[i].LastIndexOf('<') - 1) - words[i].IndexOf('>')
              )
            )
          );
          Console.Write(" ");
        } else {
          Console.ForegroundColor = ConsoleColor.White;
          Console.Write(words[i]);
          Console.Write(" ");
        }
      }
    }
  }
}