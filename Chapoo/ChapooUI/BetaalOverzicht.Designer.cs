
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
            this.panelOpmerking = new System.Windows.Forms.Panel();
            this.TextBoxOpmerking = new System.Windows.Forms.RichTextBox();
            this.buttonToevoegenOpmerking = new System.Windows.Forms.Button();
            this.buttonOpmerking = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelfooi = new System.Windows.Forms.Label();
            this.numericUpDownFooi = new System.Windows.Forms.NumericUpDown();
            this.labelBrutoInput = new System.Windows.Forms.Label();
            this.labelBTWinput = new System.Windows.Forms.Label();
            this.labelNettoinput = new System.Windows.Forms.Label();
            this.labelNettoprijs = new System.Windows.Forms.Label();
            this.labelBrutoprijs = new System.Windows.Forms.Label();
            this.labelBTW = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelTotaalprijsoutput = new System.Windows.Forms.Label();
            this.labelTotaalprijstitle = new System.Windows.Forms.Label();
            this.AfrekenenButton = new System.Windows.Forms.Button();
            this.RadioContant = new System.Windows.Forms.RadioButton();
            this.radioCreditcard = new System.Windows.Forms.RadioButton();
            this.radioPinpas = new System.Windows.Forms.RadioButton();
            this.MenuBarPanel.SuspendLayout();
            this.MenuBarAccountPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PanelAfrekenOverzicht.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelOpmerking.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFooi)).BeginInit();
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
            this.UserFunctieLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UserFunctieLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            this.UserFunctieLabel.Location = new System.Drawing.Point(3, 112);
            this.UserFunctieLabel.Name = "UserFunctieLabel";
            this.UserFunctieLabel.Size = new System.Drawing.Size(184, 16);
            this.UserFunctieLabel.TabIndex = 2;
            this.UserFunctieLabel.Text = "Functie";
            this.UserFunctieLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UsernameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.UsernameLabel.Location = new System.Drawing.Point(3, 90);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(184, 21);
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
            this.AfrekeninglistView.SelectedIndexChanged += new System.EventHandler(this.AfrekeninglistView_SelectedIndexChanged);
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
            this.panel1.Controls.Add(this.panelOpmerking);
            this.panel1.Controls.Add(this.radioPinpas);
            this.panel1.Controls.Add(this.radioCreditcard);
            this.panel1.Controls.Add(this.RadioContant);
            this.panel1.Controls.Add(this.buttonOpmerking);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.labelfooi);
            this.panel1.Controls.Add(this.numericUpDownFooi);
            this.panel1.Controls.Add(this.labelBrutoInput);
            this.panel1.Controls.Add(this.labelBTWinput);
            this.panel1.Controls.Add(this.labelNettoinput);
            this.panel1.Controls.Add(this.labelNettoprijs);
            this.panel1.Controls.Add(this.labelBrutoprijs);
            this.panel1.Controls.Add(this.labelBTW);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.labelTotaalprijsoutput);
            this.panel1.Controls.Add(this.labelTotaalprijstitle);
            this.panel1.Controls.Add(this.AfrekenenButton);
            this.panel1.Location = new System.Drawing.Point(829, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(530, 593);
            this.panel1.TabIndex = 4;
            // 
            // panelOpmerking
            // 
            this.panelOpmerking.Controls.Add(this.TextBoxOpmerking);
            this.panelOpmerking.Controls.Add(this.buttonToevoegenOpmerking);
            this.panelOpmerking.Location = new System.Drawing.Point(15, 20);
            this.panelOpmerking.Name = "panelOpmerking";
            this.panelOpmerking.Size = new System.Drawing.Size(497, 550);
            this.panelOpmerking.TabIndex = 20;
            // 
            // TextBoxOpmerking
            // 
            this.TextBoxOpmerking.Location = new System.Drawing.Point(26, 22);
            this.TextBoxOpmerking.Name = "TextBoxOpmerking";
            this.TextBoxOpmerking.Size = new System.Drawing.Size(446, 431);
            this.TextBoxOpmerking.TabIndex = 2;
            this.TextBoxOpmerking.Text = "";
            // 
            // buttonToevoegenOpmerking
            // 
            this.buttonToevoegenOpmerking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.buttonToevoegenOpmerking.FlatAppearance.BorderSize = 0;
            this.buttonToevoegenOpmerking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonToevoegenOpmerking.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonToevoegenOpmerking.ForeColor = System.Drawing.Color.White;
            this.buttonToevoegenOpmerking.Location = new System.Drawing.Point(165, 470);
            this.buttonToevoegenOpmerking.Name = "buttonToevoegenOpmerking";
            this.buttonToevoegenOpmerking.Size = new System.Drawing.Size(153, 48);
            this.buttonToevoegenOpmerking.TabIndex = 1;
            this.buttonToevoegenOpmerking.Text = "Toevoegen";
            this.buttonToevoegenOpmerking.UseVisualStyleBackColor = false;
            this.buttonToevoegenOpmerking.Click += new System.EventHandler(this.buttonToevoegenOpmerking_Click);
            // 
            // buttonOpmerking
            // 
            this.buttonOpmerking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.buttonOpmerking.FlatAppearance.BorderSize = 0;
            this.buttonOpmerking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpmerking.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonOpmerking.ForeColor = System.Drawing.Color.White;
            this.buttonOpmerking.Location = new System.Drawing.Point(137, 415);
            this.buttonOpmerking.Name = "buttonOpmerking";
            this.buttonOpmerking.Size = new System.Drawing.Size(242, 37);
            this.buttonOpmerking.TabIndex = 19;
            this.buttonOpmerking.Text = "Opmerking toevoegen";
            this.buttonOpmerking.UseVisualStyleBackColor = false;
            this.buttonOpmerking.Click += new System.EventHandler(this.buttonOpmerking_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.panel6.Location = new System.Drawing.Point(38, 383);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(446, 10);
            this.panel6.TabIndex = 8;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.panel5.Location = new System.Drawing.Point(38, 64);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(446, 10);
            this.panel5.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.panel3.Location = new System.Drawing.Point(38, 311);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(446, 10);
            this.panel3.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.panel4.Location = new System.Drawing.Point(38, 226);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(446, 10);
            this.panel4.TabIndex = 9;
            // 
            // labelfooi
            // 
            this.labelfooi.AutoSize = true;
            this.labelfooi.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelfooi.ForeColor = System.Drawing.Color.White;
            this.labelfooi.Location = new System.Drawing.Point(38, 253);
            this.labelfooi.Name = "labelfooi";
            this.labelfooi.Size = new System.Drawing.Size(60, 32);
            this.labelfooi.TabIndex = 18;
            this.labelfooi.Text = "Fooi";
            // 
            // numericUpDownFooi
            // 
            this.numericUpDownFooi.DecimalPlaces = 2;
            this.numericUpDownFooi.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericUpDownFooi.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.numericUpDownFooi.Location = new System.Drawing.Point(165, 252);
            this.numericUpDownFooi.Name = "numericUpDownFooi";
            this.numericUpDownFooi.Size = new System.Drawing.Size(108, 33);
            this.numericUpDownFooi.TabIndex = 17;
            this.numericUpDownFooi.ValueChanged += new System.EventHandler(this.numericUpDownFooi_ValueChanged);
            // 
            // labelBrutoInput
            // 
            this.labelBrutoInput.AutoSize = true;
            this.labelBrutoInput.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelBrutoInput.ForeColor = System.Drawing.Color.White;
            this.labelBrutoInput.Location = new System.Drawing.Point(165, 79);
            this.labelBrutoInput.Name = "labelBrutoInput";
            this.labelBrutoInput.Size = new System.Drawing.Size(34, 32);
            this.labelBrutoInput.TabIndex = 13;
            this.labelBrutoInput.Text = "....";
            // 
            // labelBTWinput
            // 
            this.labelBTWinput.AutoSize = true;
            this.labelBTWinput.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelBTWinput.ForeColor = System.Drawing.Color.White;
            this.labelBTWinput.Location = new System.Drawing.Point(165, 127);
            this.labelBTWinput.Name = "labelBTWinput";
            this.labelBTWinput.Size = new System.Drawing.Size(34, 32);
            this.labelBTWinput.TabIndex = 12;
            this.labelBTWinput.Text = "....";
            // 
            // labelNettoinput
            // 
            this.labelNettoinput.AutoSize = true;
            this.labelNettoinput.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNettoinput.ForeColor = System.Drawing.Color.White;
            this.labelNettoinput.Location = new System.Drawing.Point(165, 173);
            this.labelNettoinput.Name = "labelNettoinput";
            this.labelNettoinput.Size = new System.Drawing.Size(34, 32);
            this.labelNettoinput.TabIndex = 11;
            this.labelNettoinput.Text = "....";
            // 
            // labelNettoprijs
            // 
            this.labelNettoprijs.AutoSize = true;
            this.labelNettoprijs.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNettoprijs.ForeColor = System.Drawing.Color.White;
            this.labelNettoprijs.Location = new System.Drawing.Point(38, 173);
            this.labelNettoprijs.Name = "labelNettoprijs";
            this.labelNettoprijs.Size = new System.Drawing.Size(119, 32);
            this.labelNettoprijs.TabIndex = 10;
            this.labelNettoprijs.Text = "Nettoprijs";
            // 
            // labelBrutoprijs
            // 
            this.labelBrutoprijs.AutoSize = true;
            this.labelBrutoprijs.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelBrutoprijs.ForeColor = System.Drawing.Color.White;
            this.labelBrutoprijs.Location = new System.Drawing.Point(38, 79);
            this.labelBrutoprijs.Name = "labelBrutoprijs";
            this.labelBrutoprijs.Size = new System.Drawing.Size(116, 32);
            this.labelBrutoprijs.TabIndex = 9;
            this.labelBrutoprijs.Text = "Brutoprijs";
            // 
            // labelBTW
            // 
            this.labelBTW.AutoSize = true;
            this.labelBTW.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelBTW.ForeColor = System.Drawing.Color.White;
            this.labelBTW.Location = new System.Drawing.Point(38, 127);
            this.labelBTW.Name = "labelBTW";
            this.labelBTW.Size = new System.Drawing.Size(62, 32);
            this.labelBTW.TabIndex = 8;
            this.labelBTW.Text = "BTW";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.panel2.Location = new System.Drawing.Point(38, 479);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(446, 10);
            this.panel2.TabIndex = 7;
            // 
            // labelTotaalprijsoutput
            // 
            this.labelTotaalprijsoutput.AutoSize = true;
            this.labelTotaalprijsoutput.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTotaalprijsoutput.ForeColor = System.Drawing.Color.White;
            this.labelTotaalprijsoutput.Location = new System.Drawing.Point(165, 510);
            this.labelTotaalprijsoutput.Name = "labelTotaalprijsoutput";
            this.labelTotaalprijsoutput.Size = new System.Drawing.Size(34, 32);
            this.labelTotaalprijsoutput.TabIndex = 6;
            this.labelTotaalprijsoutput.Text = "....";
            // 
            // labelTotaalprijstitle
            // 
            this.labelTotaalprijstitle.AutoSize = true;
            this.labelTotaalprijstitle.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTotaalprijstitle.ForeColor = System.Drawing.Color.White;
            this.labelTotaalprijstitle.Location = new System.Drawing.Point(38, 510);
            this.labelTotaalprijstitle.Name = "labelTotaalprijstitle";
            this.labelTotaalprijstitle.Size = new System.Drawing.Size(121, 32);
            this.labelTotaalprijstitle.TabIndex = 5;
            this.labelTotaalprijstitle.Text = "Totaalprijs";
            // 
            // AfrekenenButton
            // 
            this.AfrekenenButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.AfrekenenButton.FlatAppearance.BorderSize = 0;
            this.AfrekenenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AfrekenenButton.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AfrekenenButton.ForeColor = System.Drawing.Color.White;
            this.AfrekenenButton.Location = new System.Drawing.Point(331, 510);
            this.AfrekenenButton.Name = "AfrekenenButton";
            this.AfrekenenButton.Size = new System.Drawing.Size(153, 48);
            this.AfrekenenButton.TabIndex = 0;
            this.AfrekenenButton.Text = "Afrekenen";
            this.AfrekenenButton.UseVisualStyleBackColor = false;
            this.AfrekenenButton.Click += new System.EventHandler(this.AfrekenenButton_Click);
            // 
            // RadioContant
            // 
            this.RadioContant.AutoSize = true;
            this.RadioContant.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RadioContant.ForeColor = System.Drawing.Color.White;
            this.RadioContant.Location = new System.Drawing.Point(57, 339);
            this.RadioContant.Name = "RadioContant";
            this.RadioContant.Size = new System.Drawing.Size(97, 29);
            this.RadioContant.TabIndex = 20;
            this.RadioContant.TabStop = true;
            this.RadioContant.Text = "Contant";
            this.RadioContant.UseVisualStyleBackColor = true;
            // 
            // radioCreditcard
            // 
            this.radioCreditcard.AutoSize = true;
            this.radioCreditcard.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioCreditcard.ForeColor = System.Drawing.Color.White;
            this.radioCreditcard.Location = new System.Drawing.Point(198, 339);
            this.radioCreditcard.Name = "radioCreditcard";
            this.radioCreditcard.Size = new System.Drawing.Size(118, 29);
            this.radioCreditcard.TabIndex = 21;
            this.radioCreditcard.TabStop = true;
            this.radioCreditcard.Text = "Creditcard";
            this.radioCreditcard.UseVisualStyleBackColor = true;
            // 
            // radioPinpas
            // 
            this.radioPinpas.AutoSize = true;
            this.radioPinpas.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioPinpas.ForeColor = System.Drawing.Color.White;
            this.radioPinpas.Location = new System.Drawing.Point(366, 339);
            this.radioPinpas.Name = "radioPinpas";
            this.radioPinpas.Size = new System.Drawing.Size(86, 29);
            this.radioPinpas.TabIndex = 22;
            this.radioPinpas.TabStop = true;
            this.radioPinpas.Text = "Pinpas";
            this.radioPinpas.UseVisualStyleBackColor = true;
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BetaalOverzicht";
            this.Text = "Chapoo Betaaloverzicht";
            this.MenuBarPanel.ResumeLayout(false);
            this.MenuBarAccountPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PanelAfrekenOverzicht.ResumeLayout(false);
            this.PanelAfrekenOverzicht.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelOpmerking.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFooi)).EndInit();
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelTotaalprijsoutput;
        private System.Windows.Forms.Label labelTotaalprijstitle;
        private System.Windows.Forms.Label labelBrutoInput;
        private System.Windows.Forms.Label labelBTWinput;
        private System.Windows.Forms.Label labelNettoinput;
        private System.Windows.Forms.Label labelNettoprijs;
        private System.Windows.Forms.Label labelBrutoprijs;
        private System.Windows.Forms.Label labelBTW;
        private System.Windows.Forms.Label labelfooi;
        private System.Windows.Forms.NumericUpDown numericUpDownFooi;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button buttonOpmerking;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panelOpmerking;
        private System.Windows.Forms.Button buttonToevoegenOpmerking;
        private System.Windows.Forms.RichTextBox TextBoxOpmerking;
        private System.Windows.Forms.RadioButton RadioContant;
        private System.Windows.Forms.RadioButton radioPinpas;
        private System.Windows.Forms.RadioButton radioCreditcard;
    }
}