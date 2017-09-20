using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbilityBlockingMoba
{
    public class GameRender<T> where T : Game
    {
        public IRender<T> ActiveRender;

        public T Game;

        public GameRender()
        {
                      
        }

        public virtual void Render()
        {

        }
    }
}
