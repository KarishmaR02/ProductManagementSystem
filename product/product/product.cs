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
    public partial class product : Form
    {

        public product()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\v11.0;Initial Catalog=master;Integrated Security=True");
        public void add_Click(object sender, EventArgs e)
        {
            int proid = int.Parse(pid.Text);
            string proname = pname.Text;
            string description = descrip.Text;
            string categ = category.Text;
            long pri = long.Parse(price.Text);
            int stock = int.Parse(stock_q.Text);
            string manufacture = manuf.Text;
            DateTime releasedate = DateTime.Parse(rdate.Text);
            //string date = releasedate.ToString();
			   
            string sta = status.Text;
            string addinf = addinfo.Text;
         //  SqlCommand cmd = new SqlCommand("insert into product_basic_info(product_id,product_name,description,category,price,stock_quantity,manufacturer,release_date,create_at,update_at,status,additional_info) values(" + proid + ",'" + proname + "','" + description + "','" + categ + "'," + pri + "," + stock + ",'" + manufacture + "'," + releasedate + "," + DateTime.Now + "," + DateTime.Now + ",'" + sta + "','" + addinf + "')", con);
             SqlCommand cmd = new SqlCommand("INSERT INTO product_basic_info VALUES (@product_id, @product_name, @description, @category, @price, @stock_quantity, @manufacturer, @release_date,@create_at,@update_at, @status, @additional_info)", con);
            cmd.Parameters.AddWithValue("@product_id", proid);
            cmd.Parameters.AddWithValue("@product_name", proname);
            cmd.Parameters.AddWithValue("@description", description);
            cmd.Parameters.AddWithValue("@category", categ);
            cmd.Parameters.AddWithValue("@price", pri);
            cmd.Parameters.AddWithValue("@stock_quantity", stock);
            cmd.Parameters.AddWithValue("@manufacturer", manufacture);
            cmd.Parameters.AddWithValue("@release_date",releasedate);
             cmd.Parameters.AddWithValue("@create_at", DateTime.Now);
            cmd.Parameters.AddWithValue("@update_at", DateTime.Now);
             
            cmd.Parameters.AddWithValue("@status", sta);
            cmd.Parameters.AddWithValue("@additional_info", addinf);
			 
            con.Open();
            int res = cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show((res != 0) ? "Data inserted" : "Data not inserted");
            
            pid.Text = " ";
            pname.Text = " ";
            descrip.Text = " ";
            category.Text = " ";
            price.Text = " ";
            stock_q.Text = " ";
            manuf.Text = " ";
            //    rdate.Text = " ";
     
            status.Text = " ";
            addinfo.Text = " ";
        }

        private void product_Load(object sender, EventArgs e)
        {

        }

        public void update_Click(object sender, EventArgs e)
        {

            int proid = int.Parse(pid.Text);
           
            int stock = int.Parse(stock_q.Text);
            SqlCommand cmd = new SqlCommand("update product_basic_info set stock_quantity ="+stock+" where product_id="+proid+"", con);
            con.Open();
            int res = cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show((res != 0) ? "Data updated" : "Data not updated");

            pid.Text = " ";
           
            stock_q.Text = " ";
           }

        public void button1_Click(object sender, EventArgs e)
        {
            int proid = int.Parse(pid.Text);
            SqlCommand cmd = new SqlCommand("delete from product_basic_info where product_id="+proid+"", con);
            con.Open();
            int res = cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show((res != 0) ? "Data deleted" : "Data not deleted");

            pid.Text = " ";

        }

        public void print_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from product_basic_info", con);
            con.Open();
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            ad.Fill(ds);
            data.DataSource = ds.Tables[0];
            con.Close();
        }

        private void BACK_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            this.Hide();
        }
    }
}
