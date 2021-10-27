namespace Music
{
    partial class frmSavePLaylist
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
            this.listBoxSavePL = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxSavePL
            // 
            this.listBoxSavePL.FormattingEnabled = true;
            this.listBoxSavePL.Location = new System.Drawing.Point(23, 28);
            this.listBoxSavePL.Name = "listBoxSavePL";
            this.listBoxSavePL.Size = new System.Drawing.Size(316, 251);
            this.listBoxSavePL.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(134, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmSavePLaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 351);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBoxSavePL);
            this.Name = "frmSavePLaylist";
            this.Text = "frmSavePLaylist";
            this.Load += new System.EventHandler(this.frmSavePLaylist_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxSavePL;
        private System.Windows.Forms.Button button1;
    }
}