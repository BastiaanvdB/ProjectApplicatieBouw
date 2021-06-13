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
        }

        private void FillBill()
        {
         
            listViewBonDetails.Items.Clear();
            foreach (ChapooModel.OrderDetail orderItem in _bill.OrderDetails)
            {
                listViewBonDetails.Items.Add(new ListViewItem(new string[] { $"{orderItem.item.item_Name}", $"{orderItem.quantity}", $"{orderItem.ordered_DateTime}", $"{orderItem.item.item_Price.ToString("€ 0.00")}", $"{(orderItem.item.item_Price * orderItem.quantity).ToString("€ 0.00")}" }));
                LabelBonInputTafel.Text = _bill.Table.table_ID.ToString();
                this.Text = $"Bon tafel {_bill.Table.table_ID}";
            }
        }

        private void BonSluitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
