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

        #region Var
        DateTime timespam;
        int[,] a = new int[24, 12];
        //ux - unit x cordinate
        int mode = 0, ux = -1, uy = -1;
        bool isPlaced = false;
        Button[,] but = new Button[24,12];
        #endregion

        #region Elements
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

        private void ElementInit()
        {
            for (int i = 0; i < 24; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    a[i, j] = 0;
                    Button btn = new()
                    {
                        Width = 50,
                        Height = 50,
                        BackColor = Color.White,
                        Location = new Point(i * 50, j * 50),
                        Name = i + " " + j
                    };
                    btn.Click += button_Click;
                    but[i,j]= btn;
                    MoveMapP.Controls.Add(but[i,j]);
                }
            }
        }
        #endregion

        #region MenuButtons
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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
        #endregion

        private Color c(int i)
        {
            switch (i)
            {
                case 1: return Color.Green; break;
                case 2: return Color.Aquamarine; break;
                case 3: return Color.Red; break;
                case 4: return Color.SlateGray; break;                
            }
            return Color.White;
        }

        #region GetBtnCord
        private int BCx(string s)
        {
            int i = 0;
            while (s[i] != ' ') i++;
            return int.Parse(s.Substring(0, i));
        }

        private int BCy(string s)
        {
            int i = 0;
            while (s[i] != ' ') i++;
            return int.Parse(s.Substring(i));
        }
        #endregion

        //MoveMap buttons
        private void button_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            int x = BCx(b.Name), y = BCy(b.Name);
            if (ux == x && uy == y) return;
            a[x, y] = mode;
            if (mode == 1 && !isPlaced)
            {
                b.Text = "R";
                b.BackColor = c(mode);
                isPlaced = true;
                ux = x; uy = y;
                return;
            } else
                if (mode ==1)
            {
                a[ux,uy] = 0;
                but[ux, uy].BackColor = c(0);
                but[ux, uy].Text = null;
                b.BackColor = c(mode);
                b.Text = "R";
                ux= x; uy = y;
                return;
            }
            b.BackColor = c(mode);
        }

        #region MoveOption
        //Nothing
        private void button10_Click(object sender, EventArgs e)
        {
            mode = 0;
        }

        //MoveOnl
        private void b2_Click(object sender, EventArgs e)
        {
            mode = 2;
        }

        //AttOnl
        private void b3_Click(object sender, EventArgs e)
        {
            mode = 3;
        }

        //Att/Move
        private void b4_Click(object sender, EventArgs e)
        {
            mode = 4;
        }

        //Unit
        private void b1_Click(object sender, EventArgs e)
        {
            mode = 1;
        }
        #endregion
    }
}
