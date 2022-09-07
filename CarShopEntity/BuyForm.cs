using CarShopEntity.Entity;
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
    public partial class BuyForm : Form
    {
        public BuyForm()
        {
            InitializeComponent();
        }

        private void BuyForm_Load(object sender, EventArgs e)
        {
     
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            CarShopEntityContext carShopEntityContext = new CarShopEntityContext();
            
        }

        private void btnSellCar_Click(object sender, EventArgs e)
        {
            CarShopEntityContext carShopEntityContext = new CarShopEntityContext();
            var query = from item in carShopEntityContext.carRepos
                        select item;

            dataGridView1.DataSource = query.ToList();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void homePageLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
