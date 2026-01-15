namespace Grathimut.TUI;

public class Window
{
    public Window(uint PosX = 0, uint PosY = 0, uint SizeX = 80, uint SizeY = 60, string Title = "Grathimut App")
    {
        //uint[,] Bufer = new uint[SizeX-1, SizeY-1];
        for(int CounterY = 0; CounterY < SizeY; CounterY++)
        {
            for(int CounterX = 0; CounterX < SizeX; CounterX++)
            {
                Console.SetCursorPosition(CounterX, CounterY);
                if(CounterX == 0 || CounterX == SizeX-1 || CounterY == 0 || CounterY == SizeY-1)
                {
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                } else Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.Write(" ");
            }
        }
        Console.BackgroundColor = ConsoleColor.Black;
        Console.WriteLine();
    }

    public void AddObject(Window win, ConsoleObject obj, int x, int y)
    {
        int CursorPosX = Console.GetCursorPosition().Left, CursorPosY = Console.GetCursorPosition().Top;
        Console.SetCursorPosition(x, y);
        foreach(string StringOfSprite in obj.Sprite)
        {
            Console.Write(StringOfSprite);
            y++;
            Console.SetCursorPosition(x, y);
        }
        Console.SetCursorPosition(CursorPosX, CursorPosY);
    }
}

public class ConsoleObject(string sprite, int x, int y)
{
    public string[] Sprite = sprite.Split("\n");
    public int SizeX = x, SizeY = y;
}
