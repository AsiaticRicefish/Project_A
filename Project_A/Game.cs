using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_A.Scene;

namespace Project_A
{
    public static class Game
    {

        private static Dictionary<string, BaseScene> sceneDic;
        private static BaseScene curScene;

        private static bool gameOver;

        public static void Run()
        {
            while (gameOver == false)
            {
                curScene.Render();
                curScene.Input();
                curScene.Update();
                curScene.Result();
            }

        }


        private static void Start()
        {
            gameOver = false;

            sceneDic = new Dictionary<string, BaseScene>();
            sceneDic.Add("Title", new TitleScene());

            curScene = sceneDic["Title"];

        }

        public static void End() 
        {

        }

    }
}
