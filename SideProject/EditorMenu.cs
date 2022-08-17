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
            UnitPiture.AllowDrop = true;
        }

        private void UnitPiture_DragDrop(object sender, DragEventArgs e)
        {
            var data = e.Data.GetData(DataFormats.FileDrop);
            if (data != null)
            {
                var fName = data as string[];
                if (fName.Length>0)
                    UnitPiture.Image = Image.FromFile(fName[0]);
            }
        }

        private void UnitPiture_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UnitPiture.Image = null;
            UnitNameB.Text = null;
            UnitDescrip.Text = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
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
