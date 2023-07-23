using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CRUD_Application
{
    public partial class CRUD_Application : Form
    {
        public CRUD_Application()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=JPG\\SQLEXPRESS;Initial Catalog=crudApp;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into userTable values(@id, @name, @email)",con);
            cmd.Parameters.AddWithValue("@id", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@name", textBox2.Text);
            cmd.Parameters.AddWithValue("@email", textBox3.Text);

            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Data Inserted Successfully");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=JPG\\SQLEXPRESS;Initial Catalog=crudApp;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("update userTable set name=@name, email=@email where id=@id",con);
            cmd.Parameters.AddWithValue("@id", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@name", textBox2.Text);
            cmd.Parameters.AddWithValue("@email", textBox3.Text);

            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Data Updated Successfully");
        }
        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=JPG\\SQLEXPRESS;Initial Catalog=crudApp;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("delete userTable where id=@id", con);
            cmd.Parameters.AddWithValue("@id", int.Parse(textBox1.Text));

            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Data Deleted Successfully");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=JPG\\SQLEXPRESS;Initial Catalog=crudApp;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("select * from userTable where id=@id", con);
            cmd.Parameters.AddWithValue("@id", int.Parse(textBox1.Text));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);

            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
    }
}
