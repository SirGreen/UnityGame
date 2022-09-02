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
    public partial class TerrainMaker : Form
    {

        static int TerrainNum = 0;
        static string TerrainName = "", TerrainDes = "";

        public TerrainMaker()
        {
            InitializeComponent();
            TerrainPicture.AllowDrop = true;
            InitTerrainNum();
        }

        private void InitTerrainNum()
        {
            if (!File.Exists("NumOfTerrain.txt"))
            {
                TerrainNum = 0;
                File.WriteAllText("NumOfTerrain.txt", "0");
            }
            else
            {
                string s = File.ReadAllText("NumOfTerrain.txt");
                TerrainNum = Convert.ToInt32(s);
            }
        }

        private void TerrainMaker_Load(object sender, EventArgs e)
        {
            groupBox1.Location = new Point(0, 0);
            groupBox2.Location = new Point(groupBox1.Width + 10, 0);
            flowLayoutPanel1.Location = new Point(0, groupBox1.Height + 25);
        }

        private void TerrainPicture_DragDrop(object sender, DragEventArgs e)
        {
            var data = e.Data.GetData(DataFormats.FileDrop);
            if (data != null)
            {
                var fName = data as string[];
                if (fName.Length > 0)
                    TerrainPicture.Image = Image.FromFile(fName[0]);
            }
        }

        private void TerrainPicture_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || TerrainPicture.Image == null)
            {
                MessageBox.Show("Sth missing :vv");
                return;
            }

            if (!Directory.Exists("Terrain")) Directory.CreateDirectory("Terrain");

            if (!Directory.Exists("Terrain/" + TerrainName))
                Directory.CreateDirectory("Terrain/" + TerrainName);
            else
            {
                MessageBox.Show("This name has been used!!");
                return;
            }
            File.WriteAllText("Terrain/" + TerrainName + "/Des.txt", TerrainDes);
            TerrainPicture.Image.Save("Terrain/" + TerrainName + "/Img.png");

            TerrainNum++;
            File.WriteAllText("NumOfTerrain.txt", TerrainNum.ToString());

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            TerrainDes = textBox2.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
            TerrainPicture.Image = null;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TerrainName = textBox1.Text;
        }
    }
}

