﻿namespace SideProject
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
            this.MoveOp = new System.Windows.Forms.GroupBox();
            this.MoveMap = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fPButton = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.fPButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // UPic
            // 
            this.UPic.Location = new System.Drawing.Point(32, 263);
            this.UPic.Name = "UPic";
            this.UPic.Size = new System.Drawing.Size(236, 175);
            this.UPic.TabIndex = 0;
            this.UPic.TabStop = false;
            this.UPic.Text = "Unit Picture";
            // 
            // MoveOp
            // 
            this.MoveOp.Location = new System.Drawing.Point(516, 12);
            this.MoveOp.Name = "MoveOp";
            this.MoveOp.Size = new System.Drawing.Size(272, 343);
            this.MoveOp.TabIndex = 1;
            this.MoveOp.TabStop = false;
            this.MoveOp.Text = "Move Option";
            // 
            // MoveMap
            // 
            this.MoveMap.Location = new System.Drawing.Point(32, 12);
            this.MoveMap.Name = "MoveMap";
            this.MoveMap.Size = new System.Drawing.Size(478, 245);
            this.MoveMap.TabIndex = 2;
            this.MoveMap.TabStop = false;
            this.MoveMap.Text = "MoveMap";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(274, 263);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 175);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Unit Description";
            // 
            // fPButton
            // 
            this.fPButton.Controls.Add(this.button1);
            this.fPButton.Controls.Add(this.button2);
            this.fPButton.Controls.Add(this.button3);
            this.fPButton.Controls.Add(this.button4);
            this.fPButton.Controls.Add(this.button5);
            this.fPButton.Location = new System.Drawing.Point(516, 361);
            this.fPButton.Name = "fPButton";
            this.fPButton.Size = new System.Drawing.Size(272, 77);
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
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fPButton);
            this.Controls.Add(this.MoveOp);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.MoveMap);
            this.Controls.Add(this.UPic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EditorMenu";
            this.Text = "Unit Editor";
            this.fPButton.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private Button button5;
    }
}