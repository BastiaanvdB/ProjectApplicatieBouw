
namespace ChapooUI
{
    partial class BillDetails
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.LabelBonTafelTitel = new System.Windows.Forms.Label();
            this.LabelBonInputTafel = new System.Windows.Forms.Label();
            this.BonSluitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(54, 85);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(476, 529);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // LabelBonTafelTitel
            // 
            this.LabelBonTafelTitel.AutoSize = true;
            this.LabelBonTafelTitel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelBonTafelTitel.Location = new System.Drawing.Point(54, 34);
            this.LabelBonTafelTitel.Name = "LabelBonTafelTitel";
            this.LabelBonTafelTitel.Size = new System.Drawing.Size(130, 37);
            this.LabelBonTafelTitel.TabIndex = 1;
            this.LabelBonTafelTitel.Text = "Bon Tafel:";
            // 
            // LabelBonInputTafel
            // 
            this.LabelBonInputTafel.AutoSize = true;
            this.LabelBonInputTafel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelBonInputTafel.Location = new System.Drawing.Point(190, 34);
            this.LabelBonInputTafel.Name = "LabelBonInputTafel";
            this.LabelBonInputTafel.Size = new System.Drawing.Size(74, 37);
            this.LabelBonInputTafel.TabIndex = 2;
            this.LabelBonInputTafel.Text = "Leeg";
            // 
            // BonSluitButton
            // 
            this.BonSluitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BonSluitButton.FlatAppearance.BorderSize = 0;
            this.BonSluitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BonSluitButton.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BonSluitButton.ForeColor = System.Drawing.Color.White;
            this.BonSluitButton.Location = new System.Drawing.Point(405, 644);
            this.BonSluitButton.Name = "BonSluitButton";
            this.BonSluitButton.Size = new System.Drawing.Size(125, 35);
            this.BonSluitButton.TabIndex = 3;
            this.BonSluitButton.Text = "Sluit bon";
            this.BonSluitButton.UseVisualStyleBackColor = false;
            this.BonSluitButton.Click += new System.EventHandler(this.BonSluitButton_Click);
            // 
            // BillDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 716);
            this.Controls.Add(this.BonSluitButton);
            this.Controls.Add(this.LabelBonInputTafel);
            this.Controls.Add(this.LabelBonTafelTitel);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BillDetails";
            this.Text = "Bill";
            this.Load += new System.EventHandler(this.BillDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label LabelBonTafelTitel;
        private System.Windows.Forms.Label LabelBonInputTafel;
        private System.Windows.Forms.Button BonSluitButton;
    }
}