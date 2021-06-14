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
using ChapooModel;
using ChapooUI.Properties;

namespace ChapooUI
{
    public partial class TafelOverzicht : Form
    {
        private Employee _CurrentEmployee;
        private Dashboard _Dashboard;
        private DiningTable _CurrentDiningTable;
        private List<DiningTable> _DiningTablesList;

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

        public TafelOverzicht(Employee currentEmployee, Dashboard dashboard)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            _DiningTablesList = new List<DiningTable>();
            _CurrentEmployee = currentEmployee;
            _Dashboard = dashboard;
            buttonBezet.Enabled = false;
            buttonGereed.Enabled = false;
            buttonVrij.Enabled = false;
            buttonWachten.Enabled = false;
            CurrentUserProfile();
            LoadDiningTableList();
            LoadDiningtableLabels();
        }

        private void CurrentUserProfile()
        {
            UsernameLabel.Text = _CurrentEmployee.Name;
            UserFunctieLabel.Text = _CurrentEmployee.Position.ToString();
        }

        private void EnableButtons()
        {
            buttonBezet.Enabled = true;
            buttonGereed.Enabled = true;
            buttonVrij.Enabled = true;
            buttonWachten.Enabled = true;
        }

        private void LoadDiningTableList()
        {
            ChapooLogic.DiningTable_Service diningTable_Service = new ChapooLogic.DiningTable_Service();
            _DiningTablesList = diningTable_Service.DB_Get_All_DiningTables();
        }

