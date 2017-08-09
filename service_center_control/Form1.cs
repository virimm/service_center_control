using Bunifu.Framework.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace service_center_control
{
    public partial class Form1 : Form
    {
        UCOrders orders = new UCOrders() { Dock = DockStyle.Fill };
        UCClients clients = new UCClients() { Dock = DockStyle.Fill };
        UCShop shop = new UCShop() { Dock = DockStyle.Fill };
        UCPayments payments = new UCPayments() { Dock = DockStyle.Fill };
        UCWarehouse warehouse = new UCWarehouse() { Dock = DockStyle.Fill };

        List<BunifuTileButton> buttons;

        public Form1()
        {
            InitializeComponent();
            buttons = new List<BunifuTileButton>()
            { btnOrders, btnClients, btnShop, btnPayments, btnWarehouse, btnReports, btnSettings };
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            panelData.Controls.Clear();
            panelData.Controls.Add(orders);
            ControlsAnimate(orders, (BunifuTileButton)sender);

        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            panelData.Controls.Clear();
            panelData.Controls.Add(clients);
            ControlsAnimate(clients, (BunifuTileButton)sender);
        }

        private void btnShop_Click(object sender, EventArgs e)
        {
            panelData.Controls.Clear();
            panelData.Controls.Add(shop);
            ControlsAnimate(shop, (BunifuTileButton)sender);
        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            panelData.Controls.Clear();
            panelData.Controls.Add(payments);
            ControlsAnimate(payments, (BunifuTileButton)sender);
        }

        private void btnWarehouse_Click(object sender, EventArgs e)
        {
            panelData.Controls.Clear();
            panelData.Controls.Add(warehouse);
            ControlsAnimate(warehouse, (BunifuTileButton)sender);
        }

        private void ControlsAnimate(UserControl control, BunifuTileButton button)
        {
            foreach (var item in buttons)
            {
                item.color = Color.White;
            }


            //button.color = Color.FromArgb(202, 218, 248);
            button.color = Color.Gainsboro;
            control.Visible = false;
            bunifuTransition1.ShowSync(control);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Завершить работу с приложением?", "Выход", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }


    }
}
