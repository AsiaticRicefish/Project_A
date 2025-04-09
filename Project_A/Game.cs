using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Project_A.Scene;

namespace Project_A
{
    public static class Game
    {

        private static Dictionary<string, BaseScene> sceneDic;
        private static BaseScene curScene;
        public static string prevSceneName;

        private static bool gameOver;

        private static Player player;
        public static Player Player { get { return player; } }

        public static void Run()
        {

            Start();

            while (gameOver == false)
            {
                Console.Clear(); // 지워주는 기능

                curScene.Render();
                curScene.Input();
                curScene.Update();
                curScene.Result();
            }

            End();
        }

        public static void ChangeScene (string sceneName) // 장면 전환을 위한 함수 구현
        {
            prevSceneName = curScene.name;

            curScene.Exit();
            curScene = sceneDic[sceneName];
            curScene.Enter();
        }


        public static void GameOver(string reason)
        {
            Console.Clear();
            Console.WriteLine("**********************************");
            Console.WriteLine("*           게임 종료            *");
            Console.WriteLine("**********************************");
            Console.WriteLine();
            Console.WriteLine(reason);

            gameOver = true;
        }

        public static void PrintInfo()
        {
            Console.WriteLine("*****************************");
            Console.WriteLine(" 플레이어");
            Console.WriteLine(" 속도 : {0}\t 시야 : {1}", Player.Speed, Player.View);
            Console.WriteLine("*****************************");
            Console.WriteLine();
        }

        public static void Start()
        {
            Console.CursorVisible = false;

            gameOver = false;

            player = new Player();

            sceneDic = new Dictionary<string, BaseScene>();
            sceneDic.Add("Title", new TitleScene());
            sceneDic.Add("Hospital", new HospitalScene());
            sceneDic.Add("Corridor", new CorridorScene());
            sceneDic.Add("Room1", new HospitalRoom1Scene());
            sceneDic.Add("BadEnding1", new BedEnding1Scene());
            sceneDic.Add("TwoCorridor", new TwoCorridorScene());
            sceneDic.Add("Room2", new Room2());
            sceneDic.Add("Chase", new ChaseScene());
            sceneDic.Add("Exit", new ExitScene());

            curScene = sceneDic["Title"];

        }

        public static void End() 
        {

        }

    }
}
