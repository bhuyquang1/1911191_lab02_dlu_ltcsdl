namespace _1911191_Lab02_Bai01
{
    partial class frmTB
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
            this.lblTB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTB
            // 
            this.lblTB.Location = new System.Drawing.Point(13, 13);
            this.lblTB.Name = "lblTB";
            this.lblTB.Size = new System.Drawing.Size(410, 221);
            this.lblTB.TabIndex = 0;
            this.lblTB.Text = "label1";
            // 
            // frmTB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 243);
            this.Controls.Add(this.lblTB);
            this.Name = "frmTB";
            this.Text = "frmTB";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTB;
    }
}