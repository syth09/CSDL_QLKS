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

namespace WindowsFormsApp11
{

    public partial class Form1 : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=NAMNAM\ADMIN;Initial Catalog=KT;Integrated Security=True;trustServerCertificate=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loaddata()
        {
          
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();

        }

        private void bt_hienthi_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from GiangVien";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgv.DataSource = table;
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgv.CurrentRow.Index;
            tb_magv.Text = dgv.Rows[i].Cells[0].Value.ToString();
            tb_tengv.Text = dgv.Rows[i].Cells[1].Value.ToString();
            tb_sdt.Text = dgv.Rows[i].Cells[2].Value.ToString();
            tb_email.Text = dgv.Rows[i].Cells[3].Value.ToString();
            tb_noict.Text = dgv.Rows[i].Cells[4].Value.ToString();
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "insert into GiangVien values('"+tb_magv.Text+ "','"+tb_tengv.Text+ "','"+tb_sdt.Text+ "','"+tb_email.Text+ "','"+tb_noict.Text+"')";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from GiangVien where MaGV= '" + tb_magv.Text + "'";
            command.ExecuteNonQuery();
            loaddata();
            command = connection.CreateCommand();
            command.CommandText = "delete from DeTai where MaGV= '" + tb_magv.Text + "'";
            command.ExecuteNonQuery();
            loaddata();
        }
    }
}