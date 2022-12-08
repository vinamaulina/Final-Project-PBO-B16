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
    public partial class Laporan : UserControl
    {
        public Laporan()
        {
            InitializeComponent();
        }

        private void TabelReport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = Report.All();
            TabelReport.DataSource = dt;
        }

        private void simpan_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=vinacantik28;Database=girls_need;Port=5432");
            conn.Open();
            NpgsqlCommand create = new NpgsqlCommand();
            create.Connection = conn;
            create.CommandText = "INSERT INTO reports(tanggal, pemasukkan, pengeluaran, metode_pembayaran_id, barang_masuk, barang_keluar) VALUES(@tanggal, @pemasukkan, @pengeluaran, @metode_pembayaran_id, @barang_masuk, @barang_keluar)";
            create.Parameters.AddWithValue("tanggal", tanggal.Value);
            create.Parameters.AddWithValue("pemasukkan", jumlah_pemasukan.Value);
            create.Parameters.AddWithValue("pengeluaran", jumlah_pengeluaran.Value);
            create.Parameters.AddWithValue("metode_pembayaran_id", metode_id.Value);
            create.Parameters.AddWithValue("barang_masuk", barang_masuk.Value);
            create.Parameters.AddWithValue("barang_keluar", barang_keluar.Value);
            create.Prepare();
            create.ExecuteNonQuery();
            create.Parameters.Clear();
        }

        private void edit_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=vinacantik28;Database=girls_need;Port=5432");
            conn.Open();
            NpgsqlCommand create = new NpgsqlCommand();
            create.Connection = conn;
            create.CommandText = "UPDATE reports SET tanggal=@tanggal, pemasukkan=@pemasukkan, pengeluaran=@pengeluaran, metode_pembayaran_id=@metode_pembayaran_id, barang_masuk=@barang_masuk, barang_keluar=@barang_keluar WHERE id=@id";
            create.Parameters.AddWithValue("tanggal", tanggal.Value);
            create.Parameters.AddWithValue("pemasukkan", jumlah_pemasukan.Value);
            create.Parameters.AddWithValue("pengeluaran", jumlah_pengeluaran.Value);
            create.Parameters.AddWithValue("metode_pembayaran_id", metode_id.Value);
            create.Parameters.AddWithValue("barang_masuk", barang_masuk.Value);
            create.Parameters.AddWithValue("barang_keluar", barang_keluar.Value);
            create.Parameters.AddWithValue("id", report_id.Value);
            create.ExecuteNonQuery();
            create.Parameters.Clear();
        }

        private void hapus_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=vinacantik28;Database=girls_need;Port=5432");
            conn.Open();
            NpgsqlCommand delete = new NpgsqlCommand();
            delete.Connection = conn;
            delete.CommandText = "DELETE FROM reports WHERE id=@id";
            delete.Parameters.AddWithValue("id", hapus_report_id.Value);
            delete.ExecuteNonQuery();
            delete.Parameters.Clear();
        }

        private void TabelReport_Click(object sender, EventArgs e)
        {
            DataTable dt = Report.All();
            TabelReport.DataSource = dt;
        }
    }
}
