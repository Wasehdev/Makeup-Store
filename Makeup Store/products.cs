using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Makeup_Store
{
    public partial class products : Form
    {
        SqlConnection con = new SqlConnection("Data Source=ABDUL_WASEH\\SQLEXPRESS;Initial Catalog=MakeupStore;Integrated Security=True");
        SqlCommand cmd;
        public products()
        {
            InitializeComponent();
            dataGridView1.ColumnCount = 7;
            dataGridView1.Columns[0].Name = "ID";
            dataGridView1.Columns[1].Name = "Item Name";
            dataGridView1.Columns[2].Name = "Details";
            dataGridView1.Columns[3].Name = "Category";
            dataGridView1.Columns[4].Name = "Stock";
            dataGridView1.Columns[5].Name = "Image";
            dataGridView1.Columns[6].Name = "Item Price";

            ShowData("select * from products");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();

            cmd = new SqlCommand("insert into products values(@a,@b,@c,@d,@e,@f,@g)", con);
            cmd.Parameters.AddWithValue("@a", textBox1.Text);
            cmd.Parameters.AddWithValue("@b", textBox2.Text);
            cmd.Parameters.AddWithValue("@c", textBox3.Text);
            cmd.Parameters.AddWithValue("@d", textBox4.Text);
            cmd.Parameters.AddWithValue("@e", Convert.ToInt32(textBox5.Text));
            conv_photo();
            // cmd.Parameters.AddWithValue("@f", File.ReadAllBytes(openFileDialog1.FileName));
            cmd.Parameters.AddWithValue("@g", Convert.ToInt32(textBox6.Text));
           int n= cmd.ExecuteNonQuery();
            if (n > 0)
            {
                MessageBox.Show("Product added Successfully");
            }
            else
            {
                MessageBox.Show("Product could not be added Successfully");
            }

        }

        void conv_photo()
        {
            //converting photo to binary data
            if (pictureBox1.Image != null)
            {
                //using MemoryStream:
               MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, ImageFormat.Jpeg);
                byte[] photo_aray = new byte[ms.Length];
                ms.Position = 0;
                ms.Read(photo_aray, 0, photo_aray.Length);
                cmd.Parameters.AddWithValue("@f", photo_aray);
            }
        }

        

        private void button5_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "jpeg|*.jpg|bmp|*.bmp|all files|*.*";
            DialogResult res = openFileDialog1.ShowDialog();
            if (res == DialogResult.OK)
            {

                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                
            cmd = new SqlCommand("update products set name=@b,details=@c,category=@d,stock=@e,pro_image=@f,price=@g where pro_id=@a", con);
            con.Open();
            cmd.Parameters.AddWithValue("@a", textBox1.Text);
            cmd.Parameters.AddWithValue("@b", textBox2.Text);
            cmd.Parameters.AddWithValue("@c", textBox3.Text);
            cmd.Parameters.AddWithValue("@d", textBox4.Text);
            cmd.Parameters.AddWithValue("@e", Convert.ToInt32(textBox5.Text));
            conv_photo();
            // cmd.Parameters.AddWithValue("@f", File.ReadAllBytes(openFileDialog1.FileName));
            cmd.Parameters.AddWithValue("@g", Convert.ToInt32(textBox6.Text));
            int n = cmd.ExecuteNonQuery();
            if (n > 0)
            {
                MessageBox.Show("Product updated Successfully");
                    ShowData("select * from  products");
                }
            else
            {
                MessageBox.Show("Product could not be updated Successfully");
            }
            }
            catch
            {
                MessageBox.Show("Insert an Image");

            }

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //try
            //{

            if (e.RowIndex + 1 == dataGridView1.Rows.Count) return;

            DataGridViewRow abc = dataGridView1.Rows[e.RowIndex];
            textBox1.Text = abc.Cells[0].Value.ToString();
            textBox2.Text = abc.Cells[1].Value.ToString();
            textBox3.Text = abc.Cells[2].Value.ToString();
            textBox4.Text = abc.Cells[3].Value.ToString();
            textBox5.Text = abc.Cells[4].Value.ToString();
           
            MemoryStream ms = new MemoryStream((byte[])abc.Cells[5].Value);
            pictureBox1.Image = Image.FromStream(ms);
            textBox6.Text = abc.Cells[6].Value.ToString();

            //}
            //catch
            //{

            //}

        


        }


        public void ShowData(string selectcmd)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(selectcmd, con);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string proid = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                string proname = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                string prodetails= ds.Tables[0].Rows[i].ItemArray[2].ToString();
                string procategory = ds.Tables[0].Rows[i].ItemArray[3].ToString();
                string prostock = ds.Tables[0].Rows[i].ItemArray[4].ToString();
                string proimage = ds.Tables[0].Rows[i].ItemArray[5].ToString();
                string proprice = ds.Tables[0].Rows[i].ItemArray[6].ToString();


                DataGridViewRow abc = new DataGridViewRow();
                abc.CreateCells(dataGridView1);
                abc.Cells[0].Value = proid;
                abc.Cells[1].Value = proname;
                abc.Cells[2].Value = prodetails;
                abc.Cells[3].Value = procategory;
                abc.Cells[4].Value = prostock;
                abc.Cells[5].Value = proimage;
                abc.Cells[6].Value = proprice;

                dataGridView1.Rows.Add(abc);

            }

        }

        private void dataGridView1_CellEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex + 1 == dataGridView1.Rows.Count) return;

            DataGridViewRow abc = dataGridView1.Rows[e.RowIndex];
            textBox1.Text = abc.Cells[0].Value.ToString();
            textBox2.Text = abc.Cells[1].Value.ToString();
            textBox3.Text = abc.Cells[2].Value.ToString();
            textBox4.Text = abc.Cells[3].Value.ToString();
            textBox5.Text = abc.Cells[4].Value.ToString();
       
            textBox6.Text = abc.Cells[6].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
             cmd = new SqlCommand("delete from products where pro_id=@a", con);
            con.Open();
            cmd.Parameters.AddWithValue("@a", textBox1.Text);
            cmd.ExecuteNonQuery();

            ShowData("select * from  products");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem.ToString())
            {
                case "Pro_id":
                    ShowData("select * from products where lower(Pro_id) like '%" + textBox7.Text.ToLower() + "%'");
                    break;

                case "Name":
                    ShowData("select * from products where lower(name) like '%" + textBox7.Text.ToLower() + "%'");
                    break;
                case "Price":
                    ShowData("select * from products where lower(price) like '%" + textBox7.Text.ToLower() + "%'");
                    break;
                case "Category":
                    ShowData("select * from products where lower(Category) like '%" + textBox7.Text.ToLower() + "%'");
                    break;
                case "Stock":
                    ShowData("select * from products where lower(stock) like '%" + textBox7.Text.ToLower() + "%'");
                    break;


            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Sales sales = new Sales();
            this.Hide();
            sales.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }
    }
}
