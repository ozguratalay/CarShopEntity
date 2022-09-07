using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarShopEntity.Entity;
using CarShopEntity;



namespace CarShopEntity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        public void checkUser()
        {
            CarShopEntityContext carShopEntityContext = new CarShopEntityContext();
            var query = from item in carShopEntityContext.carShopUserDatas
                        where item.userName == userTxtBox.Text && item.userPassword == PwTxtBox.Text
                        select item;

            if (query.Any())
            {
                MessageBox.Show("Loging Successful!");
                CarsForm carsForm = new CarsForm();
                carsForm.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Invalid username or password!");
            }
        }

        public void checkAdmin()
        {
            CarShopEntityContext carShopEntityContext = new CarShopEntityContext();
            var query2 = from item in carShopEntityContext.AdminLogins
                         where item.adminName == userTxtBox.Text && item.adminPassword == PwTxtBox.Text
                         select item;

            if (query2.Any())
            {
                MessageBox.Show("Loging Successful!");
                AdminForm adminForm = new AdminForm();
                adminForm.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Invalid username or password!");
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Admin");
            comboBox1.Items.Add("User");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "User")
            {
                checkUser();
            }
            else if (comboBox1.SelectedItem == "Admin")
            {
                checkAdmin();
            }
            else
            {
                MessageBox.Show("Select User!");
            }
      
           
            
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(RegUserTxtBox.Text) && String.IsNullOrEmpty(RegPwTxtBox.Text) &&
                String.IsNullOrEmpty(RegMailTxtBox.Text) && String.IsNullOrEmpty(dateTimePicker1.Text))
            {
                MessageBox.Show("You have to fill all the fields!");
            }
            else
            {
                CarShopEntityContext carShopEntityContext = new CarShopEntityContext();
                carShopEntityContext.carShopUserDatas.Add(new CarShopUserData()
                {
                    userName = RegUserTxtBox.Text,
                    userPassword = RegPwTxtBox.Text,
                    userMail = RegMailTxtBox.Text,
                    userBirthDate = Convert.ToDateTime(dateTimePicker1.Text)
                }
                );
                carShopEntityContext.SaveChanges();
                MessageBox.Show("Register successful!");
            }
          
        }

        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
