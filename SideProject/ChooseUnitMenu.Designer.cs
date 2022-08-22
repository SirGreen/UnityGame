namespace SideProject
{
    partial class ChooseUnit
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
            this.ChooseUnitfP = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // ChooseUnitfP
            // 
            this.ChooseUnitfP.AutoScroll = true;
            this.ChooseUnitfP.AutoSize = true;
            this.ChooseUnitfP.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ChooseUnitfP.Location = new System.Drawing.Point(12, 12);
            this.ChooseUnitfP.Name = "ChooseUnitfP";
            this.ChooseUnitfP.Size = new System.Drawing.Size(389, 292);
            this.ChooseUnitfP.TabIndex = 0;
            // 
            // ChooseUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 450);
            this.Controls.Add(this.ChooseUnitfP);
            this.Name = "ChooseUnit";
            this.Text = "Choose Unit Menu";
            this.Load += new System.EventHandler(this.ChooseUnit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlowLayoutPanel ChooseUnitfP;
    }
}