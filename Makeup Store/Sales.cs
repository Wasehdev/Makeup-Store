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

namespace Makeup_Store
{
    public partial class Sales : Form
    {
        SqlConnection con = new SqlConnection("Data Source=ABDUL_WASEH\\SQLEXPRESS;Initial Catalog=MakeupStore;Integrated Security=True");
        SqlCommand cmd;
        public Sales()
        {
            InitializeComponent();
            dataGridView1.ColumnCount = 7;
            dataGridView1.Columns[0].Name = "Order ID"; 
            dataGridView1.Columns[1].Name = "User Name";
            dataGridView1.Columns[2].Name = "Item Name";
            dataGridView1.Columns[3].Name = "Item Price"; 
            dataGridView1.Columns[4].Name = "Quantity"; 
            dataGridView1.Columns[5].Name = "Total"; 
            dataGridView1.Columns[6].Name = "Date";

            ShowData(" select o.invoice_id , o.customer,od.item_name,od.item_price,od.quantity,od.total,o.date from orders o  inner join order_details od on o.invoice_id=od.invoice_id ");
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
                string id = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                string username = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                string itemname= ds.Tables[0].Rows[i].ItemArray[2].ToString();
                string price = ds.Tables[0].Rows[i].ItemArray[3].ToString();
                string quantity = ds.Tables[0].Rows[i].ItemArray[4].ToString();
                string total = ds.Tables[0].Rows[i].ItemArray[5].ToString();
                string date = ds.Tables[0].Rows[i].ItemArray[6].ToString();


                DataGridViewRow abc = new DataGridViewRow();
                abc.CreateCells(dataGridView1);
                abc.Cells[0].Value = id;
                abc.Cells[1].Value = username;
                abc.Cells[2].Value = itemname;
                abc.Cells[3].Value = price;
                abc.Cells[4].Value = quantity;
                abc.Cells[5].Value = total;
                abc.Cells[6].Value = date;

                dataGridView1.Rows.Add(abc);

            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Sales_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem.ToString())
            {
                case "Invoice_id":
                    ShowData("select o.invoice_id , o.customer,od.item_name,od.item_price,od.quantity,od.total,o.date from orders o  inner join order_details od on o.invoice_id=od.invoice_id  where lower(o.invoice_id) like '%" + textBox1.Text.ToLower() + "%'");
                    break;

                case "Customer Name":
                    ShowData("select o.invoice_id , o.customer,od.item_name,od.item_price,od.quantity,od.total,o.date from orders o  inner join order_details od on o.invoice_id=od.invoice_id  where lower(o.customer) like '%" + textBox1.Text.ToLower() + "%'");
                    break;
                case "Product Name":
                    ShowData("select o.invoice_id , o.customer,od.item_name,od.item_price,od.quantity,od.total,o.date from orders o  inner join order_details od on o.invoice_id=od.invoice_id  where lower(od.item_name) like '%" + textBox1.Text.ToLower() + "%'");
                    break;
                case "Total":
                    ShowData("select o.invoice_id , o.customer,od.item_name,od.item_price,od.quantity,od.total,o.date from orders o  inner join order_details od on o.invoice_id=od.invoice_id  where lower(od.total) like '%" + textBox1.Text.ToLower() + "%'");
                    break;
                case "Price":
                    ShowData("select o.invoice_id , o.customer,od.item_name,od.item_price,od.quantity,od.total,o.date from orders o  inner join order_details od on o.invoice_id=od.invoice_id  where lower(od.price) like '%" + textBox1.Text.ToLower() + "%'");
                    break;

                case "Date":
                    ShowData("select o.invoice_id , o.customer,od.item_name,od.item_price,od.quantity,od.total,o.date from orders o  inner join order_details od on o.invoice_id=od.invoice_id  where lower(o.date) like '%" + textBox1.Text.ToLower() + "%'");
                    break;


            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            products p = new products();
            this.Hide();
            p.Show();
        }
    }
}
