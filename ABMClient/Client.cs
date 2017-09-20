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
        public Game1v1 World = new Game1v1();
        public Camera View = new Camera();

        public bool IsRunning = false;
        public Client()
        {

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
                
                Application.DoEvents();
            }
        }

        public void Stop()
        {
            IsRunning = false;
        }
    }
}
