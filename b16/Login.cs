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
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=vinacantik28;Database=girls_need;Port=5432");
            conn.Open();
            NpgsqlCommand login = new NpgsqlCommand();
            login.Connection = conn;
            login.CommandText = "SELECT * FROM users WHERE username=@username AND password=@password";
            login.Parameters.AddWithValue("username", username.Text);
            login.Parameters.AddWithValue("password", password.Text);
            login.Prepare();
            NpgsqlDataReader reader;
            reader = login.ExecuteReader();
            if (reader.Read())
            {
                this.Hide();
            }
            else
            {
                this.Show();
                this.BringToFront();
            }
        }
    }
}
