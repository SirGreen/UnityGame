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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
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
            UnitPiture.Image = null;
            UnitNameB.Text = null;
            UnitDescrip.Text = null;

            MoveMapP.Controls.Clear();
            button3.Enabled = false;

            if ((DateTime.Now - timespam).Ticks < 5000000) return;
            timespam = DateTime.Now;

            ElementInit();

            await Task.Delay(300);
            button3.Enabled = true;
        }

        private void EditorMenu_Load(object sender, EventArgs e)
        {
            MoveMap.Location = new Point(0, 0);

            MoveOp.Location = new Point(MoveMap.Width + 25, 0);
            MoveOp.Height = MoveMap.Height;
            MoveOpfP.Height = MoveMap.Height - 50;

            UPic.Location = new Point(0, MoveMap.Height + 25);

            groupBox1.Location = new Point(UPic.Width + 25, MoveMap.Height + 25);

            fPButton.Location = new Point(MoveMap.Width + 25, MoveMap.Height + 25);
        }
    }
}
