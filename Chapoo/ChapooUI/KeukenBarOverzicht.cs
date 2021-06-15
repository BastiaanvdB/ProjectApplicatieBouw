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
    public partial class KeukenBarOverzicht : Form
    {
        //List of bar_orders_finished
        private List<OrderDetail> _ListOfFinnishedOrderDetails;
        //List of bar orders_open
        private List<OrderDetail> _ListOfNewOrderDetails;
        //List of Open Kitchenorders
        private List<OrderDetail> _ListOfNewkitchenOrderDetails;
        //List of finished kitchen order
        private List<OrderDetail> _ListOfFinnishedkitchenOrderDetails;
        //object for storing the curront order
        private OrderDetail _CurrentOrderDetail;

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
            _CurrentOrderDetail = new OrderDetail();
            btn_Gereed.Enabled = false;
            //UpdateAllLists();
            CurrentUserProfile();
            System.Windows.Forms.Timer timerBar = new System.Windows.Forms.Timer();
            timerBar.Interval = 20000;//20 seconds
            timerBar.Tick += new System.EventHandler(timerBar_Tick);
            timerBar.Start();
        }


        // auto timer refresh
        private void timerBar_Tick(object sender, EventArgs e)
        {
            if (_CurrentEmployee.Position == Position.Kok)
            {
                UpdateKicthenlists();
            }
            else if (_CurrentEmployee.Position == Position.Bardienst)
            {
                UpdateAllLists();
            }
        }


        private void CurrentUserProfile()
        {
            UsernameLabel.Text = _CurrentEmployee.Name;
            UserFunctieLabel.Text = _CurrentEmployee.Position.ToString();

            if(_CurrentEmployee.Position == Position.Kok)
            {
                Pnl_keukenoverzicht.Show();
                pnl_Baroverzicht.Hide();
            }
            else if(_CurrentEmployee.Position == Position.Bardienst)
            {
                Pnl_keukenoverzicht.Hide();
                pnl_Baroverzicht.Show();
            }

        }

        //method for updating all the listview
        private void UpdateAllLists()
        {
            FillBarOpenOrderList();
            Fillbarfinishedlist();
            FillListview();
            Fillfinishedlistview();
        }
        private void UpdateKicthenlists()
        {
            FillKeukenOpenOrderList();
            FillKeukenOpgediendOrderList();
            FillKeukenOpenListview();
            FillKeukenOpgediendListview();
        }

        //...
        //Baroverzicht
        //..
        //method for filling the list for the openorders
        private void FillBarOpenOrderList()
        {
            // fill the the order list with open/bestelde orders
            ChapooLogic.OrderDetail_Service orderDetail_Service = new ChapooLogic.OrderDetail_Service();
            _ListOfNewOrderDetails = orderDetail_Service.DB_Get_All_Orders_By_MenuName_And_OrderStatus("Dranken", "Besteld");
        }


        //filling the bar list view with open/bestelde orders
        private void FillListview()
        {
            // fill the the order list with open/bestelde orders
            Listview_Bar_OpenOrder.Items.Clear();
            foreach (ChapooModel.OrderDetail orderdetail in _ListOfNewOrderDetails)
            {
                Listview_Bar_OpenOrder.Items.Add(new ListViewItem(new string[] { $"{orderdetail.Table_ID}", $"{orderdetail.Item.Item_Name}", $"{orderdetail.Quantity}", $"{orderdetail.OrderStatus.ToString()}", $"{orderdetail.Ordered_DateTime}" }));
            }
        }


        //Method for filling the list with finished/opgediend orders
        private void Fillbarfinishedlist()
        {
            // fill the the order list with finished/gereed orders
            ChapooLogic.OrderDetail_Service orderDetail_Service = new ChapooLogic.OrderDetail_Service();
            _ListOfFinnishedOrderDetails = orderDetail_Service.DB_Get_All_Orders_By_MenuName_And_OrderStatus("Dranken", "Opgediend");
        }

        //Mehtod for filling the bar listview with the finished/Opgediend orders
        private void Fillfinishedlistview()
        {
            // fill the the order list with finished/opgediend orders
            Listview_Order_finished.Items.Clear();
            foreach (ChapooModel.OrderDetail orderdetail in _ListOfFinnishedOrderDetails)
            {
                Listview_Order_finished.Items.Add(new ListViewItem(new string[] { $"{orderdetail.Table_ID}", $"{orderdetail.Item.Item_Name}", $"{orderdetail.Quantity}", $"{orderdetail.OrderStatus.ToString()}", $"{orderdetail.Finished_DateTime}" }));
            }
        }
        
        private void Listview_Bar_OpenOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Listview_Bar_OpenOrder.SelectedItems.Count is not 0)
            {
                _CurrentOrderDetail = _ListOfNewOrderDetails[Listview_Bar_OpenOrder.SelectedIndices[0]];
                btn_Gereed.Enabled = true;
            }
            else
            {
                _CurrentOrderDetail = null;
                btn_Gereed.Enabled = false;
            }
        }
        //...
        //Einde Baroverzicht
        //...
        //...
        //Keukenoverzicht
        //...
        private void FillKeukenOpenOrderList()
        {
            // fill the the order list with open/bestelde orders
            ChapooLogic.OrderDetail_Service orderDetail_Service = new ChapooLogic.OrderDetail_Service();
            _ListOfNewkitchenOrderDetails = new List<OrderDetail>();
            if ((RBtn_Diner.Checked == true) && (RBtn_Lunch.Checked == false))
            {
                _ListOfNewkitchenOrderDetails = orderDetail_Service.DB_Get_All_Orders_By_MenuName_And_OrderStatus("Diner", "Besteld");
            }
            else if ((RBtn_Diner.Checked == false) && (RBtn_Lunch.Checked == true))
            {
                _ListOfNewkitchenOrderDetails = orderDetail_Service.DB_Get_All_Orders_By_MenuName_And_OrderStatus("Lunch", "Besteld");
            }
        }
        //filling the bar list view with open/bestelde orders
        private void FillKeukenOpenListview()
        {
            // fill the the order list with open/bestelde orders
            listView_Keuken_besteld.Items.Clear();
            foreach (ChapooModel.OrderDetail orderdetail in _ListOfNewkitchenOrderDetails)
            {
                listView_Keuken_besteld.Items.Add(new ListViewItem(new string[] { $"{orderdetail.Table_ID}", $"{orderdetail.Item.Item_Name}", $"{orderdetail.Quantity}", $"{orderdetail.OrderStatus.ToString()}", $"{orderdetail.Ordered_DateTime}" }));
            }
        }
        private void FillKeukenOpgediendOrderList()
        {
            // fill the the order list with open/bestelde orders
            ChapooLogic.OrderDetail_Service orderDetail_Service = new ChapooLogic.OrderDetail_Service();
            _ListOfFinnishedkitchenOrderDetails = new List<OrderDetail>();
            if ((RBtn_Diner.Checked == true) && (RBtn_Lunch.Checked == false))
            {
                _ListOfFinnishedkitchenOrderDetails = orderDetail_Service.DB_Get_All_Orders_By_MenuName_And_OrderStatus("Diner", "Opgediend");
            }
            else if ((RBtn_Diner.Checked == false) && (RBtn_Lunch.Checked == true))
            {
                _ListOfFinnishedkitchenOrderDetails = orderDetail_Service.DB_Get_All_Orders_By_MenuName_And_OrderStatus("Lunch", "Opgediend");
            }
        }
        //filling the bar list view with open/bestelde orders
        private void FillKeukenOpgediendListview()
        {
            // fill the the order list with open/bestelde orders
            listView_keuken_Opgediend.Items.Clear();
            foreach (ChapooModel.OrderDetail orderdetail in _ListOfFinnishedkitchenOrderDetails)
            {
                listView_keuken_Opgediend.Items.Add(new ListViewItem(new string[] { $"{orderdetail.Table_ID}", $"{orderdetail.Item.Item_Name}", $"{orderdetail.Quantity}", $"{orderdetail.OrderStatus.ToString()}", $"{orderdetail.Ordered_DateTime}" }));
            }
        }
        private void listView_Keuken_besteld_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_Keuken_besteld.SelectedItems.Count is not 0)
            {
                _CurrentOrderDetail = _ListOfNewkitchenOrderDetails[listView_Keuken_besteld.SelectedIndices[0]];
                btn_Gereed.Enabled = true;
            }
            else
            {
                _CurrentOrderDetail = null;
                btn_Gereed.Enabled = false;
            }
        }
        //...
        //Einde Keukenoverzicht
        //...
        public void UpdateCurrentOrder()
        {
            ChapooLogic.OrderDetail_Service orderDetail_Service = new ChapooLogic.OrderDetail_Service();
            _CurrentOrderDetail.OrderStatus = OrderStatus.Opgediend;
            _CurrentOrderDetail.Finished_DateTime = DateTime.Now;

            orderDetail_Service.DB_Update_OrderDetails(_CurrentOrderDetail);
        }


        // Button area
        private void BtnAfmelden_Click(object sender, EventArgs e)
        {
            _Dashboard.Show();
            this.Close();
        }

        private void btn_Gereed_Click(object sender, EventArgs e)
        {
            UpdateCurrentOrder();
            UpdateAllLists();
        }

        private void Btn_update_bar_Click(object sender, EventArgs e)
        {
            UpdateAllLists();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Update_keuken_Click(object sender, EventArgs e)
        {
            UpdateKicthenlists();
        }

        private void Btn_Keuken_gereed_Click(object sender, EventArgs e)
        {
            UpdateCurrentOrder();
            UpdateKicthenlists();
        }

        private void RBtn_Lunch_CheckedChanged(object sender, EventArgs e)
        {
            UpdateKicthenlists();
        }

        private void RBtn_Diner_CheckedChanged(object sender, EventArgs e)
        {
            UpdateKicthenlists();
        }




        // ---------------------
    }
}
