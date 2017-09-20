using AbilityBlockingMoba;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABMClient
{
    public class RenderGDI : IRender
    {
        public void Render(Game1v1 game)
        {
            foreach (var minion in game.Team1_Minions)
            {
                this.Render()
            }
            foreach (var minion in game.Team1_Minions)
            {

            }
        }

        public void Render(Game5v5 game)
        {
            throw new NotImplementedException();
        }

        public void Render(Minion minion)
        {
            throw new NotImplementedException();
        }
    }
}
