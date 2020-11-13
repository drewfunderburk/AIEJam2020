using System;

namespace AIEJam2020
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.SetWindowSize(100, 60);
            Game game = new Game();
            game.Run();
        }
    }
}
