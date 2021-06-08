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
        private List<OrderDetail> _ListOfOrders;
        OrderDetail orderDetail = new OrderDetail();
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

        public KeukenBarOverzicht()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            FillBarOpenOrderList();
            FillListview();
        }
        private void FillBarOpenOrderList()
        {
            // fill the the order list with open/bestelde orders
            ChapooLogic.OrderDetail_Service orderDetail_Service = new ChapooLogic.OrderDetail_Service();
            _ListOfOrders = orderDetail_Service.DB_Get_All_Orders_By_MenuName_And_OrderStatus("Dranken", "Besteld");
        }
        private void FillListview()
        {
            // fill the the order list with open/bestelde orders
            Listview_Bar_OpenOrder.Items.Clear();
            foreach (ChapooModel.OrderDetail order in _ListOfOrders)
            {
                Listview_Bar_OpenOrder.Items.Add(new ListViewItem(new string[] { $"{order.order_ID}", $"{order.item.item_Name}", $"{order.quantity}", $"{order.orderStatus.ToString()}" }));
            }
        }
        private void Fillbarfinishedlist()
        {
            // fill the the order list with finished/gereed orders
            ChapooLogic.OrderDetail_Service orderDetail_Service = new ChapooLogic.OrderDetail_Service();
            _ListOfOrders = orderDetail_Service.DB_Get_All_Orders_By_MenuName_And_OrderStatus("Dranken", "Besteld");
        }
        private void Fillfinishedlistview()
        {
            // fill the the order list with finished/gereed orders
            Listview_Bar_OpenOrder.Items.Clear();
            foreach (ChapooModel.OrderDetail order in _ListOfOrders)
            {
                Listview_Bar_OpenOrder.Items.Add(new ListViewItem(new string[] { $"{order.order_ID}", $"{order.item.item_Name}", $"{order.quantity}", $"{order.orderStatus.ToString()}" }));
            }
        }

        private void ShowPanels(string PanelName)
        {
            switch (PanelName)
            {
                case "BarOverzicht":

                    pnl_Baroverzicht.Show();
                    
                    break;
                case "Keukenoverzicht":

                    pnl_Baroverzicht.Hide();

                    break;
            }
        }
        // Button area
        private void BtnAfmelden_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Btn_BarOverzicht_Click_1(object sender, EventArgs e)
        {
            ShowPanels("BarOverzicht");
        }

        private void Btn_KeukenOverzicht_Click_1(object sender, EventArgs e)
        {
            ShowPanels("Keukenoverzicht");
        }

        private void btn_Gereed_Click(object sender, EventArgs e)
        {

        }
        // ---------------------
    }
}
