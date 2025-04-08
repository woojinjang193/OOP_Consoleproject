using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _250408_consolegame
{
    public static class Game
    {
        private static Dictionary<SceneType, BaseScene> sceneDic;
        private static BaseScene curScene;

        private static bool gameOver;

        
        public static void Run()
        {
            Start();

            while (gameOver == false)
            {
                Console.Clear();

                curScene.Render();
                curScene.Input();
                curScene.Update();
                curScene.Result();
            }
            End();
        }

        private static void Start() //게임 초기설정
        {
            gameOver = false;
            Console.CursorVisible = false;

            //씬 설정
            sceneDic = new Dictionary<SceneType, BaseScene>();
            sceneDic.Add(SceneType.Title, new TitleScene());

            curScene = sceneDic[SceneType.Title];
        }

        private static void End() // 마무리 작업
        {

        }
    }
}
