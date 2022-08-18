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
        public TerrainMaker()
        {
            InitializeComponent();
            TerrainPicture.AllowDrop = true;
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
    }
}