        private void LoadDiningtableLabels()
        {
            foreach(DiningTable diningTable in _DiningTablesList)
            {
                switch(diningTable.Table_ID)
                {
                    case 1:
                        switch(diningTable.Table_Status)
                        {
                            case TableStatus.Vrij:
                                pictureTafel1.Image = Resources.tafelVrij;
                                labelTafel1.BackColor = Color.White;
                                labelTafel1.ForeColor = Color.Black;
                                break;
                            case TableStatus.Bezet:
                                pictureTafel1.Image = Resources.tafelBezet;
                                labelTafel1.BackColor = Color.Red;
                                labelTafel1.ForeColor = Color.White;
                                break;
                            case TableStatus.Wachten:
                                pictureTafel1.Image = Resources.tafelWachten;
                                labelTafel1.BackColor = Color.Orange;
                                labelTafel1.ForeColor = Color.White;
                                break;
                            case TableStatus.Gereed:
                                pictureTafel1.Image = Resources.tafelGereed;
                                labelTafel1.BackColor = Color.Green;
                                labelTafel1.ForeColor = Color.White;
                                break;
                        }
                        break;
                    case 2:
                        switch (diningTable.Table_Status)
                        {
                            case TableStatus.Vrij:
                                pictureTafel2.Image = Resources.tafelVrij;
                                labelTafel2.BackColor = Color.White;
                                labelTafel2.ForeColor = Color.Black;
                                break;
                            case TableStatus.Bezet:
                                pictureTafel2.Image = Resources.tafelBezet;
                                labelTafel2.BackColor = Color.Red;
                                labelTafel2.ForeColor = Color.White;
                                break;
                            case TableStatus.Wachten:
                                pictureTafel2.Image = Resources.tafelWachten;
                                labelTafel2.BackColor = Color.Orange;
                                labelTafel2.ForeColor = Color.White;
                                break;
                            case TableStatus.Gereed:
                                pictureTafel2.Image = Resources.tafelGereed;
                                labelTafel2.BackColor = Color.Green;
                                labelTafel2.ForeColor = Color.White;
                                break;
                        }
                        break;
                    case 3:
                        switch (diningTable.Table_Status)
                        {
                            case TableStatus.Vrij:
                                pictureTafel3.Image = Resources.tafelVrij;
                                labelTafel3.BackColor = Color.White;
                                labelTafel3.ForeColor = Color.Black;
                                break;
                            case TableStatus.Bezet:
                                pictureTafel3.Image = Resources.tafelBezet;
                                labelTafel3.BackColor = Color.Red;
                                labelTafel3.ForeColor = Color.White;
                                break;
                            case TableStatus.Wachten:
                                pictureTafel3.Image = Resources.tafelWachten;
                                labelTafel3.BackColor = Color.Orange;
                                labelTafel3.ForeColor = Color.White;
                                break;
                            case TableStatus.Gereed:
                                pictureTafel3.Image = Resources.tafelGereed;
                                labelTafel3.BackColor = Color.Green;
                                labelTafel3.ForeColor = Color.White;
                                break;
                        }
                        break;
                    case 4:
                        switch (diningTable.Table_Status)
                        {
                            case TableStatus.Vrij:
                                pictureTafel4.Image = Resources.tafelVrij;
                                labelTafel4.BackColor = Color.White;
                                labelTafel4.ForeColor = Color.Black;
                                break;
                            case TableStatus.Bezet:
                                pictureTafel4.Image = Resources.tafelBezet;
                                labelTafel4.BackColor = Color.Red;
                                labelTafel4.ForeColor = Color.White;
                                break;
                            case TableStatus.Wachten:
                                pictureTafel4.Image = Resources.tafelWachten;
                                labelTafel4.BackColor = Color.Orange;
                                labelTafel4.ForeColor = Color.White;
                                break;
                            case TableStatus.Gereed:
                                pictureTafel4.Image = Resources.tafelGereed;
                                labelTafel4.BackColor = Color.Green;
                                labelTafel4.ForeColor = Color.White;
                                break;
                        }
                        break;
                    case 5:
                        switch (diningTable.Table_Status)
                        {
                            case TableStatus.Vrij:
                                pictureTafel5.Image = Resources.tafelVrij;
                                labelTafel5.BackColor = Color.White;
                                labelTafel5.ForeColor = Color.Black;
                                break;
                            case TableStatus.Bezet:
                                pictureTafel5.Image = Resources.tafelBezet;
                                labelTafel5.BackColor = Color.Red;
                                labelTafel5.ForeColor = Color.White;
                                break;
                            case TableStatus.Wachten:
                                pictureTafel5.Image = Resources.tafelWachten;
                                labelTafel5.BackColor = Color.Orange;
                                labelTafel5.ForeColor = Color.White;
                                break;
                            case TableStatus.Gereed:
                                pictureTafel5.Image = Resources.tafelGereed;
                                labelTafel5.BackColor = Color.Green;
                                labelTafel5.ForeColor = Color.White;
                                break;
                        }
                        break;
                    case 6:
                        switch (diningTable.Table_Status)
                        {
                            case TableStatus.Vrij:
                                labelTafel6.BackColor = Color.White;
                                labelTafel6.ForeColor = Color.Black;
                                pictureTafel6.Image = Resources.tafelVrij;
                                break;
                            case TableStatus.Bezet:
                                pictureTafel6.Image = Resources.tafelBezet;
                                labelTafel6.BackColor = Color.Red;
                                labelTafel6.ForeColor = Color.White;
                                break;
                            case TableStatus.Wachten:
                                pictureTafel6.Image = Resources.tafelWachten;
                                labelTafel6.BackColor = Color.Orange;
                                labelTafel6.ForeColor = Color.White;
                                break;
                            case TableStatus.Gereed:
                                pictureTafel6.Image = Resources.tafelGereed;
                                labelTafel6.BackColor = Color.Green;
                                labelTafel6.ForeColor = Color.White;
                                break;
                        }
                        break;
                    case 7:
                        switch (diningTable.Table_Status)
                        {
                            case TableStatus.Vrij:
                                labelTafel7.BackColor = Color.White;
                                labelTafel7.ForeColor = Color.Black;
                                pictureTafel7.Image = Resources.tafelVrij;
                                break;
                            case TableStatus.Bezet:
                                pictureTafel7.Image = Resources.tafelBezet;
                                labelTafel7.BackColor = Color.Red;
                                labelTafel7.ForeColor = Color.White;
                                break;
                            case TableStatus.Wachten:
                                pictureTafel7.Image = Resources.tafelWachten;
                                labelTafel7.BackColor = Color.Orange;
                                labelTafel7.ForeColor = Color.White;
                                break;
                            case TableStatus.Gereed:
                                pictureTafel7.Image = Resources.tafelGereed;
                                labelTafel7.BackColor = Color.Green;
                                labelTafel7.ForeColor = Color.White;
                                break;
                        }
                        break;
                    case 8:
                        switch (diningTable.Table_Status)
                        {
                            case TableStatus.Vrij:
                                labelTafel8.BackColor = Color.White;
                                labelTafel8.ForeColor = Color.Black;
                                pictureTafel8.Image = Resources.tafelVrij;
                                break;
                            case TableStatus.Bezet:
                                pictureTafel8.Image = Resources.tafelBezet;
                                labelTafel8.BackColor = Color.Red;
                                labelTafel8.ForeColor = Color.White;
                                break;
                            case TableStatus.Wachten:
                                pictureTafel8.Image = Resources.tafelWachten;
                                labelTafel8.BackColor = Color.Orange;
                                labelTafel8.ForeColor = Color.White;
                                break;
                            case TableStatus.Gereed:
                                pictureTafel8.Image = Resources.tafelGereed;
                                labelTafel8.BackColor = Color.Green;
                                labelTafel8.ForeColor = Color.White;
                                break;
                        }
                        break;
                    case 9:
                        switch (diningTable.Table_Status)
                        {
                            case TableStatus.Vrij:
                                labelTafel9.BackColor = Color.White;
                                labelTafel9.ForeColor = Color.Black;
                                pictureTafel9.Image = Resources.tafelVrij;
                                break;
                            case TableStatus.Bezet:
                                pictureTafel9.Image = Resources.tafelBezet;
                                labelTafel9.BackColor = Color.Red;
                                labelTafel9.ForeColor = Color.White;
                                break;
                            case TableStatus.Wachten:
                                pictureTafel9.Image = Resources.tafelWachten;
                                labelTafel9.BackColor = Color.Orange;
                                labelTafel9.ForeColor = Color.White;
                                break;
                            case TableStatus.Gereed:
                                pictureTafel9.Image = Resources.tafelGereed;
                                labelTafel9.BackColor = Color.Green;
                                labelTafel9.ForeColor = Color.White;
                                break;
                        }
                        break;
                    case 10:
                        switch (diningTable.Table_Status)
                        {
                            case TableStatus.Vrij:
                                labelTafel10.BackColor = Color.White;
                                labelTafel10.ForeColor = Color.Black;
                                pictureTafel10.Image = Resources.tafelVrij;
                                break;
                            case TableStatus.Bezet:
                                pictureTafel10.Image = Resources.tafelBezet;
                                labelTafel10.BackColor = Color.Red;
                                labelTafel10.ForeColor = Color.White;
                                break;
                            case TableStatus.Wachten:
                                pictureTafel10.Image = Resources.tafelWachten;
                                labelTafel10.BackColor = Color.Orange;
                                labelTafel10.ForeColor = Color.White;
                                break;
                            case TableStatus.Gereed:
                                pictureTafel10.Image = Resources.tafelGereed;
                                labelTafel10.BackColor = Color.Green;
                                labelTafel10.ForeColor = Color.White;
                                break;
                        }
                        break;
                }
            }
        }

