using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using CarShopEntity.Entity;
using System.Data.SqlClient;

namespace CarShopEntity
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            CarShopEntityContext carShopEntityContext = new CarShopEntityContext();
            var query = from item in carShopEntityContext.carRepos
                        select item;

            dataGridView1.DataSource = query.ToList();
            var query2 = from item in carShopEntityContext.SellLists
                         select item;
            dataGridView2.DataSource = query2.ToList();
        }

        public void confirmPending()
        {
            CarShopEntityContext carShopEntityContext = new CarShopEntityContext();
            var query = from item in carShopEntityContext.carRepos
                        select item;
            var query2 = from item in carShopEntityContext.SellLists
                        select item;
            var toBeDeleted = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            var carData = carShopEntityContext.carRepos.First(c => c.carID == toBeDeleted);         
            carShopEntityContext.carRepos.Remove(carData);
            carShopEntityContext.SellLists.Add(new SellList()
            {
                carBrand = (string)dataGridView1.SelectedRows[0].Cells[1].Value,
                carModel = (string)dataGridView1.SelectedRows[0].Cells[2].Value,
                carYear = (int)dataGridView1.SelectedRows[0].Cells[3].Value,
                carKm = (int)dataGridView1.SelectedRows[0].Cells[4].Value,
                carPrice = (int)dataGridView1.SelectedRows[0].Cells[5].Value,


            }) ;
            carShopEntityContext.SaveChanges();
            dataGridView1.DataSource = query.ToList();
            dataGridView2.DataSource = query2.ToList();
        }

        public void rejectPending()
        {
            CarShopEntityContext carShopEntityContext = new CarShopEntityContext();
            var query = from item in carShopEntityContext.carRepos
                        select item;
            var toBeDeleted = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            var carData = carShopEntityContext.carRepos.First(c => c.carID == toBeDeleted);
            carShopEntityContext.carRepos.Remove(carData);
            carShopEntityContext.SaveChanges();
            dataGridView1.DataSource = query.ToList();
        }

        private void btnAdminConfirm_Click(object sender, EventArgs e)
        {
            confirmPending();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void btnAdminReject_Click(object sender, EventArgs e)
        {
            rejectPending();
        }
    }
}
