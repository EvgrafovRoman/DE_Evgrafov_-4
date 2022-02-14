using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DE_Evgrafov_4
{
    public partial class Avtorization : Form
    {
        public Avtorization()
        {
            InitializeComponent();
        }

        private void Avtorization_Load(object sender, EventArgs e)
        {

        }

        private void Vhod_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source = DESKTOP - DAO2Q0L\SQLEXPRESS01; Initial Catalog = DE_Evgrafov_№4; Integrated Security = True");
            string query = "Select * from Avtorizacziya where Логин = '" + tbLogin.Text.Trim() + "' and Пароль = '" + tbPassword.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                if (tbLogin.Text == "Admid")
                {
                    Admid ad = new Admid();
                    ad.Show();
                    this.Hide();
                    MessageBox.Show("Добро пожаловать!");
                }
                else
                {
                    Сlient us = new Сlient();
                    this.Hide();
                    us.Show();
                    MessageBox.Show("Добро пожаловать!");
                }
            }
            else
            {
                MessageBox.Show("Не верно введён логин или пароль!");
                tbLogin.Clear();
                tbPassword.Clear();
            }
        }
    }
}