        private void UpdateStatusFromTable(TableStatus tableStatus)
        {
            if (_CurrentDiningTable is not null)
            {
                ChapooLogic.DiningTable_Service table_Service = new ChapooLogic.DiningTable_Service();
                _CurrentDiningTable.Table_Status = tableStatus;
                table_Service.DB_Update_DiningTable(_CurrentDiningTable);
                CurrentUserProfile();
                LoadDiningTableList();
                LoadDiningtableLabels();
            }
        }

        // Button area

        private void BtnAfmelden_Click(object sender, EventArgs e)
        {
            _Dashboard.Show();
            this.Close();
        }

        private void buttonVrij_Click(object sender, EventArgs e)
        {
            UpdateStatusFromTable(TableStatus.Vrij);
        }

        private void buttonBezet_Click(object sender, EventArgs e)
        {
            UpdateStatusFromTable(TableStatus.Bezet);
        }

        private void buttonGereed_Click(object sender, EventArgs e)
        {
            UpdateStatusFromTable(TableStatus.Gereed);
        }

        private void buttonWachten_Click(object sender, EventArgs e)
        {
            UpdateStatusFromTable(TableStatus.Wachten);
        }

        private void pictureTafel1_Click(object sender, EventArgs e)
        {
            pictureTafel1.BorderStyle = BorderStyle.Fixed3D;
            pictureTafel2.BorderStyle = BorderStyle.None;
            pictureTafel3.BorderStyle = BorderStyle.None;
            pictureTafel4.BorderStyle = BorderStyle.None;
            pictureTafel5.BorderStyle = BorderStyle.None;
            pictureTafel6.BorderStyle = BorderStyle.None;
            pictureTafel7.BorderStyle = BorderStyle.None;
            pictureTafel8.BorderStyle = BorderStyle.None;
            pictureTafel9.BorderStyle = BorderStyle.None;
            pictureTafel10.BorderStyle = BorderStyle.None;
            _CurrentDiningTable = _DiningTablesList[0];
            EnableButtons();
        }

