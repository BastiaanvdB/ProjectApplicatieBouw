
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
            this.Btn_KeukenOverzicht = new System.Windows.Forms.Button();
            this.Btn_BarOverzicht = new System.Windows.Forms.Button();
            this.BtnAfmelden = new System.Windows.Forms.Button();
            this.MenuBarAccountPanel = new System.Windows.Forms.Panel();
            this.UserFunctieLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnl_Baroverzicht = new System.Windows.Forms.Panel();
            this.btn_Gereed = new System.Windows.Forms.Button();
            this.Listview_Order_finished = new System.Windows.Forms.ListView();
            this.Listview_Bar_OpenOrder = new System.Windows.Forms.ListView();
            this.lbl_Baroverzicht = new System.Windows.Forms.Label();
            this.MenuBarPanel.SuspendLayout();
            this.MenuBarAccountPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnl_Baroverzicht.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuBarPanel
            // 
            this.MenuBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.MenuBarPanel.Controls.Add(this.Btn_KeukenOverzicht);
            this.MenuBarPanel.Controls.Add(this.Btn_BarOverzicht);
            this.MenuBarPanel.Controls.Add(this.BtnAfmelden);
            this.MenuBarPanel.Controls.Add(this.MenuBarAccountPanel);
            this.MenuBarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuBarPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuBarPanel.Name = "MenuBarPanel";
            this.MenuBarPanel.Size = new System.Drawing.Size(190, 839);
            this.MenuBarPanel.TabIndex = 0;
            // 
            // Btn_KeukenOverzicht
            // 
            this.Btn_KeukenOverzicht.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.Btn_KeukenOverzicht.FlatAppearance.BorderSize = 0;
            this.Btn_KeukenOverzicht.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_KeukenOverzicht.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_KeukenOverzicht.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Btn_KeukenOverzicht.Location = new System.Drawing.Point(0, 256);
            this.Btn_KeukenOverzicht.Name = "Btn_KeukenOverzicht";
            this.Btn_KeukenOverzicht.Size = new System.Drawing.Size(190, 50);
            this.Btn_KeukenOverzicht.TabIndex = 9;
            this.Btn_KeukenOverzicht.Text = "Keukenoverzicht";
            this.Btn_KeukenOverzicht.UseVisualStyleBackColor = false;
            this.Btn_KeukenOverzicht.Click += new System.EventHandler(this.Btn_KeukenOverzicht_Click_1);
            // 
            // Btn_BarOverzicht
            // 
            this.Btn_BarOverzicht.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.Btn_BarOverzicht.FlatAppearance.BorderSize = 0;
            this.Btn_BarOverzicht.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_BarOverzicht.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_BarOverzicht.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Btn_BarOverzicht.Location = new System.Drawing.Point(0, 200);
            this.Btn_BarOverzicht.Name = "Btn_BarOverzicht";
            this.Btn_BarOverzicht.Size = new System.Drawing.Size(190, 50);
            this.Btn_BarOverzicht.TabIndex = 8;
            this.Btn_BarOverzicht.Text = "Baroverzicht";
            this.Btn_BarOverzicht.UseVisualStyleBackColor = false;
            this.Btn_BarOverzicht.Click += new System.EventHandler(this.Btn_BarOverzicht_Click_1);
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
            this.pnl_Baroverzicht.Controls.Add(this.lbl_Baroverzicht);
            this.pnl_Baroverzicht.Controls.Add(this.btn_Gereed);
            this.pnl_Baroverzicht.Controls.Add(this.Listview_Order_finished);
            this.pnl_Baroverzicht.Controls.Add(this.Listview_Bar_OpenOrder);
            this.pnl_Baroverzicht.Location = new System.Drawing.Point(248, 44);
            this.pnl_Baroverzicht.Name = "pnl_Baroverzicht";
            this.pnl_Baroverzicht.Size = new System.Drawing.Size(1315, 731);
            this.pnl_Baroverzicht.TabIndex = 1;
            // 
            // btn_Gereed
            // 
            this.btn_Gereed.Location = new System.Drawing.Point(573, 306);
            this.btn_Gereed.Name = "btn_Gereed";
            this.btn_Gereed.Size = new System.Drawing.Size(168, 55);
            this.btn_Gereed.TabIndex = 2;
            this.btn_Gereed.Text = "Gereed";
            this.btn_Gereed.UseVisualStyleBackColor = true;
            // 
            // Listview_Order_finished
            // 
            this.Listview_Order_finished.HideSelection = false;
            this.Listview_Order_finished.Location = new System.Drawing.Point(787, 67);
            this.Listview_Order_finished.Name = "Listview_Order_finished";
            this.Listview_Order_finished.Size = new System.Drawing.Size(489, 643);
            this.Listview_Order_finished.TabIndex = 1;
            this.Listview_Order_finished.UseCompatibleStateImageBehavior = false;
            // 
            // Listview_Bar_OpenOrder
            // 
            this.Listview_Bar_OpenOrder.HideSelection = false;
            this.Listview_Bar_OpenOrder.Location = new System.Drawing.Point(40, 67);
            this.Listview_Bar_OpenOrder.Name = "Listview_Bar_OpenOrder";
            this.Listview_Bar_OpenOrder.Size = new System.Drawing.Size(481, 643);
            this.Listview_Bar_OpenOrder.TabIndex = 0;
            this.Listview_Bar_OpenOrder.UseCompatibleStateImageBehavior = false;
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
            // KeukenBarOverzicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1596, 839);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuBarPanel;
        private System.Windows.Forms.Panel MenuBarAccountPanel;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label UserFunctieLabel;
        private System.Windows.Forms.Button BtnAfmelden;
        private System.Windows.Forms.Button Btn_KeukenOverzicht;
        private System.Windows.Forms.Button Btn_BarOverzicht;
        private System.Windows.Forms.ColumnHeader ItemID;
        private System.Windows.Forms.Panel pnl_Baroverzicht;
        private System.Windows.Forms.Button btn_Gereed;
        private System.Windows.Forms.ListView Listview_Order_finished;
        private System.Windows.Forms.ListView Listview_Bar_OpenOrder;
        private System.Windows.Forms.Label lbl_Baroverzicht;
    }
}

