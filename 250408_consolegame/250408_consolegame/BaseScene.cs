using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _250408_consolegame
{
    public enum SceneType
    {
        Title, Opening, Map1, Map2, Map3, Boss, Ending, CloseScene
    }
    public abstract class BaseScene
    {
        public abstract void Render();
        public abstract void Input();
        public abstract void Update();
        public abstract void Result();
    }
}
