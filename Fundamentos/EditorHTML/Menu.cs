using System;

namespace EditorHTML
{
  public static class Menu
  {
    public static void Show()
    {
      Console.Clear();
      Console.BackgroundColor = ConsoleColor.Black;
      Console.ForegroundColor = ConsoleColor.Green;

      DrawScreen();
      WriteOptions();
      short option = short.Parse(Console.ReadLine());
      HandleMenuOptions(option);
    }

    private static void DrawExtremeLine(int size = 20)
    {
      Console.Write("+");
      for (int c = 0; c <= size; c++)
        Console.Write("-");

      Console.Write("+\n");
    }

    private static void DrawInternalLine(int size = 20, int lines = 10)
    {
      for (int line = 0; line <= lines; line++)
      {
        Console.Write("|");
          for (int c = 0; c <= size; c++)
            Console.Write(" ");

        Console.Write("|\n");
      }

    }

    private static void DrawScreen()
    {
      DrawExtremeLine(30);
      DrawInternalLine(30);
      DrawExtremeLine(30);
    }

    private static void WriteOptions()
    {
      Console.SetCursorPosition(3,2);
      Console.WriteLine("Editor HTML");
      Console.SetCursorPosition(3,3);
      Console.WriteLine("===========");
      Console.SetCursorPosition(3,5);
      Console.WriteLine("Selecione uma opção:");
      Console.SetCursorPosition(3,7);
      Console.WriteLine("1 - Criar novo texto HTML");
      Console.SetCursorPosition(3,8);
      Console.WriteLine("0 - Sair");
      Console.SetCursorPosition(3,10);
      Console.Write("Opção: ");
    }

    private static void HandleMenuOptions(short option)
    {
      switch (option)
      {
        case 1: Editor.Show(); break;
        case 0: Console.Clear(); Environment.Exit(0); break;
        default: Show(); break;
      }
    }
  }
}