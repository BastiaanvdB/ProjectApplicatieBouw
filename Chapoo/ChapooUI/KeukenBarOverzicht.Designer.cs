
namespace ChapooUI
{
    partial class KeukenBarOverzicht
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KeukenBarOverzicht));
            this.MenuBarPanel = new System.Windows.Forms.Panel();
            this.BtnAfmelden = new System.Windows.Forms.Button();
            this.MenuBarAccountPanel = new System.Windows.Forms.Panel();
            this.UserFunctieLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelAfrekenOverzicht = new System.Windows.Forms.Panel();
            this.listViewNewOrders = new System.Windows.Forms.ListView();
            this.TafelHeader = new System.Windows.Forms.ColumnHeader();
            this.ItemHeader = new System.Windows.Forms.ColumnHeader();
            this.headerhoeveelheidKeuken = new System.Windows.Forms.ColumnHeader();
            this.headeropmerking = new System.Windows.Forms.ColumnHeader();
            this.Headertijdvanbestellingkeuken = new System.Windows.Forms.ColumnHeader();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.lbloverzicht = new System.Windows.Forms.Label();
            this.BtnGereed = new System.Windows.Forms.Button();
            this.timerBar = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.MenuBarPanel.Controls.Add(this.BtnAfmelden);
            this.MenuBarPanel.Controls.Add(this.MenuBarAccountPanel);
            this.MenuBarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuBarPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuBarPanel.Name = "MenuBarPanel";
            this.MenuBarPanel.Size = new System.Drawing.Size(190, 806);
            this.MenuBarPanel.TabIndex = 0;
            // 
            // BtnAfmelden
            // 
            this.BtnAfmelden.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnAfmelden.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnAfmelden.FlatAppearance.BorderSize = 0;
            this.BtnAfmelden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAfmelden.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnAfmelden.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BtnAfmelden.Image = ((System.Drawing.Image)(resources.GetObject("BtnAfmelden.Image")));
            this.BtnAfmelden.Location = new System.Drawing.Point(0, 144);
            this.BtnAfmelden.Name = "BtnAfmelden";
            this.BtnAfmelden.Size = new System.Drawing.Size(190, 50);
            this.BtnAfmelden.TabIndex = 7;
            this.BtnAfmelden.Text = "Terug";
            this.BtnAfmelden.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnAfmelden.UseVisualStyleBackColor = true;
            this.BtnAfmelden.Click += new System.EventHandler(this.BtnAfmelden_Click);
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
            this.UserFunctieLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UserFunctieLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            this.UserFunctieLabel.Location = new System.Drawing.Point(3, 111);
            this.UserFunctieLabel.Name = "UserFunctieLabel";
            this.UserFunctieLabel.Size = new System.Drawing.Size(184, 14);
            this.UserFunctieLabel.TabIndex = 4;
            this.UserFunctieLabel.Text = "Functie";
            this.UserFunctieLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UsernameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.UsernameLabel.Location = new System.Drawing.Point(0, 90);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(187, 21);
            this.UsernameLabel.TabIndex = 3;
            this.UsernameLabel.Text = "Username";
            this.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // PanelAfrekenOverzicht
            // 
            this.PanelAfrekenOverzicht.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.PanelAfrekenOverzicht.Controls.Add(this.listViewNewOrders);
            this.PanelAfrekenOverzicht.Controls.Add(this.label2);
            this.PanelAfrekenOverzicht.Location = new System.Drawing.Point(212, 54);
            this.PanelAfrekenOverzicht.Name = "PanelAfrekenOverzicht";
            this.PanelAfrekenOverzicht.Size = new System.Drawing.Size(1197, 730);
            this.PanelAfrekenOverzicht.TabIndex = 10;
            // 
            // listViewNewOrders
            // 
            this.listViewNewOrders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TafelHeader,
            this.ItemHeader,
            this.headerhoeveelheidKeuken,
            this.headeropmerking,
            this.Headertijdvanbestellingkeuken});
            this.listViewNewOrders.FullRowSelect = true;
            this.listViewNewOrders.GridLines = true;
            this.listViewNewOrders.HideSelection = false;
            this.listViewNewOrders.Location = new System.Drawing.Point(35, 57);
            this.listViewNewOrders.Name = "listViewNewOrders";
            this.listViewNewOrders.Size = new System.Drawing.Size(1132, 643);
            this.listViewNewOrders.TabIndex = 0;
            this.listViewNewOrders.UseCompatibleStateImageBehavior = false;
            this.listViewNewOrders.View = System.Windows.Forms.View.Details;
            this.listViewNewOrders.SelectedIndexChanged += new System.EventHandler(this.listViewNewOrders_SelectedIndexChanged);
            // 
            // TafelHeader
            // 
            this.TafelHeader.Text = "Tafelnummer";
            this.TafelHeader.Width = 100;
            // 
            // ItemHeader
            // 
            this.ItemHeader.Text = "Bestelde gerecht";
            this.ItemHeader.Width = 380;
            // 
            // headerhoeveelheidKeuken
            // 
            this.headerhoeveelheidKeuken.Text = "Aantal";
            // 
            // headeropmerking
            // 
            this.headeropmerking.Text = "Opmerking";
            this.headeropmerking.Width = 380;
            // 
            // Headertijdvanbestellingkeuken
            // 
            this.Headertijdvanbestellingkeuken.Text = "Tijd van bestelling";
            this.Headertijdvanbestellingkeuken.Width = 205;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(888, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(279, 37);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nieuwe bestellingen";
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BtnUpdate.FlatAppearance.BorderSize = 0;
            this.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnUpdate.ForeColor = System.Drawing.Color.White;
            this.BtnUpdate.Location = new System.Drawing.Point(35, 46);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(197, 55);
            this.BtnUpdate.TabIndex = 4;
            this.BtnUpdate.Text = "Ververs lijst";
            this.BtnUpdate.UseVisualStyleBackColor = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // lbloverzicht
            // 
            this.lbloverzicht.AutoSize = true;
            this.lbloverzicht.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbloverzicht.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lbloverzicht.Location = new System.Drawing.Point(212, 14);
            this.lbloverzicht.Name = "lbloverzicht";
            this.lbloverzicht.Size = new System.Drawing.Size(231, 37);
            this.lbloverzicht.TabIndex = 3;
            this.lbloverzicht.Text = "Keukenoverzicht";
            // 
            // BtnGereed
            // 
            this.BtnGereed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnGereed.FlatAppearance.BorderSize = 0;
            this.BtnGereed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGereed.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnGereed.ForeColor = System.Drawing.Color.White;
            this.BtnGereed.Location = new System.Drawing.Point(35, 142);
            this.BtnGereed.Name = "BtnGereed";
            this.BtnGereed.Size = new System.Drawing.Size(197, 61);
            this.BtnGereed.TabIndex = 2;
            this.BtnGereed.Text = "Gereed";
            this.BtnGereed.UseVisualStyleBackColor = false;
            this.BtnGereed.Click += new System.EventHandler(this.BtnGereed_Click);
            // 
            // timerBar
            // 
            this.timerBar.Enabled = true;
            this.timerBar.Interval = 20000;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.BtnGereed);
            this.panel1.Controls.Add(this.BtnUpdate);
            this.panel1.Location = new System.Drawing.Point(1436, 162);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 248);
            this.panel1.TabIndex = 11;
            // 
            // KeukenBarOverzicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1715, 806);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelAfrekenOverzicht);
            this.Controls.Add(this.MenuBarPanel);
            this.Controls.Add(this.lbloverzicht);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KeukenBarOverzicht";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chapoo Bar overzicht";
            this.MenuBarPanel.ResumeLayout(false);
            this.MenuBarAccountPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PanelAfrekenOverzicht.ResumeLayout(false);
            this.PanelAfrekenOverzicht.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel MenuBarPanel;
        private System.Windows.Forms.Panel MenuBarAccountPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnAfmelden;
        private System.Windows.Forms.ColumnHeader ItemID;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Label lbloverzicht;
        private System.Windows.Forms.Button BtnGereed;
        private System.Windows.Forms.ListView listViewNewOrders;
        private System.Windows.Forms.ColumnHeader TafelHeader;
        private System.Windows.Forms.ColumnHeader ItemHeader;
        private System.Windows.Forms.ColumnHeader headerhoeveelheidKeuken;
        private System.Windows.Forms.ColumnHeader headeropmerking;
        private System.Windows.Forms.ColumnHeader Headertijdvanbestellingkeuken;
        private System.Windows.Forms.Timer timerBar;
        private System.Windows.Forms.Label UserFunctieLabel;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel PanelAfrekenOverzicht;
        private System.Windows.Forms.Panel panel1;
    }
}

