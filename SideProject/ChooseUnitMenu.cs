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
    public partial class ChooseUnit : Form
    {
        public ChooseUnit()
        {
            InitializeComponent();
        }

        private void DeleteFile(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            EditorMenu em = new();
            em.UnitGet();
            if (Directory.Exists(btn.Name))
            {
                Directory.Delete(btn.Name,true);
                em.UnitNumber--;
                File.WriteAllText("NumOfUnit.txt", em.UnitNumber.ToString());
                MessageBox.Show("Just deleted the files owo)b");
            }
            else MessageBox.Show("Already deleted >:(");
        }

        public bool Loading = false;
        public string LoadThis;

        private void LoadUnit(object sender, EventArgs e)
        {
            Loading = true;
            Button btn = sender as Button;
            LoadThis = btn.Name;
            this.Close();
        }

        private void ChooseUnit_Load(object sender, EventArgs e)
        {
            string[] s = Directory.GetDirectories(Directory.GetCurrentDirectory()).Select(Path.GetFileName).ToArray();
            EditorMenu em = new();
            em.UnitGet();
            for (int i = 1; i <= em.UnitNumber; i++)
            {
                FlowLayoutPanel fp = new();
                fp.Height = 50; fp.Width = 300;
                Label lbl = new Label();
                lbl.Text = s[i];
                fp.Controls.Add(lbl);
                Button btns = new();
                btns.Text = "Load";
                btns.Name = s[i];
                fp.Controls.Add(btns);
                Button btnd = new();
                btnd.Text = "Delete";
                btnd.Name = s[i];
                btnd.Click += DeleteFile;
                btns.Click += LoadUnit;
                fp.Controls.Add(btnd);
                ChooseUnitfP.Controls.Add(fp);
            }
        }
    }
}
