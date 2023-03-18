namespace Clowned_OpenSource
{
    partial class MainPanel
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
            this.SelectButtonPanel = new System.Windows.Forms.Panel();
            this.SelectGamesPanel = new System.Windows.Forms.Panel();
            this.SelectHomeButton = new System.Windows.Forms.Button();
            this.SelectSSOButton = new System.Windows.Forms.Button();
            this.SelectAOButton = new System.Windows.Forms.Button();
            this.SelectETS2Button = new System.Windows.Forms.Button();
            this.SelectGIButton = new System.Windows.Forms.Button();
            this.SelectSettingsButton = new System.Windows.Forms.Button();
            this.SelectButtonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SelectButtonPanel
            // 
            this.SelectButtonPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.SelectButtonPanel.Controls.Add(this.SelectSettingsButton);
            this.SelectButtonPanel.Controls.Add(this.SelectGIButton);
            this.SelectButtonPanel.Controls.Add(this.SelectETS2Button);
            this.SelectButtonPanel.Controls.Add(this.SelectAOButton);
            this.SelectButtonPanel.Controls.Add(this.SelectSSOButton);
            this.SelectButtonPanel.Controls.Add(this.SelectHomeButton);
            this.SelectButtonPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SelectButtonPanel.Location = new System.Drawing.Point(0, 0);
            this.SelectButtonPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SelectButtonPanel.Name = "SelectButtonPanel";
            this.SelectButtonPanel.Size = new System.Drawing.Size(266, 701);
            this.SelectButtonPanel.TabIndex = 0;
            // 
            // SelectGamesPanel
            // 
            this.SelectGamesPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.SelectGamesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SelectGamesPanel.Location = new System.Drawing.Point(266, 0);
            this.SelectGamesPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SelectGamesPanel.Name = "SelectGamesPanel";
            this.SelectGamesPanel.Size = new System.Drawing.Size(1103, 701);
            this.SelectGamesPanel.TabIndex = 1;
            // 
            // SelectHomeButton
            // 
            this.SelectHomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectHomeButton.ForeColor = System.Drawing.Color.Fuchsia;
            this.SelectHomeButton.Location = new System.Drawing.Point(11, 13);
            this.SelectHomeButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SelectHomeButton.Name = "SelectHomeButton";
            this.SelectHomeButton.Size = new System.Drawing.Size(244, 33);
            this.SelectHomeButton.TabIndex = 0;
            this.SelectHomeButton.Text = "Home";
            this.SelectHomeButton.UseVisualStyleBackColor = true;
            this.SelectHomeButton.Click += new System.EventHandler(this.SelectHomeButton_Click);
            // 
            // SelectSSOButton
            // 
            this.SelectSSOButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectSSOButton.ForeColor = System.Drawing.Color.Fuchsia;
            this.SelectSSOButton.Location = new System.Drawing.Point(11, 83);
            this.SelectSSOButton.Margin = new System.Windows.Forms.Padding(4);
            this.SelectSSOButton.Name = "SelectSSOButton";
            this.SelectSSOButton.Size = new System.Drawing.Size(244, 33);
            this.SelectSSOButton.TabIndex = 1;
            this.SelectSSOButton.Text = "Star Stable Online";
            this.SelectSSOButton.UseVisualStyleBackColor = true;
            this.SelectSSOButton.Click += new System.EventHandler(this.SelectSSOButton_Click);
            // 
            // SelectAOButton
            // 
            this.SelectAOButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectAOButton.ForeColor = System.Drawing.Color.Fuchsia;
            this.SelectAOButton.Location = new System.Drawing.Point(11, 124);
            this.SelectAOButton.Margin = new System.Windows.Forms.Padding(4);
            this.SelectAOButton.Name = "SelectAOButton";
            this.SelectAOButton.Size = new System.Drawing.Size(244, 33);
            this.SelectAOButton.TabIndex = 2;
            this.SelectAOButton.Text = "Alicia Online";
            this.SelectAOButton.UseVisualStyleBackColor = true;
            this.SelectAOButton.Click += new System.EventHandler(this.SelectAOButton_Click);
            // 
            // SelectETS2Button
            // 
            this.SelectETS2Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectETS2Button.ForeColor = System.Drawing.Color.Fuchsia;
            this.SelectETS2Button.Location = new System.Drawing.Point(11, 165);
            this.SelectETS2Button.Margin = new System.Windows.Forms.Padding(4);
            this.SelectETS2Button.Name = "SelectETS2Button";
            this.SelectETS2Button.Size = new System.Drawing.Size(244, 33);
            this.SelectETS2Button.TabIndex = 3;
            this.SelectETS2Button.Text = "Euro Truck Simulator 2";
            this.SelectETS2Button.UseVisualStyleBackColor = true;
            this.SelectETS2Button.Click += new System.EventHandler(this.SelectETS2Button_Click);
            // 
            // SelectGIButton
            // 
            this.SelectGIButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectGIButton.ForeColor = System.Drawing.Color.Fuchsia;
            this.SelectGIButton.Location = new System.Drawing.Point(11, 206);
            this.SelectGIButton.Margin = new System.Windows.Forms.Padding(4);
            this.SelectGIButton.Name = "SelectGIButton";
            this.SelectGIButton.Size = new System.Drawing.Size(244, 33);
            this.SelectGIButton.TabIndex = 4;
            this.SelectGIButton.Text = "Genshin Impact";
            this.SelectGIButton.UseVisualStyleBackColor = true;
            this.SelectGIButton.Click += new System.EventHandler(this.SelectGIButton_Click);
            // 
            // SelectSettingsButton
            // 
            this.SelectSettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectSettingsButton.ForeColor = System.Drawing.Color.Fuchsia;
            this.SelectSettingsButton.Location = new System.Drawing.Point(11, 655);
            this.SelectSettingsButton.Margin = new System.Windows.Forms.Padding(4);
            this.SelectSettingsButton.Name = "SelectSettingsButton";
            this.SelectSettingsButton.Size = new System.Drawing.Size(244, 33);
            this.SelectSettingsButton.TabIndex = 5;
            this.SelectSettingsButton.Text = "Settings";
            this.SelectSettingsButton.UseVisualStyleBackColor = true;
            this.SelectSettingsButton.Click += new System.EventHandler(this.SelectSettingsButton_Click);
            // 
            // MainPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.ClientSize = new System.Drawing.Size(1369, 701);
            this.Controls.Add(this.SelectGamesPanel);
            this.Controls.Add(this.SelectButtonPanel);
            this.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "MainPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clowned Tool - Open Source";
            this.Load += new System.EventHandler(this.MainPanel_Load);
            this.SelectButtonPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SelectButtonPanel;
        private System.Windows.Forms.Panel SelectGamesPanel;
        private System.Windows.Forms.Button SelectSettingsButton;
        private System.Windows.Forms.Button SelectGIButton;
        private System.Windows.Forms.Button SelectETS2Button;
        private System.Windows.Forms.Button SelectAOButton;
        private System.Windows.Forms.Button SelectSSOButton;
        private System.Windows.Forms.Button SelectHomeButton;
    }
}

