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
            this.Terrain = new System.Windows.Forms.GroupBox();
            this.fPButtonMap = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.MapBox.SuspendLayout();
            this.fPButtonMap.SuspendLayout();
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
            // Terrain
            // 
            this.Terrain.Location = new System.Drawing.Point(733, 83);
            this.Terrain.Name = "Terrain";
            this.Terrain.Size = new System.Drawing.Size(346, 150);
            this.Terrain.TabIndex = 2;
            this.Terrain.TabStop = false;
            this.Terrain.Text = "Terrain";
            // 
            // fPButtonMap
            // 
            this.fPButtonMap.AutoSize = true;
            this.fPButtonMap.Controls.Add(this.button1);
            this.fPButtonMap.Controls.Add(this.button2);
            this.fPButtonMap.Location = new System.Drawing.Point(749, 270);
            this.fPButtonMap.Name = "fPButtonMap";
            this.fPButtonMap.Size = new System.Drawing.Size(251, 41);
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
            // 
            // Map
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(1924, 877);
            this.Controls.Add(this.fPButtonMap);
            this.Controls.Add(this.Terrain);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox MapBox;
        private Panel MapP;
        private GroupBox MapDBox;
        private GroupBox Terrain;
        private FlowLayoutPanel fPButtonMap;
        private Button button1;
        private Button button2;
    }
}