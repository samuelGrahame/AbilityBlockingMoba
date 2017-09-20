using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbilityBlockingMoba
{
    public interface IRender
    {
        void Render(Game1v1 game);
        void Render(Game5v5 game);
        void Render(Minion minion);
        void Render(Player player);
    }
}
