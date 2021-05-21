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

        public BillDetails(int ordernummer)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            FillBill(ordernummer);
        }

        private void FillBill(int ordernummer)
        {
            listViewBonDetails.Items.Clear();

            // fill the billlistview with bill details
            ChapooLogic.BillDetail_Service billDetail_Service = new ChapooLogic.BillDetail_Service();
            List<ChapooModel.BillDetail> billList = billDetail_Service.DB_Get_All_Bill_Details(ordernummer);
            listViewBonDetails.View = View.Details;
            foreach (ChapooModel.BillDetail bill in billList)
            {
                listViewBonDetails.Items.Add(new ListViewItem(new string[] { $"{bill.menuItem_Name}", $"{bill.quantity}", $"{bill.item_price.ToString("€ 0.00")}", $"{bill.totalPrice.ToString("€ 0.00")}" }));
                LabelBonInputTafel.Text = bill.table_ID.ToString();
                this.Text = $"Bon tafel {bill.table_ID}";
            }
        }

        private void BonSluitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
