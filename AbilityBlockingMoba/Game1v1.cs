using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbilityBlockingMoba
{
    public class Game1v1 : Game
    {
        public Player Player1 = new Player();
        public Player Player2 = new Player();

        public List<Minion> Team1_Minions = new List<Minion>();
        public List<Minion> Team2_Minions = new List<Minion>();

        public Game1v1()
        {
            base.Name = "MOBA 1v1";
        }
    }
}
