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
    public partial class Map : Form
    {
        public Map()
        {
            InitializeComponent();
            initMap();
            LoadTerrain();
        }

        static bool isDelete = false;

        void initMap()
        {
            for(int i=0;i<30;i++)
            {
                for(int j=0;j<14;j++)
                {
                    Button btn = new Button()
                    {
                        Width = 50,
                        Height = 50,
                        Location = new Point(i * 50, j * 50),
                    };

                    MapP.Controls.Add(btn);
                }
            }
        }

        private void LoadTerrain()
        {
            if (!Directory.Exists("Terrain")) return;
            DirectoryInfo direct = new DirectoryInfo("Terrain");

            Bitmap img;

            foreach(DirectoryInfo dir in direct.GetDirectories())
            {
                img = new Bitmap(dir + "/Img.png");
                Button btn = new Button()
                {
                    Name = dir.Name,
                    Image = img,
                    Size = new Size(40, 40)
                };
                fpOpt.Controls.Add(btn);
                btn.Click += Btn_Click;
            }
        }

        private void DeleteTerrain(string s)
        {
            fpInfo.Controls.Clear();
            fpOpt.Controls.Clear();
            if (!Directory.Exists("Terrain/"+s)) return;

            DirectoryInfo dir = new DirectoryInfo("Terrain/"+s);
            if (dir.Exists) dir.Delete(true);

            LoadTerrain();
        }

        private void Btn_Click(object? sender, EventArgs e)
        {
            Button btn = sender as Button;
            if(!isDelete)
            {
                fpInfo.Controls.Clear();
                PictureBox pb = new PictureBox()
                {
                    Image = btn.Image
                };
                Label lb = new Label()
                {
                    Text = btn.Name,
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

                switch(result)
                {
                    case DialogResult.Yes:
                        {
                            btn.Image = null;
                            string s = btn.Name;
                            fpOpt.Controls.Remove(btn);
                            DeleteTerrain(s);
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

            fpTerrain.Location = new Point(5,25);
            fpTerrain.Width = Terraingb.Width-25;
            fpTerrain.Height = Terraingb.Height - 40;

            TerrainOpt.Width = fpTerrain.Width;
            TerrainOpt.Height = fpTerrain.Height/3*2-10;

            fpOpt.Width = TerrainOpt.Width - 25;
            fpOpt.Height = TerrainOpt.Height - 40;
            fpOpt.Location = new Point(5, 25);

            TerrainInfo.Width = fpTerrain.Width;
            TerrainInfo.Height = fpTerrain.Height / 3;

            fpInfo.Width = TerrainInfo.Width - 25;
            fpInfo.Height = TerrainInfo.Height - 40;
            fpInfo.Location = new Point(5, 25);


            fPButtonMap.Location = new Point(MapBox.Width + 25, Terraingb.Height + 25);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TerrainMaker ter = new TerrainMaker();
            this.Hide();
            ter.ShowDialog();

            fpOpt.Controls.Clear();
            LoadTerrain();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(button3.Text=="Delete Terrain")
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
    }
}