        private void pictureTafel2_Click(object sender, EventArgs e)
        {
            pictureTafel1.BorderStyle = BorderStyle.None;
            pictureTafel2.BorderStyle = BorderStyle.Fixed3D;
            pictureTafel3.BorderStyle = BorderStyle.None;
            pictureTafel4.BorderStyle = BorderStyle.None;
            pictureTafel5.BorderStyle = BorderStyle.None;
            pictureTafel6.BorderStyle = BorderStyle.None;
            pictureTafel7.BorderStyle = BorderStyle.None;
            pictureTafel8.BorderStyle = BorderStyle.None;
            pictureTafel9.BorderStyle = BorderStyle.None;
            pictureTafel10.BorderStyle = BorderStyle.None;
            _CurrentDiningTable = _DiningTablesList[1];
            EnableButtons();
        }

        private void pictureTafel3_Click(object sender, EventArgs e)
        {
            pictureTafel2.BorderStyle = BorderStyle.None;
            pictureTafel1.BorderStyle = BorderStyle.None;
            pictureTafel2.BorderStyle = BorderStyle.None;
            pictureTafel3.BorderStyle = BorderStyle.Fixed3D;
            pictureTafel4.BorderStyle = BorderStyle.None;
            pictureTafel5.BorderStyle = BorderStyle.None;
            pictureTafel6.BorderStyle = BorderStyle.None;
            pictureTafel7.BorderStyle = BorderStyle.None;
            pictureTafel8.BorderStyle = BorderStyle.None;
            pictureTafel9.BorderStyle = BorderStyle.None;
            pictureTafel10.BorderStyle = BorderStyle.None;
            _CurrentDiningTable = _DiningTablesList[2];
            EnableButtons();
        }

        private void pictureTafel4_Click(object sender, EventArgs e)
        {
            pictureTafel1.BorderStyle = BorderStyle.None;
            pictureTafel2.BorderStyle = BorderStyle.None;
            pictureTafel3.BorderStyle = BorderStyle.None;
            pictureTafel4.BorderStyle = BorderStyle.Fixed3D;
            pictureTafel5.BorderStyle = BorderStyle.None;
            pictureTafel6.BorderStyle = BorderStyle.None;
            pictureTafel7.BorderStyle = BorderStyle.None;
            pictureTafel8.BorderStyle = BorderStyle.None;
            pictureTafel9.BorderStyle = BorderStyle.None;
            pictureTafel10.BorderStyle = BorderStyle.None;
            _CurrentDiningTable = _DiningTablesList[3];
            EnableButtons();
        }

        private void pictureTafel5_Click(object sender, EventArgs e)
        {
            pictureTafel1.BorderStyle = BorderStyle.None;
            pictureTafel2.BorderStyle = BorderStyle.None;
            pictureTafel3.BorderStyle = BorderStyle.None;
            pictureTafel4.BorderStyle = BorderStyle.None;
            pictureTafel5.BorderStyle = BorderStyle.Fixed3D;
            pictureTafel6.BorderStyle = BorderStyle.None;
            pictureTafel7.BorderStyle = BorderStyle.None;
            pictureTafel8.BorderStyle = BorderStyle.None;
            pictureTafel9.BorderStyle = BorderStyle.None;
            pictureTafel10.BorderStyle = BorderStyle.None;
            _CurrentDiningTable = _DiningTablesList[4];
            EnableButtons();
        }

