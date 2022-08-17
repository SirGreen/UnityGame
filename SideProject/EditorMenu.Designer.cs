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
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
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
            this.MoveMap.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.fPButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // UPic
            // 
            this.UPic.Controls.Add(this.UnitPiture);
            this.UPic.Location = new System.Drawing.Point(32, 717);
            this.UPic.Name = "UPic";
            this.UPic.Size = new System.Drawing.Size(159, 175);
            this.UPic.TabIndex = 0;
            this.UPic.TabStop = false;
            this.UPic.Text = "Unit Picture";
            // 
            // UnitPiture
            // 
            this.UnitPiture.BackColor = System.Drawing.Color.LightCoral;
            this.UnitPiture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.UnitPiture.Location = new System.Drawing.Point(4, 13);
            this.UnitPiture.Margin = new System.Windows.Forms.Padding(2);
            this.UnitPiture.Name = "UnitPiture";
            this.UnitPiture.Size = new System.Drawing.Size(150, 150);
            this.UnitPiture.TabIndex = 0;
            this.UnitPiture.TabStop = false;
            this.UnitPiture.DragDrop += new System.Windows.Forms.DragEventHandler(this.UnitPiture_DragDrop);
            this.UnitPiture.DragEnter += new System.Windows.Forms.DragEventHandler(this.UnitPiture_DragEnter);
            // 
            // MoveOp
            // 
            this.MoveOp.Controls.Add(this.button9);
            this.MoveOp.Controls.Add(this.button8);
            this.MoveOp.Controls.Add(this.button7);
            this.MoveOp.Controls.Add(this.button6);
            this.MoveOp.Location = new System.Drawing.Point(1415, 12);
            this.MoveOp.Name = "MoveOp";
            this.MoveOp.Size = new System.Drawing.Size(411, 807);
            this.MoveOp.TabIndex = 1;
            this.MoveOp.TabStop = false;
            this.MoveOp.Text = "Move Option";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(6, 109);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(91, 23);
            this.button9.TabIndex = 3;
            this.button9.Text = "Unit";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(6, 80);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(91, 23);
            this.button8.TabIndex = 2;
            this.button8.Text = "Move / Attack";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(6, 51);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(91, 23);
            this.button7.TabIndex = 1;
            this.button7.Text = "Attack Only";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(6, 22);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(91, 23);
            this.button6.TabIndex = 0;
            this.button6.Text = "Move Only";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // MoveMap
            // 
            this.MoveMap.AutoSize = true;
            this.MoveMap.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MoveMap.Controls.Add(this.MoveMapP);
            this.MoveMap.Location = new System.Drawing.Point(32, 12);
            this.MoveMap.Name = "MoveMap";
            this.MoveMap.Size = new System.Drawing.Size(917, 461);
            this.MoveMap.TabIndex = 2;
            this.MoveMap.TabStop = false;
            this.MoveMap.Text = "MoveMap";
            // 
            // MoveMapP
            // 
            this.MoveMapP.AutoSize = true;
            this.MoveMapP.Location = new System.Drawing.Point(5, 19);
            this.MoveMapP.Margin = new System.Windows.Forms.Padding(2);
            this.MoveMapP.Name = "MoveMapP";
            this.MoveMapP.Size = new System.Drawing.Size(907, 421);
            this.MoveMapP.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.UnitDescrip);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.UnitNameB);
            this.groupBox1.Location = new System.Drawing.Point(221, 717);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(604, 175);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Unit Description";
            // 
            // UnitDescrip
            // 
            this.UnitDescrip.Location = new System.Drawing.Point(5, 60);
            this.UnitDescrip.Margin = new System.Windows.Forms.Padding(2);
            this.UnitDescrip.Multiline = true;
            this.UnitDescrip.Name = "UnitDescrip";
            this.UnitDescrip.PlaceholderText = "Say what this unit is";
            this.UnitDescrip.Size = new System.Drawing.Size(594, 109);
            this.UnitDescrip.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Unit Description:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Unit Name:";
            // 
            // UnitNameB
            // 
            this.UnitNameB.Location = new System.Drawing.Point(76, 18);
            this.UnitNameB.Margin = new System.Windows.Forms.Padding(2);
            this.UnitNameB.Name = "UnitNameB";
            this.UnitNameB.PlaceholderText = "Insert name";
            this.UnitNameB.Size = new System.Drawing.Size(523, 23);
            this.UnitNameB.TabIndex = 0;
            // 
            // fPButton
            // 
            this.fPButton.Controls.Add(this.button1);
            this.fPButton.Controls.Add(this.button2);
            this.fPButton.Controls.Add(this.button3);
            this.fPButton.Controls.Add(this.button4);
            this.fPButton.Controls.Add(this.button5);
            this.fPButton.Location = new System.Drawing.Point(1497, 825);
            this.fPButton.Name = "fPButton";
            this.fPButton.Size = new System.Drawing.Size(243, 61);
            this.fPButton.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(84, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(165, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Reset";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(3, 32);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(123, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Choose Unit";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(132, 32);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(108, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "New Unit";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // EditorMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.fPButton);
            this.Controls.Add(this.MoveOp);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.MoveMap);
            this.Controls.Add(this.UPic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EditorMenu";
            this.Text = "Unit Editor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.UPic.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UnitPiture)).EndInit();
            this.MoveOp.ResumeLayout(false);
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
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button9;
        private Panel MoveMapP;
        private Button button5;
    }
}