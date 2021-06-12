
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KeukenBarOverzicht));
            this.MenuBarPanel = new System.Windows.Forms.Panel();
            this.BtnAfmelden = new System.Windows.Forms.Button();
            this.MenuBarAccountPanel = new System.Windows.Forms.Panel();
            this.UserFunctieLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnl_Baroverzicht = new System.Windows.Forms.Panel();
            this.Btn_update_bar = new System.Windows.Forms.Button();
            this.lbl_Baroverzicht = new System.Windows.Forms.Label();
            this.btn_Gereed = new System.Windows.Forms.Button();
            this.Listview_Order_finished = new System.Windows.Forms.ListView();
            this.TafelnrHeader = new System.Windows.Forms.ColumnHeader();
            this.Bestellingheader = new System.Windows.Forms.ColumnHeader();
            this.Headerhoeveelheid = new System.Windows.Forms.ColumnHeader();
            this.Statusheader = new System.Windows.Forms.ColumnHeader();
            this.HeaderTijdOpgediend = new System.Windows.Forms.ColumnHeader();
            this.Listview_Bar_OpenOrder = new System.Windows.Forms.ListView();
            this.TafelnummerHeader = new System.Windows.Forms.ColumnHeader();
            this.Drankheader = new System.Windows.Forms.ColumnHeader();
            this.hoeveelheidheader = new System.Windows.Forms.ColumnHeader();
            this.HeaderStatus = new System.Windows.Forms.ColumnHeader();
            this.HeaderTijdBesteld = new System.Windows.Forms.ColumnHeader();
            this.Pnl_keukenoverzicht = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.RBtn_Diner = new System.Windows.Forms.RadioButton();
            this.RBtn_Lunch = new System.Windows.Forms.RadioButton();
            this.Btn_Update_keuken = new System.Windows.Forms.Button();
            this.lblKeukenoverzicht = new System.Windows.Forms.Label();
            this.Btn_Keuken_gereed = new System.Windows.Forms.Button();
            this.listView_keuken_Opgediend = new System.Windows.Forms.ListView();
            this.Headerfinshed = new System.Windows.Forms.ColumnHeader();
            this.HeaderFinItem = new System.Windows.Forms.ColumnHeader();
            this.headerfinhoeveelheid = new System.Windows.Forms.ColumnHeader();
            this.headerfinstatus = new System.Windows.Forms.ColumnHeader();
            this.fintijdvanopdieningheader = new System.Windows.Forms.ColumnHeader();
            this.listView_Keuken_besteld = new System.Windows.Forms.ListView();
            this.TafelHeader = new System.Windows.Forms.ColumnHeader();
            this.ItemHeader = new System.Windows.Forms.ColumnHeader();
            this.headerhoeveelheidKeuken = new System.Windows.Forms.ColumnHeader();
            this.headerstatuskeuken = new System.Windows.Forms.ColumnHeader();
            this.Headertijdvanbestellingkeuken = new System.Windows.Forms.ColumnHeader();
            this.MenuBarPanel.SuspendLayout();
            this.MenuBarAccountPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnl_Baroverzicht.SuspendLayout();
            this.Pnl_keukenoverzicht.SuspendLayout();
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
            this.MenuBarPanel.Size = new System.Drawing.Size(190, 839);
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
            // pnl_Baroverzicht
            // 
            this.pnl_Baroverzicht.Controls.Add(this.Btn_update_bar);
            this.pnl_Baroverzicht.Controls.Add(this.lbl_Baroverzicht);
            this.pnl_Baroverzicht.Controls.Add(this.btn_Gereed);
            this.pnl_Baroverzicht.Controls.Add(this.Listview_Order_finished);
            this.pnl_Baroverzicht.Controls.Add(this.Listview_Bar_OpenOrder);
            this.pnl_Baroverzicht.Location = new System.Drawing.Point(248, 44);
            this.pnl_Baroverzicht.Name = "pnl_Baroverzicht";
            this.pnl_Baroverzicht.Size = new System.Drawing.Size(1434, 731);
            this.pnl_Baroverzicht.TabIndex = 1;
            // 
            // Btn_update_bar
            // 
            this.Btn_update_bar.Location = new System.Drawing.Point(645, 67);
            this.Btn_update_bar.Name = "Btn_update_bar";
            this.Btn_update_bar.Size = new System.Drawing.Size(168, 55);
            this.Btn_update_bar.TabIndex = 4;
            this.Btn_update_bar.Text = "Update";
            this.Btn_update_bar.UseVisualStyleBackColor = true;
            this.Btn_update_bar.Click += new System.EventHandler(this.Btn_update_bar_Click);
            // 
            // lbl_Baroverzicht
            // 
            this.lbl_Baroverzicht.AutoSize = true;
            this.lbl_Baroverzicht.Font = new System.Drawing.Font("Nirmala UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Baroverzicht.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lbl_Baroverzicht.Location = new System.Drawing.Point(40, 28);
            this.lbl_Baroverzicht.Name = "lbl_Baroverzicht";
            this.lbl_Baroverzicht.Size = new System.Drawing.Size(132, 28);
            this.lbl_Baroverzicht.TabIndex = 3;
            this.lbl_Baroverzicht.Text = "Baroverzicht";
            // 
            // btn_Gereed
            // 
            this.btn_Gereed.Location = new System.Drawing.Point(645, 317);
            this.btn_Gereed.Name = "btn_Gereed";
            this.btn_Gereed.Size = new System.Drawing.Size(168, 55);
            this.btn_Gereed.TabIndex = 2;
            this.btn_Gereed.Text = "Gereed";
            this.btn_Gereed.UseVisualStyleBackColor = true;
            this.btn_Gereed.Click += new System.EventHandler(this.btn_Gereed_Click);
            // 
            // Listview_Order_finished
            // 
            this.Listview_Order_finished.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TafelnrHeader,
            this.Bestellingheader,
            this.Headerhoeveelheid,
            this.Statusheader,
            this.HeaderTijdOpgediend});
            this.Listview_Order_finished.GridLines = true;
            this.Listview_Order_finished.HideSelection = false;
            this.Listview_Order_finished.Location = new System.Drawing.Point(846, 67);
            this.Listview_Order_finished.Name = "Listview_Order_finished";
            this.Listview_Order_finished.Size = new System.Drawing.Size(568, 643);
            this.Listview_Order_finished.TabIndex = 1;
            this.Listview_Order_finished.UseCompatibleStateImageBehavior = false;
            this.Listview_Order_finished.View = System.Windows.Forms.View.Details;
            // 
            // TafelnrHeader
            // 
            this.TafelnrHeader.Text = "Tafelnummer";
            this.TafelnrHeader.Width = 100;
            // 
            // Bestellingheader
            // 
            this.Bestellingheader.Text = "Bestelde drank";
            this.Bestellingheader.Width = 150;
            // 
            // Headerhoeveelheid
            // 
            this.Headerhoeveelheid.Text = "Hoeveelheid";
            this.Headerhoeveelheid.Width = 100;
            // 
            // Statusheader
            // 
            this.Statusheader.Text = "Status";
            this.Statusheader.Width = 75;
            // 
            // HeaderTijdOpgediend
            // 
            this.HeaderTijdOpgediend.Text = "Tijd van opdiening";
            this.HeaderTijdOpgediend.Width = 150;
            // 
            // Listview_Bar_OpenOrder
            // 
            this.Listview_Bar_OpenOrder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TafelnummerHeader,
            this.Drankheader,
            this.hoeveelheidheader,
            this.HeaderStatus,
            this.HeaderTijdBesteld});
            this.Listview_Bar_OpenOrder.FullRowSelect = true;
            this.Listview_Bar_OpenOrder.GridLines = true;
            this.Listview_Bar_OpenOrder.HideSelection = false;
            this.Listview_Bar_OpenOrder.Location = new System.Drawing.Point(40, 67);
            this.Listview_Bar_OpenOrder.Name = "Listview_Bar_OpenOrder";
            this.Listview_Bar_OpenOrder.Size = new System.Drawing.Size(568, 643);
            this.Listview_Bar_OpenOrder.TabIndex = 0;
            this.Listview_Bar_OpenOrder.UseCompatibleStateImageBehavior = false;
            this.Listview_Bar_OpenOrder.View = System.Windows.Forms.View.Details;
            this.Listview_Bar_OpenOrder.SelectedIndexChanged += new System.EventHandler(this.Listview_Bar_OpenOrder_SelectedIndexChanged);
            // 
            // TafelnummerHeader
            // 
            this.TafelnummerHeader.Text = "Tafelnummer";
            this.TafelnummerHeader.Width = 100;
            // 
            // Drankheader
            // 
            this.Drankheader.Text = "Bestelde drank";
            this.Drankheader.Width = 150;
            // 
            // hoeveelheidheader
            // 
            this.hoeveelheidheader.Text = "Hoeveelheid";
            this.hoeveelheidheader.Width = 100;
            // 
            // HeaderStatus
            // 
            this.HeaderStatus.Text = "Status";
            this.HeaderStatus.Width = 70;
            // 
            // HeaderTijdBesteld
            // 
            this.HeaderTijdBesteld.Text = "Tijd van bestelling";
            this.HeaderTijdBesteld.Width = 150;
            // 
            // Pnl_keukenoverzicht
            // 
            this.Pnl_keukenoverzicht.Controls.Add(this.label1);
            this.Pnl_keukenoverzicht.Controls.Add(this.RBtn_Diner);
            this.Pnl_keukenoverzicht.Controls.Add(this.RBtn_Lunch);
            this.Pnl_keukenoverzicht.Controls.Add(this.Btn_Update_keuken);
            this.Pnl_keukenoverzicht.Controls.Add(this.lblKeukenoverzicht);
            this.Pnl_keukenoverzicht.Controls.Add(this.Btn_Keuken_gereed);
            this.Pnl_keukenoverzicht.Controls.Add(this.listView_keuken_Opgediend);
            this.Pnl_keukenoverzicht.Controls.Add(this.listView_Keuken_besteld);
            this.Pnl_keukenoverzicht.Location = new System.Drawing.Point(222, 44);
            this.Pnl_keukenoverzicht.Name = "Pnl_keukenoverzicht";
            this.Pnl_keukenoverzicht.Size = new System.Drawing.Size(1431, 728);
            this.Pnl_keukenoverzicht.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(645, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "Selecteer menu";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // RBtn_Diner
            // 
            this.RBtn_Diner.AutoSize = true;
            this.RBtn_Diner.Font = new System.Drawing.Font("Nirmala UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RBtn_Diner.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.RBtn_Diner.Location = new System.Drawing.Point(645, 324);
            this.RBtn_Diner.Name = "RBtn_Diner";
            this.RBtn_Diner.Size = new System.Drawing.Size(82, 32);
            this.RBtn_Diner.TabIndex = 6;
            this.RBtn_Diner.TabStop = true;
            this.RBtn_Diner.Text = "Diner";
            this.RBtn_Diner.UseVisualStyleBackColor = true;
            // 
            // RBtn_Lunch
            // 
            this.RBtn_Lunch.AutoSize = true;
            this.RBtn_Lunch.Font = new System.Drawing.Font("Nirmala UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RBtn_Lunch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.RBtn_Lunch.Location = new System.Drawing.Point(645, 279);
            this.RBtn_Lunch.Name = "RBtn_Lunch";
            this.RBtn_Lunch.Size = new System.Drawing.Size(86, 32);
            this.RBtn_Lunch.TabIndex = 5;
            this.RBtn_Lunch.TabStop = true;
            this.RBtn_Lunch.Text = "Lunch";
            this.RBtn_Lunch.UseVisualStyleBackColor = true;
            // 
            // Btn_Update_keuken
            // 
            this.Btn_Update_keuken.Location = new System.Drawing.Point(645, 67);
            this.Btn_Update_keuken.Name = "Btn_Update_keuken";
            this.Btn_Update_keuken.Size = new System.Drawing.Size(168, 55);
            this.Btn_Update_keuken.TabIndex = 4;
            this.Btn_Update_keuken.Text = "Update";
            this.Btn_Update_keuken.UseVisualStyleBackColor = true;
            this.Btn_Update_keuken.Click += new System.EventHandler(this.Btn_Update_keuken_Click);
            // 
            // lblKeukenoverzicht
            // 
            this.lblKeukenoverzicht.AutoSize = true;
            this.lblKeukenoverzicht.Font = new System.Drawing.Font("Nirmala UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblKeukenoverzicht.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblKeukenoverzicht.Location = new System.Drawing.Point(40, 28);
            this.lblKeukenoverzicht.Name = "lblKeukenoverzicht";
            this.lblKeukenoverzicht.Size = new System.Drawing.Size(170, 28);
            this.lblKeukenoverzicht.TabIndex = 3;
            this.lblKeukenoverzicht.Text = "Keukenoverzicht";
            // 
            // Btn_Keuken_gereed
            // 
            this.Btn_Keuken_gereed.Location = new System.Drawing.Point(645, 472);
            this.Btn_Keuken_gereed.Name = "Btn_Keuken_gereed";
            this.Btn_Keuken_gereed.Size = new System.Drawing.Size(168, 55);
            this.Btn_Keuken_gereed.TabIndex = 2;
            this.Btn_Keuken_gereed.Text = "Gereed";
            this.Btn_Keuken_gereed.UseVisualStyleBackColor = true;
            this.Btn_Keuken_gereed.Click += new System.EventHandler(this.Btn_Keuken_gereed_Click);
            // 
            // listView_keuken_Opgediend
            // 
            this.listView_keuken_Opgediend.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Headerfinshed,
            this.HeaderFinItem,
            this.headerfinhoeveelheid,
            this.headerfinstatus,
            this.fintijdvanopdieningheader});
            this.listView_keuken_Opgediend.GridLines = true;
            this.listView_keuken_Opgediend.HideSelection = false;
            this.listView_keuken_Opgediend.Location = new System.Drawing.Point(846, 67);
            this.listView_keuken_Opgediend.Name = "listView_keuken_Opgediend";
            this.listView_keuken_Opgediend.Size = new System.Drawing.Size(568, 643);
            this.listView_keuken_Opgediend.TabIndex = 1;
            this.listView_keuken_Opgediend.UseCompatibleStateImageBehavior = false;
            this.listView_keuken_Opgediend.View = System.Windows.Forms.View.Details;
            // 
            // Headerfinshed
            // 
            this.Headerfinshed.Text = "Tafelnummer";
            this.Headerfinshed.Width = 100;
            // 
            // HeaderFinItem
            // 
            this.HeaderFinItem.Text = "Bestelde gerecht";
            this.HeaderFinItem.Width = 150;
            // 
            // headerfinhoeveelheid
            // 
            this.headerfinhoeveelheid.Text = "Hoeveelheid";
            this.headerfinhoeveelheid.Width = 100;
            // 
            // headerfinstatus
            // 
            this.headerfinstatus.Text = "Status";
            this.headerfinstatus.Width = 75;
            // 
            // fintijdvanopdieningheader
            // 
            this.fintijdvanopdieningheader.Text = "Tijd van opdiening";
            this.fintijdvanopdieningheader.Width = 150;
            // 
            // listView_Keuken_besteld
            // 
            this.listView_Keuken_besteld.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TafelHeader,
            this.ItemHeader,
            this.headerhoeveelheidKeuken,
            this.headerstatuskeuken,
            this.Headertijdvanbestellingkeuken});
            this.listView_Keuken_besteld.FullRowSelect = true;
            this.listView_Keuken_besteld.GridLines = true;
            this.listView_Keuken_besteld.HideSelection = false;
            this.listView_Keuken_besteld.Location = new System.Drawing.Point(40, 67);
            this.listView_Keuken_besteld.Name = "listView_Keuken_besteld";
            this.listView_Keuken_besteld.Size = new System.Drawing.Size(568, 643);
            this.listView_Keuken_besteld.TabIndex = 0;
            this.listView_Keuken_besteld.UseCompatibleStateImageBehavior = false;
            this.listView_Keuken_besteld.View = System.Windows.Forms.View.Details;
            this.listView_Keuken_besteld.SelectedIndexChanged += new System.EventHandler(this.listView_Keuken_besteld_SelectedIndexChanged);
            // 
            // TafelHeader
            // 
            this.TafelHeader.Text = "Tafelnummer";
            this.TafelHeader.Width = 100;
            // 
            // ItemHeader
            // 
            this.ItemHeader.Text = "Bestelde gerecht";
            this.ItemHeader.Width = 150;
            // 
            // headerhoeveelheidKeuken
            // 
            this.headerhoeveelheidKeuken.Text = "Hoeveelheid";
            this.headerhoeveelheidKeuken.Width = 100;
            // 
            // headerstatuskeuken
            // 
            this.headerstatuskeuken.Text = "Status";
            this.headerstatuskeuken.Width = 70;
            // 
            // Headertijdvanbestellingkeuken
            // 
            this.Headertijdvanbestellingkeuken.Text = "Tijd van bestelling";
            this.Headertijdvanbestellingkeuken.Width = 150;
            // 
            // KeukenBarOverzicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1694, 839);
            this.Controls.Add(this.Pnl_keukenoverzicht);
            this.Controls.Add(this.pnl_Baroverzicht);
            this.Controls.Add(this.MenuBarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KeukenBarOverzicht";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chapoo Bar overzicht";
            this.MenuBarPanel.ResumeLayout(false);
            this.MenuBarAccountPanel.ResumeLayout(false);
            this.MenuBarAccountPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnl_Baroverzicht.ResumeLayout(false);
            this.pnl_Baroverzicht.PerformLayout();
            this.Pnl_keukenoverzicht.ResumeLayout(false);
            this.Pnl_keukenoverzicht.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuBarPanel;
        private System.Windows.Forms.Panel MenuBarAccountPanel;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label UserFunctieLabel;
        private System.Windows.Forms.Button BtnAfmelden;
        private System.Windows.Forms.ColumnHeader ItemID;
        private System.Windows.Forms.Panel pnl_Baroverzicht;
        private System.Windows.Forms.Button btn_Gereed;
        private System.Windows.Forms.ListView Listview_Order_finished;
        private System.Windows.Forms.ListView Listview_Bar_OpenOrder;
        private System.Windows.Forms.Label lbl_Baroverzicht;
        private System.Windows.Forms.ColumnHeader TafelnummerHeader;
        private System.Windows.Forms.ColumnHeader Drankheader;
        private System.Windows.Forms.ColumnHeader hoeveelheidheader;
        private System.Windows.Forms.ColumnHeader HeaderStatus;
        private System.Windows.Forms.ColumnHeader TafelnrHeader;
        private System.Windows.Forms.ColumnHeader Bestellingheader;
        private System.Windows.Forms.ColumnHeader Headerhoeveelheid;
        private System.Windows.Forms.ColumnHeader Statusheader;
        private System.Windows.Forms.ColumnHeader HeaderTijdOpgediend;
        private System.Windows.Forms.ColumnHeader HeaderTijdBesteld;
        private System.Windows.Forms.Button Btn_update_bar;
        private System.Windows.Forms.Panel Pnl_keukenoverzicht;
        private System.Windows.Forms.Button Btn_Update_keuken;
        private System.Windows.Forms.Label lblKeukenoverzicht;
        private System.Windows.Forms.Button Btn_Keuken_gereed;
        private System.Windows.Forms.ListView listView_keuken_Opgediend;
        private System.Windows.Forms.ColumnHeader Headerfinshed;
        private System.Windows.Forms.ColumnHeader HeaderFinItem;
        private System.Windows.Forms.ColumnHeader headerfinhoeveelheid;
        private System.Windows.Forms.ColumnHeader headerfinstatus;
        private System.Windows.Forms.ColumnHeader fintijdvanopdieningheader;
        private System.Windows.Forms.ListView listView_Keuken_besteld;
        private System.Windows.Forms.ColumnHeader TafelHeader;
        private System.Windows.Forms.ColumnHeader ItemHeader;
        private System.Windows.Forms.ColumnHeader headerhoeveelheidKeuken;
        private System.Windows.Forms.ColumnHeader headerstatuskeuken;
        private System.Windows.Forms.ColumnHeader Headertijdvanbestellingkeuken;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton RBtn_Diner;
        private System.Windows.Forms.RadioButton RBtn_Lunch;
    }
}

