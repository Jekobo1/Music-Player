namespace Music
{
    partial class frmAbout
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
            this.lblMassege = new System.Windows.Forms.Label();
            this.lblEsc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMassege
            // 
            this.lblMassege.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblMassege.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMassege.Font = new System.Drawing.Font("Mustafa", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMassege.Location = new System.Drawing.Point(0, 0);
            this.lblMassege.Name = "lblMassege";
            this.lblMassege.Size = new System.Drawing.Size(414, 209);
            this.lblMassege.TabIndex = 0;
            this.lblMassege.Text = "label1";
            this.lblMassege.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEsc
            // 
            this.lblEsc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblEsc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEsc.Location = new System.Drawing.Point(0, 189);
            this.lblEsc.Name = "lblEsc";
            this.lblEsc.Size = new System.Drawing.Size(414, 20);
            this.lblEsc.TabIndex = 0;
            this.lblEsc.Text = "label1";
            this.lblEsc.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 209);
            this.Controls.Add(this.lblEsc);
            this.Controls.Add(this.lblMassege);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAbout";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAbout";
            this.Load += new System.EventHandler(this.frmAbout_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmAbout_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMassege;
        private System.Windows.Forms.Label lblEsc;
    }
}