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
    public partial class Management : Form
    {
        private MenuItem CurrentItem;
        private List<MenuItem> StockList;
        private int CurrentMenuCode;
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

                    break;
                case "StockManagement":

                    break;
                case "FinancialOverview":

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
                listViewStockManagement.Items.Add(new ListViewItem(new string[] { $"{menuItem.MenuGroup}", $"{menuItem.item_Name}", $"{menuItem.item_Price.ToString("€ 0.00")}", $"{menuItem.item_Taxpercentage}%", $"{menuItem.item_Restock}", $"{menuItem.item_Stock}", $"{"test"}" }));
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
                    break;
                case "Add":
                    ButtonModifyConfirm.Text = ("Toevoegen");
                    break;
                case "Update":
                    ButtonModifyConfirm.Text = ("Wijzigen");
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

        private void RemoveMenuItem()
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

        private void UpdateMenuItem()
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


        // Button area Stock management

        private void BtnStockManagement_Click(object sender, EventArgs e)
        {

        }

        private void btnUserManagement_Click(object sender, EventArgs e)
        {

        }

        private void btnFinancialOverview_Click(object sender, EventArgs e)
        {

        }

        private void BtnAfmelden_Click(object sender, EventArgs e)
        {
            _Dashboard.Show();
            this.Close();
        }

        private void radioButtonLunchVoorraad_CheckedChanged(object sender, EventArgs e)
        {
            CurrentMenuCode = 1;
            groupBoxAlcohol.Hide();
            panelModifySelection.Show();
            panelLunchSetting.Show();
            UpdateStockList();
            UpdateStockViewList();
            AdjustMenuGroupSetting(1);
        }

        private void radioButtonDinerVoorraad_CheckedChanged(object sender, EventArgs e)
        {
            CurrentMenuCode = 2;
            groupBoxAlcohol.Hide();
            panelModifySelection.Show();
            panelDinerSetting.Show();
            UpdateStockList();
            UpdateStockViewList();
            AdjustMenuGroupSetting(2);
        }

        private void radioButtonDrankVoorraad_CheckedChanged(object sender, EventArgs e)
        {
            CurrentMenuCode = 3;
            panelModifySelection.Show();
            panelDrankSetting.Show();
            groupBoxAlcohol.Show();
            UpdateStockList();
            UpdateStockViewList();
            AdjustMenuGroupSetting(3);
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
    }
}
