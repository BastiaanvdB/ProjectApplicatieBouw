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

namespace ChapooUI
{
    public partial class Management : Form
    {
        private MenuItem CurrentItem;
        private List<MenuItem> StockList;
        private int CurrentMenuCode;


        private Employee _CurrentEmployee;
        private Dashboard _Dashboard;

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

        public Management(Employee currentEmployee, Dashboard dashboard)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            _CurrentEmployee = currentEmployee;
            _Dashboard = dashboard;
            panelModifySelection.Hide();
            panelModifyControls.Hide();
            panelLunchSetting.Hide();
            panelDinerSetting.Hide();
            panelDrankSetting.Hide();
            CurrentUserProfile();
        }

        private void CurrentUserProfile()
        {
            UsernameLabel.Text = _CurrentEmployee.name;
            UserFunctieLabel.Text = _CurrentEmployee.position.ToString();
        }


        private void ManagementMenu(string menu)
        {
            switch(menu)
            {
                case "UserMangement":

                    break;
                case "StockManagement":

                    break;
                case "FinancialOverview":

                    break;
            }
        }


        private void UpdateStockList()
        {
            ChapooLogic.Stock_Service stock_Service = new ChapooLogic.Stock_Service();
            StockList = stock_Service.DB_Get_Specific_Stock(CurrentMenuCode);
        }

        private void UpdateStockViewList()
        {
            listViewStockManagement.Items.Clear();
            foreach (ChapooModel.MenuItem menuItem  in StockList)
            {
                listViewStockManagement.Items.Add(new ListViewItem(new string[] { $"{menuItem.MenuGroup}", $"{menuItem.item_Name}", $"{menuItem.item_Price.ToString("€ 0.00")}", $"{menuItem.item_Taxpercentage}%", $"{menuItem.item_Restock}", $"{menuItem.item_Stock}", $"{"test"}" }));
            }
        }

        private void AdjustModifyControls(int AdjustCode)
        {
            switch(AdjustCode)
            {
                case 1:

                    break;
                case 2:

                    break;
                case 3:

                    break;
            }
        }

        private void AdjustMenuGroupSetting(int MenuCode)
        {
            switch(MenuCode)
            {
                case 1:
                    panelLunchSetting.Show();
                    panelDinerSetting.Hide();
                    panelDrankSetting.Hide();
                    break;
                case 2:
                    panelLunchSetting.Hide();
                    panelDinerSetting.Show();
                    panelDrankSetting.Hide();
                    break;
                case 3:
                    panelLunchSetting.Hide();
                    panelDinerSetting.Hide();
                    panelDrankSetting.Show();
                    break;
            }
        }


        // Button area

        private void BtnStockManagement_Click(object sender, EventArgs e)
        {

        }

        private void btnUserManagement_Click(object sender, EventArgs e)
        {

        }

        private void btnFinancialOverview_Click(object sender, EventArgs e)
        {

        }

        private void BtnAfmelden_Click(object sender, EventArgs e)
        {
            _Dashboard.Show();
            this.Close();
        }

        private void radioButtonLunchVoorraad_CheckedChanged(object sender, EventArgs e)
        {
            radioButtonDinerVoorraad.Checked = false;
            radioButtonDrankVoorraad.Checked = false;
            CurrentMenuCode = 1;
            panelModifySelection.Show();
            panelModifyControls.Show();
            panelLunchSetting.Show();
            UpdateStockList();
            UpdateStockViewList();
            AdjustMenuGroupSetting(1);
        }

        private void radioButtonDinerVoorraad_CheckedChanged(object sender, EventArgs e)
        {
            radioButtonLunchVoorraad.Checked = false;
            radioButtonDrankVoorraad.Checked = false;
            CurrentMenuCode = 2;
            panelModifySelection.Show();
            panelModifyControls.Show();
            panelDinerSetting.Show();
            UpdateStockList();
            UpdateStockViewList();
            AdjustMenuGroupSetting(2);
        }

        private void radioButtonDrankVoorraad_CheckedChanged(object sender, EventArgs e)
        {
            radioButtonLunchVoorraad.Checked = false;
            radioButtonDinerVoorraad.Checked = false;
            CurrentMenuCode = 3;
            panelModifySelection.Show();
            panelModifyControls.Show();
            panelDrankSetting.Show();
            UpdateStockList();
            UpdateStockViewList();
            AdjustMenuGroupSetting(3);
        }

        private void radioButtonWijzigen_CheckedChanged(object sender, EventArgs e)
        {
            panelModifyControls.Show();
        }

        private void radioButtonToevoegen_CheckedChanged(object sender, EventArgs e)
        {
            panelModifyControls.Show();
        }

        private void radioButtonVerwijderen_CheckedChanged(object sender, EventArgs e)
        {
            panelModifyControls.Show();
        }

        // ---------------------
    }
}
