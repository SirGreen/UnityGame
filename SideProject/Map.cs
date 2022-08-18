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
        }

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

        private void Map_Load(object sender, EventArgs e)
        {
            MapBox.Location = new Point(0, 0);

            MapDBox.Location = new Point(0, MapBox.Height + 25);
            MapDBox.Width = MapBox.Width;

            Terrain.Location = new Point(MapBox.Width + 25, 0);
            Terrain.Height = MapBox.Height;

            fPButtonMap.Location = new Point(MapBox.Width + 25, Terrain.Height + 25);
        }
    }
}
