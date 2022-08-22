using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
        int[,] a = new int[12, 24];
        string[] atofile = new string[26];
        //ux - UnitNumber x cordinate
        int mode = 0, ux = -1, uy = -1;
        public int UnitNumber=0;
        bool isPlaced = false;
        string unitName = "", unitDes = "";
        Button[,] but = new Button[12,24];
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

        public void UnitGet()
        {
            string s = File.ReadAllText("NumOfUnit.txt");

            UnitNumber = Convert.ToInt32(s);
        }

        private void ElementInit()
        {
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 24; j++)
                {
                    a[i, j] = 0;
                    Button btn = new()
                    {
                        Width = 50,
                        Height = 50,
                        BackColor = Color.White,
                        Location = new Point(j * 50, i * 50),
                        Name = i + " " + j
                    };
                    btn.Click += button_Click;
                    but[i, j] = btn;
                    MoveMapP.Controls.Add(but[i,j]);
                }
            }
            UnitGet();
        }
        #endregion

        #region MenuButtons
        //Exit button
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void Reset(Button btn)
        {
            UnitPiture.Image = null;
            UnitNameB.Text = null;
            UnitDescrip.Text = null;

            MoveMapP.Controls.Clear();
            btn.Enabled = false;

            if ((DateTime.Now - timespam).Ticks < 5000000) return;
            timespam = DateTime.Now;

            ElementInit();

            for (int i = 0; i < 12; i++) 
            {
                for (int j = 0; j < 24; j++) 
                {
                    a[i, j] = 0;
                }
                atofile[i] = "";
            }

            await Task.Delay(300);
            btn.Enabled = true;
        }
        #endregion

        private Color c(int i)
        {
            switch (i)
            {
                case 1: return Color.Green; 
                case 2: return Color.Aquamarine; 
                case 3: return Color.Red; 
                case 4: return Color.SlateGray;               
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

        #region Advance Button 

        ///////Unit Name//////////
        private void UnitNameB_TextChanged(object sender, EventArgs e)
        {
            unitName = UnitNameB.Text;
        }

        //Choose unit
        private void ChooseUnitB_Click(object sender, EventArgs e)
        {
            ChooseUnit choose = new ChooseUnit();
            choose.ShowDialog();
            if (choose.Loading)
            {
                ResetBut_Click(button1,null);
                UnitPiture.Image = Image.FromFile(choose.LoadThis + "/Img.png");
                UnitNameB.Text = choose.LoadThis;
                string[] s = File.ReadAllLines(choose.LoadThis + "/info.txt");
                UnitDescrip.Text = s[13];
                for (int i = 0; i < 12; i++)
                {
                    int[] b = new int[24];
                    int x = 0;
                    string t = "";
                    while (s[i].Length>0)
                        if (s[i][0] !=' ')
                    {
                            t += s[i][0];
                            s[i] = s[i].Remove(0, 1);
                    } else
                        {
                            s[i] = s[i].Remove(0, 1);
                            b[x] = int.Parse(t);
                            t = "";
                            x++;
                        }
                    for (int j = 0; j < 24; j++)
                    {
                        a[i,j] = b[j];
                    }
                }
                for (int i = 0; i < 12; i++)
                    for (int j = 0; j < 24; j++)
                    {
                        but[i, j].BackColor = c(a[i, j]);
                        if (a[i, j] == 1)
                        {
                            but[i, j].Text = "R";
                            ux = i; uy = j;
                        }
                    }
            }
        }

        //////////Unit Des//////////////
        private void UnitDescrip_TextChanged(object sender, EventArgs e)
        {
            unitDes = UnitDescrip.Text;
        }

        ///////////New Unit//////////
        private void ResetBut_Click(object sender, EventArgs e)
        {
            UnitGet();
            Reset(ResetBut);
        }

        private void SaveBut_Click(object sender, EventArgs e)
        {
            /////Save
            if (unitName == "" || UnitPiture.Image == null || unitDes == "" || ux == -1) 
            {
                MessageBox.Show("Something's missing! >:(");
                return;
            }
            
            /// Move Map
            UnitGet();
            for (int i = 0; i < 26; i++) atofile[i] = "";
            for (int i = 0; i < 12; i++) 
            {
                for (int j = 0; j < 24; j++) 
                {
                    atofile[i] += a[i, j].ToString() + " ";
                }
            }

            atofile[13] = unitDes;

            ////Tao folder

            if (!Directory.Exists(unitName))
            {
                Directory.CreateDirectory(unitName);
                MessageBox.Show("Saved uwu");
            }
            else
            {
                MessageBox.Show("This name has been used!");
                return;
            }

            File.WriteAllLines(unitName + "/info.txt", atofile);

            /// Picture
            UnitPiture.Image.Save(unitName + "/Img.png");

            UnitNumber++;
            File.WriteAllText("NumOfUnit.txt", UnitNumber.ToString());

        }
        #endregion
    }
}
