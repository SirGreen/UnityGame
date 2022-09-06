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
            this.fPButtonMap = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
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
            this.MapBox.Location = new System.Drawing.Point(22, 17);
            this.MapBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MapBox.Name = "MapBox";
            this.MapBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MapBox.Size = new System.Drawing.Size(278, 160);
            this.MapBox.TabIndex = 0;
            this.MapBox.TabStop = false;
            this.MapBox.Text = "Map";
            // 
            // MapP
            // 
            this.MapP.AutoSize = true;
            this.MapP.Location = new System.Drawing.Point(4, 18);
            this.MapP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MapP.Name = "MapP";
            this.MapP.Size = new System.Drawing.Size(270, 90);
            this.MapP.TabIndex = 0;
            // 
            // MapDBox
            // 
            this.MapDBox.Location = new System.Drawing.Point(22, 206);
            this.MapDBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MapDBox.Name = "MapDBox";
            this.MapDBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MapDBox.Size = new System.Drawing.Size(402, 101);
            this.MapDBox.TabIndex = 1;
            this.MapDBox.TabStop = false;
            this.MapDBox.Text = "Map Description";
            // 
            // fPButtonMap
            // 
            this.fPButtonMap.Controls.Add(this.button1);
            this.fPButtonMap.Controls.Add(this.button2);
            this.fPButtonMap.Controls.Add(this.button3);
            this.fPButtonMap.Controls.Add(this.button4);
            this.fPButtonMap.Location = new System.Drawing.Point(312, 55);
            this.fPButtonMap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fPButtonMap.Name = "fPButtonMap";
            this.fPButtonMap.Size = new System.Drawing.Size(218, 52);
            this.fPButtonMap.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(2, 2);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 20);
            this.button1.TabIndex = 0;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Location = new System.Drawing.Point(84, 2);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 25);
            this.button2.TabIndex = 1;
            this.button2.Text = "Terrain Maker";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(2, 31);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 20);
            this.button3.TabIndex = 2;
            this.button3.Text = "Delete Terrain";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(112, 31);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(99, 20);
            this.button4.TabIndex = 3;
            this.button4.Text = "Fill Terrain";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Terraingb
            // 
            this.Terraingb.Controls.Add(this.fpTerrain);
            this.Terraingb.Location = new System.Drawing.Point(614, 73);
            this.Terraingb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Terraingb.Name = "Terraingb";
            this.Terraingb.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Terraingb.Size = new System.Drawing.Size(255, 356);
            this.Terraingb.TabIndex = 4;
            this.Terraingb.TabStop = false;
            this.Terraingb.Text = "Terrain";
            // 
            // fpTerrain
            // 
            this.fpTerrain.Controls.Add(this.TerrainOpt);
            this.fpTerrain.Controls.Add(this.TerrainInfo);
            this.fpTerrain.Location = new System.Drawing.Point(25, 43);
            this.fpTerrain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fpTerrain.Name = "fpTerrain";
            this.fpTerrain.Size = new System.Drawing.Size(225, 310);
            this.fpTerrain.TabIndex = 0;
            // 
            // TerrainOpt
            // 
            this.TerrainOpt.Controls.Add(this.fpOpt);
            this.TerrainOpt.Location = new System.Drawing.Point(2, 2);
            this.TerrainOpt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TerrainOpt.Name = "TerrainOpt";
            this.TerrainOpt.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TerrainOpt.Size = new System.Drawing.Size(210, 138);
            this.TerrainOpt.TabIndex = 0;
            this.TerrainOpt.TabStop = false;
            this.TerrainOpt.Text = "Terrain Option";
            // 
            // fpOpt
            // 
            this.fpOpt.AutoScroll = true;
            this.fpOpt.Location = new System.Drawing.Point(4, 24);
            this.fpOpt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fpOpt.Name = "fpOpt";
            this.fpOpt.Size = new System.Drawing.Size(202, 90);
            this.fpOpt.TabIndex = 0;
            // 
            // TerrainInfo
            // 
            this.TerrainInfo.Controls.Add(this.fpInfo);
            this.TerrainInfo.Location = new System.Drawing.Point(2, 144);
            this.TerrainInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TerrainInfo.Name = "TerrainInfo";
            this.TerrainInfo.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TerrainInfo.Size = new System.Drawing.Size(223, 129);
            this.TerrainInfo.TabIndex = 1;
            this.TerrainInfo.TabStop = false;
            this.TerrainInfo.Text = "Terrain Info";
            // 
            // fpInfo
            // 
            this.fpInfo.Location = new System.Drawing.Point(4, 18);
            this.fpInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fpInfo.Name = "fpInfo";
            this.fpInfo.Size = new System.Drawing.Size(210, 90);
            this.fpInfo.TabIndex = 0;
            // 
            // Map
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(1347, 526);
            this.Controls.Add(this.Terraingb);
            this.Controls.Add(this.fPButtonMap);
            this.Controls.Add(this.MapDBox);
            this.Controls.Add(this.MapBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Map";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Map";
            this.Load += new System.EventHandler(this.Map_Load);
            this.MapBox.ResumeLayout(false);
            this.MapBox.PerformLayout();
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
    }
}