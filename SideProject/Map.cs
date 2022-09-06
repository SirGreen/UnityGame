using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace SideProject
{
    public partial class Map : Form
    {
        public Map()
        {
            InitializeComponent();
            initMap();
            LoadTerrain();
        }

        static bool isDelete = false, isFill = false;
        static int[,] mapgame = new int[30, 14];
        static bool[,] isUnvisit = new bool[30, 14];  

        Button[,] btnmap = new Button[30, 14];
        PictureBox pbmap = new PictureBox();
        Button btnerase = new Button()
        {
            Size = new Size(70, 40),
            Text = "Erase"
        };
        int mode = 0;

        void initMap()
        {
            for (int i = 0; i < 30; i++)
            {
                for (int j = 0; j < 14; j++)
                {
                    mapgame[i, j] = 0;
                    Button btn = new Button()
                    {
                        Width = 50,
                        Height = 50,
                        Location = new Point(i * 50, j * 50),
                        Name = i.ToString() + "_" + j.ToString(),
                        BackgroundImageLayout = ImageLayout.Stretch,
                    };

                    btnmap[i, j] = btn;
                    btn.Click += MapBtnClick;
                    MapP.Controls.Add(btn);

                    isUnvisit[i, j] = true;
                }
            }
            button3.Text = "Delete Terrain";
            isDelete = false;
        }

        static int[] dx = new int[4] { -1, 0, 1, 0 };
        static int[] dy = new int[4] { 0, -1, 0, 1 };
       
        bool isValid(int x, int y, int h)
        {
            return (x + dx[h] > -1 && x + dx[h] < 30 && y + dy[h] > -1 && y + dy[h] < 14);
        }

        private void Loan(int x, int y, int ch)
        {
            mapgame[x,y]=mode;
            isUnvisit[x,y] = false;

            btnmap[x, y].BackgroundImage = pbmap.Image;

            for (int i = 0; i < 4; i++)
            {
                if (isValid(x, y, i) && mapgame[x + dx[i], y + dy[i]] == ch
                    && isUnvisit[x + dx[i], y + dy[i]])                     
                    Loan(x + dx[i], y + dy[i],ch);
            }
        }

        private void MapBtnClick(object? sender, EventArgs e)
        {
            Button btn = sender as Button;

            string s = btn.Name,s2="";
            int x = 0, y = 0;
            
            for (int i = 0; i < s.Length; i++) 
            {
                if (s[i] == '_')
                {
                    x = Convert.ToInt32(s2);
                    s2 = "";
                }
                else s2 += s[i];
            }

            y = Convert.ToInt32(s2);

            if(isFill)
            {
                for (int i = 0; i < 30; i++)
                    for (int j = 0; j < 14; j++) isUnvisit[i, j] = true;
                Loan(x, y, mapgame[x,y]);
            }
            else 
            {
                btn.BackgroundImage = pbmap.Image;
                mapgame[x, y] = mode;
            }
        }

        private Bitmap LoadBitMapUnlock(string s)
        {
            using (Bitmap bm = new Bitmap(s))
            {
                return new Bitmap(bm);
            }
        }


        private void LoadTerrain()
        {
            fpOpt.Controls.Clear();

            ///Nothing btn
            fpOpt.Controls.Add(btnerase);
            btnerase.Click += EraseButton_click;

            if (!Directory.Exists("Terrain")) return;
            DirectoryInfo direct = new DirectoryInfo("Terrain");

            string s,s1;

            foreach (DirectoryInfo dir in direct.GetDirectories())
            {
                s = dir + "/Img.png";
                Button btn = new Button()
                {
                    Name = dir.Name,
                    BackgroundImage = LoadBitMapUnlock(s),
                    Size = new Size(50, 50),
                    BackgroundImageLayout = ImageLayout.Stretch,
                };
                fpOpt.Controls.Add(btn);
                btn.Click += Btn_Click;
            }
        }

        private void EraseButton_click(object? sender, EventArgs e)
        {
            mode = 0;
            pbmap.Image = null;
            fpInfo.Controls.Clear();
        }

        private void DeleteTerrain(string s)
        {
            if (!Directory.Exists("Terrain/" + s)) return;

            DirectoryInfo dir = new DirectoryInfo("Terrain/" + s);
            if (dir.Exists) dir.Delete(true);

            LoadTerrain();
        }

        private void Btn_Click(object? sender, EventArgs e)
        {
            Button btn = sender as Button;
            
            
            if (!isDelete)
            {
                if (File.Exists("Terrain/"+btn.Name + "/Des.txt"))
                {
                    string[] s2 = File.ReadAllLines("Terrain/"+btn.Name + "/Des.txt");
                    mode = Convert.ToInt32(s2[0]);
                }
                fpInfo.Controls.Clear();
                PictureBox pb = new PictureBox()
                {
                    Image = btn.BackgroundImage,
                };
                pbmap = pb;
                Label lb = new Label()
                {
                    Text = btn.Name + ": ",
                    AutoSize = true
                };

                fpInfo.Controls.Add(pb);
                fpInfo.Controls.Add(lb);

                if (File.Exists("Terrain/" + btn.Name + "/Des.txt"))
                {
                    Label lb2 = new Label()
                    {
                        Text = File.ReadAllText("Terrain/" + btn.Name + "/Des.txt"),
                        AutoSize = true
                    };
                    fpInfo.Controls.Add(lb2);
                }
            }
            else
            {
                Color c = btn.BackColor;
                btn.BackColor = Color.OrangeRed;
                DialogResult result = MessageBox.Show("Are you sure to delete this terrain?", "Notification", MessageBoxButtons.YesNo);

                switch (result)
                {
                    case DialogResult.Yes:
                        {
                            fpOpt.Controls.Clear();
                            DeleteTerrain(btn.Name);
                            break;
                        }
                    case DialogResult.No:
                        {
                            btn.BackColor = c;
                            break;
                        }
                }

            }
        }

        private void Map_Load(object sender, EventArgs e)
        {
            MapBox.Location = new Point(0, 0);

            MapDBox.Location = new Point(0, MapBox.Height + 25);
            MapDBox.Width = MapBox.Width;

            Terraingb.Location = new Point(MapBox.Width + 25, 0);
            Terraingb.Height = MapBox.Height;

            fpTerrain.Location = new Point(5, 25);
            fpTerrain.Width = Terraingb.Width - 25;
            fpTerrain.Height = Terraingb.Height - 40;

            TerrainOpt.Width = fpTerrain.Width;
            TerrainOpt.Height = fpTerrain.Height / 3 * 2 - 10;

            fpOpt.Width = TerrainOpt.Width - 25;
            fpOpt.Height = TerrainOpt.Height - 40;
            fpOpt.Location = new Point(5, 25);

            TerrainInfo.Width = fpTerrain.Width;
            TerrainInfo.Height = fpTerrain.Height / 3;

            fpInfo.Width = TerrainInfo.Width - 25;
            fpInfo.Height = TerrainInfo.Height - 40;
            fpInfo.Location = new Point(5, 25);

            isFill = false;
            isDelete = false;

            fPButtonMap.Location = new Point(MapBox.Width + 25, Terraingb.Height + 25);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TerrainMaker ter = new TerrainMaker();
            this.Hide();

            button3.Text = "Delete Terrain";
            isDelete = false;

            button4.Text = "Fill Terrain";
            isFill = false;

            ter.ShowDialog();

            LoadTerrain();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == "Delete Terrain")
            {
                isDelete = true;
                MessageBox.Show("Please choose the terrain that you want to delete!");
                button3.Text = "Normal Mode";
            }
            else
            {
                isDelete = false;
                button3.Text = "Delete Terrain";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(button4.Text=="Fill Terrain")
            {
                isFill = true;
                button4.Text = "Draw Terrain";
            }
            else
            {
                button4.Text = "Fill Terrain";
                isFill = false;
            }
        }
    }
}

