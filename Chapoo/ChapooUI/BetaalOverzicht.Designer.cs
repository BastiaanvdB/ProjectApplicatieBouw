
namespace ChapooUI
{
    partial class BetaalOverzicht
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BetaalOverzicht));
            this.MenuBarPanel = new System.Windows.Forms.Panel();
            this.BtnTerug = new System.Windows.Forms.Button();
            this.MenuBarAccountPanel = new System.Windows.Forms.Panel();
            this.UserFunctieLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AfrekeninglistView = new System.Windows.Forms.ListView();
            this.TafelHeader = new System.Windows.Forms.ColumnHeader();
            this.BestelnummerHeader = new System.Windows.Forms.ColumnHeader();
            this.TotaalprijsHeader = new System.Windows.Forms.ColumnHeader();
            this.BetaalstatusHeader = new System.Windows.Forms.ColumnHeader();
            this.PanelAfrekenOverzicht = new System.Windows.Forms.Panel();
            this.labelOpenStaandeRekening = new System.Windows.Forms.Label();
            this.labelAfrekenen = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AfrekenenButton = new System.Windows.Forms.Button();
            this.MenuBarPanel.SuspendLayout();
            this.MenuBarAccountPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PanelAfrekenOverzicht.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuBarPanel
            // 
            this.MenuBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.MenuBarPanel.Controls.Add(this.BtnTerug);
            this.MenuBarPanel.Controls.Add(this.MenuBarAccountPanel);
            this.MenuBarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuBarPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuBarPanel.Name = "MenuBarPanel";
            this.MenuBarPanel.Size = new System.Drawing.Size(190, 765);
            this.MenuBarPanel.TabIndex = 1;
            // 
            // BtnTerug
            // 
            this.BtnTerug.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnTerug.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnTerug.FlatAppearance.BorderSize = 0;
            this.BtnTerug.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTerug.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnTerug.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BtnTerug.Image = ((System.Drawing.Image)(resources.GetObject("BtnTerug.Image")));
            this.BtnTerug.Location = new System.Drawing.Point(0, 144);
            this.BtnTerug.Name = "BtnTerug";
            this.BtnTerug.Size = new System.Drawing.Size(190, 50);
            this.BtnTerug.TabIndex = 4;
            this.BtnTerug.Text = "Terug";
            this.BtnTerug.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnTerug.UseVisualStyleBackColor = true;
            this.BtnTerug.Click += new System.EventHandler(this.BtnTerug_Click);
            // 
            // MenuBarAccountPanel
            // 
            this.MenuBarAccountPanel.Controls.Add(this.UserFunctieLabel);
            this.MenuBarAccountPanel.Controls.Add(this.UsernameLabel);
            this.MenuBarAccountPanel.Controls.Add(this.pictureBox1);
            this.MenuBarAccountPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuBarAccountPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuBarAccountPanel.Name = "MenuBarAccountPanel";
            this.MenuBarAccountPanel.Size = new System.Drawing.Size(190, 144);
            this.MenuBarAccountPanel.TabIndex = 0;
            // 
            // UserFunctieLabel
            // 
            this.UserFunctieLabel.AutoSize = true;
            this.UserFunctieLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UserFunctieLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            this.UserFunctieLabel.Location = new System.Drawing.Point(66, 111);
            this.UserFunctieLabel.Name = "UserFunctieLabel";
            this.UserFunctieLabel.Size = new System.Drawing.Size(48, 17);
            this.UserFunctieLabel.TabIndex = 2;
            this.UserFunctieLabel.Text = "Functie";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UsernameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.UsernameLabel.Location = new System.Drawing.Point(54, 90);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(81, 21);
            this.UsernameLabel.TabIndex = 1;
            this.UsernameLabel.Text = "Username";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(54, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // AfrekeninglistView
            // 
            this.AfrekeninglistView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AfrekeninglistView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TafelHeader,
            this.BestelnummerHeader,
            this.TotaalprijsHeader,
            this.BetaalstatusHeader});
            this.AfrekeninglistView.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AfrekeninglistView.FullRowSelect = true;
            this.AfrekeninglistView.GridLines = true;
            this.AfrekeninglistView.HideSelection = false;
            this.AfrekeninglistView.Location = new System.Drawing.Point(41, 42);
            this.AfrekeninglistView.MultiSelect = false;
            this.AfrekeninglistView.Name = "AfrekeninglistView";
            this.AfrekeninglistView.Size = new System.Drawing.Size(494, 516);
            this.AfrekeninglistView.TabIndex = 2;
            this.AfrekeninglistView.UseCompatibleStateImageBehavior = false;
            this.AfrekeninglistView.View = System.Windows.Forms.View.Details;
            // 
            // TafelHeader
            // 
            this.TafelHeader.Text = "Tafelnummer";
            this.TafelHeader.Width = 130;
            // 
            // BestelnummerHeader
            // 
            this.BestelnummerHeader.Text = "Bestelnummer";
            this.BestelnummerHeader.Width = 140;
            // 
            // TotaalprijsHeader
            // 
            this.TotaalprijsHeader.Text = "Totaalprijs";
            this.TotaalprijsHeader.Width = 100;
            // 
            // BetaalstatusHeader
            // 
            this.BetaalstatusHeader.Text = "Betaalstatus";
            this.BetaalstatusHeader.Width = 120;
            // 
            // PanelAfrekenOverzicht
            // 
            this.PanelAfrekenOverzicht.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.PanelAfrekenOverzicht.Controls.Add(this.labelOpenStaandeRekening);
            this.PanelAfrekenOverzicht.Controls.Add(this.AfrekeninglistView);
            this.PanelAfrekenOverzicht.Location = new System.Drawing.Point(228, 70);
            this.PanelAfrekenOverzicht.Name = "PanelAfrekenOverzicht";
            this.PanelAfrekenOverzicht.Size = new System.Drawing.Size(571, 593);
            this.PanelAfrekenOverzicht.TabIndex = 3;
            // 
            // labelOpenStaandeRekening
            // 
            this.labelOpenStaandeRekening.AutoSize = true;
            this.labelOpenStaandeRekening.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelOpenStaandeRekening.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.labelOpenStaandeRekening.Location = new System.Drawing.Point(41, 9);
            this.labelOpenStaandeRekening.Name = "labelOpenStaandeRekening";
            this.labelOpenStaandeRekening.Size = new System.Drawing.Size(202, 21);
            this.labelOpenStaandeRekening.TabIndex = 3;
            this.labelOpenStaandeRekening.Text = "Openstaande rekeningen";
            // 
            // labelAfrekenen
            // 
            this.labelAfrekenen.AutoSize = true;
            this.labelAfrekenen.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAfrekenen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.labelAfrekenen.Location = new System.Drawing.Point(228, 12);
            this.labelAfrekenen.Name = "labelAfrekenen";
            this.labelAfrekenen.Size = new System.Drawing.Size(175, 38);
            this.labelAfrekenen.TabIndex = 4;
            this.labelAfrekenen.Text = "Afrekenen";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.AfrekenenButton);
            this.panel1.Location = new System.Drawing.Point(829, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(530, 593);
            this.panel1.TabIndex = 4;
            // 
            // AfrekenenButton
            // 
            this.AfrekenenButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.AfrekenenButton.FlatAppearance.BorderSize = 0;
            this.AfrekenenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AfrekenenButton.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AfrekenenButton.ForeColor = System.Drawing.Color.White;
            this.AfrekenenButton.Location = new System.Drawing.Point(359, 523);
            this.AfrekenenButton.Name = "AfrekenenButton";
            this.AfrekenenButton.Size = new System.Drawing.Size(125, 35);
            this.AfrekenenButton.TabIndex = 0;
            this.AfrekenenButton.Text = "Afrekenen";
            this.AfrekenenButton.UseVisualStyleBackColor = false;
            // 
            // BetaalOverzicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1412, 765);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelAfrekenen);
            this.Controls.Add(this.PanelAfrekenOverzicht);
            this.Controls.Add(this.MenuBarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BetaalOverzicht";
            this.Text = "Chapoo Betaaloverzicht";
            this.MenuBarPanel.ResumeLayout(false);
            this.MenuBarAccountPanel.ResumeLayout(false);
            this.MenuBarAccountPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PanelAfrekenOverzicht.ResumeLayout(false);
            this.PanelAfrekenOverzicht.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel MenuBarPanel;
        private System.Windows.Forms.Button BtnTerug;
        private System.Windows.Forms.ListView AfrekeninglistView;
        private System.Windows.Forms.Panel MenuBarAccountPanel;
        private System.Windows.Forms.Label UserFunctieLabel;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ColumnHeader TafelHeader;
        private System.Windows.Forms.ColumnHeader BestelnummerHeader;
        private System.Windows.Forms.ColumnHeader TotaalprijsHeader;
        private System.Windows.Forms.ColumnHeader BetaalstatusHeader;
        private System.Windows.Forms.Panel PanelAfrekenOverzicht;
        private System.Windows.Forms.Label labelAfrekenen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button AfrekenenButton;
        private System.Windows.Forms.Label labelOpenStaandeRekening;
    }
}