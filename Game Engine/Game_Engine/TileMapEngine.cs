using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Engine
{
    public interface Renderer
    { 
        public void Render(Renderer renderer);  
    }

    internal class TileMapEngine
    {
        private static TileMapEngine _instance;

        public TileMapEngine()
        {
        }

        public static TileMapEngine GetInstance()
        {
            return _instance ?? (_instance = new TileMapEngine());
        }

    }
}
