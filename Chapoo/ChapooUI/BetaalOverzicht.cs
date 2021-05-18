using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChapooModel;
using ChapooLogic;

namespace ChapooUI
{
    public partial class BetaalOverzicht : Form
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

        public BetaalOverzicht()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            FillBillList();
        }

        private void FillBillList()
        {
            AfrekeninglistView.Items.Clear();

            // fill the students listview within the students panel with a list of students
            ChapooLogic.Bill_Service billService = new ChapooLogic.Bill_Service();
            List<Bill> billList = billService.DB_Get_All_Unpaid_Bills();
            AfrekeninglistView.View = View.Details;
            foreach (ChapooModel.Bill bill in billList)
            {
                AfrekeninglistView.Items.Add(new ListViewItem(new string[] { $"{bill.tableNumber}", $"{bill.orderNumber}", $"{bill.totalPrice.ToString("€ 0.00")}", $"{bill.payStatus.ToString()}"}));
            }



        }


        private void BtnTerug_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
