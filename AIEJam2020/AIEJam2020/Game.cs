using System;
using System.Collections.Generic;
using System.Text;

namespace AIEJam2020
{
    class Game
    {
        public static bool GameOver = false;
        public static int Width { get; set; }
        public static int Height { get; set; }

        public Scene scene;

        #region CORE
        private void Start()
        {
            scene = new Scene();
        }

        private void Update()
        {

        }

        private void Draw()
        {
            scene.Draw();
            // Draw buffer to screen
            ScreenBuffer.DrawScreen();
        }

        private void End()
        {

        }

        public void Run()
        {
            Start();
            while(!GameOver)
            {
                Update();
                Draw();
            }
            End();
        }
        #endregion
    }
}
