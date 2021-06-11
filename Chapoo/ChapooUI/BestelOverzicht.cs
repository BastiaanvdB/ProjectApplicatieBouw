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
    public partial class BestelOverzicht : Form
    {
        private Employee CurrentEmployee;
        private Dashboard Dashboard;
        private List<OrderDetail> _CurrentOrderDetails;
        private Order _CurrentOrder;

        private List<MenuItem> MenuItemsList;

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

        public BestelOverzicht(Employee employee, Dashboard dashboard)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            MenuItemsList = new List<MenuItem>();
            CurrentEmployee = employee;
            Dashboard = dashboard;
            CurrentUserProfile();
        }

        private void CurrentUserProfile()
        {
            UsernameLabel.Text = CurrentEmployee.name;
            UserFunctieLabel.Text = CurrentEmployee.position.ToString();
        }

        private void GetSpecificMenuItemsList(int MenuID, int MenuGroupID)
        {
            ChapooLogic.MenuItem_Service menuItem_Service = new ChapooLogic.MenuItem_Service();
            MenuItemsList = menuItem_Service.DB_Get_Specific_MenuItems(MenuID, MenuGroupID);
        }




        // Button area

        private void BtnAfmelden_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // ---------------------
    }
}
