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
    public partial class Checkout : Form
    {
        SqlConnection con = new SqlConnection("Data Source=ABDUL_WASEH\\SQLEXPRESS;Initial Catalog=MakeupStore;Integrated Security=True");
        public Checkout(string i,string p,string q,string t)
        {
            InitializeComponent();
           
            items.Text = i;
            price.Text = p;
            quantity.Text = q;
            total.Text = t;

            char[] mychar = { '\n' };
            string[] totals = t.Split(mychar);
            string[] itemnames= i.Split(mychar);
            string[] prices = p.Split(mychar);
            string[] quantities= q.Split(mychar);


            int totalamountt = 0;
            
            try {
                foreach (var tt in totals)
                {
                    totalamountt += Convert.ToInt32(tt);
                }
            }
            catch { };

            con.Open();
            DateTime now = DateTime.Now;
            string username = LogIn.user;
            SqlCommand cmd = new SqlCommand("insert into orders values(@a,@b,@c)",con);
            cmd.Parameters.AddWithValue("@a",username);
            cmd.Parameters.AddWithValue("@b",totalamountt);
            cmd.Parameters.AddWithValue("@c",now);
            try
            {
            cmd.ExecuteNonQuery();

            }
            catch
            {

            }
            totalamount.Text = totalamountt.ToString();
            //  con.Close();

            try
            {
                for(int j=0; j<itemnames.Length; j++)
                {   
                    string nn = itemnames[j];
                    int pp = Convert.ToInt32(prices[j]);
                    int qq = Convert.ToInt32(quantities[j]);
                    int tt = Convert.ToInt32(totals[j]);

                    insertintoOrderdetails(nn, pp, qq, tt);
                }
            
            }
            catch
            {

            }

            

            
        }

       public int maxinvoiceid()
        {
            SqlCommand cmd = new SqlCommand("select MAX(invoice_id) from orders ",con);
         //   con.Open();
              int max= Convert.ToInt32(cmd.ExecuteScalar());
           //  con.Close();

            return max;
          
        }

        public void insertintoOrderdetails(string n,int p,int q, int t)
        {
            
          //  con.Open();
            SqlCommand cmd = new SqlCommand("insert into order_details values(@a,@b,@c,@d,@e)",con);
            cmd.Parameters.AddWithValue("@a",maxinvoiceid());
            cmd.Parameters.AddWithValue("@b",n);
            cmd.Parameters.AddWithValue("@c",p);
            cmd.Parameters.AddWithValue("@d",q);
            cmd.Parameters.AddWithValue("@e",t);
            cmd.ExecuteNonQuery();
          //  con.Close();
        }
        

        private void Checkout_Load(object sender, EventArgs e)
        {
       
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have successfully purchased items");
        }
    }
}
