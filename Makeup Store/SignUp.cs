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
    public partial class SignUp : Form
    {
        int noc1 = 0;
        int noc2 = 0;
        int noc3 = 0;
        int noc4 = 0;
        int noc5 = 0;

       SqlConnection con = new SqlConnection("Data Source=ABDUL_WASEH\\SQLEXPRESS;Initial Catalog=MakeupStore;Integrated Security=True");

        public SignUp()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panelp_Paint(object sender, PaintEventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void passpic_Click(object sender, EventArgs e)
        {

        }

        private void unt_TextChanged(object sender, EventArgs e)
        {
           
        }
        private void unt_Click(object sender, EventArgs e)
        {
            ++noc1;

            switch(noc1)
            {
                case 1:
                    unt.Clear();
                    unp.Image = Properties.Resources.useryellow;
                    panelu.BackColor = Color.FromArgb(240, 144, 0);
                    unt.ForeColor = Color.FromArgb(240, 144, 0);

                    pp.Image = Properties.Resources.passwordwhite;
                    panelp.BackColor = Color.White;
                    pt.ForeColor = Color.White;

                    ep.Image = Properties.Resources.ewhite;
                    panele.BackColor = Color.White;
                    et.ForeColor = Color.White;


                    php.Image = Properties.Resources.pwhite;
                    panelph.BackColor = Color.White;
                    pht.ForeColor = Color.White;


                    np.Image = Properties.Resources.userwhite;
                    paneln.BackColor = Color.White;
                    nt.ForeColor = Color.White;

                    break;

                default:
                    unp.Image = Properties.Resources.useryellow;
                    panelu.BackColor = Color.FromArgb(240, 144, 0);
                    unt.ForeColor = Color.FromArgb(240, 144, 0);

                    pp.Image = Properties.Resources.passwordwhite;
                    panelp.BackColor = Color.White;
                    pt.ForeColor = Color.White;

                    ep.Image = Properties.Resources.ewhite;
                    panele.BackColor = Color.White;
                    et.ForeColor = Color.White;


                    php.Image = Properties.Resources.pwhite;
                    panelph.BackColor = Color.White;
                    pht.ForeColor = Color.White;


                    np.Image = Properties.Resources.userwhite;
                    paneln.BackColor = Color.White;
                    nt.ForeColor = Color.White;

                    break;


            }
        }

        private void nt_Click(object sender, EventArgs e)
        {
            ++noc2;
            switch (noc2)
            {
                case 1:
            nt.Clear();
            np.Image = Properties.Resources.useryellow;
            paneln.BackColor = Color.FromArgb(240, 144, 0);
            nt.ForeColor = Color.FromArgb(240, 144, 0);

            pp.Image = Properties.Resources.passwordwhite;
            panelp.BackColor = Color.White;
            pt.ForeColor = Color.White;


            ep.Image = Properties.Resources.ewhite;
            panele.BackColor = Color.White;
            et.ForeColor = Color.White;


            php.Image = Properties.Resources.pwhite;
            panelph.BackColor = Color.White;
            pht.ForeColor = Color.White;


            unp.Image = Properties.Resources.userwhite;
            panelu.BackColor = Color.White;
            unt.ForeColor = Color.White;
                    break;


                default:
                    np.Image = Properties.Resources.useryellow;
                    paneln.BackColor = Color.FromArgb(240, 144, 0);
                    nt.ForeColor = Color.FromArgb(240, 144, 0);

                    pp.Image = Properties.Resources.passwordwhite;
                    panelp.BackColor = Color.White;
                    pt.ForeColor = Color.White;


                    ep.Image = Properties.Resources.ewhite;
                    panele.BackColor = Color.White;
                    et.ForeColor = Color.White;


                    php.Image = Properties.Resources.pwhite;
                    panelph.BackColor = Color.White;
                    pht.ForeColor = Color.White;


                    unp.Image = Properties.Resources.userwhite;
                    panelu.BackColor = Color.White;
                    unt.ForeColor = Color.White;

                    break;
            }
        }

        private void et_Click(object sender, EventArgs e)
        {
            ++noc3;

            switch (noc3)
            {
                case 1:
            
            et.Clear();
            ep.Image = Properties.Resources.eyellow;
            panele.BackColor = Color.FromArgb(240, 144, 0);
            et.ForeColor = Color.FromArgb(240, 144, 0);

            pp.Image = Properties.Resources.passwordwhite;
            panelp.BackColor = Color.White;
            pt.ForeColor = Color.White;


            unp.Image = Properties.Resources.userwhite;
            panelu.BackColor = Color.White;
            unt.ForeColor = Color.White;


            php.Image = Properties.Resources.pwhite;
            panelph.BackColor = Color.White;
            pht.ForeColor = Color.White;


            np.Image = Properties.Resources.userwhite;
            paneln.BackColor = Color.White;
            nt.ForeColor = Color.White;

                    break;

                default:

                    ep.Image = Properties.Resources.eyellow;
                    panele.BackColor = Color.FromArgb(240, 144, 0);
                    et.ForeColor = Color.FromArgb(240, 144, 0);

                    pp.Image = Properties.Resources.passwordwhite;
                    panelp.BackColor = Color.White;
                    pt.ForeColor = Color.White;


                    unp.Image = Properties.Resources.userwhite;
                    panelu.BackColor = Color.White;
                    unt.ForeColor = Color.White;


                    php.Image = Properties.Resources.pwhite;
                    panelph.BackColor = Color.White;
                    pht.ForeColor = Color.White;


                    np.Image = Properties.Resources.userwhite;
                    paneln.BackColor = Color.White;
                    nt.ForeColor = Color.White;

                    break;
            
            
            }
        }

        private void pht_Click(object sender, EventArgs e)
        {
            ++noc4;

            switch (noc4)
            {
                case 1:

                    pht.Clear();
                    php.Image = Properties.Resources.pyellow;
                    panelph.BackColor = Color.FromArgb(240, 144, 0);
                    pht.ForeColor = Color.FromArgb(240, 144, 0);

                    pp.Image = Properties.Resources.passwordwhite;
                    panelp.BackColor = Color.White;
                    pt.ForeColor = Color.White;


                    unp.Image = Properties.Resources.userwhite;
                    panelu.BackColor = Color.White;
                    unt.ForeColor = Color.White;


                    ep.Image = Properties.Resources.ewhite;
                    panele.BackColor = Color.White;
                    et.ForeColor = Color.White;


                    np.Image = Properties.Resources.userwhite;
                    paneln.BackColor = Color.White;
                    nt.ForeColor = Color.White;

                    break;

                default:

                    php.Image = Properties.Resources.pyellow;
                    panelph.BackColor = Color.FromArgb(240, 144, 0);
                    pht.ForeColor = Color.FromArgb(240, 144, 0);

                    pp.Image = Properties.Resources.passwordwhite;
                    panelp.BackColor = Color.White;
                    pt.ForeColor = Color.White;


                    unp.Image = Properties.Resources.userwhite;
                    panelu.BackColor = Color.White;
                    unt.ForeColor = Color.White;


                    ep.Image = Properties.Resources.ewhite;
                    panele.BackColor = Color.White;
                    et.ForeColor = Color.White;


                    np.Image = Properties.Resources.userwhite;
                    paneln.BackColor = Color.White;
                    nt.ForeColor = Color.White;

                    break;


            }
        }

        private void pt_Click(object sender, EventArgs e)
        {
            ++noc5;

            switch (noc5)
            {
                case 1:

                    pt.Clear();
                    pt.PasswordChar = '*';
                    pp.Image = Properties.Resources.passwordyellow;
                    panelp.BackColor = Color.FromArgb(240, 144, 0);
                    pt.ForeColor = Color.FromArgb(240, 144, 0);

                    php.Image = Properties.Resources.pwhite;
                    panelph.BackColor = Color.White;
                    pht.ForeColor = Color.White;


                    unp.Image = Properties.Resources.userwhite;
                    panelu.BackColor = Color.White;
                    unt.ForeColor = Color.White;


                    ep.Image = Properties.Resources.ewhite;
                    panele.BackColor = Color.White;
                    et.ForeColor = Color.White;


                    np.Image = Properties.Resources.userwhite;
                    paneln.BackColor = Color.White;
                    nt.ForeColor = Color.White;

                    break;


                default:
            pt.PasswordChar = '*';
            pp.Image = Properties.Resources.passwordyellow;
            panelp.BackColor = Color.FromArgb(240, 144, 0);
            pt.ForeColor = Color.FromArgb(240, 144, 0);

            php.Image = Properties.Resources.pwhite;
            panelph.BackColor = Color.White;
            pht.ForeColor = Color.White;


            unp.Image = Properties.Resources.userwhite;
            panelu.BackColor = Color.White;
            unt.ForeColor = Color.White;


            ep.Image = Properties.Resources.ewhite;
            panele.BackColor = Color.White;
            et.ForeColor = Color.White;


            np.Image = Properties.Resources.userwhite;
            paneln.BackColor = Color.White;
            nt.ForeColor = Color.White;

                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            con.Open();
            SqlCommand cmd = new SqlCommand("insert into customers VALUES (@a,@b,@c,@d,@e)",con);
            cmd.Parameters.AddWithValue("@a", unt.Text);
            cmd.Parameters.AddWithValue("@b", nt.Text);
            cmd.Parameters.AddWithValue("@c", et.Text);
            cmd.Parameters.AddWithValue("@d", pht.Text);
            cmd.Parameters.AddWithValue("@e", pt.Text);
            try
            {

                int n=cmd.ExecuteNonQuery();
            if (n > 0)
            {
                MessageBox.Show("You have registered successfully ");
            }
            else
            {
                MessageBox.Show("Not successfull ");
            }

            }

            catch
            {
                MessageBox.Show("Sign up Failed");
            }

            con.Close();


        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogIn l = new LogIn();
            l.Show();
        }
    }
}
