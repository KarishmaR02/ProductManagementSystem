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

namespace product
{
    public partial class customerlogin : Form
    {
        public customerlogin()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\v11.0;Initial Catalog=master;Integrated Security=True");
        private void BACK_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void LOGIN_Click(object sender, EventArgs e)
        {
            string uname = u.Text;
            string pword = p.Text;
            SqlCommand cmd = new SqlCommand("select * from customer_info where username='" + uname + "' and password='" + pword + "'", con);
            con.Open();
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataSet d = new DataSet();
            int r = ad.Fill(d);
            con.Close();
            if (r != 0)
            {
                MessageBox.Show("Login Successfully");
                productlist pl = new productlist();
                pl.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username");
            }
        }

        private void customerlogin_Load(object sender, EventArgs e)
        {

        }
    }
}
