namespace searchGoogle
{
    partial class navigateurFenetre
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
            this.wb_seeRes = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // wb_seeRes
            // 
            this.wb_seeRes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wb_seeRes.Location = new System.Drawing.Point(0, 0);
            this.wb_seeRes.MinimumSize = new System.Drawing.Size(20, 20);
            this.wb_seeRes.Name = "wb_seeRes";
            this.wb_seeRes.Size = new System.Drawing.Size(1179, 596);
            this.wb_seeRes.TabIndex = 0;
            // 
            // navigateurFenetre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 596);
            this.Controls.Add(this.wb_seeRes);
            this.Name = "navigateurFenetre";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.WebBrowser wb_seeRes;
    }
}