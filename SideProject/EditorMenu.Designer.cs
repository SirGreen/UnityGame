namespace SideProject
{
    partial class EditorMenu
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
            this.UPic = new System.Windows.Forms.GroupBox();
            this.UnitPiture = new System.Windows.Forms.PictureBox();
            this.MoveOp = new System.Windows.Forms.GroupBox();
            this.MoveOpfP = new System.Windows.Forms.FlowLayoutPanel();
            this.b2 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.MoveMap = new System.Windows.Forms.GroupBox();
            this.MoveMapP = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.UnitDescrip = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UnitNameB = new System.Windows.Forms.TextBox();
            this.fPButton = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.UPic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UnitPiture)).BeginInit();
            this.MoveOp.SuspendLayout();
            this.MoveOpfP.SuspendLayout();
            this.MoveMap.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.fPButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // UPic
            // 
            this.UPic.Controls.Add(this.UnitPiture);
            this.UPic.Location = new System.Drawing.Point(46, 1195);
            this.UPic.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UPic.Name = "UPic";
            this.UPic.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UPic.Size = new System.Drawing.Size(227, 292);
            this.UPic.TabIndex = 0;
            this.UPic.TabStop = false;
            this.UPic.Text = "Unit Picture";
            // 
            // UnitPiture
            // 
            this.UnitPiture.BackColor = System.Drawing.Color.LightCoral;
            this.UnitPiture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.UnitPiture.Location = new System.Drawing.Point(6, 22);
            this.UnitPiture.Name = "UnitPiture";
            this.UnitPiture.Size = new System.Drawing.Size(213, 247);
            this.UnitPiture.TabIndex = 0;
            this.UnitPiture.TabStop = false;
            this.UnitPiture.DragDrop += new System.Windows.Forms.DragEventHandler(this.UnitPiture_DragDrop);
            this.UnitPiture.DragEnter += new System.Windows.Forms.DragEventHandler(this.UnitPiture_DragEnter);
            // 
            // MoveOp
            // 
            this.MoveOp.Controls.Add(this.MoveOpfP);
            this.MoveOp.Location = new System.Drawing.Point(1953, 20);
            this.MoveOp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MoveOp.Name = "MoveOp";
            this.MoveOp.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MoveOp.Size = new System.Drawing.Size(546, 1345);
            this.MoveOp.TabIndex = 1;
            this.MoveOp.TabStop = false;
            this.MoveOp.Text = "Move Option";
            // 
            // MoveOpfP
            // 
            this.MoveOpfP.AutoScroll = true;
            this.MoveOpfP.Controls.Add(this.b2);
            this.MoveOpfP.Controls.Add(this.b3);
            this.MoveOpfP.Controls.Add(this.b4);
            this.MoveOpfP.Controls.Add(this.b1);
            this.MoveOpfP.Controls.Add(this.button10);
            this.MoveOpfP.Location = new System.Drawing.Point(7, 32);
            this.MoveOpfP.Name = "MoveOpfP";
            this.MoveOpfP.Size = new System.Drawing.Size(531, 150);
            this.MoveOpfP.TabIndex = 0;
            // 
            // b2
            // 
            this.b2.Location = new System.Drawing.Point(4, 5);
            this.b2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(130, 38);
            this.b2.TabIndex = 0;
            this.b2.Text = "Move Only";
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.b2_Click);
            // 
            // b3
            // 
            this.b3.Location = new System.Drawing.Point(142, 5);
            this.b3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(130, 38);
            this.b3.TabIndex = 1;
            this.b3.Text = "Attack Only";
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.b3_Click);
            // 
            // b4
            // 
            this.b4.Location = new System.Drawing.Point(280, 5);
            this.b4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(143, 38);
            this.b4.TabIndex = 2;
            this.b4.Text = "Move / Attack";
            this.b4.UseVisualStyleBackColor = true;
            this.b4.Click += new System.EventHandler(this.b4_Click);
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(4, 53);
            this.b1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(130, 38);
            this.b1.TabIndex = 3;
            this.b1.Text = "Unit";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(142, 53);
            this.button10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(130, 38);
            this.button10.TabIndex = 4;
            this.button10.Text = "Nothing";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // MoveMap
            // 
            this.MoveMap.AutoSize = true;
            this.MoveMap.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MoveMap.Controls.Add(this.MoveMapP);
            this.MoveMap.Location = new System.Drawing.Point(46, 20);
            this.MoveMap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MoveMap.Name = "MoveMap";
            this.MoveMap.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MoveMap.Size = new System.Drawing.Size(478, 506);
            this.MoveMap.TabIndex = 2;
            this.MoveMap.TabStop = false;
            this.MoveMap.Text = "MoveMap";
            // 
            // MoveMapP
            // 
            this.MoveMapP.AutoSize = true;
            this.MoveMapP.Location = new System.Drawing.Point(7, 32);
            this.MoveMapP.Name = "MoveMapP";
            this.MoveMapP.Size = new System.Drawing.Size(464, 442);
            this.MoveMapP.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.UnitDescrip);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.UnitNameB);
            this.groupBox1.Location = new System.Drawing.Point(316, 1195);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(863, 292);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Unit Description";
            // 
            // UnitDescrip
            // 
            this.UnitDescrip.Location = new System.Drawing.Point(7, 100);
            this.UnitDescrip.Multiline = true;
            this.UnitDescrip.Name = "UnitDescrip";
            this.UnitDescrip.PlaceholderText = "Say what this unit is";
            this.UnitDescrip.Size = new System.Drawing.Size(847, 179);
            this.UnitDescrip.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Unit Description:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Unit Name:";
            // 
            // UnitNameB
            // 
            this.UnitNameB.Location = new System.Drawing.Point(109, 30);
            this.UnitNameB.Name = "UnitNameB";
            this.UnitNameB.PlaceholderText = "Insert name";
            this.UnitNameB.Size = new System.Drawing.Size(745, 31);
            this.UnitNameB.TabIndex = 0;
            this.UnitNameB.TextChanged += new System.EventHandler(this.UnitNameB_TextChanged);
            // 
            // fPButton
            // 
            this.fPButton.Controls.Add(this.button1);
            this.fPButton.Controls.Add(this.button2);
            this.fPButton.Controls.Add(this.button3);
            this.fPButton.Controls.Add(this.button4);
            this.fPButton.Controls.Add(this.button5);
            this.fPButton.Location = new System.Drawing.Point(2139, 1375);
            this.fPButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fPButton.Name = "fPButton";
            this.fPButton.Size = new System.Drawing.Size(347, 102);
            this.fPButton.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(4, 5);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(119, 5);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 38);
            this.button2.TabIndex = 1;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(234, 5);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 38);
            this.button3.TabIndex = 2;
            this.button3.Text = "Reset";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(4, 53);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(176, 38);
            this.button4.TabIndex = 3;
            this.button4.Text = "Choose Unit";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(188, 53);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(154, 38);
            this.button5.TabIndex = 4;
            this.button5.Text = "New Unit";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // EditorMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.fPButton);
            this.Controls.Add(this.MoveOp);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.MoveMap);
            this.Controls.Add(this.UPic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EditorMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Unit Editor";
            this.Load += new System.EventHandler(this.EditorMenu_Load);
            this.UPic.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UnitPiture)).EndInit();
            this.MoveOp.ResumeLayout(false);
            this.MoveOpfP.ResumeLayout(false);
            this.MoveMap.ResumeLayout(false);
            this.MoveMap.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.fPButton.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox UPic;
        private GroupBox MoveOp;
        private GroupBox MoveMap;
        private GroupBox groupBox1;
        private FlowLayoutPanel fPButton;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private PictureBox UnitPiture;
        private TextBox UnitDescrip;
        private Label label2;
        private Label label1;
        private TextBox UnitNameB;
        private Button b4;
        private Button b3;
        private Button b2;
        private Button b1;
        private Panel MoveMapP;
        private Button button5;
        private FlowLayoutPanel MoveOpfP;
        private Button button10;
    }
}