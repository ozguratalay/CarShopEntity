using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarShopEntity
{
    public partial class CarsForm : Form
    {
        public CarsForm()
        {
            InitializeComponent();
        }

        private void homePageLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void aboutLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Created by Özgür Atalay\n28.06.2022");
        }

        private void sellLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SellForm sellForm = new SellForm();
            sellForm.Show();
            this.Hide();
        }

        private void buyLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            BuyForm buyForm = new BuyForm(); 
            buyForm.Show();
            this.Hide();
        }
    }
}
