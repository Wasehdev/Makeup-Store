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
        int srno = 0;


        public static string na="";
        public static string pr="";
        public static string qu="";
        public static string to="";

        public Form1()
        {
            InitializeComponent();

            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "SR NO";
            dataGridView1.Columns[1].Name = "Item Name"; 
            dataGridView1.Columns[2].Name = "Item Price";
            dataGridView1.Columns[3].Name = "Quantity";
            dataGridView1.Columns[4].Name = "Total";

           
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
        //form 1 loads
        private void Form1_Load(object sender, EventArgs e)
        {


            eyes.Visible = true;
            lips.Visible = false;
            Tools.Visible = false;
            face.Visible = false;
            item1.Visible = false;
            item2.Visible = false;
            item3.Visible = true;
            item4.Visible = false;
            item5.Visible = false;
            item6.Visible = false;
            item7.Visible = false;
            item8.Visible = false;
            item9.Visible = false;
            item10.Visible = false;
            item11.Visible = false;
            item12.Visible = false;
            item13.Visible = false;
            item14.Visible = false;
            item15.Visible = false;
            item16.Visible = false;
            item17.Visible = false;
            item22.Visible = false;
            item19.Visible = false;
            item20.Visible = false;
            item21.Visible = false;
            item18.Visible = false;
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

            // btn5
            adpt = new SqlDataAdapter("select name,price,pro_image from products where pro_id=7", con);
            ds = new DataSet();
            adpt.Fill(ds);
            namee = ds.Tables[0].Rows[0].ItemArray[0].ToString();
            price = ds.Tables[0].Rows[0].ItemArray[1].ToString();

            ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["pro_image"]);

            btn5.BackgroundImage = new Bitmap(ms);
            pl5.Text = price;
            nl5.Text = namee;




        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        //lips panel
        private void button2_Click(object sender, EventArgs e)
        {
            eyes.Visible = false;
            lips.Visible = true;
            Tools.Visible = false;
            face.Visible = false;
            item1.Visible = false;
            item2.Visible = false;
            item3.Visible = false;
            item4.Visible = false;
            item5.Visible = false;
            item6.Visible = false;
            item7.Visible = false;
            item8.Visible = false;
            item9.Visible = false;
            item10.Visible = false;
            item11.Visible = false;
            item12.Visible = false;
            item13.Visible = false;
            item14.Visible = false;
            item15.Visible = false;
            item16.Visible = false;
            item17.Visible = false;
            item22.Visible = false;
            item19.Visible = false;
            item20.Visible = false;
            item21.Visible = false;
            item18.Visible = false;
            eyechecked.Visible = false;
            lipschecked.Visible = true;
            facechecked.Visible = false;
            toolschecked.Visible = false;

            // btn6   
            
            SqlDataAdapter adpt = new SqlDataAdapter("select name,price,pro_image from products where pro_id=5", con);
            DataSet ds = new DataSet();
            adpt.Fill(ds);
            string namee = ds.Tables[0].Rows[0].ItemArray[0].ToString();
            string price = ds.Tables[0].Rows[0].ItemArray[1].ToString();

            MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["pro_image"]);

            btn6.BackgroundImage = new Bitmap(ms);
            pl6.Text = price;
            nl6.Text = namee;

            // btn7  
            adpt = new SqlDataAdapter("select name,price,pro_image from products where pro_id=6", con);
            ds = new DataSet();
            adpt.Fill(ds);
            namee = ds.Tables[0].Rows[0].ItemArray[0].ToString();
            price = ds.Tables[0].Rows[0].ItemArray[1].ToString();

            ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["pro_image"]);

            btn7.BackgroundImage = new Bitmap(ms);
            pl7.Text = price;
            nl7.Text = namee;

            // btn8
            adpt = new SqlDataAdapter("select name,price,pro_image from products where pro_id=8", con);
            ds = new DataSet();
            adpt.Fill(ds);
            namee = ds.Tables[0].Rows[0].ItemArray[0].ToString();
            price = ds.Tables[0].Rows[0].ItemArray[1].ToString();

            ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["pro_image"]);

            btn8.BackgroundImage = new Bitmap(ms);
            pl8.Text = price;
            nl8.Text = namee;

            // btn9
            adpt = new SqlDataAdapter("select name,price,pro_image from products where pro_id=9", con);
            ds = new DataSet();
            adpt.Fill(ds);
            namee = ds.Tables[0].Rows[0].ItemArray[0].ToString();
            price = ds.Tables[0].Rows[0].ItemArray[1].ToString();

            ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["pro_image"]);

            btn9.BackgroundImage = new Bitmap(ms);
            pl9.Text = price;
            nl9.Text = namee;

            // btn10
            adpt = new SqlDataAdapter("select name,price,pro_image from products where pro_id=10", con);
            ds = new DataSet();
            adpt.Fill(ds);
            namee = ds.Tables[0].Rows[0].ItemArray[0].ToString();
            price = ds.Tables[0].Rows[0].ItemArray[1].ToString();

            ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["pro_image"]);

            btn10.BackgroundImage = new Bitmap(ms);
            pl10.Text = price;
            nl10.Text = namee;

            // btn11
            adpt = new SqlDataAdapter("select name,price,pro_image from products where pro_id=11", con);
            ds = new DataSet();
            adpt.Fill(ds);
            namee = ds.Tables[0].Rows[0].ItemArray[0].ToString();
            price = ds.Tables[0].Rows[0].ItemArray[1].ToString();

            ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["pro_image"]);

            btn11.BackgroundImage = new Bitmap(ms);
            pl11.Text = price;
            nl11.Text = namee;



        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
        //item 1
        private void button1_Click_1(object sender, EventArgs e)
        {
            eyes.Visible = false;
            lips.Visible = false;
            Tools.Visible = false;
            face.Visible = false;
            item3.Visible = false;
            item2.Visible = false;
            item1.Visible = true;
            item4.Visible = false;
            item5.Visible = false;
            item6.Visible = false;
            item7.Visible = false;
            item8.Visible = false;
            item9.Visible = false;
            item10.Visible = false;
            item11.Visible = false;
            item12.Visible = false;
            item13.Visible = false;
            item14.Visible = false;
            item15.Visible = false;
            item16.Visible = false;
            item17.Visible = false;
            item22.Visible = false;
            item19.Visible = false;
            item20.Visible = false;
            item21.Visible = false;
            item18.Visible = false;


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
        //eyes panel
        private void button4_Click(object sender, EventArgs e)
        {
            eyes.Visible = true;
            lips.Visible = false;
            Tools.Visible = false;
            face.Visible = false;
            item1.Visible = false;
            item2.Visible = false;
            item3.Visible = false;
            item4.Visible = false;
            item5.Visible = false;
            item6.Visible = false;
            item7.Visible = false;
            item8.Visible = false;
            item9.Visible = false;
            item10.Visible = false;
            item11.Visible = false;
            item12.Visible = false;
            item13.Visible = false;
            item14.Visible = false;
            item15.Visible = false;
            item16.Visible = false;
            item17.Visible = false;
            item22.Visible = false;
            item19.Visible = false;
            item20.Visible = false;
            item21.Visible = false;
            item18.Visible = false;
            eyechecked.Visible = true;
            lipschecked.Visible = false;
            facechecked.Visible = false;
            toolschecked.Visible = false;

        }
        // face panel 
        private void button5_Click(object sender, EventArgs e)
        {
            eyes.Visible = false;
            lips.Visible = false;
            Tools.Visible = false;
            face.Visible = true;
            item1.Visible = false;
            item2.Visible = false;
            item3.Visible = false;
            item4.Visible = false;
            item5.Visible = false;
            item6.Visible = false;
            item7.Visible = false;
            item8.Visible = false;
            item9.Visible = false;
            item10.Visible = false;
            item11.Visible = false;
            item12.Visible = false;
            item13.Visible = false;
            item14.Visible = false;
            item15.Visible = false;
            item16.Visible = false;
            item17.Visible = false;
            item22.Visible = false;
            item19.Visible = false;
            item20.Visible = false;
            item21.Visible = false;
            item18.Visible = false;
            eyechecked.Visible = false;
            lipschecked.Visible = false;
            facechecked.Visible = true;
            toolschecked.Visible = false;



            // btn12  

            SqlDataAdapter adpt = new SqlDataAdapter("select name,price,pro_image from products where pro_id=12", con);
            DataSet ds = new DataSet();
            adpt.Fill(ds);
            string namee = ds.Tables[0].Rows[0].ItemArray[0].ToString();
            string price = ds.Tables[0].Rows[0].ItemArray[1].ToString();

            MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["pro_image"]);

            btn12.BackgroundImage = new Bitmap(ms);
            pl12.Text = price;
            nl12.Text = namee;

            // btn13 
            adpt = new SqlDataAdapter("select name,price,pro_image from products where pro_id=13", con);
            ds = new DataSet();
            adpt.Fill(ds);
            namee = ds.Tables[0].Rows[0].ItemArray[0].ToString();
            price = ds.Tables[0].Rows[0].ItemArray[1].ToString();

            ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["pro_image"]);

            btn13.BackgroundImage = new Bitmap(ms);
            pl13.Text = price;
            nl13.Text = namee;

            // btn14
            adpt = new SqlDataAdapter("select name,price,pro_image from products where pro_id=14", con);
            ds = new DataSet();
            adpt.Fill(ds);
            namee = ds.Tables[0].Rows[0].ItemArray[0].ToString();
            price = ds.Tables[0].Rows[0].ItemArray[1].ToString();

            ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["pro_image"]);

            btn14.BackgroundImage = new Bitmap(ms);
            pl14.Text = price;
            nl14.Text = namee;

            // btn15
            adpt = new SqlDataAdapter("select name,price,pro_image from products where pro_id=15", con);
            ds = new DataSet();
            adpt.Fill(ds);
            namee = ds.Tables[0].Rows[0].ItemArray[0].ToString();
            price = ds.Tables[0].Rows[0].ItemArray[1].ToString();

            ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["pro_image"]);

            btn15.BackgroundImage = new Bitmap(ms);
            pl15.Text = price;
            nl15.Text = namee;

            // btn16
            adpt = new SqlDataAdapter("select name,price,pro_image from products where pro_id=16", con);
            ds = new DataSet();
            adpt.Fill(ds);
            namee = ds.Tables[0].Rows[0].ItemArray[0].ToString();
            price = ds.Tables[0].Rows[0].ItemArray[1].ToString();

            ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["pro_image"]);

            btn16.BackgroundImage = new Bitmap(ms);
            pl16.Text = price;
            nl16.Text = namee;

            // btn17
            adpt = new SqlDataAdapter("select name,price,pro_image from products where pro_id=17", con);
            ds = new DataSet();
            adpt.Fill(ds);
            namee = ds.Tables[0].Rows[0].ItemArray[0].ToString();
            price = ds.Tables[0].Rows[0].ItemArray[1].ToString();

            ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["pro_image"]);

            btn17.BackgroundImage = new Bitmap(ms);
            pl17.Text = price;
            nl17.Text = namee;


        }
        //tools panel
        private void button6_Click(object sender, EventArgs e)
        {
            eyes.Visible = false;
            lips.Visible = false;
            Tools.Visible = true;
            face.Visible = false;
            item1.Visible = false;
            item2.Visible = false;
            item3.Visible = false;
            item4.Visible = false;
            item5.Visible = false;
            item6.Visible = false;
            item7.Visible = false;
            item8.Visible = false;
            item9.Visible = false;
            item10.Visible = false;
            item11.Visible = false;
            item12.Visible = false;
            item13.Visible = false;
            item14.Visible = false;
            item15.Visible = false;
            item16.Visible = false;
            item17.Visible = false;
            item22.Visible = false;
            item19.Visible = false;
            item20.Visible = false;
            item21.Visible = false;
            item18.Visible = false;
            eyechecked.Visible = false;
            lipschecked.Visible = false;
            facechecked.Visible = false;
            toolschecked.Visible = true;

            // btn18  

            SqlDataAdapter adpt = new SqlDataAdapter("select name,price,pro_image from products where pro_id=18", con);
            DataSet ds = new DataSet();
            adpt.Fill(ds);
            string namee = ds.Tables[0].Rows[0].ItemArray[0].ToString();
            string price = ds.Tables[0].Rows[0].ItemArray[1].ToString();

            MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["pro_image"]);

            btn18.BackgroundImage = new Bitmap(ms);
            pl18.Text = price;
            nl18.Text = namee;

            // btn19 
            adpt = new SqlDataAdapter("select name,price,pro_image from products where pro_id=19", con);
            ds = new DataSet();
            adpt.Fill(ds);
            namee = ds.Tables[0].Rows[0].ItemArray[0].ToString();
            price = ds.Tables[0].Rows[0].ItemArray[1].ToString();

            ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["pro_image"]);

            btn19.BackgroundImage = new Bitmap(ms);
            pl19.Text = price;
            nl19.Text = namee;

            // btn20
            adpt = new SqlDataAdapter("select name,price,pro_image from products where pro_id=20", con);
            ds = new DataSet();
            adpt.Fill(ds);
            namee = ds.Tables[0].Rows[0].ItemArray[0].ToString();
            price = ds.Tables[0].Rows[0].ItemArray[1].ToString();

            ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["pro_image"]);

            btn20.BackgroundImage = new Bitmap(ms);
            pl20.Text = price;
            nl20.Text = namee;

            // btn21
            adpt = new SqlDataAdapter("select name,price,pro_image from products where pro_id=21", con);
            ds = new DataSet();
            adpt.Fill(ds);
            namee = ds.Tables[0].Rows[0].ItemArray[0].ToString();
            price = ds.Tables[0].Rows[0].ItemArray[1].ToString();

            ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["pro_image"]);

            btn21.BackgroundImage = new Bitmap(ms);
            pl21.Text = price;
            nl21.Text = namee;

            // btn22
            adpt = new SqlDataAdapter("select name,price,pro_image from products where pro_id=22", con);
            ds = new DataSet();
            adpt.Fill(ds);
            namee = ds.Tables[0].Rows[0].ItemArray[0].ToString();
            price = ds.Tables[0].Rows[0].ItemArray[1].ToString();

            ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["pro_image"]);

            btn22.BackgroundImage = new Bitmap(ms);
            pl22.Text = price;
            nl22.Text = namee;

         


        }
        //item 4
        private void button9_Click(object sender, EventArgs e)
        {
            eyes.Visible = false;
            lips.Visible = false;
            Tools.Visible = false;
            face.Visible = false;
            item1.Visible = false;
            item2.Visible = false;
            item4.Visible = true;
            item3.Visible = false;
            item5.Visible = false;
            item6.Visible = false;
            item7.Visible = false;
            item8.Visible = false;
            item9.Visible = false;
            item10.Visible = false;
            item11.Visible = false;
            item12.Visible = false;
            item13.Visible = false;
            item14.Visible = false;
            item15.Visible = false;
            item16.Visible = false;
            item17.Visible = false;
            item22.Visible = false;
            item19.Visible = false;
            item20.Visible = false;
            item21.Visible = false;
            item18.Visible = false;


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
            price4.Text = price+ " $";
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
      //  buy now 1
        private void button4_Click_1(object sender, EventArgs e)
        {
            buyNow(name1.Text, price1.Text, cb1.Text);
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
        //item2
        private void btn2_Click(object sender, EventArgs e)
        {
            eyes.Visible = false;
            lips.Visible = false;
            Tools.Visible = false;
            face.Visible = false;
            item1.Visible = false;
            item2.Visible = true;
            item3.Visible = false;
            item4.Visible = false;
            item5.Visible = false;
            item6.Visible = false;
            item7.Visible = false;
            item8.Visible = false;
            item9.Visible = false;
            item10.Visible = false;
            item11.Visible = false;
            item12.Visible = false;
            item13.Visible = false;
            item14.Visible = false;
            item15.Visible = false;
            item16.Visible = false;
            item17.Visible = false;
            item22.Visible = false;
            item19.Visible = false;
            item20.Visible = false;
            item21.Visible = false;
            item18.Visible = false;

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
        //item 3
        private void btn3_Click(object sender, EventArgs e)
        {
            eyes.Visible = false;
            lips.Visible = false;
            Tools.Visible = false;
            face.Visible = false;
            item1.Visible = false;
            item2.Visible = false;
            item3.Visible = true;
            item4.Visible = false;
            item5.Visible = false;
            item6.Visible = false;
            item7.Visible = false;
            item8.Visible = false;
            item9.Visible = false;
            item10.Visible = false;
            item11.Visible = false;
            item12.Visible = false;
            item13.Visible = false;
            item14.Visible = false;
            item15.Visible = false;
            item16.Visible = false;
            item17.Visible = false;
            item22.Visible = false;
            item19.Visible = false;
            item20.Visible = false;
            item21.Visible = false;
            item18.Visible = false;




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
        //item 5
        private void btn5_Click(object sender, EventArgs e)
        {
            eyes.Visible = false;
            lips.Visible = false;
            Tools.Visible = false;
            face.Visible = false;
            item1.Visible = false;
            item2.Visible = false;
            item3.Visible = false;
            item4.Visible = false;
            item5.Visible = true;
            item6.Visible = false;
            item7.Visible = false;
            item8.Visible = false;
            item9.Visible = false;
            item10.Visible = false;
            item11.Visible = false;
            item12.Visible = false;
            item13.Visible = false;
            item16.Visible = false;
            item14.Visible = false;
            item15.Visible = false;
            item17.Visible = false;
            item22.Visible = false;
            item19.Visible = false;
            item20.Visible = false;
            item21.Visible = false;
            item18.Visible = false;


            SqlDataAdapter adpt = new SqlDataAdapter("select name,price,details,stock,pro_image from products where pro_id=7", con);
            DataSet ds = new DataSet();
            adpt.Fill(ds);
            string namee = ds.Tables[0].Rows[0].ItemArray[0].ToString();
            string price = ds.Tables[0].Rows[0].ItemArray[1].ToString();
            string details = ds.Tables[0].Rows[0].ItemArray[2].ToString();
            string s = ds.Tables[0].Rows[0].ItemArray[3].ToString();
            int stock = Convert.ToInt32(s);

            MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["pro_image"]);

            pictureBox5.Image = new Bitmap(ms);
            name5.Text = namee;
            price5.Text = price;
            richTextBox5.Text = details;

            if (stock > 0)
            {
                stock5.Text = "YES";
            }
            else
            {
                stock5.Text = "NO";
            }

        }
        //Item 6
        private void btn6_Click(object sender, EventArgs e)
        {
            eyes.Visible = false;
            lips.Visible = false;
            Tools.Visible = false;
            face.Visible = false;
            item1.Visible = false;
            item2.Visible = false;
            item3.Visible = false;
            item4.Visible = false;
            item5.Visible = false;
            item6.Visible = true; 
            item7.Visible = false;
            item8.Visible = false;
            item9.Visible = false;
            item10.Visible = false;
            item11.Visible = false;
            item12.Visible = false;
            item13.Visible = false;
            item16.Visible = false;
            item14.Visible = false;
            item15.Visible = false;
            item17.Visible = false;
            item22.Visible = false;
            item19.Visible = false;
            item20.Visible = false;
            item21.Visible = false;
            item18.Visible = false;


            SqlDataAdapter adpt = new SqlDataAdapter("select name,price,details,stock,pro_image from products where pro_id=5", con);
            DataSet ds = new DataSet();
            adpt.Fill(ds);
            string namee = ds.Tables[0].Rows[0].ItemArray[0].ToString();
            string price = ds.Tables[0].Rows[0].ItemArray[1].ToString();
            string details = ds.Tables[0].Rows[0].ItemArray[2].ToString();
            string s = ds.Tables[0].Rows[0].ItemArray[3].ToString();
            int stock = Convert.ToInt32(s);

            MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["pro_image"]);

            pictureBox6.Image = new Bitmap(ms);
            name6.Text = namee;
            price6.Text = price;
            richTextBox6.Text = details;

            if (stock > 0)
            {
                stock6.Text = "YES";
            }
            else
            {
                stock6.Text = "NO";
            }
        }
        //item 7
        private void btn7_Click(object sender, EventArgs e)
        {
            eyes.Visible = false;
            lips.Visible = false;
            Tools.Visible = false;
            face.Visible = false;
            item1.Visible = false;
            item2.Visible = false;
            item3.Visible = false;
            item4.Visible = false;
            item5.Visible = false;
            item6.Visible = false;
            item7.Visible = true;
            item8.Visible = false;
            item9.Visible = false;
            item10.Visible = false;
            item11.Visible = false;
            item12.Visible = false;
            item13.Visible = false;
            item16.Visible = false;
            item14.Visible = false;
            item15.Visible = false;
            item17.Visible = false;
            item22.Visible = false;
            item19.Visible = false;
            item20.Visible = false;
            item21.Visible = false;
            item18.Visible = false;


            SqlDataAdapter adpt = new SqlDataAdapter("select name,price,details,stock,pro_image from products where pro_id=6", con);
            DataSet ds = new DataSet();
            adpt.Fill(ds);
            string namee = ds.Tables[0].Rows[0].ItemArray[0].ToString();
            string price = ds.Tables[0].Rows[0].ItemArray[1].ToString();
            string details = ds.Tables[0].Rows[0].ItemArray[2].ToString();
            string s = ds.Tables[0].Rows[0].ItemArray[3].ToString();
            int stock = Convert.ToInt32(s);

            MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["pro_image"]);

            pictureBox7.Image = new Bitmap(ms);
            name7.Text = namee;
            price7.Text = price;
            richTextBox7.Text = details;

            if (stock > 0)
            {
                stock7.Text = "YES";
            }
            else
            {
                stock7.Text = "NO";
            }
        }
        //item 8
        private void btn8_Click(object sender, EventArgs e)
        {
            eyes.Visible = false;
            lips.Visible = false;
            Tools.Visible = false;
            face.Visible = false;
            item1.Visible = false;
            item2.Visible = false;
            item3.Visible = false;
            item4.Visible = false;
            item5.Visible = false;
            item6.Visible = false;
            item7.Visible = false;
            item8.Visible = true;
            item9.Visible = false;
            item10.Visible = false;
            item11.Visible = false;
            item12.Visible = false;
            item13.Visible = false;
            item16.Visible = false;
            item14.Visible = false;
            item15.Visible = false;
            item17.Visible = false;
            item22.Visible = false;
            item19.Visible = false;
            item20.Visible = false;
            item21.Visible = false;
            item18.Visible = false;

            SqlDataAdapter adpt = new SqlDataAdapter("select name,price,details,stock,pro_image from products where pro_id=8", con);
            DataSet ds = new DataSet();
            adpt.Fill(ds);
            string namee = ds.Tables[0].Rows[0].ItemArray[0].ToString();
            string price = ds.Tables[0].Rows[0].ItemArray[1].ToString();
            string details = ds.Tables[0].Rows[0].ItemArray[2].ToString();
            string s = ds.Tables[0].Rows[0].ItemArray[3].ToString();
            int stock = Convert.ToInt32(s);

            MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["pro_image"]);

            pictureBox8.Image = new Bitmap(ms);
            name8.Text = namee;
            price8.Text = price;
            richTextBox8.Text = details;

            if (stock > 0)
            {
                stock8.Text = "YES";
            }
            else
            {
                stock8.Text = "NO";
            }
        }
        //item 9
        private void btn9_Click(object sender, EventArgs e)
        {
            eyes.Visible = false;
            lips.Visible = false;
            Tools.Visible = false;
            face.Visible = false;
            item1.Visible = false;
            item2.Visible = false;
            item3.Visible = false;
            item4.Visible = false;
            item5.Visible = false;
            item6.Visible = false;
            item7.Visible = false;
            item8.Visible = false;
            item9.Visible = true;
            item10.Visible = false;
            item11.Visible = false;
            item12.Visible = false;
            item13.Visible = false;
            item16.Visible = false;
            item14.Visible = false;
            item15.Visible = false;
            item17.Visible = false;
            item22.Visible = false;
            item19.Visible = false;
            item20.Visible = false;
            item21.Visible = false;
            item18.Visible = false;


            SqlDataAdapter adpt = new SqlDataAdapter("select name,price,details,stock,pro_image from products where pro_id=9", con);
            DataSet ds = new DataSet();
            adpt.Fill(ds);
            string namee = ds.Tables[0].Rows[0].ItemArray[0].ToString();
            string price = ds.Tables[0].Rows[0].ItemArray[1].ToString();
            string details = ds.Tables[0].Rows[0].ItemArray[2].ToString();
            string s = ds.Tables[0].Rows[0].ItemArray[3].ToString();
            int stock = Convert.ToInt32(s);

            MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["pro_image"]);

            pictureBox9.Image = new Bitmap(ms);
            name9.Text = namee;
            price9.Text = price;
            richTextBox9.Text = details;

            if (stock > 0)
            {
                stock9.Text = "YES";
            }
            else
            {
                stock9.Text = "NO";
            }
        }
        //item10
        private void btn10_Click(object sender, EventArgs e)
        {
            eyes.Visible = false;
            lips.Visible = false;
            Tools.Visible = false;
            face.Visible = false;
            item1.Visible = false;
            item2.Visible = false;
            item3.Visible = false;
            item4.Visible = false;
            item5.Visible = false;
            item6.Visible = false;
            item7.Visible = false;
            item8.Visible = false;
            item9.Visible = false;
            item10.Visible = true;
            item11.Visible = false; 
            item12.Visible = false;
            item13.Visible = false;
            item16.Visible = false;
            item14.Visible = false;
            item15.Visible = false;
            item17.Visible = false;
            item22.Visible = false;
            item19.Visible = false;
            item20.Visible = false;
            item21.Visible = false;
            item18.Visible = false;


            SqlDataAdapter adpt = new SqlDataAdapter("select name,price,details,stock,pro_image from products where pro_id=10", con);
            DataSet ds = new DataSet();
            adpt.Fill(ds);
            string namee = ds.Tables[0].Rows[0].ItemArray[0].ToString();
            string price = ds.Tables[0].Rows[0].ItemArray[1].ToString();
            string details = ds.Tables[0].Rows[0].ItemArray[2].ToString();
            string s = ds.Tables[0].Rows[0].ItemArray[3].ToString();
            int stock = Convert.ToInt32(s);

            MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["pro_image"]);

            pictureBox10.Image = new Bitmap(ms);
            name10.Text = namee;
            price10.Text = price;
            richTextBox10.Text = details;

            if (stock > 0)
            {
                stock10.Text = "YES";
            }
            else
            {
                stock10.Text = "NO";
            }
        }
        //item 11
        private void btn11_Click(object sender, EventArgs e)
        {
            eyes.Visible = false;
            lips.Visible = false;
            Tools.Visible = false;
            face.Visible = false;
            item1.Visible = false;
            item2.Visible = false;
            item3.Visible = false;
            item4.Visible = false;
            item5.Visible = false;
            item6.Visible = false;
            item7.Visible = false;
            item8.Visible = false;
            item9.Visible = false;
            item10.Visible = false;
            item11.Visible = true;
            item12.Visible = false;
            item13.Visible = false;
            item16.Visible = false;
            item14.Visible = false;
            item15.Visible = false;
            item17.Visible = false;
            item22.Visible = false;
            item19.Visible = false;
            item20.Visible = false;
            item21.Visible = false;
            item18.Visible = false;


            SqlDataAdapter adpt = new SqlDataAdapter("select name,price,details,stock,pro_image from products where pro_id=11", con);
            DataSet ds = new DataSet();
            adpt.Fill(ds);
            string namee = ds.Tables[0].Rows[0].ItemArray[0].ToString();
            string price = ds.Tables[0].Rows[0].ItemArray[1].ToString();
            string details = ds.Tables[0].Rows[0].ItemArray[2].ToString();
            string s = ds.Tables[0].Rows[0].ItemArray[3].ToString();
            int stock = Convert.ToInt32(s);

            MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["pro_image"]);

            pictureBox11.Image = new Bitmap(ms);
            name11.Text = namee;
            price11.Text = price;
            richTextBox11.Text = details;

            if (stock > 0)
            {
                stock11.Text = "YES";
            }
            else
            {
                stock11.Text = "NO";
            }
        }
         // item 12
        private void btn12_Click(object sender, EventArgs e)
        {
            eyes.Visible = false;
            lips.Visible = false;
            Tools.Visible = false;
            face.Visible = false;
            item1.Visible = false;
            item2.Visible = false;
            item3.Visible = false;
            item4.Visible = false;
            item5.Visible = false;
            item6.Visible = false;
            item7.Visible = false;
            item8.Visible = false;
            item9.Visible = false;
            item10.Visible = false;
            item11.Visible = false;
            item12.Visible = true;
            item13.Visible = false;
            item16.Visible = false;
            item14.Visible = false;
            item15.Visible = false;
            item17.Visible = false;
            item22.Visible = false;
            item19.Visible = false;
            item20.Visible = false;
            item21.Visible = false;
            item18.Visible = false;

            SqlDataAdapter adpt = new SqlDataAdapter("select name,price,details,stock,pro_image from products where pro_id=12", con);
            DataSet ds = new DataSet();
            adpt.Fill(ds);
            string namee = ds.Tables[0].Rows[0].ItemArray[0].ToString();
            string price = ds.Tables[0].Rows[0].ItemArray[1].ToString();
            string details = ds.Tables[0].Rows[0].ItemArray[2].ToString();
            string s = ds.Tables[0].Rows[0].ItemArray[3].ToString();
            int stock = Convert.ToInt32(s);

            MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["pro_image"]);

            pictureBox12.Image = new Bitmap(ms);
            name12.Text = namee;
            price12.Text = price;
            richTextBox12.Text = details;

            if (stock > 0)
            {
                stock12.Text = "YES";
            }
            else
            {
                stock12.Text = "NO";
            }
        }
       // item 13
        private void btn13_Click(object sender, EventArgs e)
        {
            eyes.Visible = false;
            lips.Visible = false;
            Tools.Visible = false;
            face.Visible = false;
            item1.Visible = false;
            item2.Visible = false;
            item3.Visible = false;
            item4.Visible = false;
            item5.Visible = false;
            item6.Visible = false;
            item7.Visible = false;
            item8.Visible = false;
            item9.Visible = false;
            item10.Visible = false;
            item11.Visible = false;
            item12.Visible = false;
            item13.Visible = true;
            item16.Visible = false;
            item14.Visible = false;
            item15.Visible = false;
            item17.Visible = false;
            item22.Visible = false;
            item19.Visible = false;
            item20.Visible = false;
            item21.Visible = false;
            item18.Visible = false;

            SqlDataAdapter adpt = new SqlDataAdapter("select name,price,details,stock,pro_image from products where pro_id=13", con);
            DataSet ds = new DataSet();
            adpt.Fill(ds);
            string namee = ds.Tables[0].Rows[0].ItemArray[0].ToString();
            string price = ds.Tables[0].Rows[0].ItemArray[1].ToString();
            string details = ds.Tables[0].Rows[0].ItemArray[2].ToString();
            string s = ds.Tables[0].Rows[0].ItemArray[3].ToString();
            int stock = Convert.ToInt32(s);

            MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["pro_image"]);

            pictureBox13.Image = new Bitmap(ms);
            name13.Text = namee;
            price13.Text = price;
            richTextBox13.Text = details;

            if (stock > 0)
            {
                stock13.Text = "YES";
            }
            else
            {
                stock13.Text = "NO";
            }
        }
        //item 14
        private void btn14_Click(object sender, EventArgs e)
        {
            eyes.Visible = false;
            lips.Visible = false;
            Tools.Visible = false;
            face.Visible = false;
            item1.Visible = false;
            item2.Visible = false;
            item3.Visible = false;
            item4.Visible = false;
            item5.Visible = false;
            item6.Visible = false;
            item7.Visible = false;
            item8.Visible = false;
            item9.Visible = false;
            item10.Visible = false;
            item11.Visible = false;
            item12.Visible = false;
            item13.Visible = false;
            item16.Visible = false;
            item14.Visible = true;
            item15.Visible = false;
            item17.Visible = false;
            item22.Visible = false;
            item19.Visible = false;
            item20.Visible = false;
            item21.Visible = false;
            item18.Visible = false;

            SqlDataAdapter adpt = new SqlDataAdapter("select name,price,details,stock,pro_image from products where pro_id=14", con);
            DataSet ds = new DataSet();
            adpt.Fill(ds);
            string namee = ds.Tables[0].Rows[0].ItemArray[0].ToString();
            string price = ds.Tables[0].Rows[0].ItemArray[1].ToString();
            string details = ds.Tables[0].Rows[0].ItemArray[2].ToString();
            string s = ds.Tables[0].Rows[0].ItemArray[3].ToString();
            int stock = Convert.ToInt32(s);

            MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["pro_image"]);

            pictureBox14.Image = new Bitmap(ms);
            name14.Text = namee;
            price14.Text = price;
            richTextBox14.Text = details;

            if (stock > 0)
            {
                stock14.Text = "YES";
            }
            else
            {
                stock14.Text = "NO";
            }
        }

        //item 15

        private void btn15_Click(object sender, EventArgs e)
        {
            eyes.Visible = false;
            lips.Visible = false;
            Tools.Visible = false;
            face.Visible = false;
            item1.Visible = false;
            item2.Visible = false;
            item3.Visible = false;
            item4.Visible = false;
            item5.Visible = false;
            item6.Visible = false;
            item7.Visible = false;
            item8.Visible = false;
            item9.Visible = false;
            item10.Visible = false;
            item11.Visible = false;
            item12.Visible = false;
            item13.Visible = false;
            item16.Visible = false;
            item14.Visible = false;
            item15.Visible = true;
            item17.Visible = false;
            item22.Visible = false;
            item19.Visible = false;
            item20.Visible = false;
            item21.Visible = false;
            item18.Visible = false;

            SqlDataAdapter adpt = new SqlDataAdapter("select name,price,details,stock,pro_image from products where pro_id=15", con);
            DataSet ds = new DataSet();
            adpt.Fill(ds);
            string namee = ds.Tables[0].Rows[0].ItemArray[0].ToString();
            string price = ds.Tables[0].Rows[0].ItemArray[1].ToString();
            string details = ds.Tables[0].Rows[0].ItemArray[2].ToString();
            string s = ds.Tables[0].Rows[0].ItemArray[3].ToString();
            int stock = Convert.ToInt32(s);

            MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["pro_image"]);

            pictureBox15.Image = new Bitmap(ms);
            name15.Text = namee;
            price15.Text = price;
            richTextBox15.Text = details;

            if (stock > 0)
            {
                stock15.Text = "YES";
            }
            else
            {
                stock15.Text = "NO";
            }
        }
        //item 16
        private void btn16_Click(object sender, EventArgs e)
        {
            eyes.Visible = false;
            lips.Visible = false;
            Tools.Visible = false;
            face.Visible = false;
            item1.Visible = false;
            item2.Visible = false;
            item3.Visible = false;
            item4.Visible = false;
            item5.Visible = false;
            item6.Visible = false;
            item7.Visible = false;
            item8.Visible = false;
            item9.Visible = false;
            item10.Visible = false;
            item11.Visible = false;
            item12.Visible = false;
            item13.Visible = false;
            item16.Visible = true;
            item14.Visible = false;
            item15.Visible = false;
            item17.Visible = false;
            item22.Visible = false;
            item19.Visible = false;
            item20.Visible = false;
            item21.Visible = false;
            item18.Visible = false;

            SqlDataAdapter adpt = new SqlDataAdapter("select name,price,details,stock,pro_image from products where pro_id=16", con);
            DataSet ds = new DataSet();
            adpt.Fill(ds);
            string namee = ds.Tables[0].Rows[0].ItemArray[0].ToString();
            string price = ds.Tables[0].Rows[0].ItemArray[1].ToString();
            string details = ds.Tables[0].Rows[0].ItemArray[2].ToString();
            string s = ds.Tables[0].Rows[0].ItemArray[3].ToString();
            int stock = Convert.ToInt32(s);

            MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["pro_image"]);

            pictureBox16.Image = new Bitmap(ms);
            name16.Text = namee;
            price16.Text = price;
            richTextBox16.Text = details;

            if (stock > 0)
            {
                stock16.Text = "YES";
            }
            else
            {
                stock16.Text = "NO";
            }
        }
        //item 17
        private void btn17_Click(object sender, EventArgs e)
        {
            eyes.Visible = false;
            lips.Visible = false;
            Tools.Visible = false;
            face.Visible = false;
            item1.Visible = false;
            item2.Visible = false;
            item3.Visible = false;
            item4.Visible = false;
            item5.Visible = false;
            item6.Visible = false;
            item7.Visible = false;
            item8.Visible = false;
            item9.Visible = false;
            item10.Visible = false;
            item11.Visible = false;
            item12.Visible = false;
            item13.Visible = false;
            item16.Visible = false;
            item14.Visible = false;
            item15.Visible = false;
            item17.Visible = true;

            SqlDataAdapter adpt = new SqlDataAdapter("select name,price,details,stock,pro_image from products where pro_id=17", con);
            DataSet ds = new DataSet();
            adpt.Fill(ds);
            string namee = ds.Tables[0].Rows[0].ItemArray[0].ToString();
            string price = ds.Tables[0].Rows[0].ItemArray[1].ToString();
            string details = ds.Tables[0].Rows[0].ItemArray[2].ToString();
            string s = ds.Tables[0].Rows[0].ItemArray[3].ToString();
            int stock = Convert.ToInt32(s);

            MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["pro_image"]);

            pictureBox17.Image = new Bitmap(ms);
            name17.Text = namee;
            price17.Text = price;
            richTextBox17.Text = details;

            if (stock > 0)
            {
                stock17.Text = "YES";
            }
            else
            {
                stock17.Text = "NO";
            }
        }
        //item 18
        private void btn18_Click(object sender, EventArgs e)
        {
            eyes.Visible = false;
            lips.Visible = false;
            Tools.Visible = false;
            face.Visible = false;
            item1.Visible = false;
            item2.Visible = false;
            item3.Visible = false;
            item4.Visible = false;
            item5.Visible = false;
            item6.Visible = false;
            item7.Visible = false;
            item8.Visible = false;
            item9.Visible = false;
            item10.Visible = false;
            item11.Visible = false;
            item12.Visible = false;
            item13.Visible = false;
            item16.Visible = false;
            item14.Visible = false;
            item15.Visible = false;
            item18.Visible = true;
            item17.Visible = false;
            item19.Visible = false;
            item20.Visible = false;
            item21.Visible = false;
            item22.Visible = false;

            SqlDataAdapter adpt = new SqlDataAdapter("select name,price,details,stock,pro_image from products where pro_id=18", con);
            DataSet ds = new DataSet();
            adpt.Fill(ds);
            string namee = ds.Tables[0].Rows[0].ItemArray[0].ToString();
            string price = ds.Tables[0].Rows[0].ItemArray[1].ToString();
            string details = ds.Tables[0].Rows[0].ItemArray[2].ToString();
            string s = ds.Tables[0].Rows[0].ItemArray[3].ToString();
            int stock = Convert.ToInt32(s);

            MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["pro_image"]);

            pictureBox18.Image = new Bitmap(ms);
            name18.Text = namee;
            price18.Text = price;
            richTextBox18.Text = details;

            if (stock > 0)
            {
                stock18.Text = "YES";
            }
            else
            {
                stock18.Text = "NO";
            }
        }
        //item 19
        private void btn19_Click(object sender, EventArgs e)
        {
            eyes.Visible = false;
            lips.Visible = false;
            Tools.Visible = false;
            face.Visible = false;
            item1.Visible = false;
            item2.Visible = false;
            item3.Visible = false;
            item4.Visible = false;
            item5.Visible = false;
            item6.Visible = false;
            item7.Visible = false;
            item8.Visible = false;
            item9.Visible = false;
            item10.Visible = false;
            item11.Visible = false;
            item12.Visible = false;
            item13.Visible = false;
            item16.Visible = false;
            item14.Visible = false;
            item15.Visible = false;
            item19.Visible = true;
            item17.Visible = false;
            item18.Visible = false;
            item20.Visible = false;
            item21.Visible = false;
            item22.Visible = false;

            SqlDataAdapter adpt = new SqlDataAdapter("select name,price,details,stock,pro_image from products where pro_id=19", con);
            DataSet ds = new DataSet();
            adpt.Fill(ds);
            string namee = ds.Tables[0].Rows[0].ItemArray[0].ToString();
            string price = ds.Tables[0].Rows[0].ItemArray[1].ToString();
            string details = ds.Tables[0].Rows[0].ItemArray[2].ToString();
            string s = ds.Tables[0].Rows[0].ItemArray[3].ToString();
            int stock = Convert.ToInt32(s);

            MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["pro_image"]);

            pictureBox19.Image = new Bitmap(ms);
            name19.Text = namee;
            price19.Text = price;
            richTextBox19.Text = details;

            if (stock > 0)
            {
                stock19.Text = "YES";
            }
            else
            {
                stock19.Text = "NO";
            }
        }
        //item 20
        private void btn20_Click(object sender, EventArgs e)
        {
            eyes.Visible = false;
            lips.Visible = false;
            Tools.Visible = false;
            face.Visible = false;
            item1.Visible = false;
            item2.Visible = false;
            item3.Visible = false;
            item4.Visible = false;
            item5.Visible = false;
            item6.Visible = false;
            item7.Visible = false;
            item8.Visible = false;
            item9.Visible = false;
            item10.Visible = false;
            item11.Visible = false;
            item12.Visible = false;
            item13.Visible = false;
            item16.Visible = false;
            item14.Visible = false;
            item15.Visible = false;
            item20.Visible = true;
            item17.Visible = false;
            item18.Visible = false;
            item19.Visible = false;
            item21.Visible = false;
            item22.Visible = false;

            SqlDataAdapter adpt = new SqlDataAdapter("select name,price,details,stock,pro_image from products where pro_id=20", con);
            DataSet ds = new DataSet();
            adpt.Fill(ds);
            string namee = ds.Tables[0].Rows[0].ItemArray[0].ToString();
            string price = ds.Tables[0].Rows[0].ItemArray[1].ToString();
            string details = ds.Tables[0].Rows[0].ItemArray[2].ToString();
            string s = ds.Tables[0].Rows[0].ItemArray[3].ToString();
            int stock = Convert.ToInt32(s);

            MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["pro_image"]);

            pictureBox20.Image = new Bitmap(ms);
            name20.Text = namee;
            price20.Text = price;
            richTextBox20.Text = details;

            if (stock > 0)
            {
                stock20.Text = "YES";
            }
            else
            {
                stock20.Text = "NO";
            }
        }
        //item 21
        private void btn21_Click(object sender, EventArgs e)
        {
            eyes.Visible = false;
            lips.Visible = false;
            Tools.Visible = false;
            face.Visible = false;
            item1.Visible = false;
            item2.Visible = false;
            item3.Visible = false;
            item4.Visible = false;
            item5.Visible = false;
            item6.Visible = false;
            item7.Visible = false;
            item8.Visible = false;
            item9.Visible = false;
            item10.Visible = false;
            item11.Visible = false;
            item12.Visible = false;
            item13.Visible = false;
            item16.Visible = false;
            item14.Visible = false;
            item15.Visible = false;
            item21.Visible = true;
            item17.Visible = false;
            item19.Visible = false;
            item20.Visible = false;
            item18.Visible = false;
            item22.Visible = false;

            SqlDataAdapter adpt = new SqlDataAdapter("select name,price,details,stock,pro_image from products where pro_id=21", con);
            DataSet ds = new DataSet();
            adpt.Fill(ds);
            string namee = ds.Tables[0].Rows[0].ItemArray[0].ToString();
            string price = ds.Tables[0].Rows[0].ItemArray[1].ToString();
            string details = ds.Tables[0].Rows[0].ItemArray[2].ToString();
            string s = ds.Tables[0].Rows[0].ItemArray[3].ToString();
            int stock = Convert.ToInt32(s);

            MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["pro_image"]);

            pictureBox21.Image = new Bitmap(ms);
            name21.Text = namee;
            price21.Text = price;
            richTextBox21.Text = details;

            if (stock > 0)
            {
                stock21.Text = "YES";
            }
            else
            {
                stock21.Text = "NO";
            }
        }
        //item 22
        
        private void btn22_Click_1(object sender, EventArgs e)
        {
            eyes.Visible = false;
            lips.Visible = false;
            Tools.Visible = false;
            face.Visible = false;
            item1.Visible = false;
            item2.Visible = false;
            item3.Visible = false;
            item4.Visible = false;
            item5.Visible = false;
            item6.Visible = false;
            item7.Visible = false;
            item8.Visible = false;
            item9.Visible = false;
            item10.Visible = false;
            item11.Visible = false;
            item12.Visible = false;
            item13.Visible = false;
            item16.Visible = false;
            item14.Visible = false;
            item15.Visible = false;
            item21.Visible = false;
            item17.Visible = false;
            item19.Visible = false;
            item20.Visible = false;
            item18.Visible = false;
            item22.Visible = true;

            SqlDataAdapter adpt = new SqlDataAdapter("select name,price,details,stock,pro_image from products where pro_id=22", con);
            DataSet ds = new DataSet();
            adpt.Fill(ds);
            string namee = ds.Tables[0].Rows[0].ItemArray[0].ToString();
            string price = ds.Tables[0].Rows[0].ItemArray[1].ToString();
            string details = ds.Tables[0].Rows[0].ItemArray[2].ToString();
            string s = ds.Tables[0].Rows[0].ItemArray[3].ToString();
            int stock = Convert.ToInt32(s);

            MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["pro_image"]);

            pictureBox22.Image = new Bitmap(ms);
            name22.Text = namee;
            price22.Text = price;
            richTextBox22.Text = details;

            if (stock > 0)
            {
                stock22.Text = "YES";
            }
            else
            {
                stock22.Text = "NO";
            }
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            addToCart((++srno).ToString(), name1.Text, price1.Text, cb1.Text.ToString());
        }

        public void addToCart( string srNo, string name,string price,string quantity)
        {
            int pricee = Convert.ToInt32(price);
            int quantityy = Convert.ToInt32(quantity);
            string total = (pricee * quantityy).ToString();

            string[] row = { srNo, name, price, quantity,total};
            dataGridView1.Rows.Add(row);

            MessageBox.Show("Item has been added to your cart");
            
        }
        public void buyNow( string name, string price, string quantity)
        {
            try
            {

            int pricee = Convert.ToInt32(price);
            int quantityy = Convert.ToInt32(quantity);
            string total = (pricee * quantityy).ToString();
            Checkout c = new Checkout(name, price,quantity,total );
            c.Show();

            }
            catch
            {
                MessageBox.Show("Please Enter the Quantity");
            }
        }
        public void getdata()
        {
            //na name
            //pr price
            //qu quantity
            //to total

            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("You have no items in the cart");
               
            }
            else
            {
                try
                {
                    na = "";
                    pr = "";
                    qu = "";
                    to = "";
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        na += dataGridView1.Rows[i].Cells[1].Value.ToString() + "\n";
                        pr += dataGridView1.Rows[i].Cells[2].Value.ToString() + "\n";
                        qu += dataGridView1.Rows[i].Cells[3].Value.ToString() + "\n";
                        to += dataGridView1.Rows[i].Cells[4].Value.ToString() + "\n";

                    }
                }

                catch { }
               
            }
           
        }



        private void button1_Click_2(object sender, EventArgs e)
        {
            try {
                addToCart((++srno).ToString(), name2.Text, price2.Text, cb2.Text.ToString());

            }
            catch { }
            }
        //Checkout button 1
        private void Checkoutbtn1_Click(object sender, EventArgs e)
        {
            getdata();
            Checkout c = new Checkout(na, pr, qu, to);
            c.Show();

            dataGridView1.Rows.Clear();
            
        }

        private void nl5_Click(object sender, EventArgs e)
        {

        }

        private void pl5_Click(object sender, EventArgs e)
        {

        }

        private void nl4_Click(object sender, EventArgs e)
        {

        }

        private void pl4_Click(object sender, EventArgs e)
        {

        }

        private void nl3_Click(object sender, EventArgs e)
        {

        }

        private void pl3_Click(object sender, EventArgs e)
        {

        }

        private void pl2_Click(object sender, EventArgs e)
        {

        }

        private void nl1_Click(object sender, EventArgs e)
        {

        }

        private void pl1_Click(object sender, EventArgs e)
        {

        }
        //Checkout button 2
        private void button48_Click(object sender, EventArgs e)
        {
            getdata();
            Checkout c = new Checkout(na, pr, qu, to);
            c.Show();

            dataGridView1.Rows.Clear();

        }
        //checkout button 3
        private void button46_Click(object sender, EventArgs e)
        {
            getdata();
            Checkout c = new Checkout(na, pr, qu, to);
            c.Show();

            dataGridView1.Rows.Clear();

        }
        //checkout button 4

        private void button47_Click(object sender, EventArgs e)
        {
            getdata();
            Checkout c = new Checkout(na, pr, qu, to);
            c.Show();

            dataGridView1.Rows.Clear();

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            buyNow(name2.Text, price2.Text, cb2.Text);
        }

        private void button45_Click(object sender, EventArgs e)
        {
            buyNow(name22.Text, price22.Text, cb22.Text);
        }

        private void button44_Click(object sender, EventArgs e)
        {
            try
            {
                addToCart((++srno).ToString(), name22.Text, price22.Text, cb22.Text.ToString());

            }
            catch { }
        }

        private void button42_Click(object sender, EventArgs e)
        {
            try
            {
                addToCart((++srno).ToString(), name21.Text, price21.Text, cb21.Text.ToString());

            }
            catch { }
        }

        private void button43_Click(object sender, EventArgs e)
        {
            buyNow(name21.Text, price21.Text, cb21.Text);
        }

        private void button40_Click(object sender, EventArgs e)
        {
            try
            {
                addToCart((++srno).ToString(), name20.Text, price20.Text, cb20.Text.ToString());

            }
            catch { }
        }

        private void button41_Click(object sender, EventArgs e)
        {
            buyNow(name20.Text, price20.Text, cb20.Text);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            try
            {
                addToCart((++srno).ToString(), name19.Text, price19.Text, cb19.Text.ToString());

            }
            catch { }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            buyNow(name19.Text, price19.Text, cb19.Text);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            try
            {
                addToCart((++srno).ToString(), name18.Text, price18.Text, cb18.Text.ToString());

            }
            catch { }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            buyNow(name18.Text, price18.Text, cb18.Text);
        }

        private void button38_Click(object sender, EventArgs e)
        {
            try
            {
                addToCart((++srno).ToString(), name17.Text, price17.Text, cb17.Text.ToString());

            }
            catch { }
        }

        private void button39_Click(object sender, EventArgs e)
        {
            buyNow(name17.Text, price17.Text, cb17.Text);
        }

        private void button36_Click(object sender, EventArgs e)
        {
            try
            {
                addToCart((++srno).ToString(), name16.Text, price16.Text, cb16.Text.ToString());

            }
            catch { }
        }

        private void button37_Click(object sender, EventArgs e)
        {
            buyNow(name16.Text, price16.Text, cb16.Text);
        }

        private void button35_Click(object sender, EventArgs e)
        {
            buyNow(name17.Text, price17.Text, cb15.Text);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            try
            {
                addToCart((++srno).ToString(), name15.Text, price15.Text, cb15.Text.ToString());

            }
            catch { }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            try
            {
                addToCart((++srno).ToString(), name14.Text, price14.Text, cb14.Text.ToString());

            }
            catch { }
        }

        private void button33_Click(object sender, EventArgs e)
        {
            buyNow(name14.Text, price14.Text, cb14.Text);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            buyNow(name13.Text, price13.Text, cb13.Text);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            try
            {
                addToCart((++srno).ToString(), name13.Text, price13.Text, cb13.Text.ToString());

            }
            catch { }
        }

        private void item12_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
                addToCart((++srno).ToString(), name12.Text, price12.Text, cb12.Text.ToString());

            }
            catch { }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            buyNow(name12.Text, price12.Text, cb12.Text);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            try
            {
                addToCart((++srno).ToString(), name10.Text, price10.Text, cb10.Text.ToString());

            }
            catch { }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            buyNow(name10.Text, price10.Text, cb10.Text);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            try
            {
                addToCart((++srno).ToString(), name11.Text, price11.Text, cb11.Text.ToString());

            }
            catch { }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            buyNow(name11.Text, price11.Text, cb11.Text);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            try
            {
                addToCart((++srno).ToString(), name9.Text, price9.Text, cb9.Text.ToString());

            }
            catch { }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            buyNow(name9.Text, price9.Text, cb9.Text);
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            try
            {
                addToCart((++srno).ToString(), name3.Text, price3.Text, cb3.Text.ToString());

            }
            catch { }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            buyNow(name3.Text, price3.Text, cb3.Text);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            buyNow(name8.Text, price8.Text, cb8.Text);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            try
            {
                addToCart((++srno).ToString(), name8.Text, price8.Text, cb8.Text.ToString());

            }
            catch { }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                addToCart((++srno).ToString(), name4.Text, price4.Text, cb4.Text.ToString());

            }
            catch { }
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            buyNow(name4.Text, price4.Text, cb4.Text);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                addToCart((++srno).ToString(), name7.Text, price7.Text, cb7.Text.ToString());

            }
            catch { }
        }

        private void button13_Click(object sender, EventArgs e)
        {

            buyNow(name7.Text, price7.Text, cb7.Text);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                addToCart((++srno).ToString(), name6.Text, price6.Text, cb6.Text.ToString());

            }
            catch { }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            buyNow(name6.Text, price6.Text, cb6.Text);
        }

        private void button14_Click(object sender, EventArgs e)
        {

            buyNow(name5.Text, price5.Text, cb5.Text);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            try
            {
                addToCart((++srno).ToString(), name5.Text, price5.Text, cb5.Text.ToString());

            }
            catch { }
        }
    }
    }
    

