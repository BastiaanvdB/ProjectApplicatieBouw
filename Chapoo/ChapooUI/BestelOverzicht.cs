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
    public partial class x : Form
    {
        private Employee CurrentEmployee;
        private Dashboard Dashboard;
        private ChapooLogic.Order_Service Order_Service;

        private Order _CurrentOrder;

        private List<MenuItem> MenuItemsList;

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

        public x(Employee employee, Dashboard dashboard)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            MenuItemsList = new List<MenuItem>();
            _CurrentOrder = new Order();
            Order_Service = new ChapooLogic.Order_Service();
            CurrentEmployee = employee;
            Dashboard = dashboard;
            panelMenuOverview.Hide();
            CurrentUserProfile();
        }

        private void CurrentUserProfile()
        {
            UsernameLabel.Text = CurrentEmployee.name;
            UserFunctieLabel.Text = CurrentEmployee.position.ToString();
        }

        private void MenuOverviewSettings(string MenuSetting)
        {
            switch(MenuSetting)
            {
                case "Lunch":
                    listViewMenuOverviewList.Items.Clear();
                    panelMenuOverview.Show();

                    buttonVoorgerechtLunch.Show();
                    buttonHoofdgerechtLunch.Show();
                    buttonNagerechtLunch.Show();

                    buttonVoorgerechtDiner.Hide();
                    buttonTussengerechtDiner.Hide();
                    buttonHoofdgerechtDiner.Hide();
                    buttonNagerechtDiner.Hide();

                    buttonFrisdranken.Hide();
                    buttonBieren.Hide();
                    buttonWijnen.Hide();
                    buttonGedistilleerdeDranken.Hide();
                    buttonWarmeDranken.Hide();

                    break;
                case "Dinner":
                    listViewMenuOverviewList.Items.Clear();
                    panelMenuOverview.Show();

                    buttonVoorgerechtDiner.Show();
                    buttonTussengerechtDiner.Show();
                    buttonHoofdgerechtDiner.Show();
                    buttonNagerechtDiner.Show();

                    buttonVoorgerechtLunch.Hide();
                    buttonHoofdgerechtLunch.Hide();
                    buttonNagerechtLunch.Hide();

                    buttonFrisdranken.Hide();
                    buttonBieren.Hide();
                    buttonWijnen.Hide();
                    buttonGedistilleerdeDranken.Hide();
                    buttonWarmeDranken.Hide();
                    break;
                case "Dranken":
                    listViewMenuOverviewList.Items.Clear();
                    panelMenuOverview.Show();

                    buttonFrisdranken.Show();
                    buttonBieren.Show();
                    buttonWijnen.Show();
                    buttonGedistilleerdeDranken.Show();
                    buttonWarmeDranken.Show();

                    buttonVoorgerechtLunch.Hide();
                    buttonHoofdgerechtLunch.Hide();
                    buttonNagerechtLunch.Hide();
                    buttonVoorgerechtDiner.Hide();
                    buttonTussengerechtDiner.Hide();
                    buttonHoofdgerechtDiner.Hide();
                    buttonNagerechtDiner.Hide();
                    break;
            }
        }


        private void GetSpecificMenuItemsList(int MenuID, int MenuGroupID)
        {
            ChapooLogic.MenuItem_Service menuItem_Service = new ChapooLogic.MenuItem_Service();
            MenuItemsList = menuItem_Service.DB_Get_Specific_MenuItems(MenuID, MenuGroupID);
        }

        private void FillMenuOverviewList()
        {
            listViewMenuOverviewList.Items.Clear();
            foreach (ChapooModel.MenuItem item in MenuItemsList)
            {
                listViewMenuOverviewList.Items.Add(new ListViewItem(new string[] { $"{item.item_Name}", $"{item.item_Price.ToString("€ 0.00")}" }));
            }
        }

        private void CheckExistingOrder(int TableNumber)
        {
            _CurrentOrder.order_ID = Order_Service.DB_Add_Order(TableNumber);
        }


        // Button area

        private void BtnAfmelden_Click(object sender, EventArgs e)
        {
            Dashboard.Show();
            this.Close();
        }

        private void buttonLunchMenu_Click(object sender, EventArgs e)
        {
            MenuOverviewSettings("Lunch");
        }

        private void ButtonDinnerMenu_Click(object sender, EventArgs e)
        {
            MenuOverviewSettings("Dinner");
        }

        private void buttonDrankenMenu_Click(object sender, EventArgs e)
        {
            MenuOverviewSettings("Dranken");
        }

        private void buttonSluitMenu_Click(object sender, EventArgs e)
        {
            panelMenuOverview.Hide();
        }

        private void listViewMenuOverviewList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonVoorgerechtLunch_Click(object sender, EventArgs e)
        {
            GetSpecificMenuItemsList(1, 1);
            FillMenuOverviewList();
        }

        private void buttonHoofdgerechtLunch_Click(object sender, EventArgs e)
        {
            GetSpecificMenuItemsList(1, 2);
            FillMenuOverviewList();
        }

        private void buttonNagerechtLunch_Click(object sender, EventArgs e)
        {
            GetSpecificMenuItemsList(1, 3);
            FillMenuOverviewList();
        }

        private void buttonVoorgerechtDiner_Click(object sender, EventArgs e)
        {
            GetSpecificMenuItemsList(2, 4);
            FillMenuOverviewList();
        }

        private void buttonTussengerechtDiner_Click(object sender, EventArgs e)
        {
            GetSpecificMenuItemsList(2, 5);
            FillMenuOverviewList();
        }

        private void buttonHoofdgerechtDiner_Click(object sender, EventArgs e)
        {
            GetSpecificMenuItemsList(2, 6);
            FillMenuOverviewList();
        }

        private void buttonNagerechtDiner_Click(object sender, EventArgs e)
        {
            GetSpecificMenuItemsList(2, 7);
            FillMenuOverviewList();
        }

        private void buttonFrisdranken_Click(object sender, EventArgs e)
        {
            GetSpecificMenuItemsList(3, 8);
            FillMenuOverviewList();
        }

        private void buttonBieren_Click(object sender, EventArgs e)
        {
            GetSpecificMenuItemsList(3, 9);
            FillMenuOverviewList();
        }

        private void buttonWijnen_Click(object sender, EventArgs e)
        {
            GetSpecificMenuItemsList(3, 10);
            FillMenuOverviewList();
        }

        private void buttonGedistilleerdeDranken_Click(object sender, EventArgs e)
        {
            GetSpecificMenuItemsList(3, 11);
            FillMenuOverviewList();
        }

        private void buttonWarmeDranken_Click(object sender, EventArgs e)
        {
            GetSpecificMenuItemsList(3, 12);
            FillMenuOverviewList();
        }

        // ---------------------
    }
}
