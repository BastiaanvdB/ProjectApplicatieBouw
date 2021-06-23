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
using ChapooLogic;

namespace ChapooUI
{
    public partial class KeukenBarOverzicht : Form
    {
        //List of bar_orders_finished
        private List<OrderDetail> NewOrders;
        
        //object for storing the curront order
        private OrderDetail SelectedOrder;

        private OrderDetail_Service orderDetail_Service;

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

        public KeukenBarOverzicht(Employee currentEmployee, Dashboard dashboard)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            _CurrentEmployee = currentEmployee;
            _Dashboard = dashboard;
            NewOrders = new List<OrderDetail>();
            orderDetail_Service = new OrderDetail_Service();

            //SetCorrectSettingForUser();
            CurrentUserProfile();
            System.Windows.Forms.Timer timerBar = new System.Windows.Forms.Timer();
            timerBar.Interval = 30000;//30 seconds
            timerBar.Tick += new System.EventHandler(timerBar_Tick);
            timerBar.Start();
        }

        // auto timer refresh
        private void timerBar_Tick(object sender, EventArgs e)
        {
            FillAndDisplay();
        }

        private void CurrentUserProfile()
        {
            UsernameLabel.Text = _CurrentEmployee.Name;
            UserFunctieLabel.Text = _CurrentEmployee.Position.ToString();
            BtnGereed.Enabled = false;
            if (_CurrentEmployee.Position == Position.Kok)
            {
                lbloverzicht.Text = "Keukenoverzicht";
            }
            else if(_CurrentEmployee.Position == Position.Bardienst)
            {
                lbloverzicht.Text = "Baroverzicht";
            }
            FillAndDisplay();
        }

        private void FillAndDisplay()
        {
            FillList();
            FillListview();
        }

        private void FillList()
        {
            if (_CurrentEmployee.Position == Position.Kok)
            {
                NewOrders = orderDetail_Service.DB_Get_All_Orders_By_MenuName_And_OrderStatus_OrderTime("Lunch", "Diner", "Besteld");
            }
            else if (_CurrentEmployee.Position == Position.Bardienst)
            {
                NewOrders = orderDetail_Service.DB_Get_All_Orders_By_MenuName_And_OrderStatus_OrderTime("Dranken", "", "Besteld");
            }
        }

        private void FillListview()
        {
            listViewNewOrders.Items.Clear();
            foreach(OrderDetail order in NewOrders)
            {
                listViewNewOrders.Items.Add(new ListViewItem(new string[] { $"{order.Table_ID}", $"{order.Item.Item_Name}", $"{order.Quantity}", $"{order.Comment}", $"{order.Ordered_DateTime}" }));
            }
        }

        private void listViewNewOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewNewOrders.SelectedItems.Count != 0)
            {
                BtnGereed.Enabled = true;
                SelectedOrder = NewOrders[listViewNewOrders.SelectedIndices[0]];
            }
            else
            {
                BtnGereed.Enabled = false;
                SelectedOrder = null;
            }
        }

        private void UpdateSelectedOrder()
        {
            SelectedOrder.OrderStatus = OrderStatus.Afhalen;
            SelectedOrder.Finished_DateTime = DateTime.Now;
            orderDetail_Service.DB_Update_OrderStatus(SelectedOrder);
        }

        // Button area
        private void BtnAfmelden_Click(object sender, EventArgs e)
        {
            _Dashboard.Show();
            this.Close();
        }

        private void BtnGereed_Click(object sender, EventArgs e)
        {
            if (listViewNewOrders.SelectedItems.Count != 0)
            {
                UpdateSelectedOrder();
                FillAndDisplay();
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            FillAndDisplay();
        }

        // ---------------------
    }
}
