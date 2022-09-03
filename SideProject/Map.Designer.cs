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
            this.Terraingb = new System.Windows.Forms.GroupBox();
            this.fpTerrain = new System.Windows.Forms.FlowLayoutPanel();
            this.TerrainOpt = new System.Windows.Forms.GroupBox();
            this.fpOpt = new System.Windows.Forms.FlowLayoutPanel();
            this.TerrainInfo = new System.Windows.Forms.GroupBox();
            this.fpInfo = new System.Windows.Forms.FlowLayoutPanel();
            this.button3 = new System.Windows.Forms.Button();
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
            this.MapBox.Location = new System.Drawing.Point(32, 29);
            this.MapBox.Name = "MapBox";
            this.MapBox.Size = new System.Drawing.Size(397, 266);
            this.MapBox.TabIndex = 0;
            this.MapBox.TabStop = false;
            this.MapBox.Text = "Map";
            // 
            // MapP
            // 
            this.MapP.AutoSize = true;
            this.MapP.Location = new System.Drawing.Point(6, 30);
            this.MapP.Name = "MapP";
            this.MapP.Size = new System.Drawing.Size(385, 150);
            this.MapP.TabIndex = 0;
            // 
            // MapDBox
            // 
            this.MapDBox.Location = new System.Drawing.Point(32, 344);
            this.MapDBox.Name = "MapDBox";
            this.MapDBox.Size = new System.Drawing.Size(575, 168);
            this.MapDBox.TabIndex = 1;
            this.MapDBox.TabStop = false;
            this.MapDBox.Text = "Map Description";
            // 
            // fPButtonMap
            // 
            this.fPButtonMap.AutoSize = true;
            this.fPButtonMap.Controls.Add(this.button1);
            this.fPButtonMap.Controls.Add(this.button2);
            this.fPButtonMap.Controls.Add(this.button3);
            this.fPButtonMap.Location = new System.Drawing.Point(465, 148);
            this.fPButtonMap.Name = "fPButtonMap";
            this.fPButtonMap.Size = new System.Drawing.Size(409, 41);
            this.fPButtonMap.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Location = new System.Drawing.Point(121, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 35);
            this.button2.TabIndex = 1;
            this.button2.Text = "Terrain Maker";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            this.fpTerrain.Location = new System.Drawing.Point(36, 71);
            this.fpTerrain.Name = "fpTerrain";
            this.fpTerrain.Size = new System.Drawing.Size(322, 516);
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
            this.fpOpt.Size = new System.Drawing.Size(288, 150);
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
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(254, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(152, 34);
            this.button3.TabIndex = 2;
            this.button3.Text = "Delete Terrain";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
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
    }
}