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
using System.IO;
using System.Security.Cryptography;

namespace ChapooUI
{
    public partial class LoginForm : Form
    {
        private ChapooLogic.Employees_Service _Employees_Service;
        private string _CurrentPincode;
        private List<Employee> _EmployeeList;
        private Employee _CurrentEmployee;

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

        public LoginForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 80, 80));
            _Employees_Service = new Employees_Service();
            FillEmployeeList();
            FillComboBox();
        }

        private void FillEmployeeList()
        {
            _EmployeeList = _Employees_Service.DB_Get_Employees();
        }

        private void FillComboBox()
        {
            foreach(Employee employee in _EmployeeList)
            {
                EmployeeCombobox.Items.Add(employee.Name);
            }
            EmployeeCombobox.SelectedIndex = 0;
        }

        private void UpdatePincodeBox()
        {
            PincodeTextbox.Text = _CurrentPincode;
        }

        private void LoginCurrentEmployee()
        {
            if(_CurrentPincode == Decrypt(_CurrentEmployee.Pin))
            {
                Dashboard dashboard = new Dashboard(_CurrentEmployee);
                dashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Ingevoerde pincode incorrect!", "Chapoo login",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                _CurrentPincode = "";
                UpdatePincodeBox();
            }
        }

        private static string Decrypt(string EncryptPincode)
        {
            string EncryptionKey = "lifefindsaway";
            EncryptPincode = EncryptPincode.Replace(" ", "+");
            try
            {
                byte[] cipherBytes = Convert.FromBase64String(EncryptPincode);
                using (Aes encryptor = Aes.Create())
                {
                    Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                    encryptor.Key = pdb.GetBytes(32);
                    encryptor.IV = pdb.GetBytes(16);
                    using (MemoryStream ms = new MemoryStream())
                    {
                        using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                        {
                            cs.Write(cipherBytes, 0, cipherBytes.Length);
                            cs.Close();
                        }
                        EncryptPincode = Encoding.Unicode.GetString(ms.ToArray());
                    }
                }
            }
            catch (Exception ex)
            {

            }

            return EncryptPincode;
        }

        private void EmployeeCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_EmployeeList.Count > 0)
            {
                _CurrentEmployee = _EmployeeList[EmployeeCombobox.SelectedIndex];
                _CurrentPincode = "";
                UpdatePincodeBox();
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonNumber1_Click(object sender, EventArgs e)
        {
            _CurrentPincode += 1;
            UpdatePincodeBox();
        }

        private void buttonNumber2_Click(object sender, EventArgs e)
        {
            _CurrentPincode += 2;
            UpdatePincodeBox();
        }

        private void buttonNumber3_Click(object sender, EventArgs e)
        {
            _CurrentPincode += 3;
            UpdatePincodeBox();
        }

        private void buttonNumber4_Click(object sender, EventArgs e)
        {
            _CurrentPincode += 4;
            UpdatePincodeBox();
        }

        private void buttonNumber5_Click(object sender, EventArgs e)
        {
            _CurrentPincode += 5;
            UpdatePincodeBox();
        }

        private void buttonNumber6_Click(object sender, EventArgs e)
        {
            _CurrentPincode += 6;
            UpdatePincodeBox();
        }

        private void buttonNumber7_Click(object sender, EventArgs e)
        {
            _CurrentPincode += 7;
            UpdatePincodeBox();
        }

        private void buttonNumber8_Click(object sender, EventArgs e)
        {
            _CurrentPincode += 8;
            UpdatePincodeBox();
        }

        private void buttonNumber9_Click(object sender, EventArgs e)
        {
            _CurrentPincode += 9;
            UpdatePincodeBox();
        }

        private void buttonNumber0_Click(object sender, EventArgs e)
        {
            _CurrentPincode += 0;
            UpdatePincodeBox();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (_CurrentPincode.Length > 0)
            {
                _CurrentPincode = _CurrentPincode.Remove(_CurrentPincode.Length - 1);
                UpdatePincodeBox();
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            LoginCurrentEmployee();
        }
    }
}
