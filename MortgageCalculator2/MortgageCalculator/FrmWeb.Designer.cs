namespace MortgageCalculator
{
    partial class FrmWeb
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
            this.TxtUrl = new System.Windows.Forms.TextBox();
            this.BtnApply = new System.Windows.Forms.Button();
            this.BtnHome = new System.Windows.Forms.Button();
            this.BtnTab = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.SuspendLayout();
            // 
            // TxtUrl
            // 
            this.TxtUrl.Location = new System.Drawing.Point(13, 13);
            this.TxtUrl.Name = "TxtUrl";
            this.TxtUrl.Size = new System.Drawing.Size(312, 20);
            this.TxtUrl.TabIndex = 1;
            // 
            // BtnApply
            // 
            this.BtnApply.Location = new System.Drawing.Point(349, 10);
            this.BtnApply.Name = "BtnApply";
            this.BtnApply.Size = new System.Drawing.Size(75, 23);
            this.BtnApply.TabIndex = 2;
            this.BtnApply.Text = "Go";
            this.BtnApply.UseVisualStyleBackColor = true;
            this.BtnApply.Click += new System.EventHandler(this.BtnApply_Click_1);
            // 
            // BtnHome
            // 
            this.BtnHome.Location = new System.Drawing.Point(445, 9);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Size = new System.Drawing.Size(75, 23);
            this.BtnHome.TabIndex = 3;
            this.BtnHome.Text = "Home";
            this.BtnHome.UseVisualStyleBackColor = true;
            this.BtnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // BtnTab
            // 
            this.BtnTab.Location = new System.Drawing.Point(544, 9);
            this.BtnTab.Name = "BtnTab";
            this.BtnTab.Size = new System.Drawing.Size(75, 23);
            this.BtnTab.TabIndex = 4;
            this.BtnTab.Text = "New Tab";
            this.BtnTab.UseVisualStyleBackColor = true;
            this.BtnTab.Click += new System.EventHandler(this.BtnTab_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Location = new System.Drawing.Point(0, 39);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(665, 491);
            this.tabControl1.TabIndex = 6;
            // 
            // FrmWeb
            // 
            this.ClientSize = new System.Drawing.Size(668, 542);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.BtnTab);
            this.Controls.Add(this.BtnHome);
            this.Controls.Add(this.BtnApply);
            this.Controls.Add(this.TxtUrl);
            this.Name = "FrmWeb";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
        private System.Windows.Forms.TextBox TxtUrl;
        private System.Windows.Forms.Button BtnApply;
        private System.Windows.Forms.Button BtnHome;
        private System.Windows.Forms.Button BtnTab;
        private System.Windows.Forms.TabControl tabControl1;
    }
}