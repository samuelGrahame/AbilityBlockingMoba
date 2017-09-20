using AbilityBlockingMoba;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABMClient
{
    public class RenderGDI<T> : IRender<T>
        where T : Game
    {        
        public Graphics g;
        public Client Window;

        public void Clear()
        {
            g.Clear(Color.CornflowerBlue);
        }

        public Brush GetBrushFromTeam(TeamType type)
        {
            Brush brush;
            switch (type)
            {
                default:
                case TeamType.Red:
                    brush = Brushes.Red;
                    break;
                case TeamType.Blue:
                    brush = Brushes.Blue;
                    break;
            }
            return brush;
        }

        /// <summary>
        /// Render Minion
        /// </summary>
        /// <param name="minion"></param>
        public void Render(Minion minion)
        {
            g.FillRectangle(GetBrushFromTeam(minion.Team), new RectangleF(minion.X - 15, minion.Y - 15, 30, 30));
        }

        /// <summary>
        /// Render Player
        /// </summary>
        /// <param name="player"></param>
        public void Render(Player player)
        {
            g.FillEllipse(GetBrushFromTeam(player.Team), new RectangleF(player.X - 20, player.Y - 20, 40, 40));
        }

        public void Render()
        {
            // render world
            g.FillRectangle(Brushes.ForestGreen, new Rectangle(Point.Empty, Window.ClientSize));
        }
    }
}
