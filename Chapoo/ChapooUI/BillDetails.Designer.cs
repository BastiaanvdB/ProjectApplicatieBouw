
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillDetails));
            this.listViewBonDetails = new System.Windows.Forms.ListView();
            this.GerechtHeader = new System.Windows.Forms.ColumnHeader();
            this.AantalHeader = new System.Windows.Forms.ColumnHeader();
            this.columntijd = new System.Windows.Forms.ColumnHeader();
            this.PrijsHeader = new System.Windows.Forms.ColumnHeader();
            this.PrijsTotalHeader = new System.Windows.Forms.ColumnHeader();
            this.LabelBonTafelTitel = new System.Windows.Forms.Label();
            this.LabelBonInputTafel = new System.Windows.Forms.Label();
            this.BonSluitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewBonDetails
            // 
            this.listViewBonDetails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.GerechtHeader,
            this.AantalHeader,
            this.columntijd,
            this.PrijsHeader,
            this.PrijsTotalHeader});
            this.listViewBonDetails.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listViewBonDetails.GridLines = true;
            this.listViewBonDetails.HideSelection = false;
            this.listViewBonDetails.Location = new System.Drawing.Point(54, 85);
            this.listViewBonDetails.Name = "listViewBonDetails";
            this.listViewBonDetails.Size = new System.Drawing.Size(890, 529);
            this.listViewBonDetails.TabIndex = 0;
            this.listViewBonDetails.UseCompatibleStateImageBehavior = false;
            this.listViewBonDetails.View = System.Windows.Forms.View.Details;
            // 
            // GerechtHeader
            // 
            this.GerechtHeader.Text = "Gerecht/Drank";
            this.GerechtHeader.Width = 480;
            // 
            // AantalHeader
            // 
            this.AantalHeader.Text = "Aantal";
            // 
            // columntijd
            // 
            this.columntijd.Text = "Datum/Tijd";
            this.columntijd.Width = 170;
            // 
            // PrijsHeader
            // 
            this.PrijsHeader.Text = "Prijs";
            this.PrijsHeader.Width = 72;
            // 
            // PrijsTotalHeader
            // 
            this.PrijsTotalHeader.Text = "Totaalprijs";
            this.PrijsTotalHeader.Width = 100;
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
            this.LabelBonInputTafel.Location = new System.Drawing.Point(174, 34);
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
            this.BonSluitButton.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BonSluitButton.ForeColor = System.Drawing.Color.White;
            this.BonSluitButton.Location = new System.Drawing.Point(761, 637);
            this.BonSluitButton.Name = "BonSluitButton";
            this.BonSluitButton.Size = new System.Drawing.Size(183, 50);
            this.BonSluitButton.TabIndex = 3;
            this.BonSluitButton.Text = "Sluit bon";
            this.BonSluitButton.UseVisualStyleBackColor = false;
            this.BonSluitButton.Click += new System.EventHandler(this.BonSluitButton_Click);
            // 
            // BillDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 716);
            this.Controls.Add(this.BonSluitButton);
            this.Controls.Add(this.LabelBonInputTafel);
            this.Controls.Add(this.LabelBonTafelTitel);
            this.Controls.Add(this.listViewBonDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BillDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bill";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewBonDetails;
        private System.Windows.Forms.Label LabelBonTafelTitel;
        private System.Windows.Forms.Label LabelBonInputTafel;
        private System.Windows.Forms.Button BonSluitButton;
        private System.Windows.Forms.ColumnHeader GerechtHeader;
        private System.Windows.Forms.ColumnHeader AantalHeader;
        private System.Windows.Forms.ColumnHeader PrijsHeader;
        private System.Windows.Forms.ColumnHeader PrijsTotalHeader;
        private System.Windows.Forms.ColumnHeader columntijd;
    }
}