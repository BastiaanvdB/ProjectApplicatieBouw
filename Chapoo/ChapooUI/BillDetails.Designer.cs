
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
            this.PrijsHeader = new System.Windows.Forms.ColumnHeader();
            this.PrijsTotalHeader = new System.Windows.Forms.ColumnHeader();
            this.LabelBonTafelTitel = new System.Windows.Forms.Label();
            this.LabelBonInputTafel = new System.Windows.Forms.Label();
            this.BonSluitButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTotaalPrijsInput = new System.Windows.Forms.Label();
            this.labelBrutoInput = new System.Windows.Forms.Label();
            this.labelBTWinput = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewBonDetails
            // 
            this.listViewBonDetails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.GerechtHeader,
            this.AantalHeader,
            this.PrijsHeader,
            this.PrijsTotalHeader});
            this.listViewBonDetails.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listViewBonDetails.GridLines = true;
            this.listViewBonDetails.HideSelection = false;
            this.listViewBonDetails.Location = new System.Drawing.Point(54, 85);
            this.listViewBonDetails.Name = "listViewBonDetails";
            this.listViewBonDetails.Size = new System.Drawing.Size(721, 529);
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
            // PrijsHeader
            // 
            this.PrijsHeader.Text = "Prijs";
            this.PrijsHeader.Width = 72;
            // 
            // PrijsTotalHeader
            // 
            this.PrijsTotalHeader.Text = "Totaalprijs";
            this.PrijsTotalHeader.Width = 104;
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
            this.BonSluitButton.Location = new System.Drawing.Point(592, 732);
            this.BonSluitButton.Name = "BonSluitButton";
            this.BonSluitButton.Size = new System.Drawing.Size(183, 50);
            this.BonSluitButton.TabIndex = 3;
            this.BonSluitButton.Text = "Sluit bon";
            this.BonSluitButton.UseVisualStyleBackColor = false;
            this.BonSluitButton.Click += new System.EventHandler(this.BonSluitButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.labelBrutoInput);
            this.groupBox1.Controls.Add(this.labelBTWinput);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(161, 636);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(394, 176);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Prijsopgave";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.labelTotaalPrijsInput);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(6, 105);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(259, 71);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Te betalen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(6, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Totaalprijs:";
            // 
            // labelTotaalPrijsInput
            // 
            this.labelTotaalPrijsInput.AutoSize = true;
            this.labelTotaalPrijsInput.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTotaalPrijsInput.Location = new System.Drawing.Point(116, 29);
            this.labelTotaalPrijsInput.Name = "labelTotaalPrijsInput";
            this.labelTotaalPrijsInput.Size = new System.Drawing.Size(32, 25);
            this.labelTotaalPrijsInput.TabIndex = 3;
            this.labelTotaalPrijsInput.Text = "....";
            // 
            // labelBrutoInput
            // 
            this.labelBrutoInput.AutoSize = true;
            this.labelBrutoInput.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelBrutoInput.Location = new System.Drawing.Point(116, 38);
            this.labelBrutoInput.Name = "labelBrutoInput";
            this.labelBrutoInput.Size = new System.Drawing.Size(32, 25);
            this.labelBrutoInput.TabIndex = 5;
            this.labelBrutoInput.Text = "....";
            // 
            // labelBTWinput
            // 
            this.labelBTWinput.AutoSize = true;
            this.labelBTWinput.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelBTWinput.Location = new System.Drawing.Point(67, 63);
            this.labelBTWinput.Name = "labelBTWinput";
            this.labelBTWinput.Size = new System.Drawing.Size(32, 25);
            this.labelBTWinput.TabIndex = 4;
            this.labelBTWinput.Text = "....";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(6, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "BTW:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bruto prijs:";
            // 
            // BillDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 841);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BonSluitButton);
            this.Controls.Add(this.LabelBonInputTafel);
            this.Controls.Add(this.LabelBonTafelTitel);
            this.Controls.Add(this.listViewBonDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BillDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bill";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelBrutoInput;
        private System.Windows.Forms.Label labelBTWinput;
        private System.Windows.Forms.Label labelTotaalPrijsInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}