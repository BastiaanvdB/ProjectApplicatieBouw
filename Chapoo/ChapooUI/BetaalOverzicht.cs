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
        private Order _currentOrder;
        private List<Order> _ListOfOrders;
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

        public BetaalOverzicht(Employee currentEmployee, Dashboard dashboard)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            _currentOrder = new Order();
            _ListOfOrders = new List<Order>();
            _CurrentEmployee = currentEmployee;
            _Dashboard = dashboard;
            AfrekenenButton.Enabled = false;
            numericUpDownFooi.Enabled = false;
            RadioContant.Enabled = false;
            radioCreditcard.Enabled = false;
            radioPinpas.Enabled = false;
            buttonOpmerking.Enabled = false;
            TextBoxOpmerking.Clear();
            panelOpmerking.Hide();
            FillBillList();
            FillListview();
            CurrentUserProfile();
        }

        private void CurrentUserProfile()
        {
            UsernameLabel.Text = _CurrentEmployee.Name;
            UserFunctieLabel.Text = _CurrentEmployee.Position.ToString();
        }

        private void FillBillList()
        {
            // fill the billList with unpaid bills
            ChapooLogic.Order_Service OrderService = new ChapooLogic.Order_Service();
            _ListOfOrders = OrderService.DB_Get_All_Unpaid_Orders();
        }

        private void FillListview()
        {
            // fill listview with unpaid bills
            AfrekeninglistView.Items.Clear();
            foreach (ChapooModel.Order bill in _ListOfOrders)
            {
                AfrekeninglistView.Items.Add(new ListViewItem(new string[] { $"{bill.Table.Table_ID}", $"{bill.order_ID}", $"{bill.TotalPrice.ToString("€ 0.00")}", $"{bill.Paystatus.ToString()}" }));
            }
        }

        private void BtnTerug_Click(object sender, EventArgs e)
        {
            this.Close();
            //BillDetails.clo
            _Dashboard.Show();
        }

        private void AfrekeninglistView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AfrekeninglistView.SelectedItems.Count is not 0)
            {
                _currentOrder = _ListOfOrders[AfrekeninglistView.SelectedIndices[0]];
                BillDetails billDetails = new BillDetails(_currentOrder);
                billDetails.Show();
                UpdateBillPanel();
                panelOpmerking.Hide();
                AfrekenenButton.Enabled = true;
                numericUpDownFooi.Enabled = true;
                RadioContant.Enabled = true;
                radioCreditcard.Enabled = true;
                radioPinpas.Enabled = true;
                buttonOpmerking.Enabled = true;
                numericUpDownFooi.Value = 0;
            }
            else
            {
                panelOpmerking.Hide();
                _currentOrder = null;
                AfrekenenButton.Enabled = false;
                numericUpDownFooi.Enabled = false;
                RadioContant.Enabled = false;
                radioCreditcard.Enabled = false;
                radioPinpas.Enabled = false;
                buttonOpmerking.Enabled = false;
                TextBoxOpmerking.Clear();
                numericUpDownFooi.Value = 0;
                labelBrutoInput.Text = "....";
                labelBTWinput.Text = "....";
                labelNettoinput.Text = "....";
                labelTotaalprijsoutput.Text = "....";
            }
        }

        private void AfrekenenButton_Click(object sender, EventArgs e)
        {
            CreatePayment();
        }

        private void UpdateBillPanel()
        {
            labelBrutoInput.Text = (_currentOrder.TotalPrice - _currentOrder.TotalVAT).ToString("€ 0.00");
            labelBTWinput.Text = _currentOrder.TotalVAT.ToString("€ 0.00");
            labelNettoinput.Text = (_currentOrder.TotalPrice).ToString("€ 0.00");
            ShowTotalPrice();
        }

        private void numericUpDownFooi_ValueChanged(object sender, EventArgs e)
        {
            ShowTotalPrice();
        }

        private void ShowTotalPrice()
        {
            labelTotaalprijsoutput.Text = (_currentOrder.TotalPrice + numericUpDownFooi.Value).ToString("€ 0.00");
        }

        private void CreatePayment()
        {

            if ((RadioContant.Checked is true) | (radioCreditcard.Checked is true) | (radioPinpas.Checked is true))
            {
                PayMethod paymethod;
                if (RadioContant.Checked is true)
                {
                    paymethod = PayMethod.Contant;
                }
                else if (radioPinpas.Checked is true)
                {
                    paymethod = PayMethod.Pinpas;
                }
                else
                {
                    paymethod = PayMethod.Creditcard;
                }

                ChapooLogic.Payment_Service payment_Service = new Payment_Service();
                Payment payment = new Payment()
                {
                    Order = _currentOrder,
                    Table = _currentOrder.Table,
                    PayStatus = PayStatus.Betaald,
                    PayMethod = paymethod,
                    Comment = TextBoxOpmerking.Text,
                    Employee = _CurrentEmployee,
                    TotalPrice = _currentOrder.TotalPrice + numericUpDownFooi.Value,
                    Tip = numericUpDownFooi.Value,
                    TotalVAT = _currentOrder.TotalVAT,
                    Payment_DateTime = DateTime.Now
                };
                payment_Service.DB_Create_New_Payment(payment);
                FillBillList();
                FillListview();
                MessageBox.Show($"Betaling van tafelnummer {_currentOrder.Table.Table_ID} is afgerekend", "Chapoo afrekenen",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Selecteer één betaalmethode", "Chapoo afrekenen",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonOpmerking_Click(object sender, EventArgs e)
        {
            panelOpmerking.Show();
        }

        private void buttonToevoegenOpmerking_Click(object sender, EventArgs e)
        {
            panelOpmerking.Hide();
        }
    }
}
