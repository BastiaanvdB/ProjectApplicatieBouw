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
using ChapooLogic;
using ChapooModel;
using ChapooUI.Properties;

namespace ChapooUI
{
    public partial class Dashboard : Form
    {
        private Employee _CurrentEmployee;
        private OrderDetail_Service orderDetail_Service;
        private List<OrderDetail> PickupOrders;
        private List<OrderDetail> DoneOrders;
        private OrderDetail SelectedOrderDetail;

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
            string[] firstname = _CurrentEmployee.Name.Split(' ');
            labelWelkom.Text = $"Welkom {firstname[0]}";
            buttonOpgediend.Enabled = false;
            CorrectMenuForUser();
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
                    panelOber.Hide();
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
                    panelOber.Hide();
                    // disabled buttons
                    BtnAfrekenen.Hide();
                    BtnTafelOverzicht.Hide();
                    BtnBestellen.Hide();
                    BtnManagement.Hide();
                    BtnBestellen.Hide();
                    break;
                case Position.Leidinggevende:
                    // enabled buttons
                    panelOber.Hide();
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
                    orderDetail_Service = new OrderDetail_Service();
                    PickupOrders = new List<OrderDetail>();
                    DoneOrders = new List<OrderDetail>();
                    RefreshLists();

                    // disabled buttons
                    BtnBarOverzicht.Hide();
                    BtnManagement.Hide();
                    panelOber.Show();

                    System.Windows.Forms.Timer timerOber = new System.Windows.Forms.Timer();
                    timerOber.Interval = 20000;//20 seconds
                    timerOber.Tick += new System.EventHandler(timerOber_Tick);
                    timerOber.Start();
                    break;
            }
        }

        private void timerOber_Tick(object sender, EventArgs e)
        {
            RefreshLists();
        }

        // menu panel area
        private void MenuPanel(string menuItem)
        {
            switch(menuItem)
            {
                case "Betaaloverzicht":
                    BetaalOverzicht betaalOverzicht = new BetaalOverzicht(_CurrentEmployee, this);
                    timerOber.Stop();
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
                    BestelOverzicht bestelOverzicht = new BestelOverzicht(_CurrentEmployee, this);
                    timerOber.Stop();
                    bestelOverzicht.Show();
                    this.Hide();
                    break;
                case "TafelOverzicht":
                    TafelOverzicht tafelOverzicht = new TafelOverzicht(_CurrentEmployee, this);
                    timerOber.Stop();
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

        private void RefreshLists()
        {
            LoadPickupOrdersList();
            LoadDoneOrdersList();
            DisplayPickupOrders();
            DisplayDoneOrders();
        }

        private void LoadPickupOrdersList()
        {
            PickupOrders = orderDetail_Service.DB_Get_All_OrderDetails_On_Specific_OrderStatus("Afhalen");
        }

        private void LoadDoneOrdersList()
        {
            DoneOrders = orderDetail_Service.DB_Get_All_OrderDetails_On_Specific_OrderStatus("Opgediend");
        }

        private void DisplayPickupOrders()
        {
            listViewPickup.Items.Clear();
            foreach (ChapooModel.OrderDetail orderItem in PickupOrders)
            {
                listViewPickup.Items.Add(new ListViewItem(new string[] { $"{orderItem.Table_ID}", $"{orderItem.Item.Item_Name}", $"{orderItem.Quantity}"}));
            }
        }

        private void DisplayDoneOrders()
        {
            listViewDone.Items.Clear();
            foreach (ChapooModel.OrderDetail orderItem in DoneOrders)
            {
                listViewDone.Items.Add(new ListViewItem(new string[] { $"{orderItem.Table_ID}", $"{orderItem.Item.Item_Name}", $"{orderItem.Quantity}", $"{orderItem.Finished_DateTime}" }));
            }

        }

        private void UpdateSelectedOrder()
        {
            SelectedOrderDetail.OrderStatus = OrderStatus.Opgediend;
            orderDetail_Service.DB_Update_OrderDetails(SelectedOrderDetail);
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

        private void buttonOpgediend_Click(object sender, EventArgs e)
        {

            UpdateSelectedOrder();
            RefreshLists();
            buttonOpgediend.Enabled = false;
        }

        private void listViewPickup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewPickup.SelectedItems.Count != 0)
            {
                buttonOpgediend.Enabled = true;
                SelectedOrderDetail = PickupOrders[listViewPickup.SelectedIndices[0]];
            }
            else
            {

                buttonOpgediend.Enabled = false;

            }
        }
        // ---------------------
    }
}
