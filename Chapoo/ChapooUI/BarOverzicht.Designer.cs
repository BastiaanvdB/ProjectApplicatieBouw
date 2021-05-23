﻿
namespace ChapooUI
{
    partial class BarOverzicht
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BarOverzicht));
            this.MenuBarPanel = new System.Windows.Forms.Panel();
            this.BtnAfmelden = new System.Windows.Forms.Button();
            this.MenuBarAccountPanel = new System.Windows.Forms.Panel();
            this.UserFunctieLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MenuBarPanel.SuspendLayout();
            this.MenuBarAccountPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // BarOverzicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1399, 699);
            this.Controls.Add(this.MenuBarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BarOverzicht";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chapoo Bar overzicht";
            this.MenuBarPanel.ResumeLayout(false);
            this.MenuBarAccountPanel.ResumeLayout(false);
            this.MenuBarAccountPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuBarPanel;
        private System.Windows.Forms.Panel MenuBarAccountPanel;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label UserFunctieLabel;
        private System.Windows.Forms.Button BtnAfmelden;
    }
}

