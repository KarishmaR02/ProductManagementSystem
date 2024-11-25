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
    public partial class productlist : Form
    {
        public productlist()
        {
            InitializeComponent();
        }

        private void BACK_Click(object sender, EventArgs e)
        {
            customerlogin c = new customerlogin();
            c.Show();
            this.Hide();
        }

        private void productlist_Load(object sender, EventArgs e)
        {
            
            
        }

     
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\v11.0;Initial Catalog=master;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from product_basic_info", con);
            con.Open();
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            ad.Fill(ds);
            data.DataSource = ds.Tables[0];
            con.Close();
        }

        private void SEARCH_PRODUCT_Click(object sender, EventArgs e)
        {
            string search_pro = search.Text;
            SqlCommand c = new SqlCommand("select * from product_basic_info where product_name='"+search_pro+"' ", con);
            con.Open();
            SqlDataAdapter ad = new SqlDataAdapter(c);
            DataSet d=new DataSet();
            ad.Fill(d);
            con.Close();
            
            if(d.Tables[0].Rows.Count>0)
            {
                data.DataSource = d.Tables[0];
            }
            else
            {
                MessageBox.Show("Invalid Product");
            }
        }
    }
}
