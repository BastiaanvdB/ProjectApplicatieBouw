﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChapooModel;
using ChapooUI.Properties;

namespace ChapooUI
{
    public partial class Dashboard : Form
    {
        private Employee _CurrentEmployee;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2; 
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        public Dashboard(Employee CurrentEmployee)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            _CurrentEmployee = CurrentEmployee;
            CurrentUserProfile();
            CorrectMenuForUser();
            string[] firstname = _CurrentEmployee.Name.Split(' ');
            labelWelkom.Text = $"Welkom {firstname[0]}";
        }

        private void CurrentUserProfile()
        {
            UsernameLabel.Text = _CurrentEmployee.Name;
            UserFunctieLabel.Text = _CurrentEmployee.Position.ToString();
        }

        private void CorrectMenuForUser()
        {
            switch(_CurrentEmployee.Position)
            {
                case Position.Kok:
                    // enabled buttons
                    BtnBarOverzicht.Text = "Keuken overzicht";
                    BtnBarOverzicht.Image = Resources.cook_24;
                    BtnBarOverzicht.Show();

                    // disabled buttons
                    BtnAfrekenen.Hide();
                    BtnTafelOverzicht.Hide();
                    BtnBestellen.Hide();
                    BtnManagement.Hide();
                    BtnBestellen.Hide();
                    break;
                case Position.Bardienst:
                    // enabled buttons
                    BtnBarOverzicht.Text = "Bar overzicht";
                    BtnBarOverzicht.Image = Resources.bar_24;
                    BtnBarOverzicht.Show();

                    // disabled buttons
                    BtnAfrekenen.Hide();
                    BtnTafelOverzicht.Hide();
                    BtnBestellen.Hide();
                    BtnManagement.Hide();
                    BtnBestellen.Hide();
                    break;
                case Position.Leidinggevende:
                    // enabled buttons
                    BtnManagement.Show();

                    // disabled buttons
                    BtnBarOverzicht.Hide();
                    BtnAfrekenen.Hide();
                    BtnTafelOverzicht.Hide();
                    BtnBestellen.Hide();
                    BtnBestellen.Hide();
                    break;
                case Position.Bediening:
                    // enabled buttons
                    BtnAfrekenen.Show();
                    BtnTafelOverzicht.Show();
                    BtnBestellen.Show();

                    // disabled buttons
                    BtnBarOverzicht.Hide();
                    BtnManagement.Hide();
                    break;
            }
        }


        // menu panel area
        private void MenuPanel(string menuItem)
        {
            switch(menuItem)
            {
                case "Betaaloverzicht":
                    BetaalOverzicht betaalOverzicht = new BetaalOverzicht(_CurrentEmployee, this);
                    betaalOverzicht.Show();
                    this.Hide();
                    break;
                case "KeukenBarOverzicht":
                    KeukenBarOverzicht barOverzicht = new KeukenBarOverzicht(_CurrentEmployee, this);
                    barOverzicht.Show();
                    this.Hide();
                    break;
                case "Management":
                    Management management = new Management(_CurrentEmployee, this);
                    management.Show();
                    this.Hide();
                    break;
                case "Besteloverzicht":
                    x bestelOverzicht = new x(_CurrentEmployee, this);
                    bestelOverzicht.Show();
                    this.Hide();
                    break;
                case "TafelOverzicht":
                    TafelOverzicht tafelOverzicht = new TafelOverzicht(_CurrentEmployee, this);
                    tafelOverzicht.Show();
                    this.Hide();
                    break;
                case "Exit":
                    this.Hide();
                    LoginForm loginForm = new LoginForm();
                    loginForm.Show();
                    break;
            }
        }
        // --------------------

        // Button area
       

        private void BtnAfrekenen_Click(object sender, EventArgs e)
        {
            MenuPanel("Betaaloverzicht");
        }

        private void BtnBarOverzicht_Click(object sender, EventArgs e)
        {
            MenuPanel("KeukenBarOverzicht");
        }

        private void BtnBestellen_Click(object sender, EventArgs e)
        {
            MenuPanel("Besteloverzicht");
        }

        private void BtnTafelOverzicht_Click(object sender, EventArgs e)
        {
            MenuPanel("TafelOverzicht");
        }

        private void BtnAfmelden_Click(object sender, EventArgs e)
        {
            MenuPanel("Exit");
        }

        private void BtnManagement_Click(object sender, EventArgs e)
        {
            MenuPanel("Management");
        }


        // ---------------------
    }
}
