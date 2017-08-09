using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;

namespace service_center_control
{
    public partial class UCWarehouse : UserControl
    {
        public UCWarehouse()
        {
            InitializeComponent();
            buttons = new List<BunifuFlatButton>()
            { btnWhRemain, btnWhIncome, btnWhPostingfrom };

        }

        List<BunifuFlatButton> buttons;

        UCWhRemain whRemain = new UCWhRemain() { Dock = DockStyle.Fill };
        UCWhIncome whIncome = new UCWhIncome() { Dock = DockStyle.Fill };
        UCWhPostingfrom whPostingfrom = new UCWhPostingfrom() { Dock = DockStyle.Fill };


        private void UCWarehouse_Load(object sender, EventArgs e)
        {
            btnWhRemain_Click(this.btnWhRemain, e);
        }

        private void btnWhRemain_Click(object sender, EventArgs e)
        {
            panelWhData.Controls.Clear();
            panelWhData.Controls.Add(whRemain);
            ControlsAnimate(whRemain, (BunifuFlatButton)sender);
        }

        private void btnWhIncome_Click(object sender, EventArgs e)
        {
            panelWhData.Controls.Clear();
            panelWhData.Controls.Add(whIncome);
            ControlsAnimate(whIncome, (BunifuFlatButton)sender);
        }

        private void btnWhPostingfrom_Click(object sender, EventArgs e)
        {
            panelWhData.Controls.Clear();
            panelWhData.Controls.Add(whPostingfrom);
            ControlsAnimate(whPostingfrom, (BunifuFlatButton)sender);
        }

        private void ControlsAnimate(UserControl control, BunifuFlatButton button)
        {
            foreach (var item in buttons)
            {
                item.Normalcolor = Color.WhiteSmoke;
            }


            //button.color = Color.FromArgb(202, 218, 248);
            button.Normalcolor = Color.Gainsboro;
            control.Visible = false;
            bunifuTransition1.ShowSync(control);
        }


    }
}
