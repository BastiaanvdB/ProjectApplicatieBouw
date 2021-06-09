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

namespace ChapooUI
{
    public partial class TafelOverzicht : Form
    {
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

        public TafelOverzicht()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            pnl_Reserveringen.Hide();
            pnl_Tafeloverzicht.Hide();
        }

        

        // Button area

        private void BtnAfmelden_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Reserveringen_Click(object sender, EventArgs e)
        {
            pnl_Reserveringen.Show();
            pnl_Tafeloverzicht.Hide();
        }

        private void Btn_TafelOverzicht_Click(object sender, EventArgs e)
        {
            pnl_Tafeloverzicht.Show();
            pnl_Reserveringen.Hide();
        }

        // ---------------------
    }
}
