using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbilityBlockingMoba
{
    public class GameRender5v5 : GameRender<Game5v5>
    {
        public override void Render()
        {
            ActiveRender.Clear();
            ActiveRender.Render();
            foreach (var minion in Game.Team1_Minions)
            {
                ActiveRender.Render(minion);
            }
            foreach (var minion in Game.Team2_Minions)
            {
                ActiveRender.Render(minion);
            }
            foreach (var player in Game.Team1)
            {
                ActiveRender.Render(player);
            }
            foreach (var player in Game.Team2)
            {
                ActiveRender.Render(player);
            }
        }
    }
}
