using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChapooModel;

namespace ChapooUI
{
    public partial class Management : Form
    {
        private MenuItem CurrentItem;
        private List<MenuItem> StockList;
        private int CurrentMenuCode = 0;
        private ChapooLogic.Stock_Service Stock_Service;

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

        public Management(Employee currentEmployee, Dashboard dashboard)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            _CurrentEmployee = currentEmployee;
            _Dashboard = dashboard;
            panelModifySelection.Hide();
            groupBoxAlcohol.Hide();
            panelModifyControls.Hide();
            panelLunchSetting.Hide();
            panelDinerSetting.Hide();
            panelDrankSetting.Hide();
            CurrentUserProfile();
            panelPersoneelbeheer.Hide();
            panelStockManagement.Hide();
            panelFinancien.Hide();
            Stock_Service = new ChapooLogic.Stock_Service();
        }

        private void CurrentUserProfile()
        {
            UsernameLabel.Text = _CurrentEmployee.name;
            UserFunctieLabel.Text = _CurrentEmployee.position.ToString();
        }


        private void ManagementMenu(string menu)
        {
            switch(menu)
            {
                case "UserMangement":
                    panelFinancien.Hide();
                    panelPersoneelbeheer.Show();
                    panelStockManagement.Hide();
                    break;
                case "StockManagement":
                    panelFinancien.Hide();
                    panelPersoneelbeheer.Hide();
                    panelStockManagement.Show();
                    break;
                case "FinancialOverview":
                    panelFinancien.Show();
                    panelPersoneelbeheer.Hide();
                    panelStockManagement.Hide();
                    LoadfinancieelOverzichtPanel();
                    break;
            }
        }


        private void UpdateStockList()
        {
            ChapooLogic.Stock_Service stock_Service = new ChapooLogic.Stock_Service();
            StockList = stock_Service.DB_Get_Specific_Stock(CurrentMenuCode);
        }

        private void UpdateStockViewList()
        {
            listViewStockManagement.Items.Clear();
            foreach (ChapooModel.MenuItem menuItem  in StockList)
            {
                string idcheck = "ID niet nodig";

                if(menuItem.item_Stock < menuItem.item_Restock)
                {
                    DialogResult dialogResult = MessageBox.Show($"De item '{menuItem.item_Name}' raakt op, vul de voorraad aan!", "Voorraadbeheer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if(menuItem.Alcohol_Check == true)
                {
                    idcheck = "ID nodig";
                }

                listViewStockManagement.Items.Add(new ListViewItem(new string[] { $"{menuItem.MenuGroup}", $"{menuItem.item_Name}", $"{menuItem.item_Price.ToString("€ 0.00")}", $"{menuItem.item_Taxpercentage}%", $"{menuItem.item_Restock}", $"{menuItem.item_Stock}", $"{idcheck}" }));
            }
        }

        private void listViewStockManagement_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewStockManagement.SelectedItems.Count is not 0)
            {
                textBoxItemNaam.Clear();
                numericBTW.Value = 0;
                numericRestock.Value = 0;
                textBoxItemPrice.Clear();
                numericRestock.ResetText();
                numericStock.ResetText();
                CurrentItem = StockList[listViewStockManagement.SelectedIndices[0]];
                UpdateTextBoxes();
            }
            else
            {
                textBoxItemNaam.Clear();
                numericBTW.Value = 0;
                numericRestock.Value = 0;
                textBoxItemPrice.Clear();
                numericRestock.ResetText();
                numericStock.ResetText();
            }
        }

