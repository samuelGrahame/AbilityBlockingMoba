using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbilityBlockingMoba
{
    public class GameRender1v1 : GameRender<Game1v1>
    {
        public override void Render()
        {
            ActiveRender.Render();
            foreach (var minion in Game.Team1_Minions)
            {
                ActiveRender.Render(minion);
            }
            foreach (var minion in Game.Team2_Minions)
            {
                ActiveRender.Render(minion);
            }
            ActiveRender.Render(Game.Player1);
            ActiveRender.Render(Game.Player2);
        }
    }
}
