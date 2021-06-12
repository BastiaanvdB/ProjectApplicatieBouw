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

        private List<OrderDetail> _CurrentOrderList;
        private MenuItem _CurrentSelectedMenuItem;
        private OrderDetail _CurrentSelectedOrderDetail;
        private int _CurrentOrderID;

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
            _CurrentOrderID = 0;
            _CurrentOrderList = new List<OrderDetail>();
            Order_Service = new ChapooLogic.Order_Service();
            CurrentEmployee = employee;
            Dashboard = dashboard;
            panelMenuItemOptions.Hide();
            panelMenuOverview.Hide();
            CurrentUserProfile();
            buttonBestelVerwijder.Enabled = false;
            buttonBestelBewerk.Enabled = false;
            buttonBestelOrder.Enabled = false;
            panelWijzigOrder.Hide();
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

                    buttonTussengerechtDiner.Hide();
                    buttonVoorgerechtDiner.Hide();
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

                    buttonTussengerechtDiner.Show();
                    buttonVoorgerechtDiner.Show();
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
                    buttonTussengerechtDiner.Hide();
                    buttonVoorgerechtDiner.Hide();
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

        private void FillCurrentOrderListOverview()
        {
            listViewCurrentOrderList.Items.Clear();
            foreach (ChapooModel.OrderDetail orderDetail in _CurrentOrderList)
            {
                listViewCurrentOrderList.Items.Add(new ListViewItem(new string[] { $"{orderDetail.item.MenuGroup}", $"{orderDetail.item.item_Name}", $"{orderDetail.item.item_Price.ToString("€ 0.00")}", $"{orderDetail.quantity}" }));
            }

            if(_CurrentOrderList.Count > 0)
            {
                buttonBestelOrder.Enabled = true;
                buttonBestelBewerk.Enabled = true;
                buttonBestelVerwijder.Enabled = true;
            }
            else
            {
                buttonBestelOrder.Enabled = false;
                buttonBestelBewerk.Enabled = false;
                buttonBestelVerwijder.Enabled = false;
            }
        }


        private void CheckExistingOrder(int TableNumber)
        {
            _CurrentOrderID = Order_Service.DB_Add_Order(TableNumber);
        }

        private void listViewMenuOverviewList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewMenuOverviewList.SelectedItems.Count != 0)
            {
                _CurrentSelectedMenuItem = MenuItemsList[listViewMenuOverviewList.SelectedIndices[0]];
                panelMenuItemOptions.Show();
                numericUpDownHoeveelheid.Value = 1;
                richTextBoxOpmerking.ResetText();
                if (_CurrentSelectedMenuItem.Alcohol_Check == true)
                {
                    labelIDInput.Text = "Vraag ID";
                    labelIDInput.ForeColor = Color.Red;
                }
                else
                {
                    labelIDInput.Text = "Niet nodig";
                    labelIDInput.ForeColor = Color.Green;
                }
                        
            }
        }

        private void listViewCurrentOrderList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewCurrentOrderList.SelectedItems.Count != 0)
            {
                _CurrentSelectedOrderDetail = _CurrentOrderList[listViewCurrentOrderList.SelectedIndices[0]];
                buttonBestelVerwijder.Enabled = true;
                buttonBestelBewerk.Enabled = true;
            }
            else
            {
                buttonBestelVerwijder.Enabled = false;
                buttonBestelBewerk.Enabled = false;
            }
        }

        private void CreateOrderDetail()
        {
            OrderDetail orderDetail = new OrderDetail()
            {
                item = _CurrentSelectedMenuItem,
                order_ID = _CurrentOrderID,
                quantity = (int)numericUpDownHoeveelheid.Value,
                comment = richTextBoxOpmerking.Text,
                employee = CurrentEmployee,
                orderStatus = OrderStatus.Besteld,
                ordered_DateTime = DateTime.Now,
                preparing_DateTime = DateTime.Today,
                finished_DateTime = DateTime.Today,
            };
            _CurrentOrderList.Add(orderDetail);
            FillCurrentOrderListOverview();
        }

        private void FillEditForm()
        {
            numericUpDownWijzigHoeveelheid.Value = 0;
            richTextBoxWijzigCommentaar.Text = "";
            numericUpDownWijzigHoeveelheid.Value = _CurrentSelectedOrderDetail.quantity;
            richTextBoxWijzigCommentaar.Text = _CurrentSelectedOrderDetail.comment;
        }

        private void editorderdetail()
        {
            _CurrentSelectedOrderDetail.quantity = (int)numericUpDownWijzigHoeveelheid.Value;
            _CurrentSelectedOrderDetail.comment = richTextBoxWijzigCommentaar.Text;
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
            panelMenuItemOptions.Hide();
        }

        private void buttonVoorgerechtLunch_Click(object sender, EventArgs e)
        {
            GetSpecificMenuItemsList(1, 1);
            FillMenuOverviewList();
            panelMenuItemOptions.Hide();
        }

        private void buttonTussengerechtDiner_Click(object sender, EventArgs e)
        {
            GetSpecificMenuItemsList(2, 5);
            FillMenuOverviewList();
            panelMenuItemOptions.Hide();
        }

        private void buttonHoofdgerechtLunch_Click(object sender, EventArgs e)
        {
            GetSpecificMenuItemsList(1, 2);
            FillMenuOverviewList();
            panelMenuItemOptions.Hide();
        }

        private void buttonNagerechtLunch_Click(object sender, EventArgs e)
        {
            GetSpecificMenuItemsList(1, 3);
            FillMenuOverviewList();
            panelMenuItemOptions.Hide();
        }

        private void buttonVoorgerechtDiner_Click(object sender, EventArgs e)
        {
            GetSpecificMenuItemsList(2, 4);
            FillMenuOverviewList();
            panelMenuItemOptions.Hide();
        }

        private void buttonHoofdgerechtDiner_Click(object sender, EventArgs e)
        {
            GetSpecificMenuItemsList(2, 6);
            FillMenuOverviewList();
            panelMenuItemOptions.Hide();
        }

        private void buttonNagerechtDiner_Click(object sender, EventArgs e)
        {
            GetSpecificMenuItemsList(2, 7);
            FillMenuOverviewList();
            panelMenuItemOptions.Hide();
        }



        private void buttonFrisdranken_Click(object sender, EventArgs e)
        {
            GetSpecificMenuItemsList(3, 8);
            FillMenuOverviewList();
            panelMenuItemOptions.Hide();
        }

        private void buttonBieren_Click(object sender, EventArgs e)
        {
            GetSpecificMenuItemsList(3, 9);
            FillMenuOverviewList();
            panelMenuItemOptions.Hide();
        }

        private void buttonWijnen_Click(object sender, EventArgs e)
        {
            GetSpecificMenuItemsList(3, 10);
            FillMenuOverviewList();
            panelMenuItemOptions.Hide();
        }

        private void buttonGedistilleerdeDranken_Click(object sender, EventArgs e)
        {
            GetSpecificMenuItemsList(3, 11);
            FillMenuOverviewList();
            panelMenuItemOptions.Hide();
        }

        private void buttonWarmeDranken_Click(object sender, EventArgs e)
        {
            GetSpecificMenuItemsList(3, 12);
            FillMenuOverviewList();
            panelMenuItemOptions.Hide();
        }

        private void buttonAnnuleren_Click(object sender, EventArgs e)
        {
            panelMenuItemOptions.Hide();
        }

        private void buttonToevoegen_Click(object sender, EventArgs e)
        {
            CreateOrderDetail();
            panelMenuItemOptions.Hide();
        }

        private void buttonBestelVerwijder_Click(object sender, EventArgs e)
        {

            _CurrentOrderList.Remove(_CurrentOrderList[listViewCurrentOrderList.SelectedIndices[0]]);
            FillCurrentOrderListOverview();
        }

        private void buttonBestelBewerk_Click(object sender, EventArgs e)
        {
            panelWijzigOrder.Show();
            FillEditForm();
        }

        private void buttonWijzigOrder_Click(object sender, EventArgs e)
        {
            editorderdetail();
            FillCurrentOrderListOverview();
            panelWijzigOrder.Hide();
        }

        private void buttonAnnuleerWijzig_Click(object sender, EventArgs e)
        {
            panelWijzigOrder.Hide();
        }

        private void buttonBestelOrder_Click(object sender, EventArgs e)
        {

        }





        // ---------------------
    }
}
