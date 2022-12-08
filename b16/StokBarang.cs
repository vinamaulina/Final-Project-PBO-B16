using b16.Models;
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
    public partial class StokBarang : UserControl
    {
        public StokBarang()
        {
            InitializeComponent();
        }

        private void simpan_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=vinacantik28;Database=girls_need;Port=5432");
            conn.Open();
            NpgsqlCommand create = new NpgsqlCommand();
            create.Connection = conn;
            create.CommandText = "INSERT INTO products(nama_barang, jumlah_barang, harga_barang, jenis_barang) VALUES(@nama_barang, @jumlah_barang, @harga_barang, @jenis_barang)";
            create.Parameters.AddWithValue("nama_barang", nama_barang.Text);
            create.Parameters.AddWithValue("jumlah_barang", jumlah_barang.Value);
            create.Parameters.AddWithValue("harga_barang", harga_barang.Value);
            create.Parameters.AddWithValue("jenis_barang", jenis_barang.Text);
            create.ExecuteNonQuery();
            create.Parameters.Clear();
        }

        private void TabelProduk_Click(object sender, EventArgs e)
        {
            DataTable dt = Product.All();
            TabelProduk.DataSource = dt;
        }

        private void edit_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=vinacantik28;Database=girls_need;Port=5432");
            conn.Open();
            NpgsqlCommand update = new NpgsqlCommand();
            update.Connection = conn;
            update.CommandText = "UPDATE products SET nama_barang=@nama_barang, jumlah_barang=@jumlah_barang, harga_barang=@harga_barang, jenis_barang=@jenis_barang WHERE id=@id";
            update.Parameters.AddWithValue("nama_barang", nama_barang.Text);
            update.Parameters.AddWithValue("jumlah_barang", jumlah_barang.Value);
            update.Parameters.AddWithValue("harga_barang", harga_barang.Value);
            update.Parameters.AddWithValue("jenis_barang", jenis_barang.Text);
            update.Parameters.AddWithValue("id", id_update.Value);
            update.ExecuteNonQuery();
            update.Parameters.Clear();
        }

        private void hapus_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=vinacantik28;Database=girls_need;Port=5432");
            conn.Open();
            NpgsqlCommand delete = new NpgsqlCommand();
            delete.Connection = conn;
            delete.CommandText = "DELETE FROM products WHERE id=@id";
            
            delete.Parameters.AddWithValue("id", id_hapus.Value);
            delete.ExecuteNonQuery();
            delete.Parameters.Clear();
        }
    }
}