        private bool CheckAge()
        {
            if((radioButtonNeedID.Checked == true) && (radioButtonNoID.Checked == false))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private int CheckMenuGroup()
        {
            int menugroup = 0;
            switch(CurrentMenuCode)
            {
                case 1:
                    if((radioButtonLunchVoorgerecht.Checked == true) && (radioButtonLunchHoofdgerecht.Checked == false) && (radioButtonNaVoorgerecht.Checked == false))
                    {
                        menugroup = 1;
                    }
                    else if((radioButtonLunchVoorgerecht.Checked == false) && (radioButtonLunchHoofdgerecht.Checked == true) && (radioButtonNaVoorgerecht.Checked == false))
                    {
                        menugroup = 2;
                    }
                    else
                    {
                        menugroup = 3;
                    }
                    break;
                case 2:
                    if ((radioButtonDinerVoorgerecht.Checked == true) && (radioButtonDinerTussengerecht.Checked == false) && (radioButtonDinerHoofdgerecht.Checked == false) && (radioButtonDinerNagerecht.Checked == false))
                    {
                        menugroup = 4;
                    }
                    else if ((radioButtonDinerVoorgerecht.Checked == false) && (radioButtonDinerTussengerecht.Checked == true) && (radioButtonDinerHoofdgerecht.Checked == false) && (radioButtonDinerNagerecht.Checked == false))
                    {
                        menugroup = 5;
                    }
                    else if ((radioButtonDinerVoorgerecht.Checked == false) && (radioButtonDinerTussengerecht.Checked == false) && (radioButtonDinerHoofdgerecht.Checked == true) && (radioButtonDinerNagerecht.Checked == false))
                    {
                        menugroup = 6;
                    }
                    else
                    {
                        menugroup = 7;
                    }
                    break;
                case 3:
                    if((radioButtonDrankenFris.Checked == true) && (radioButtonDrankenBier.Checked == false) && (radioButtonDrankenWijn.Checked == false) && (radioButtonDrankenGedistilleerde.Checked == false) && (radioButtonDrankenWarme.Checked == false))
                    {
                        menugroup = 8;
                    }
                    else if ((radioButtonDrankenFris.Checked == false) && (radioButtonDrankenBier.Checked == true) && (radioButtonDrankenWijn.Checked == false) && (radioButtonDrankenGedistilleerde.Checked == false) && (radioButtonDrankenWarme.Checked == false))
                    {
                        menugroup = 9;
                    }
                    else if ((radioButtonDrankenFris.Checked == false) && (radioButtonDrankenBier.Checked == false) && (radioButtonDrankenWijn.Checked == true) && (radioButtonDrankenGedistilleerde.Checked == false) && (radioButtonDrankenWarme.Checked == false))
                    {
                        menugroup = 10;
                    }
                    else if ((radioButtonDrankenFris.Checked == false) && (radioButtonDrankenBier.Checked == false) && (radioButtonDrankenWijn.Checked == false) && (radioButtonDrankenGedistilleerde.Checked == true) && (radioButtonDrankenWarme.Checked == false))
                    {
                        menugroup = 11;
                    }
                    else
                    {
                        menugroup = 12;
                    }
                    break;
            }

            return menugroup;
        }

        private void UpdateTextBoxes()
        {
            textBoxItemNaam.Text = CurrentItem.item_Name;
            numericBTW.Value = CurrentItem.item_Taxpercentage;
            textBoxItemPrice.Text = CurrentItem.item_Price.ToString("€0.00");
            numericRestock.Value = CurrentItem.item_Restock;
            numericStock.Value = CurrentItem.item_Stock;

            if(CurrentItem.Alcohol_Check == true)
            {
                radioButtonNeedID.Checked = true;
                radioButtonNoID.Checked = false;
            }
            else if(CurrentItem.Alcohol_Check == false)
            {
                radioButtonNeedID.Checked = false;
                radioButtonNoID.Checked = true;
            }

            switch (CurrentItem.MenuGroup)
            {
                case "Voorgerechten":
                    if ((radioButtonLunchVoorraad.Checked == true) && (radioButtonDinerVoorraad.Checked == false))
                    {
                        radioButtonLunchVoorgerecht.Checked = true;
                        radioButtonDinerVoorgerecht.Checked = false;
                    }
                    else
                    {
                        radioButtonLunchVoorgerecht.Checked = false;
                        radioButtonDinerVoorgerecht.Checked = true;
                    }
                    break;
                case "Tussengerechten":
                    radioButtonDinerTussengerecht.Checked = true;
                    break;
                case "Hoofdgerechten":
                    if ((radioButtonLunchVoorraad.Checked == true) && (radioButtonDinerVoorraad.Checked == false))
                    {
                        radioButtonLunchHoofdgerecht.Checked = true;
                        radioButtonDinerHoofdgerecht.Checked = false;
                    }
                    else
                    {
                        radioButtonLunchHoofdgerecht.Checked = false;
                        radioButtonDinerHoofdgerecht.Checked = true;
                    }
                    break;
                case "Nagerechten":
                    if ((radioButtonLunchVoorraad.Checked == true) && (radioButtonDinerVoorraad.Checked == false))
                    {
                        radioButtonNaVoorgerecht.Checked = true;
                        radioButtonDinerNagerecht.Checked = false;
                    }
                    else
                    {
                        radioButtonNaVoorgerecht.Checked = false;
                        radioButtonDinerNagerecht.Checked = true;
                    }
                    break;
                case "Frisdranken":
                    radioButtonDrankenFris.Checked = true;
                    radioButtonDrankenBier.Checked = false;
                    radioButtonDrankenWijn.Checked = false;
                    radioButtonDrankenGedistilleerde.Checked = false;
                    radioButtonDrankenWarme.Checked = false;
                    break;
                case "Bieren":
                    radioButtonDrankenFris.Checked = false;
                    radioButtonDrankenBier.Checked = true;
                    radioButtonDrankenWijn.Checked = false;
                    radioButtonDrankenGedistilleerde.Checked = false;
                    radioButtonDrankenWarme.Checked = false;
                    break;
                case "Wijnen":
                    radioButtonDrankenFris.Checked = false;
                    radioButtonDrankenBier.Checked = false;
                    radioButtonDrankenWijn.Checked = true;
                    radioButtonDrankenGedistilleerde.Checked = false;
                    radioButtonDrankenWarme.Checked = false;
                    break;
                case "Gedistilleerde dranken":
                    radioButtonDrankenFris.Checked = false;
                    radioButtonDrankenBier.Checked = false;
                    radioButtonDrankenWijn.Checked = false;
                    radioButtonDrankenGedistilleerde.Checked = true;
                    radioButtonDrankenWarme.Checked = false;
                    break;
                case "Warme dranken":
                    radioButtonDrankenFris.Checked = false;
                    radioButtonDrankenBier.Checked = false;
                    radioButtonDrankenWijn.Checked = false;
                    radioButtonDrankenGedistilleerde.Checked = false;
                    radioButtonDrankenWarme.Checked = true;
                    break;
            }
        }

        private void AdjustModifyControls(string ModifySetting)
        {
            switch(ModifySetting)
            {
                case "Delete":
                    ButtonModifyConfirm.Text = ("Verwijderen");
                    textBoxItemNaam.Enabled = false;
                    numericBTW.Enabled = false;
                    textBoxItemPrice.Enabled = false;
                    numericRestock.Enabled = false;
                    numericStock.Enabled = false;
                    radioButtonNeedID.Enabled = false;
                    radioButtonNoID.Enabled = false;
                    radioButtonLunchVoorgerecht.Enabled = false;
                    radioButtonLunchHoofdgerecht.Enabled = false;
                    radioButtonNaVoorgerecht.Enabled = false;
                    radioButtonDinerVoorgerecht.Enabled = false;
                    radioButtonDinerTussengerecht.Enabled = false;
                    radioButtonDinerHoofdgerecht.Enabled = false;
                    radioButtonDinerNagerecht.Enabled = false;
                    radioButtonDrankenFris.Enabled = false;
                    radioButtonDrankenBier.Enabled = false;
                    radioButtonDrankenWijn.Enabled = false;
                    radioButtonDrankenGedistilleerde.Enabled = false;
                    radioButtonDrankenWarme.Enabled = false;
                    break;
                case "Add":
                    ButtonModifyConfirm.Text = ("Toevoegen");
                    textBoxItemNaam.Enabled = true;
                    numericBTW.Enabled = true;
                    textBoxItemPrice.Enabled = true;
                    numericRestock.Enabled = true;
                    numericStock.Enabled = true;
                    radioButtonNeedID.Enabled = true;
                    radioButtonNoID.Enabled = true;
                    radioButtonLunchVoorgerecht.Enabled = true;
                    radioButtonLunchHoofdgerecht.Enabled = true;
                    radioButtonNaVoorgerecht.Enabled = true;
                    radioButtonDinerVoorgerecht.Enabled = true;
                    radioButtonDinerTussengerecht.Enabled = true;
                    radioButtonDinerHoofdgerecht.Enabled = true;
                    radioButtonDinerNagerecht.Enabled = true;
                    radioButtonDrankenFris.Enabled = true;
                    radioButtonDrankenBier.Enabled = true;
                    radioButtonDrankenWijn.Enabled = true;
                    radioButtonDrankenGedistilleerde.Enabled = true;
                    radioButtonDrankenWarme.Enabled = true;
                    break;
                case "Update":
                    ButtonModifyConfirm.Text = ("Wijzigen");
                    textBoxItemNaam.Enabled = true;
                    numericBTW.Enabled = true;
                    textBoxItemPrice.Enabled = true;
                    numericRestock.Enabled = true;
                    numericStock.Enabled = true;
                    radioButtonNeedID.Enabled = true;
                    radioButtonNoID.Enabled = true;
                    radioButtonLunchVoorgerecht.Enabled = true;
                    radioButtonLunchHoofdgerecht.Enabled = true;
                    radioButtonNaVoorgerecht.Enabled = true;
                    radioButtonDinerVoorgerecht.Enabled = true;
                    radioButtonDinerTussengerecht.Enabled = true;
                    radioButtonDinerHoofdgerecht.Enabled = true;
                    radioButtonDinerNagerecht.Enabled = true;
                    radioButtonDrankenFris.Enabled = true;
                    radioButtonDrankenBier.Enabled = true;
                    radioButtonDrankenWijn.Enabled = true;
                    radioButtonDrankenGedistilleerde.Enabled = true;
                    radioButtonDrankenWarme.Enabled = true;
                    break;
            }
        }

        private void AdjustMenuGroupSetting(int MenuCode)
        {
            switch(MenuCode)
            {
                case 1:
                    panelLunchSetting.Show();
                    panelDinerSetting.Hide();
                    panelDrankSetting.Hide();
                    break;
                case 2:
                    panelLunchSetting.Hide();
                    panelDinerSetting.Show();
                    panelDrankSetting.Hide();
                    break;
                case 3:
                    panelLunchSetting.Hide();
                    panelDinerSetting.Hide();
                    panelDrankSetting.Show();
                    break;
            }
        }

        private void AddMenuItem()
        {
            if ((textBoxItemNaam.Text.Length > 0) && (textBoxItemPrice.Text.Replace("€", String.Empty).Length > 0))
            {
                DialogResult dialogResult = MessageBox.Show("U gaat iets toevoegen, Weet u het zeker?", "Voorraadbeheer", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    MenuItem item = new MenuItem()
                    {
                        MenuGroup = CheckMenuGroup().ToString(),
                        item_Name = textBoxItemNaam.Text,
                        item_Price = decimal.Parse(textBoxItemPrice.Text.Replace("€", String.Empty)),
                        item_Taxpercentage = int.Parse(numericBTW.Value.ToString()),
                        item_Stock = int.Parse(numericStock.Value.ToString()),
                        item_Restock = int.Parse(numericRestock.Value.ToString()),
                        Alcohol_Check = CheckAge(),
                    };
                    Stock_Service.DB_Add_Stock(item);
                    UpdateStockList();
                    UpdateStockViewList();
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Vul alle velden in", "Voorraadbeheer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void RemoveMenuItem()
        {
            if (listViewStockManagement.SelectedItems.Count is not 0)
            {
                DialogResult dialogResult = MessageBox.Show("U gaat iets verwijderen, Weet u het zeker?", "Voorraadbeheer", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    Stock_Service.DB_Remove_Stock(CurrentItem);
                    UpdateStockList();
                    UpdateStockViewList();
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Selecteer één item om te verwijderen", "Voorraadbeheer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void UpdateMenuItem()
        {
            if ((textBoxItemNaam.Text.Length > 0) && (textBoxItemPrice.Text.Replace("€", String.Empty).Length > 0))
            {
                DialogResult dialogResult = MessageBox.Show("U gaat iets aanpassen, Weet u het zeker?", "Voorraadbeheer", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    CurrentItem.MenuGroup = CheckMenuGroup().ToString();
                    CurrentItem.item_Name = textBoxItemNaam.Text;
                    CurrentItem.item_Price = decimal.Parse(textBoxItemPrice.Text.Replace("€", String.Empty));
                    CurrentItem.item_Taxpercentage = int.Parse(numericBTW.Value.ToString());
                    CurrentItem.item_Stock = int.Parse(numericStock.Value.ToString());
                    CurrentItem.item_Restock = int.Parse(numericRestock.Value.ToString());
                    CurrentItem.Alcohol_Check = CheckAge();
                    Stock_Service.DB_Update_Stock(CurrentItem);
                    UpdateStockList();
                    UpdateStockViewList();
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Selecteer één item om te verwijderen", "Voorraadbeheer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        // Button area Stock management

        private void BtnStockManagement_Click(object sender, EventArgs e)
        {
            ManagementMenu("StockManagement");
        }

        private void btnUserManagement_Click(object sender, EventArgs e)
        {
            ManagementMenu("UserMangement");
            LoadPersoneelBeheerpaneel();
        }

        private void btnFinancialOverview_Click(object sender, EventArgs e)
        {
            ManagementMenu("FinancialOverview");
        }

        private void BtnAfmelden_Click(object sender, EventArgs e)
        {
            _Dashboard.Show();
            this.Close();
        }

        private void radioButtonLunchVoorraad_CheckedChanged(object sender, EventArgs e)
        {
            CurrentMenuCode = 1;
            groupBoxAlcohol.Show();
            panelModifySelection.Show();
            panelLunchSetting.Show();
            if (radioButtonLunchVoorraad.Checked == true)
            {
                UpdateStockList();
                UpdateStockViewList();
                AdjustMenuGroupSetting(1);
            }
        }

        private void radioButtonDinerVoorraad_CheckedChanged(object sender, EventArgs e)
        {
            CurrentMenuCode = 2;
            groupBoxAlcohol.Show();
            panelModifySelection.Show();
            panelDinerSetting.Show();
            if (radioButtonDinerVoorraad.Checked == true)
            {
                UpdateStockList();
                AdjustMenuGroupSetting(2);
                UpdateStockViewList();
            }
        }

        private void radioButtonDrankVoorraad_CheckedChanged(object sender, EventArgs e)
        {
            CurrentMenuCode = 3;
            panelModifySelection.Show();
            panelDrankSetting.Show();
            groupBoxAlcohol.Show();
            if (radioButtonDrankVoorraad.Checked == true)
            {
                UpdateStockList();
                UpdateStockViewList();
                AdjustMenuGroupSetting(3);
            }
        }

        private void radioButtonWijzigen_CheckedChanged(object sender, EventArgs e)
        {
            panelModifyControls.Show();
            AdjustModifyControls("Update");
        }

        private void radioButtonToevoegen_CheckedChanged(object sender, EventArgs e)
        {
            panelModifyControls.Show();
            AdjustModifyControls("Add");
        }

        private void radioButtonVerwijderen_CheckedChanged(object sender, EventArgs e)
        {
            panelModifyControls.Show();
            AdjustModifyControls("Delete");

        }


        private void ButtonModifyConfirm_Click(object sender, EventArgs e)
        {
            if((radioButtonWijzigen.Checked == true) && (radioButtonToevoegen.Checked == false))
            {
                UpdateMenuItem();
            }
            else if((radioButtonToevoegen.Checked == true) && (radioButtonWijzigen.Checked == false))
            {
                AddMenuItem();
            }
            else
            {
                RemoveMenuItem();
            }
        }
        // ---------------------
        

        // user management area

        private Employee _CurrentSelectedEmployee;
        private List<Employee> ListOfEmployees;
        private ChapooLogic.Employees_Service Employees_Service;

        private void LoadPersoneelBeheerpaneel()
        {
            Employees_Service = new ChapooLogic.Employees_Service();
            textBoxPincodeHerhaal.Enabled = false;
            textBoxNaamInput.Enabled = false;
            textBoxAdresInput.Enabled = false;
            textBoxTelefoonInput.Enabled = false;
            comboBoxFuncties.Enabled = false;
            textBoxPincode.Enabled = false;
            textBoxPincodeHerhaal.Enabled = false;
            buttonUserButton.Enabled = false;
            comboBoxFuncties.DataSource = Enum.GetValues(typeof(Position));
            ClearFields();
            FillEmployeeList();
            FillListviewWithEmployees();
            RadioButtonSetting("Update");
        }

        private void FillEmployeeList()
        {
            ListOfEmployees = Employees_Service.DB_Get_Employees();


        }

        private void FillListviewWithEmployees()
        {
            listViewWerknemers.Items.Clear();
            foreach (ChapooModel.Employee employee  in ListOfEmployees)
            {
                listViewWerknemers.Items.Add(new ListViewItem(new string[] { $"{employee.employee_id}", $"{employee.name}", $"{employee.adres}", $"{employee.phone}", $"{employee.position}" }));
            }

        }

        private void listViewWerknemers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewWerknemers.SelectedItems.Count is not 0)
            {

                _CurrentSelectedEmployee = ListOfEmployees[listViewWerknemers.SelectedIndices[0]];
                LoadUserDetails();
                textBoxNaamInput.Enabled = true;
                textBoxAdresInput.Enabled = true;
                textBoxTelefoonInput.Enabled = true;
                comboBoxFuncties.Enabled = true;
                textBoxPincode.Enabled = true;
                textBoxPincodeHerhaal.Enabled = true;
                buttonUserButton.Enabled = true;
            }
            else
            {
                ClearFields();
                textBoxPincodeHerhaal.Enabled = false;
                textBoxNaamInput.Enabled = false;
                textBoxAdresInput.Enabled = false;
                textBoxTelefoonInput.Enabled = false;
                comboBoxFuncties.Enabled = false;
                textBoxPincode.Enabled = false;
                textBoxPincodeHerhaal.Enabled = false;
                buttonUserButton.Enabled = false;
            }
        }

        private void RadioButtonSetting(string modifySetting)
        {
            switch(modifySetting)
            {
                case "Add":
                    ClearFields();
                    textBoxNaamInput.Enabled = true;
                    textBoxAdresInput.Enabled = true;
                    textBoxTelefoonInput.Enabled = true;
                    comboBoxFuncties.Enabled = true;
                    textBoxPincode.Enabled = true;
                    textBoxPincodeHerhaal.Enabled = true;
                    buttonUserButton.Enabled = true;
                    buttonUserButton.BackColor = Color.DarkGreen;
                    buttonUserButton.ForeColor = Color.White;
                    buttonUserButton.Text = "Toevoegen";
                    break;
                case "Delete":
                    if (listViewWerknemers.SelectedItems.Count is 0)
                    {
                        buttonUserButton.Enabled = false;
                    }
                    textBoxNaamInput.Enabled = false;
                    textBoxAdresInput.Enabled = false;
                    textBoxTelefoonInput.Enabled = false;
                    comboBoxFuncties.Enabled = false;
                    textBoxPincode.Enabled = false;
                    textBoxPincodeHerhaal.Enabled = false;
                    buttonUserButton.BackColor = Color.DarkRed;
                    buttonUserButton.ForeColor = Color.White;
                    buttonUserButton.Text = "Verwijder"; 
                    break;
                case "Update":
                    if (listViewWerknemers.SelectedItems.Count is 0)
                    {
                        buttonUserButton.Enabled = false;
                    }
                    textBoxNaamInput.Enabled = true;
                    textBoxAdresInput.Enabled = true;
                    textBoxTelefoonInput.Enabled = true;
                    comboBoxFuncties.Enabled = true;
                    textBoxPincode.Enabled = true;
                    textBoxPincodeHerhaal.Enabled = true;
                    buttonUserButton.BackColor = Color.DarkOrange;
                    buttonUserButton.ForeColor = Color.White;
                    buttonUserButton.Text = "Wijzig";
                    break;
            }

        }

        private void LoadUserDetails()
        {
            textBoxNaamInput.Text = _CurrentSelectedEmployee.name;
            textBoxAdresInput.Text = _CurrentSelectedEmployee.adres;
            textBoxTelefoonInput.Text = _CurrentSelectedEmployee.phone;
            comboBoxFuncties.SelectedItem = _CurrentSelectedEmployee.position;
            textBoxPincode.Text = Decrypt(_CurrentSelectedEmployee.pin);
        }

        private void ClearFields()
        {
            textBoxNaamInput.Clear();
            textBoxAdresInput.Clear();
            textBoxTelefoonInput.Clear();
            textBoxPincode.Clear();
            textBoxPincodeHerhaal.Clear();
        }

        private void ModifyUserDatabase()
        {
            if ((radioButtonAddUser.Checked == true) && (radioButtonWijzigUser.Checked == false))
            {
                Employee employee = new Employee()
                {
                    name = textBoxNaamInput.Text,
                    adres = textBoxAdresInput.Text,
                    phone = textBoxTelefoonInput.Text,
                    pin = Encrypt(textBoxPincode.Text),
                    position = (Position)comboBoxFuncties.SelectedItem,
                };
                Employees_Service.DB_Add_Employee(employee);
                ClearFields();
                DialogResult dialogResult = MessageBox.Show("Werknemer is succesvol toegevoegd", "Personeel beheer", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if ((radioButtonWijzigUser.Checked == true) && (radioButtonAddUser.Checked == false))
            {
                Employee employee = new Employee()
                {
                    employee_id = _CurrentSelectedEmployee.employee_id,
                    name = textBoxNaamInput.Text,
                    adres = textBoxAdresInput.Text,
                    phone = textBoxTelefoonInput.Text,
                    pin = Encrypt(textBoxPincode.Text),
                    position = (Position)comboBoxFuncties.SelectedItem,
                };
                Employees_Service.DB_Update_Employee(employee);
                ClearFields();
                DialogResult dialogResult = MessageBox.Show("Werknemer is succesvol gewijzigd", "Personeel beheer", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Employee employee = new Employee()
                {
                    employee_id = _CurrentSelectedEmployee.employee_id,
                    name = textBoxNaamInput.Text,
                    adres = textBoxAdresInput.Text,
                    phone = textBoxTelefoonInput.Text,
                    pin = Encrypt(textBoxPincode.Text),
                    position = (Position)comboBoxFuncties.SelectedItem,
                };
                Employees_Service.DB_Delete_Employee(employee);
                ClearFields();
                DialogResult dialogResult = MessageBox.Show("Werknemer is succesvol verwijderd", "Personeel beheer", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            FillEmployeeList();
            FillListviewWithEmployees();
        }

        public static string Encrypt(string clearText)
        {
            string EncryptionKey = "lifefindsaway";
            byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    clearText = Convert.ToBase64String(ms.ToArray());
                }
            }
            return clearText;
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

        private void radioButtonWijzigUser_CheckedChanged(object sender, EventArgs e)
        {
            RadioButtonSetting("Update");
        }

        private void radioButtonAddUser_CheckedChanged(object sender, EventArgs e)
        {
            RadioButtonSetting("Add");
        }

        private void radioButtonVerwijderUser_CheckedChanged(object sender, EventArgs e)
        {
            RadioButtonSetting("Delete");
        }

        private void buttonUserButton_Click(object sender, EventArgs e)
        {   
            if ((textBoxNaamInput.Text.Length > 0) && (textBoxAdresInput.Text.Length > 0) && (textBoxTelefoonInput.Text.Length > 0) || (radioButtonVerwijderUser.Checked == true))
            {
                if ((textBoxPincode.Text == textBoxPincodeHerhaal.Text) || (radioButtonVerwijderUser.Checked == true))
                {
                    if ((radioButtonAddUser.Checked == true) && (radioButtonWijzigUser.Checked == false))
                    {
                        DialogResult dialogResult = MessageBox.Show("U gaat een werknemer toevoegen, Weet u het zeker?", "Voorraadbeheer", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dialogResult == DialogResult.Yes)
                        {
                            ModifyUserDatabase();
                        }
                        else if (dialogResult == DialogResult.No)
                        {

                        }
                    }
                    else if ((radioButtonWijzigUser.Checked == true) && (radioButtonAddUser.Checked == false))
                    {
                        DialogResult dialogResult = MessageBox.Show("U gaat een werknemer wijzigen, Weet u het zeker?", "Voorraadbeheer", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dialogResult == DialogResult.Yes)
                        {
                            ModifyUserDatabase();
                        }
                        else if (dialogResult == DialogResult.No)
                        {

                        }
                    }
                    else
                    {
                        if (listViewWerknemers.SelectedItems.Count is not 0)
                        {
                            DialogResult dialogResult = MessageBox.Show("U gaat een werknemer verwijderen, Weet u het zeker?", "Voorraadbeheer", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (dialogResult == DialogResult.Yes)
                            {
                                ModifyUserDatabase();
                            }
                            else if (dialogResult == DialogResult.No)
                            {

                            }
                        }
                        else
                        {
                            DialogResult dialogResult = MessageBox.Show("Selecteer een werknemer om te verwijderen", "Personeel beheer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("De twee ingevoerde pincodes komen niet overeen", "Personeel beheer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Vul alle velden in", "Personeel beheer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// financeel overzicht area 
        /// 
        private List<Payment> paymentList;

        private void LoadfinancieelOverzichtPanel()
        {

            paymentList = new List<Payment>();

            //FillPaymentList();
            //FillPaymentListview();
        }

        private void FillPaymentList()
        {
            ChapooLogic.Payment_Service payment_Service = new ChapooLogic.Payment_Service();
            paymentList = payment_Service.Db_Get_PaymentHistory(monthCalendarFrom.SelectionStart, monthCalendarTill.SelectionStart);
            FillPaymentListview();
        }

        private void FillPaymentListview()
        {
            listViewPayments.Items.Clear();
            foreach (ChapooModel.Payment payment in paymentList)
            {
                listViewPayments.Items.Add(new ListViewItem(new string[] { $"{payment.payment_ID}", $"{payment.employee.name}", $"{payment.payMethod}", $"{payment.totalVAT.ToString("€ 0.00")}", $"{payment.tip.ToString("€ 0.00")}", $"{payment.totalPrice.ToString("€ 0.00")}", $"{payment.payment_DateTime}", $"{payment.payStatus}" }));
            }
        }

        private void monthCalendarFrom_DateChanged(object sender, DateRangeEventArgs e)
        {
            monthCalendarTill.MinDate = monthCalendarFrom.SelectionStart;
        }

        private void monthCalendarTill_DateChanged(object sender, DateRangeEventArgs e)
        {
            monthCalendarFrom.MaxDate = monthCalendarTill.SelectionStart;
        }

        private void buttonPaymentZoeken_Click(object sender, EventArgs e)
        {
            FillPaymentList();
        }
    }
}
