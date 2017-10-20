namespace LockX
{
    partial class Main
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.cbx_screens = new System.Windows.Forms.ComboBox();
            this.lbl_screens = new System.Windows.Forms.Label();
            this.lbl_text = new System.Windows.Forms.Label();
            this.lbl_version = new System.Windows.Forms.Label();
            this.lbl_made = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // cbx_screens
            // 
            this.cbx_screens.AllowDrop = true;
            this.cbx_screens.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbx_screens.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_screens.FormattingEnabled = true;
            this.cbx_screens.Location = new System.Drawing.Point(12, 25);
            this.cbx_screens.Name = "cbx_screens";
            this.cbx_screens.Size = new System.Drawing.Size(210, 21);
            this.cbx_screens.TabIndex = 0;
            this.cbx_screens.SelectedIndexChanged += new System.EventHandler(this.cbx_screens_SelectedIndexChanged);
            // 
            // lbl_screens
            // 
            this.lbl_screens.AutoSize = true;
            this.lbl_screens.Location = new System.Drawing.Point(12, 9);
            this.lbl_screens.Name = "lbl_screens";
            this.lbl_screens.Size = new System.Drawing.Size(44, 13);
            this.lbl_screens.TabIndex = 1;
            this.lbl_screens.Text = "Display:";
            // 
            // lbl_text
            // 
            this.lbl_text.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_text.Location = new System.Drawing.Point(12, 59);
            this.lbl_text.Name = "lbl_text";
            this.lbl_text.Size = new System.Drawing.Size(210, 65);
            this.lbl_text.TabIndex = 2;
            this.lbl_text.Text = "Just select the display above\r\n(Primary enabled by default).\r\nIf you want to unlo" +
    "ck your cursor again,\r\njust close the window.";
            this.lbl_text.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_version
            // 
            this.lbl_version.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_version.AutoSize = true;
            this.lbl_version.Location = new System.Drawing.Point(9, 124);
            this.lbl_version.Name = "lbl_version";
            this.lbl_version.Size = new System.Drawing.Size(13, 13);
            this.lbl_version.TabIndex = 3;
            this.lbl_version.Text = "v";
            // 
            // lbl_made
            // 
            this.lbl_made.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_made.AutoSize = true;
            this.lbl_made.Location = new System.Drawing.Point(133, 124);
            this.lbl_made.Name = "lbl_made";
            this.lbl_made.Size = new System.Drawing.Size(89, 13);
            this.lbl_made.TabIndex = 5;
            this.lbl_made.TabStop = true;
            this.lbl_made.Text = "Made by Mister X";
            this.lbl_made.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_made_LinkClicked);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 146);
            this.Controls.Add(this.lbl_made);
            this.Controls.Add(this.lbl_version);
            this.Controls.Add(this.lbl_text);
            this.Controls.Add(this.lbl_screens);
            this.Controls.Add(this.cbx_screens);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LockX";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbx_screens;
        private System.Windows.Forms.Label lbl_screens;
        private System.Windows.Forms.Label lbl_text;
        private System.Windows.Forms.Label lbl_version;
        private System.Windows.Forms.LinkLabel lbl_made;
    }
}

