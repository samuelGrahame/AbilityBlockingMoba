using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbilityBlockingMoba
{
    public class Game5v5 : Game
    {
        public Player[] Team1 = new Player[5];
        public Player[] Team2 = new Player[5];

        public List<Minion> Team1_Minions = new List<Minion>();
        public List<Minion> Team2_Minions = new List<Minion>();

        public Game5v5()
        {
            base.Name = "MOBA 5v5";
        }
    }
}
