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
    public partial class LogIn : Form
    {
        int count = 0;
        int count1 = 0;
        public static string user="";
        public LogIn()
        {
            InitializeComponent();
          
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=ABDUL_WASEH\\SQLEXPRESS;Initial Catalog=MakeupStore;Integrated Security=True");
            con.Open();


            SqlCommand cmd = new SqlCommand("select * from customers where username=@p and passsword=@b", con);

            cmd.Parameters.AddWithValue("@p", name.Text);
            cmd.Parameters.AddWithValue("@b", password.Text);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            con.Close();

            if (ds.Tables[0].Rows.Count > 0)
            {
                user = name.Text;
                Form1 m = new Form1();
                this.Hide();
                m.Show();
                
            }
            else
            {
                MessageBox.Show("Wrong Credentials");
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            ++count;
            switch (count)
            {
                case 1:
            name.Clear();
            userpic.Image = Properties.Resources.useryellow;
            panelu.BackColor = Color.FromArgb(240, 144, 0);
            name.ForeColor = Color.FromArgb(240, 144, 0);

            passpic.Image = Properties.Resources.passwordwhite;
            panelp.BackColor = Color.White;
            password.ForeColor = Color.White;

                    break;

                default:

                    userpic.Image = Properties.Resources.useryellow;
                    panelu.BackColor = Color.FromArgb(240, 144, 0);
                    name.ForeColor = Color.FromArgb(240, 144, 0);

                    passpic.Image = Properties.Resources.passwordwhite;
                    panelp.BackColor = Color.White;
                    password.ForeColor = Color.White;

                    break;
            }

        }

        private void password_Click(object sender, EventArgs e)
        {
            ++count1;
            switch (count1)
            {
                case 1:
                    password.Clear();
                    password.PasswordChar = '*';
                    passpic.Image = Properties.Resources.passwordyellow;
                    panelp.BackColor = Color.FromArgb(240, 144, 0);
                    password.ForeColor = Color.FromArgb(240, 144, 0);

                    userpic.Image = Properties.Resources.userwhite;
                    panelu.BackColor = Color.White;
                    name.ForeColor = Color.White;
                    break;

                default:
                    password.PasswordChar = '*';
                    passpic.Image = Properties.Resources.passwordyellow;
                    panelp.BackColor = Color.FromArgb(240, 144, 0);
                    password.ForeColor = Color.FromArgb(240, 144, 0);

                    userpic.Image = Properties.Resources.userwhite;
                    panelu.BackColor = Color.White;
                    name.ForeColor = Color.White;
                    break;

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            SignUp su = new SignUp();
            this.Hide();
            su.Show();

        }
    }
}
