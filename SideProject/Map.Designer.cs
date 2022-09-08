namespace SideProject
{
    partial class Map
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MapBox = new System.Windows.Forms.GroupBox();
            this.MapP = new System.Windows.Forms.Panel();
            this.MapDBox = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.fPButtonMap = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Terraingb = new System.Windows.Forms.GroupBox();
            this.fpTerrain = new System.Windows.Forms.FlowLayoutPanel();
            this.TerrainOpt = new System.Windows.Forms.GroupBox();
            this.fpOpt = new System.Windows.Forms.FlowLayoutPanel();
            this.TerrainInfo = new System.Windows.Forms.GroupBox();
            this.fpInfo = new System.Windows.Forms.FlowLayoutPanel();
            this.MapBox.SuspendLayout();
            this.MapDBox.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.fPButtonMap.SuspendLayout();
            this.Terraingb.SuspendLayout();
            this.fpTerrain.SuspendLayout();
            this.TerrainOpt.SuspendLayout();
            this.TerrainInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // MapBox
            // 
            this.MapBox.AutoSize = true;
            this.MapBox.Controls.Add(this.MapP);
            this.MapBox.Location = new System.Drawing.Point(31, 28);
            this.MapBox.Name = "MapBox";
            this.MapBox.Size = new System.Drawing.Size(398, 267);
            this.MapBox.TabIndex = 0;
            this.MapBox.TabStop = false;
            this.MapBox.Text = "Map";
            // 
            // MapP
            // 
            this.MapP.AutoSize = true;
            this.MapP.Location = new System.Drawing.Point(6, 30);
            this.MapP.Name = "MapP";
            this.MapP.Size = new System.Drawing.Size(386, 150);
            this.MapP.TabIndex = 0;
            // 
            // MapDBox
            // 
            this.MapDBox.Controls.Add(this.flowLayoutPanel1);
            this.MapDBox.Location = new System.Drawing.Point(31, 343);
            this.MapDBox.Name = "MapDBox";
            this.MapDBox.Size = new System.Drawing.Size(574, 312);
            this.MapDBox.TabIndex = 1;
            this.MapDBox.TabStop = false;
            this.MapDBox.Text = "Map Description";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.textBox1);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.textBox2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(18, 30);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(409, 275);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Map Name:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(113, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(286, 31);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Map Description";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(3, 65);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(396, 175);
            this.textBox2.TabIndex = 3;
            // 
            // fPButtonMap
            // 
            this.fPButtonMap.Controls.Add(this.button1);
            this.fPButtonMap.Controls.Add(this.button5);
            this.fPButtonMap.Controls.Add(this.button2);
            this.fPButtonMap.Controls.Add(this.button3);
            this.fPButtonMap.Controls.Add(this.button4);
            this.fPButtonMap.Location = new System.Drawing.Point(446, 92);
            this.fPButtonMap.Name = "fPButtonMap";
            this.fPButtonMap.Size = new System.Drawing.Size(425, 87);
            this.fPButtonMap.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(120, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(85, 34);
            this.button5.TabIndex = 4;
            this.button5.Text = "Save";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Location = new System.Drawing.Point(211, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(181, 35);
            this.button2.TabIndex = 1;
            this.button2.Text = "Terrain Maker";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(3, 44);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(151, 33);
            this.button3.TabIndex = 2;
            this.button3.Text = "Delete Terrain";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(160, 44);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(141, 33);
            this.button4.TabIndex = 3;
            this.button4.Text = "Fill Terrain";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Terraingb
            // 
            this.Terraingb.Controls.Add(this.fpTerrain);
            this.Terraingb.Location = new System.Drawing.Point(877, 122);
            this.Terraingb.Name = "Terraingb";
            this.Terraingb.Size = new System.Drawing.Size(364, 593);
            this.Terraingb.TabIndex = 4;
            this.Terraingb.TabStop = false;
            this.Terraingb.Text = "Terrain";
            // 
            // fpTerrain
            // 
            this.fpTerrain.Controls.Add(this.TerrainOpt);
            this.fpTerrain.Controls.Add(this.TerrainInfo);
            this.fpTerrain.Location = new System.Drawing.Point(36, 72);
            this.fpTerrain.Name = "fpTerrain";
            this.fpTerrain.Size = new System.Drawing.Size(321, 517);
            this.fpTerrain.TabIndex = 0;
            // 
            // TerrainOpt
            // 
            this.TerrainOpt.Controls.Add(this.fpOpt);
            this.TerrainOpt.Location = new System.Drawing.Point(3, 3);
            this.TerrainOpt.Name = "TerrainOpt";
            this.TerrainOpt.Size = new System.Drawing.Size(300, 230);
            this.TerrainOpt.TabIndex = 0;
            this.TerrainOpt.TabStop = false;
            this.TerrainOpt.Text = "Terrain Option";
            // 
            // fpOpt
            // 
            this.fpOpt.AutoScroll = true;
            this.fpOpt.Location = new System.Drawing.Point(6, 40);
            this.fpOpt.Name = "fpOpt";
            this.fpOpt.Size = new System.Drawing.Size(289, 150);
            this.fpOpt.TabIndex = 0;
            // 
            // TerrainInfo
            // 
            this.TerrainInfo.Controls.Add(this.fpInfo);
            this.TerrainInfo.Location = new System.Drawing.Point(3, 239);
            this.TerrainInfo.Name = "TerrainInfo";
            this.TerrainInfo.Size = new System.Drawing.Size(319, 215);
            this.TerrainInfo.TabIndex = 1;
            this.TerrainInfo.TabStop = false;
            this.TerrainInfo.Text = "Terrain Info";
            // 
            // fpInfo
            // 
            this.fpInfo.Location = new System.Drawing.Point(6, 30);
            this.fpInfo.Name = "fpInfo";
            this.fpInfo.Size = new System.Drawing.Size(300, 150);
            this.fpInfo.TabIndex = 0;
            // 
            // Map
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(1924, 877);
            this.Controls.Add(this.Terraingb);
            this.Controls.Add(this.fPButtonMap);
            this.Controls.Add(this.MapDBox);
            this.Controls.Add(this.MapBox);
            this.Name = "Map";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Map";
            this.Load += new System.EventHandler(this.Map_Load);
            this.MapBox.ResumeLayout(false);
            this.MapBox.PerformLayout();
            this.MapDBox.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.fPButtonMap.ResumeLayout(false);
            this.fPButtonMap.PerformLayout();
            this.Terraingb.ResumeLayout(false);
            this.fpTerrain.ResumeLayout(false);
            this.TerrainOpt.ResumeLayout(false);
            this.TerrainInfo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox MapBox;
        private Panel MapP;
        private GroupBox MapDBox;
        private FlowLayoutPanel fPButtonMap;
        private Button button1;
        private Button button2;
        private GroupBox Terraingb;
        private FlowLayoutPanel fpTerrain;
        private GroupBox TerrainOpt;
        private FlowLayoutPanel fpOpt;
        private GroupBox TerrainInfo;
        private FlowLayoutPanel fpInfo;
        private Button button3;
        private Button button4;
        private Button button5;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
    }
}