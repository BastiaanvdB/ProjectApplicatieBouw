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
        private Order _currentBill;
        private List<Order> _ListOfBills;

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
            _currentBill = new Order();
            _ListOfBills = new List<Order>();
            AfrekenenButton.Enabled = false;
            numericUpDownFooi.Enabled = false;
            checkBoxContant.Enabled = false;
            checkBoxCreditcard.Enabled = false;
            checkBoxPinpas.Enabled = false;
            buttonOpmerking.Enabled = false;
            TextBoxOpmerking.Clear();
            panelOpmerking.Hide();
            FillBillList();
            FillListview();
        }

        private void FillBillList()
        {
            // fill the billList with unpaid bills
            ChapooLogic.Order_Service billService = new ChapooLogic.Order_Service();
            _ListOfBills = billService.DB_Get_All_Unpaid_Bills();
            
        }

        private void FillListview()
        {
            // fill listview with unpaid bills
            AfrekeninglistView.Items.Clear();
            foreach (ChapooModel.Order bill in _ListOfBills)
            {
                AfrekeninglistView.Items.Add(new ListViewItem(new string[] { $"{bill.Table.table_ID}", $"{bill.order_ID}", $"{bill.totalPrice.ToString("€ 0.00")}", $"{bill.paystatus.ToString()}" }));
            }
        }

        private void BtnTerug_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AfrekeninglistView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AfrekeninglistView.SelectedItems.Count is not 0)
            {
                _currentBill = _ListOfBills[AfrekeninglistView.SelectedIndices[0]];
                BillDetails billDetails = new BillDetails(_currentBill);
                billDetails.Show();
                UpdateBillPanel();
                panelOpmerking.Hide();
                AfrekenenButton.Enabled = true;
                numericUpDownFooi.Enabled = true;
                checkBoxContant.Enabled = true;
                checkBoxCreditcard.Enabled = true;
                checkBoxPinpas.Enabled = true;
                buttonOpmerking.Enabled = true;
                numericUpDownFooi.Value = 0;
            }
            else
            {
                panelOpmerking.Hide();
                _currentBill = null;
                AfrekenenButton.Enabled = false;
                numericUpDownFooi.Enabled = false;
                checkBoxContant.Enabled = false;
                checkBoxCreditcard.Enabled = false;
                checkBoxPinpas.Enabled = false;
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
            labelBrutoInput.Text = (_currentBill.totalPrice - _currentBill.totalVAT).ToString("€ 0.00");
            labelBTWinput.Text = _currentBill.totalVAT.ToString("€ 0.00");
            labelNettoinput.Text = (_currentBill.totalPrice).ToString("€ 0.00");
            ShowTotalPrice();
        }

        private void numericUpDownFooi_ValueChanged(object sender, EventArgs e)
        {
            ShowTotalPrice();
        }

        private void ShowTotalPrice()
        {
            labelTotaalprijsoutput.Text = (_currentBill.totalPrice + numericUpDownFooi.Value).ToString("€ 0.00");
        }

        private void CreatePayment()
        {

            if ((checkBoxContant.Checked is true) | (checkBoxCreditcard.Checked is true) | (checkBoxPinpas.Checked is true))
            {
                PayMethod paymethod;
                if (checkBoxContant.Checked is true)
                {
                    paymethod = PayMethod.Contant;
                }
                else if (checkBoxPinpas.Checked is true)
                {
                    paymethod = PayMethod.Pinpas;
                }
                else
                {
                    paymethod = PayMethod.Creditcard;
                }

                // tijdelijk override employee met fokke !!!!
                Employee employee = new Employee()
                {
                    employee_id = 2,
                    position = Position.Bediening,
                    name = "Fokke Modder",
                    phone = "+31035542534",
                    adres = "Haarlem",
                    pin = "0000"
                };
                // Verwijder!!!!

                ChapooLogic.Payment_Service payment_Service = new Payment_Service();
                Payment payment = new Payment()
                {
                    order = _currentBill,
                    table = _currentBill.Table,
                    payStatus = PayStatus.Betaald,
                    payMethod = paymethod,
                    comment = TextBoxOpmerking.Text,
                    employee = employee, // employee hier nog in doen !!!
                    totalPrice = _currentBill.totalPrice + numericUpDownFooi.Value,
                    tip = numericUpDownFooi.Value,
                    totalVAT = _currentBill.totalVAT,
                    payment_DateTime = DateTime.Now
                };
                payment_Service.DB_Create_New_Payment(payment);
                FillBillList();
                FillListview();
                MessageBox.Show($"Betaling van tafelnummer {_currentBill.Table.table_ID} is afgerekend", "Chapoo afrekenen",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Selecteer één betaalmethode", "Chapoo afrekenen",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void checkBoxPinpas_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxContant.Checked = false;
            checkBoxCreditcard.Checked = false;
        }

        private void checkBoxCreditcard_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxContant.Checked = false;
            checkBoxPinpas.Checked = false;
        }

        private void checkBoxContant_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxPinpas.Checked = false;
            checkBoxCreditcard.Checked = false;
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
