using System;
using System.Collections.Generic;
using System.Text;

namespace AIEJam2020
{
    class Game
    {
        public static bool GameOver = false;

        #region CORE
        private void Start()
        {

        }

        private void Update()
        {

        }

        private void Draw()
        {

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
