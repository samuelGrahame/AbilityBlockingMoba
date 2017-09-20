using AbilityBlockingMoba;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABMClient
{
    public class Client : Form
    {
        public Game1v1 World;
        public Camera View;        
        public GameRender1v1 Render;
        public bool IsRunning = false;
        public Client()
        {
            SetStyle(
                ControlStyles.AllPaintingInWmPaint | 
                ControlStyles.OptimizedDoubleBuffer | 
                ControlStyles.ResizeRedraw | 
                ControlStyles.SupportsTransparentBackColor | 
                ControlStyles.UserPaint, true);

            World = new Game1v1();
            View = new Camera();

            Render = new GameRender1v1()
            {
                ActiveRender = new RenderGDI<Game1v1>()
                {
                    g = this.CreateGraphics(),
                    Window = this
                },
                Game = World
            };            
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Client
            // 
            this.ClientSize = new System.Drawing.Size(624, 446);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Client";
            this.ResumeLayout(false);

        }

        public void Run()
        {
            IsRunning = true;
            while (IsRunning)
            {
                Render.Render();
                Application.DoEvents();
            }
        }

        public void Stop()
        {
            IsRunning = false;
        }
    }
}
