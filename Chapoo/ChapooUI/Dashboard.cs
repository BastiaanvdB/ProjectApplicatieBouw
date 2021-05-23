using System;
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
    public partial class Dashboard : Form
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

        public Dashboard()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }


        // menu panel area
        private void MenuPanel(string menuItem)
        {
            switch(menuItem)
            {
                case "Betaaloverzicht":
                    BetaalOverzicht betaalOverzicht = new BetaalOverzicht();
                    betaalOverzicht.Show();
                    break;
                case "BarOverzicht":
                    BarOverzicht barOverzicht = new BarOverzicht();
                    barOverzicht.Show();
                    break;
                case "KeukenOverzicht":
                    KeukenOverzicht keukenOverzicht = new KeukenOverzicht();
                    keukenOverzicht.Show();
                    break;
                case "VoorraadOverzicht":
                    VoorraadOverzicht voorraadOverzicht = new VoorraadOverzicht();
                    voorraadOverzicht.Show();
                    break;
                case "Exit":
                    Application.Exit();
                    break;
            }
        }
        // --------------------

        // Button area
       

        private void BtnAfrekenen_Click(object sender, EventArgs e)
        {
            MenuPanel("Betaaloverzicht");
        }

        private void BtnKeukenOverzicht_Click(object sender, EventArgs e)
        {
            MenuPanel("KeukenOverzicht");
        }

        private void BtnBarOverzicht_Click(object sender, EventArgs e)
        {
            MenuPanel("BarOverzicht");
        }

        private void BtnAfmelden_Click(object sender, EventArgs e)
        {
            MenuPanel("Exit");
        }

        private void BtnVoorraad_Click(object sender, EventArgs e)
        {
            MenuPanel("VoorraadOverzicht");
        }

        // ---------------------
    }
}
