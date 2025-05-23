﻿using _250408_consolegame.Scenes;
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

        private static Player player;
        public static Player Player { get { return player; } } 

        private static bool gameOver;

        
        public static void Run()
        {
            Start();

            while (gameOver == false)
            {
                //Console.Clear();

                curScene.Render();
                curScene.Input();
                curScene.Update();
                curScene.Result();
            }
            End();

        }

        public static void ChangeScene(SceneType sceneName)
        {
            curScene = sceneDic[sceneName];
         
            
        }
          
        private static void Start() //게임 초기설정
        {
            gameOver = false;
            Console.CursorVisible = false;
            player = new Player();

            //씬 설정
            sceneDic = new Dictionary<SceneType, BaseScene>();
            sceneDic.Add(SceneType.Title, new TitleScene());
            sceneDic.Add(SceneType.Map1, new Map1());
            sceneDic.Add(SceneType.Map2, new Map2());
            sceneDic.Add(SceneType.Map3, new Map3());
            sceneDic.Add(SceneType.Opening, new OpeningScene());
            sceneDic.Add(SceneType.Ending, new EndingScene());
            

            curScene = sceneDic[SceneType.Title];
            

            
        }

        public static void End() // 마무리 작업
        {
           
            Console.SetCursorPosition(2, 2);
            Console.WriteLine("플레이 해주셔서 감사합니다.");


            gameOver = true;
        }
    }
}
