using System;
using System.Collections.Generic;
using System.Text;

namespace AIEJam2020
{
    public class ScreenBuffer
    {
        public static char[,] screenBufferArray = new char[Game.Width, Game.Height];
        public static string screenBuffer;
        public static Char[] arr;
        public static int i = 0;

        // Writes a string to the buffer at a location
        public static void Draw(string text, int x, int y)
        {
            //split text into array
            arr = text.ToCharArray(0, text.Length);
            //iterate through the array, adding values to buffer 
            i = 0;
            foreach (char c in arr)
            {
                screenBufferArray[x + i, y] = c;
                i++;
            }
        }

        // Draw the screen
        public static void DrawScreen()
        {
            screenBuffer = "";

            // Iterate through buffer, adding each value to screenBuffer
            for (int iy = 0; iy < Game.Height - 1; iy++)
            {
                for (int ix = 0; ix < Game.Width; ix++)
                {
                    screenBuffer += screenBufferArray[ix, iy];
                }
            }

            // Set cursor position to top left and draw the string
            Console.SetCursorPosition(0, 0);
            Console.Write(screenBuffer);
            screenBufferArray = new char[Game.Height, Game.Width];
        }
    }
}
