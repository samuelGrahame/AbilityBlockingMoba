using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbilityBlockingMoba
{
    public class GameRender
    {
        public IRender ActiveRender;        

        public void Render(Game1v1 game)
        {
            ActiveRender.Render(game);
            foreach (var minion in game.Team1_Minions)
            {
                ActiveRender.Render(minion);
            }
            foreach (var minion in game.Team2_Minions)
            {
                ActiveRender.Render(minion);
            }
            ActiveRender.Render(game.Player1);
            ActiveRender.Render(game.Player2);
        }

        public void Render(Game5v5 game)
        {
            ActiveRender.Render(game);
            foreach (var minion in game.Team1_Minions)
            {
                ActiveRender.Render(minion);
            }
            foreach (var minion in game.Team2_Minions)
            {
                ActiveRender.Render(minion);
            }
            foreach (var player in game.Team1)
            {
                ActiveRender.Render(player);
            }
            foreach (var player in game.Team2)
            {
                ActiveRender.Render(player);
            }            
        }
    }
}
