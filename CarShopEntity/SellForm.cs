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
    public partial class SellForm : Form
    {
        public SellForm()
        {
            InitializeComponent();
        }

        private void homePageLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void btnSellCar_Click(object sender, EventArgs e)
        {
            CarShopEntityContext carShopEntityContext = new CarShopEntityContext();
            if (carShopEntityContext != null)
            {
                carShopEntityContext.carRepos.Add(new CarRepo()
                {
                    carBrand = carBrandTxtBox.Text,
                    carModel = carModelTxtBox.Text,
                    carYear = Convert.ToInt32(carYearTxtBox.Text),
                    carKm = Convert.ToInt32(carKmTxtBox.Text),
                    carPrice = Convert.ToInt32(carPriceTxtBox.Text),

                }
               );
                carShopEntityContext.SaveChanges();
                MessageBox.Show("Register successful.\nYour car will be added to sell list after \nwe make few controls!");
            }
            else
            {
                MessageBox.Show("You have to fill all fields!");
            }
           
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CarsForm carsForm = new CarsForm();
            carsForm.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SellForm_Load(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dataGridView1.Visible=true;
            CarShopEntityContext carShopEntityContext = new CarShopEntityContext();
            var query = from item in carShopEntityContext.carRepos
                        select item;
            dataGridView1.DataSource = query.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
