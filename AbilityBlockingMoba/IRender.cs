using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbilityBlockingMoba
{
    public interface IRender<T> where T : Game
    {        
        void Render();
        void Render(Minion minion);
        void Render(Player player);
    }
}
