using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Makeup_Store
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=ABDUL_WASEH\\SQLEXPRESS;Initial Catalog=MakeupStore;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();



        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {


            eyes.Visible = true;
            lips.Visible = false;
            Tools.Visible = false;
            Body.Visible = false;
            item1.Visible = false;
            item2.Visible = false;
            item3.Visible = false;
            item4.Visible = false;
            eyechecked.Visible = true;
            lipschecked.Visible = false;
            facechecked.Visible = false;
            toolschecked.Visible = false;

            // btn1   
            con.Open();
            SqlDataAdapter adpt = new SqlDataAdapter("select name,price,pro_image from products where pro_id=1", con);
            DataSet ds = new DataSet();
            adpt.Fill(ds);
            string namee = ds.Tables[0].Rows[0].ItemArray[0].ToString();
            string price = ds.Tables[0].Rows[0].ItemArray[1].ToString();

            MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["pro_image"]);

            btn1.BackgroundImage = new Bitmap(ms);
            pl1.Text = price;
            nl1.Text = namee;

            // btn2   
            adpt = new SqlDataAdapter("select name,price,pro_image from products where pro_id=2", con);
            ds = new DataSet();
            adpt.Fill(ds);
            namee = ds.Tables[0].Rows[0].ItemArray[0].ToString();
            price = ds.Tables[0].Rows[0].ItemArray[1].ToString();

            ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["pro_image"]);

            btn2.BackgroundImage = new Bitmap(ms);
            pl2.Text = price;
            nl2.Text = namee;

            // btn3
            adpt = new SqlDataAdapter("select name,price,pro_image from products where pro_id=3", con);
            ds = new DataSet();
            adpt.Fill(ds);
            namee = ds.Tables[0].Rows[0].ItemArray[0].ToString();
            price = ds.Tables[0].Rows[0].ItemArray[1].ToString();

            ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["pro_image"]);

            btn3.BackgroundImage = new Bitmap(ms);
            pl3.Text = price;
            nl3.Text = namee;

            // btn4
            adpt = new SqlDataAdapter("select name,price,pro_image from products where pro_id=4", con);
            ds = new DataSet();
            adpt.Fill(ds);
            namee = ds.Tables[0].Rows[0].ItemArray[0].ToString();
            price = ds.Tables[0].Rows[0].ItemArray[1].ToString();

            ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["pro_image"]);

            btn4.BackgroundImage = new Bitmap(ms);
            pl4.Text = price;
            nl4.Text = namee;




        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            eyes.Visible = false;
            lips.Visible = true;
            Tools.Visible = false;
            Body.Visible = false;
            item1.Visible = false;
            item2.Visible = false;
            item3.Visible = false;
            item4.Visible = false;
            eyechecked.Visible = false;
            lipschecked.Visible = true;
            facechecked.Visible = false;
            toolschecked.Visible = false;
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            eyes.Visible = false;
            lips.Visible = false;
            Tools.Visible = false;
            Body.Visible = false;
            item1.Visible = true;
            item2.Visible = false;
            item3.Visible = false;
            item4.Visible = false;


            SqlDataAdapter adpt = new SqlDataAdapter("select name,price,details,stock,pro_image from products where pro_id=1", con);
            DataSet ds = new DataSet();
            adpt.Fill(ds);
            string namee = ds.Tables[0].Rows[0].ItemArray[0].ToString();
            string price = ds.Tables[0].Rows[0].ItemArray[1].ToString();
            string details = ds.Tables[0].Rows[0].ItemArray[2].ToString();
            string s = ds.Tables[0].Rows[0].ItemArray[3].ToString();
            int stock = Convert.ToInt32(s);

            MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["pro_image"]);

            pictureBox1.Image = new Bitmap(ms);
            name1.Text = namee;
            price1.Text = price;
            richTextBox1.Text = details;

            if (stock > 0)
            {
                stock1.Text = "YES";
            }
            else
            {
                stock1.Text = "NO";
            }

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            eyes.Visible = true;
            lips.Visible = false;
            Tools.Visible = false;
            Body.Visible = false;
            item1.Visible = false;
            item2.Visible = false;
            item3.Visible = false;
            item4.Visible = false;
            eyechecked.Visible = true;
            lipschecked.Visible = false;
            facechecked.Visible = false;
            toolschecked.Visible = false;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            eyes.Visible = false;
            lips.Visible = false;
            Tools.Visible = false;
            Body.Visible = true;
            item1.Visible = false;
            item2.Visible = false;
            item3.Visible = false;
            item4.Visible = false;
            eyechecked.Visible = false;
            lipschecked.Visible = false;
            facechecked.Visible = true;
            toolschecked.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            eyes.Visible = false;
            lips.Visible = false;
            Tools.Visible = true;
            Body.Visible = false;
            item1.Visible = false;
            item2.Visible = false;
            item3.Visible = false;
            item4.Visible = false;
            eyechecked.Visible = false;
            lipschecked.Visible = false;
            facechecked.Visible = false;
            toolschecked.Visible = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            eyes.Visible = false;
            lips.Visible = false;
            Tools.Visible = false;
            Body.Visible = false;
            item1.Visible = false;
            item2.Visible = false;
            item3.Visible = false;
            item4.Visible = true;


            SqlDataAdapter adpt = new SqlDataAdapter("select name,price,details,stock,pro_image from products where pro_id=4", con);
            DataSet ds = new DataSet();
            adpt.Fill(ds);
            string namee = ds.Tables[0].Rows[0].ItemArray[0].ToString();
            string price = ds.Tables[0].Rows[0].ItemArray[1].ToString();
            string details = ds.Tables[0].Rows[0].ItemArray[2].ToString();
            string s = ds.Tables[0].Rows[0].ItemArray[3].ToString();
            int stock = Convert.ToInt32(s);

            MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["pro_image"]);

            pictureBox4.Image = new Bitmap(ms);
            name4.Text = namee;
            price4.Text = price;
            richTextBox4.Text = details;

            if (stock > 0)
            {
                stock4.Text = "YES";
            }
            else
            {
                stock4.Text = "NO";
            }

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void circular_button2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel8_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            eyes.Visible = false;
            lips.Visible = false;
            Tools.Visible = false;
            Body.Visible = false;
            item1.Visible = false;
            item2.Visible = true;
            item3.Visible = false;
            item4.Visible = false;


            SqlDataAdapter adpt = new SqlDataAdapter("select name,price,details,stock,pro_image from products where pro_id=2", con);
            DataSet ds = new DataSet();
            adpt.Fill(ds);
            string namee = ds.Tables[0].Rows[0].ItemArray[0].ToString();
            string price = ds.Tables[0].Rows[0].ItemArray[1].ToString();
            string details = ds.Tables[0].Rows[0].ItemArray[2].ToString();
            string s = ds.Tables[0].Rows[0].ItemArray[3].ToString();
            int stock = Convert.ToInt32(s);

            MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["pro_image"]);

            pictureBox2.Image = new Bitmap(ms);
            name2.Text = namee;
            price2.Text = price;
            richTextBox2.Text = details;

            if (stock > 0)
            {
                stock2.Text = "YES";
            }
            else
            {
                stock2.Text = "NO";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            eyes.Visible = false;
            lips.Visible = false;
            Tools.Visible = false;
            Body.Visible = false;
            item1.Visible = false;
            item2.Visible = false;
            item3.Visible = true;
            item4.Visible = false;


            SqlDataAdapter adpt = new SqlDataAdapter("select name,price,details,stock,pro_image from products where pro_id=3", con);
            DataSet ds = new DataSet();
            adpt.Fill(ds);
            string namee = ds.Tables[0].Rows[0].ItemArray[0].ToString();
            string price = ds.Tables[0].Rows[0].ItemArray[1].ToString();
            string details = ds.Tables[0].Rows[0].ItemArray[2].ToString();
            string s = ds.Tables[0].Rows[0].ItemArray[3].ToString();
            int stock = Convert.ToInt32(s);

            MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["pro_image"]);

            pictureBox3.Image = new Bitmap(ms);
            name3.Text = namee;
            price3.Text = price;
            richTextBox3.Text = details;

            if (stock > 0)
            {
                stock3.Text = "YES";
            }
            else
            {
                stock3.Text = "NO";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            //    eyes.Visible = false;
            //    item4.Visible = true;


            //    SqlDataAdapter adpt = new SqlDataAdapter("select name,price,details,stock,pro_image from products where pro_id=4", con);
            //    DataSet ds = new DataSet();
            //    adpt.Fill(ds);
            //    string namee = ds.Tables[0].Rows[0].ItemArray[0].ToString();
            //    string price = ds.Tables[0].Rows[0].ItemArray[1].ToString();
            //    string details = ds.Tables[0].Rows[0].ItemArray[2].ToString();
            //    string s = ds.Tables[0].Rows[0].ItemArray[3].ToString();
            //    int stock = Convert.ToInt32(s);

            //    MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["pro_image"]);

            //    pictureBox4.Image = new Bitmap(ms);
            //    name4.Text = namee;
            //    price4.Text = price;
            //    richTextBox4.Text = details;

            //    if (stock > 0)
            //    {
            //        stock4.Text = "YES";
            //    }
            //    else
            //    {
            //        stock4.Text = "NO";
            //    }
            //}

        }
    }
}

