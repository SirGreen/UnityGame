using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SideProject
{
    public partial class EditorMenu : Form
    {
        public EditorMenu()
        {
            InitializeComponent();
            ElementInit();
        }

        private void ElementInit()
        {
            for (int i = 0; i < 24; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    Button btn = new()
                    {
                        Width = 50,
                        Height = 50,
                        Location = new Point(i * 50, j * 50)
                    };
                    MoveMapP.Controls.Add(btn);
                }
            }
        }

        DateTime timespam;

        private async void button3_Click(object sender, EventArgs e)
        {
            MoveMapP.Controls.Clear();
            button3.Enabled = false;

            if ((DateTime.Now - timespam).Ticks < 5000000) return;
            timespam = DateTime.Now;

            ElementInit();

            await Task.Delay(444);
            button3.Enabled = true;
        }
    }
}
