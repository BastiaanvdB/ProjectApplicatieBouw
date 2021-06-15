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

namespace ChapooUI
{
    public partial class BillDetails : Form
    {
        private Order _bill;


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

        public BillDetails(Order bill)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            _bill = bill;
            FillBill();

            labelBrutoInput.Text = $"{(_bill.TotalPrice - _bill.TotalVAT).ToString("€ 0.00")}";
            labelBTWinput.Text = $"{(_bill.TotalVAT).ToString("€ 0.00")}";
            labelTotaalPrijsInput.Text = $"{(_bill.TotalPrice).ToString("€ 0.00")}";
        }

        private OrderDetail CreateTempOrderdetail(OrderDetail order)
        {
            OrderDetail TempOrder = new OrderDetail()
            {
                OrderDetails_ID = order.OrderDetails_ID,
                Item = order.Item,
                Order_ID = order.Order_ID,
                Quantity = order.Quantity,
                Comment = order.Comment,
                Employee = order.Employee,
                OrderStatus = order.OrderStatus,
                Ordered_DateTime = order.Ordered_DateTime,
                Preparing_DateTime = order.Preparing_DateTime,
                Finished_DateTime = order.Finished_DateTime
            };
            return TempOrder;
        }

        private void FillBill()
        {
            List<OrderDetail> templist = new List<OrderDetail>();

            foreach (OrderDetail order in _bill.OrderDetails)
            {
                if (templist.Count == 0)
                {
                    templist.Add(CreateTempOrderdetail(order));
                }
                else
                {
                    bool inList = false;
                    int i = 0;
                    for (; i <= templist.Count - 1; i++)
                    {
                        if (templist[i].Item.Item_ID == order.Item.Item_ID)
                        {
                            inList = true;
                            break;
                        }
                    }
                    if (inList)
                    {
                        templist[i].Quantity += order.Quantity;
                    }
                    else
                    {
                        
                        templist.Add(CreateTempOrderdetail(order));
                    }
                }
            }

            listViewBonDetails.Items.Clear();
            foreach (ChapooModel.OrderDetail orderItem in templist)
            {
                listViewBonDetails.Items.Add(new ListViewItem(new string[] { $"{orderItem.Item.Item_Name}", $"{orderItem.Quantity}", $"{orderItem.Item.Item_Price.ToString("€ 0.00")}", $"{(orderItem.Item.Item_Price * orderItem.Quantity).ToString("€ 0.00")}" }));
                LabelBonInputTafel.Text = _bill.Table.Table_ID.ToString();
                this.Text = $"Bon tafel {_bill.Table.Table_ID}";
            }
            templist.Clear();
        }

        private void BonSluitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
