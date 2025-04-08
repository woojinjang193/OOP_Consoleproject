using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _250408_consolegame
{
    public class TitleScene : BaseScene
    {
        public override void Render()  
        {
            Console.WriteLine("게임 타이틀");
        }
        public override void Input()  
        {
            Console.ReadKey(true);
            
        }
        public override void Update()  
        {

        }
        public override void Result()  
        { 

        }
    }
}
