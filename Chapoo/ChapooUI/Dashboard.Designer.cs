
namespace ChapooUI
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.MenuBarPanel = new System.Windows.Forms.Panel();
            this.BtnAfmelden = new System.Windows.Forms.Button();
            this.BtnTafelOverzicht = new System.Windows.Forms.Button();
            this.BtnBestellen = new System.Windows.Forms.Button();
            this.BtnManagement = new System.Windows.Forms.Button();
            this.BtnBarOverzicht = new System.Windows.Forms.Button();
            this.BtnAfrekenen = new System.Windows.Forms.Button();
            this.BtnDashboard = new System.Windows.Forms.Button();
            this.MenuBarAccountPanel = new System.Windows.Forms.Panel();
            this.UserFunctieLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelWelkom = new System.Windows.Forms.Label();
            this.panelOber = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listViewDone = new System.Windows.Forms.ListView();
            this.columnHeadertafel = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnaanta = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.label2 = new System.Windows.Forms.Label();
            this.PanelAfrekenOverzicht = new System.Windows.Forms.Panel();
            this.listViewPickup = new System.Windows.Forms.ListView();
            this.columnTable = new System.Windows.Forms.ColumnHeader();
            this.columnItem = new System.Windows.Forms.ColumnHeader();
            this.columnAantal = new System.Windows.Forms.ColumnHeader();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonOpgediend = new System.Windows.Forms.Button();
            this.timerOber = new System.Windows.Forms.Timer(this.components);
            this.MenuBarPanel.SuspendLayout();
            this.MenuBarAccountPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelOber.SuspendLayout();
            this.panel1.SuspendLayout();
            this.PanelAfrekenOverzicht.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuBarPanel
            // 
            this.MenuBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.MenuBarPanel.Controls.Add(this.BtnAfmelden);
            this.MenuBarPanel.Controls.Add(this.BtnTafelOverzicht);
            this.MenuBarPanel.Controls.Add(this.BtnBestellen);
            this.MenuBarPanel.Controls.Add(this.BtnManagement);
            this.MenuBarPanel.Controls.Add(this.BtnBarOverzicht);
            this.MenuBarPanel.Controls.Add(this.BtnAfrekenen);
            this.MenuBarPanel.Controls.Add(this.BtnDashboard);
            this.MenuBarPanel.Controls.Add(this.MenuBarAccountPanel);
            this.MenuBarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuBarPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuBarPanel.Name = "MenuBarPanel";
            this.MenuBarPanel.Size = new System.Drawing.Size(190, 699);
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
            this.BtnAfmelden.Location = new System.Drawing.Point(0, 444);
            this.BtnAfmelden.Name = "BtnAfmelden";
            this.BtnAfmelden.Size = new System.Drawing.Size(190, 50);
            this.BtnAfmelden.TabIndex = 9;
            this.BtnAfmelden.Text = "Afmelden";
            this.BtnAfmelden.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnAfmelden.UseVisualStyleBackColor = true;
            this.BtnAfmelden.Click += new System.EventHandler(this.BtnAfmelden_Click);
            // 
            // BtnTafelOverzicht
            // 
            this.BtnTafelOverzicht.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnTafelOverzicht.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnTafelOverzicht.FlatAppearance.BorderSize = 0;
            this.BtnTafelOverzicht.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTafelOverzicht.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnTafelOverzicht.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BtnTafelOverzicht.Image = ((System.Drawing.Image)(resources.GetObject("BtnTafelOverzicht.Image")));
            this.BtnTafelOverzicht.Location = new System.Drawing.Point(0, 394);
            this.BtnTafelOverzicht.Name = "BtnTafelOverzicht";
            this.BtnTafelOverzicht.Size = new System.Drawing.Size(190, 50);
            this.BtnTafelOverzicht.TabIndex = 8;
            this.BtnTafelOverzicht.Text = "Tafel Overzicht";
            this.BtnTafelOverzicht.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnTafelOverzicht.UseVisualStyleBackColor = true;
            this.BtnTafelOverzicht.Click += new System.EventHandler(this.BtnTafelOverzicht_Click);
            // 
            // BtnBestellen
            // 
            this.BtnBestellen.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnBestellen.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnBestellen.FlatAppearance.BorderSize = 0;
            this.BtnBestellen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBestellen.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnBestellen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BtnBestellen.Image = ((System.Drawing.Image)(resources.GetObject("BtnBestellen.Image")));
            this.BtnBestellen.Location = new System.Drawing.Point(0, 344);
            this.BtnBestellen.Name = "BtnBestellen";
            this.BtnBestellen.Size = new System.Drawing.Size(190, 50);
            this.BtnBestellen.TabIndex = 7;
            this.BtnBestellen.Text = "Besteloverzicht";
            this.BtnBestellen.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnBestellen.UseVisualStyleBackColor = true;
            this.BtnBestellen.Click += new System.EventHandler(this.BtnBestellen_Click);
            // 
            // BtnManagement
            // 
            this.BtnManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnManagement.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnManagement.FlatAppearance.BorderSize = 0;
            this.BtnManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnManagement.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnManagement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BtnManagement.Image = ((System.Drawing.Image)(resources.GetObject("BtnManagement.Image")));
            this.BtnManagement.Location = new System.Drawing.Point(0, 294);
            this.BtnManagement.Name = "BtnManagement";
            this.BtnManagement.Size = new System.Drawing.Size(190, 50);
            this.BtnManagement.TabIndex = 6;
            this.BtnManagement.Text = "Management";
            this.BtnManagement.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnManagement.UseVisualStyleBackColor = true;
            this.BtnManagement.Click += new System.EventHandler(this.BtnManagement_Click);
            // 
            // BtnBarOverzicht
            // 
            this.BtnBarOverzicht.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnBarOverzicht.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnBarOverzicht.FlatAppearance.BorderSize = 0;
            this.BtnBarOverzicht.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBarOverzicht.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnBarOverzicht.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BtnBarOverzicht.Location = new System.Drawing.Point(0, 244);
            this.BtnBarOverzicht.Name = "BtnBarOverzicht";
            this.BtnBarOverzicht.Size = new System.Drawing.Size(190, 50);
            this.BtnBarOverzicht.TabIndex = 4;
            this.BtnBarOverzicht.Text = "Bar overzicht";
            this.BtnBarOverzicht.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnBarOverzicht.UseVisualStyleBackColor = true;
            this.BtnBarOverzicht.Click += new System.EventHandler(this.BtnBarOverzicht_Click);
            // 
            // BtnAfrekenen
            // 
            this.BtnAfrekenen.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnAfrekenen.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnAfrekenen.FlatAppearance.BorderSize = 0;
            this.BtnAfrekenen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAfrekenen.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnAfrekenen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BtnAfrekenen.Image = ((System.Drawing.Image)(resources.GetObject("BtnAfrekenen.Image")));
            this.BtnAfrekenen.Location = new System.Drawing.Point(0, 194);
            this.BtnAfrekenen.Name = "BtnAfrekenen";
            this.BtnAfrekenen.Size = new System.Drawing.Size(190, 50);
            this.BtnAfrekenen.TabIndex = 2;
            this.BtnAfrekenen.Text = "Afrekenen";
            this.BtnAfrekenen.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnAfrekenen.UseVisualStyleBackColor = true;
            this.BtnAfrekenen.Click += new System.EventHandler(this.BtnAfrekenen_Click);
            // 
            // BtnDashboard
            // 
            this.BtnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnDashboard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnDashboard.FlatAppearance.BorderSize = 0;
            this.BtnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDashboard.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BtnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("BtnDashboard.Image")));
            this.BtnDashboard.Location = new System.Drawing.Point(0, 144);
            this.BtnDashboard.Name = "BtnDashboard";
            this.BtnDashboard.Size = new System.Drawing.Size(190, 50);
            this.BtnDashboard.TabIndex = 1;
            this.BtnDashboard.Text = "Dashboard";
            this.BtnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnDashboard.UseVisualStyleBackColor = true;
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
            this.UserFunctieLabel.TabIndex = 2;
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
            this.UsernameLabel.TabIndex = 1;
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
            // labelWelkom
            // 
            this.labelWelkom.AutoSize = true;
            this.labelWelkom.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelWelkom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.labelWelkom.Location = new System.Drawing.Point(224, 25);
            this.labelWelkom.Name = "labelWelkom";
            this.labelWelkom.Size = new System.Drawing.Size(203, 55);
            this.labelWelkom.TabIndex = 8;
            this.labelWelkom.Text = "Welkom";
            // 
            // panelOber
            // 
            this.panelOber.Controls.Add(this.panel1);
            this.panelOber.Controls.Add(this.PanelAfrekenOverzicht);
            this.panelOber.Controls.Add(this.buttonOpgediend);
            this.panelOber.Location = new System.Drawing.Point(224, 90);
            this.panelOber.Name = "panelOber";
            this.panelOber.Size = new System.Drawing.Size(1172, 597);
            this.panelOber.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.listViewDone);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(629, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 605);
            this.panel1.TabIndex = 13;
            // 
            // listViewDone
            // 
            this.listViewDone.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeadertafel,
            this.columnHeader2,
            this.columnaanta,
            this.columnHeader3});
            this.listViewDone.FullRowSelect = true;
            this.listViewDone.GridLines = true;
            this.listViewDone.HideSelection = false;
            this.listViewDone.Location = new System.Drawing.Point(12, 50);
            this.listViewDone.MultiSelect = false;
            this.listViewDone.Name = "listViewDone";
            this.listViewDone.Size = new System.Drawing.Size(476, 532);
            this.listViewDone.TabIndex = 1;
            this.listViewDone.UseCompatibleStateImageBehavior = false;
            this.listViewDone.View = System.Windows.Forms.View.Details;
            // 
            // columnHeadertafel
            // 
            this.columnHeadertafel.Text = "Tafel";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Gerecht/Drank";
            this.columnHeader2.Width = 220;
            // 
            // columnaanta
            // 
            this.columnaanta.Text = "Aantal";
            this.columnaanta.Width = 50;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Datum/Tijd";
            this.columnHeader3.Width = 140;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 31);
            this.label2.TabIndex = 11;
            this.label2.Text = "Opgediend";
            // 
            // PanelAfrekenOverzicht
            // 
            this.PanelAfrekenOverzicht.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.PanelAfrekenOverzicht.Controls.Add(this.listViewPickup);
            this.PanelAfrekenOverzicht.Controls.Add(this.label1);
            this.PanelAfrekenOverzicht.Location = new System.Drawing.Point(3, 4);
            this.PanelAfrekenOverzicht.Name = "PanelAfrekenOverzicht";
            this.PanelAfrekenOverzicht.Size = new System.Drawing.Size(501, 593);
            this.PanelAfrekenOverzicht.TabIndex = 12;
            // 
            // listViewPickup
            // 
            this.listViewPickup.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnTable,
            this.columnItem,
            this.columnAantal});
            this.listViewPickup.FullRowSelect = true;
            this.listViewPickup.GridLines = true;
            this.listViewPickup.HideSelection = false;
            this.listViewPickup.Location = new System.Drawing.Point(12, 49);
            this.listViewPickup.MultiSelect = false;
            this.listViewPickup.Name = "listViewPickup";
            this.listViewPickup.Size = new System.Drawing.Size(476, 532);
            this.listViewPickup.TabIndex = 0;
            this.listViewPickup.UseCompatibleStateImageBehavior = false;
            this.listViewPickup.View = System.Windows.Forms.View.Details;
            this.listViewPickup.SelectedIndexChanged += new System.EventHandler(this.listViewPickup_SelectedIndexChanged);
            // 
            // columnTable
            // 
            this.columnTable.Text = "Tafel";
            this.columnTable.Width = 50;
            // 
            // columnItem
            // 
            this.columnItem.Text = "Gerecht/Drank";
            this.columnItem.Width = 370;
            // 
            // columnAantal
            // 
            this.columnAantal.Text = "Aantal";
            this.columnAantal.Width = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "Klaar voor afhalen";
            // 
            // buttonOpgediend
            // 
            this.buttonOpgediend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.buttonOpgediend.FlatAppearance.BorderSize = 0;
            this.buttonOpgediend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpgediend.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonOpgediend.ForeColor = System.Drawing.Color.White;
            this.buttonOpgediend.Location = new System.Drawing.Point(510, 254);
            this.buttonOpgediend.Name = "buttonOpgediend";
            this.buttonOpgediend.Size = new System.Drawing.Size(113, 81);
            this.buttonOpgediend.TabIndex = 2;
            this.buttonOpgediend.Text = "Opgediend";
            this.buttonOpgediend.UseVisualStyleBackColor = false;
            this.buttonOpgediend.Click += new System.EventHandler(this.buttonOpgediend_Click);
            // 
            // timerOber
            // 
            this.timerOber.Enabled = true;
            this.timerOber.Interval = 20000;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1399, 699);
            this.Controls.Add(this.panelOber);
            this.Controls.Add(this.labelWelkom);
            this.Controls.Add(this.MenuBarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chapoo Dashboard";
            this.MenuBarPanel.ResumeLayout(false);
            this.MenuBarAccountPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelOber.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PanelAfrekenOverzicht.ResumeLayout(false);
            this.PanelAfrekenOverzicht.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel MenuBarPanel;
        private System.Windows.Forms.Panel MenuBarAccountPanel;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label UserFunctieLabel;
        private System.Windows.Forms.Button BtnDashboard;
        private System.Windows.Forms.Button BtnBarOverzicht;
        private System.Windows.Forms.Button BtnAfrekenen;
        private System.Windows.Forms.Button BtnManagement;
        private System.Windows.Forms.Button BtnBestellen;
        private System.Windows.Forms.Button BtnTafelOverzicht;
        private System.Windows.Forms.Button BtnAfmelden;
        private System.Windows.Forms.Label labelWelkom;
        private System.Windows.Forms.Panel panelOber;
        private System.Windows.Forms.Button buttonOpgediend;
        private System.Windows.Forms.ListView listViewDone;
        private System.Windows.Forms.ColumnHeader columnHeadertafel;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnaanta;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView listViewPickup;
        private System.Windows.Forms.ColumnHeader columnTable;
        private System.Windows.Forms.ColumnHeader columnItem;
        private System.Windows.Forms.ColumnHeader columnAantal;
        private System.Windows.Forms.Timer timerOber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PanelAfrekenOverzicht;
    }
}

