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
    public partial class customer : Form
    {
        public customer()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\v11.0;Initial Catalog=master;Integrated Security=True");
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cusid = customerid.Text;
            string firstn = fname.Text;
            string lastn = lname.Text;
            string mail = email.Text;
            long ph = long.Parse(phno.Text);
            string addre = addr.Text;
            string cit = city.Text;
            string count = countryname.Text;
            DateTime register = DateTime.Parse(registertimepicker.Text);
           // string registerd = register.ToString("yyyy-mm-dd");
            DateTime lastpur = DateTime.Parse(lastpurtimepicker.Text);
            //string lastpu = lastpur.ToString("yyyy-mm-dd");

            int totalpur = int.Parse(totalpurchase.Text);
            string addinfor = addinfo.Text;
            string username = u.Text;
            string password = p.Text;
            //SqlCommand cmd = new SqlCommand("insert into customer_info values('"+cusid+"','"+firstn+"','"+lastn+"','"+mail+"',"+ph+",'"+addre+"','"+cit+"','"+count+"',"+register+","+lastpur+","+totalpur+",'"+addinfor+"')", con);
            SqlCommand cmd = new SqlCommand("INSERT INTO customer_info VALUES(@cusid, @firstn, @lastn, @mail, @ph, @addre, @cit, @count, @register, @lastpur, @totalpur, @addinfor,@username,@password)", con);

            // Add parameters
            cmd.Parameters.AddWithValue("@cusid", cusid);
            cmd.Parameters.AddWithValue("@firstn", firstn);
            cmd.Parameters.AddWithValue("@lastn", lastn);
            cmd.Parameters.AddWithValue("@mail", mail);
            cmd.Parameters.AddWithValue("@ph", ph);
            cmd.Parameters.AddWithValue("@addre", addre);
            cmd.Parameters.AddWithValue("@cit", cit);
            cmd.Parameters.AddWithValue("@count", count);
            cmd.Parameters.AddWithValue("@register", register); // Use the formatted date string
            cmd.Parameters.AddWithValue("@lastpur", lastpur);    // Use the formatted date string
            cmd.Parameters.AddWithValue("@totalpur", totalpur);
            cmd.Parameters.AddWithValue("@addinfor", addinfor);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            con.Open();
            int res = cmd.ExecuteNonQuery();
            MessageBox.Show((res != 0) ? "data saved" : "data not saved");
            con.Close();
            customerid.Text = " ";
            fname.Text = " ";
            lname.Text = " ";
            email.Text = " ";
            phno.Text = " ";
            addr.Text = " ";
            city.Text = " ";
            countryname.Text = " ";
            //registertimepicker.Text = " ";
          //  lastpurtimepicker.Text = " ";
            totalpurchase.Text = " ";
            addinfo.Text = " ";
        }

        private void UPDATE_Click(object sender, EventArgs e)
        {
            int cusid = int.Parse(customerid.Text);
            
            int totalpur = int.Parse(totalpurchase.Text);
            
            SqlCommand cmd = new SqlCommand("update customer_info set total_purchase =" + totalpur + " where customer_id=" + cusid + "", con);
            con.Open();
            int res = cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show((res != 0) ? "Data updated" : "Data not updated");

            customerid.Text = " ";

            totalpurchase.Text = " ";
        }

        private void DELETE_Click(object sender, EventArgs e)
        {
            int cusid = int.Parse(customerid.Text);
            SqlCommand cmd = new SqlCommand("delete from customer_info where customer_id=" + cusid + "", con);
            con.Open();
            int res = cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show((res != 0) ? "Data deleted" : "Data not deleted");

            customerid.Text = " ";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from customer_info", con);
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

        private void customer_Load(object sender, EventArgs e)
        {

        }
    }
}
