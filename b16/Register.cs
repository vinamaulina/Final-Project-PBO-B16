using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace b16
{
    public partial class Register : UserControl
    {
        public Register()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void sign_up_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=vinacantik28;Database=girls_need;Port=5432");
            conn.Open();
            NpgsqlCommand register = new NpgsqlCommand();
            register.Connection = conn;
            register.CommandText = "INSERT INTO users(username, email, password, domisili) VALUES(@username, @email, @password, @domisili)";
            register.Parameters.AddWithValue("username", username.Text);
            register.Parameters.AddWithValue("email", email.Text);
            if(password.Text == confirm.Text)
            {
                register.Parameters.AddWithValue("password", password.Text);
                register.Parameters.AddWithValue("domisili", domisili.Text);
                register.Prepare();
                register.ExecuteNonQuery();
                register.Parameters.Clear();
                this.Hide();
            }
            else
            {
                conn.Close();
                this.Show();
                this.BringToFront();
            }
            conn.Close();

        }
    }
}