        private void pictureTafel6_Click(object sender, EventArgs e)
        {
            pictureTafel2.BorderStyle = BorderStyle.None;
            pictureTafel1.BorderStyle = BorderStyle.None;
            pictureTafel2.BorderStyle = BorderStyle.None;
            pictureTafel3.BorderStyle = BorderStyle.None;
            pictureTafel4.BorderStyle = BorderStyle.None;
            pictureTafel5.BorderStyle = BorderStyle.None;
            pictureTafel6.BorderStyle = BorderStyle.Fixed3D;
            pictureTafel7.BorderStyle = BorderStyle.None;
            pictureTafel8.BorderStyle = BorderStyle.None;
            pictureTafel9.BorderStyle = BorderStyle.None;
            pictureTafel10.BorderStyle = BorderStyle.None;
            _CurrentDiningTable = _DiningTablesList[5];
            EnableButtons();
        }

        private void pictureTafel7_Click(object sender, EventArgs e)
        {
            pictureTafel2.BorderStyle = BorderStyle.None;
            pictureTafel1.BorderStyle = BorderStyle.None;
            pictureTafel2.BorderStyle = BorderStyle.None;
            pictureTafel3.BorderStyle = BorderStyle.None;
            pictureTafel4.BorderStyle = BorderStyle.None;
            pictureTafel5.BorderStyle = BorderStyle.None;
            pictureTafel6.BorderStyle = BorderStyle.None;
            pictureTafel7.BorderStyle = BorderStyle.Fixed3D;
            pictureTafel8.BorderStyle = BorderStyle.None;
            pictureTafel9.BorderStyle = BorderStyle.None;
            pictureTafel10.BorderStyle = BorderStyle.None;
            _CurrentDiningTable = _DiningTablesList[6];
            EnableButtons();
        }

        private void pictureTafel8_Click(object sender, EventArgs e)
        {
            pictureTafel2.BorderStyle = BorderStyle.None;
            pictureTafel1.BorderStyle = BorderStyle.None;
            pictureTafel2.BorderStyle = BorderStyle.None;
            pictureTafel3.BorderStyle = BorderStyle.None;
            pictureTafel4.BorderStyle = BorderStyle.None;
            pictureTafel5.BorderStyle = BorderStyle.None;
            pictureTafel6.BorderStyle = BorderStyle.None;
            pictureTafel7.BorderStyle = BorderStyle.None;
            pictureTafel8.BorderStyle = BorderStyle.Fixed3D;
            pictureTafel9.BorderStyle = BorderStyle.None;
            pictureTafel10.BorderStyle = BorderStyle.None;
            _CurrentDiningTable = _DiningTablesList[7];
            EnableButtons();
        }

        private void pictureTafel9_Click(object sender, EventArgs e)
        {
            pictureTafel2.BorderStyle = BorderStyle.None;
            pictureTafel1.BorderStyle = BorderStyle.None;
            pictureTafel2.BorderStyle = BorderStyle.None;
            pictureTafel3.BorderStyle = BorderStyle.None;
            pictureTafel4.BorderStyle = BorderStyle.None;
            pictureTafel5.BorderStyle = BorderStyle.None;
            pictureTafel6.BorderStyle = BorderStyle.None;
            pictureTafel7.BorderStyle = BorderStyle.None;
            pictureTafel8.BorderStyle = BorderStyle.None;
            pictureTafel9.BorderStyle = BorderStyle.Fixed3D;
            pictureTafel10.BorderStyle = BorderStyle.None;
            _CurrentDiningTable = _DiningTablesList[8];
            EnableButtons();
        }

        private void pictureTafel10_Click(object sender, EventArgs e)
        {
            pictureTafel2.BorderStyle = BorderStyle.None;
            pictureTafel1.BorderStyle = BorderStyle.None;
            pictureTafel2.BorderStyle = BorderStyle.None;
            pictureTafel3.BorderStyle = BorderStyle.None;
            pictureTafel4.BorderStyle = BorderStyle.None;
            pictureTafel5.BorderStyle = BorderStyle.None;
            pictureTafel6.BorderStyle = BorderStyle.None;
            pictureTafel7.BorderStyle = BorderStyle.None;
            pictureTafel8.BorderStyle = BorderStyle.None;
            pictureTafel9.BorderStyle = BorderStyle.None;
            pictureTafel10.BorderStyle = BorderStyle.Fixed3D;
            _CurrentDiningTable = _DiningTablesList[9];
            EnableButtons();
        }


        // ---------------------
    }
}
