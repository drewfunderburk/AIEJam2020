using System;
using System.Collections.Generic;
using System.Text;

namespace AIEJam2020
{
    class Game
    {
        private System.Diagnostics.Stopwatch _stopwatch = new System.Diagnostics.Stopwatch();
        public static bool GameOver = false;
        public static int Width { get; set; }
        public static int Height { get; set; }

        public Scene scene;

        #region CORE
        private void Start()
        {
            scene = new Scene();

        }

        private void Update(float deltaTime)
        {
            if (!scene.Started)
                scene.Start();

            scene.Update(deltaTime);
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
            _stopwatch.Start();
            while(!GameOver)
            {
                float deltaTime = _stopwatch.ElapsedMilliseconds;
                Update(deltaTime);
                Draw();
                _stopwatch.Restart();
            }
            End();
        }
        #endregion
    }
}
