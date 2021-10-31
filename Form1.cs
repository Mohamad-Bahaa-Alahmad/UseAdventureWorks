using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

using System.Data.SqlClient;

namespace UseAdventureWorks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'adventureWorks2016CTP3DataSet.CountryRegion' table. You can move, or remove it, as needed.
            this.countryRegionTableAdapter.Fill(this.adventureWorks2016CTP3DataSet.CountryRegion);

        }

        

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = "Not available";
            string val = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

            
            string con = "Data Source=172.20.1.20;Initial Catalog=AdventureWorks2016CTP3;User ID=Student;Password=Student+2020";
            SqlConnection connect = new SqlConnection(con);
            connect.Open();
            
            SqlCommand cmd = new SqlCommand("Select CurrencyCode From Sales.CountryRegionCurrency Where CountryRegionCode = @CRC");
            
            cmd.Parameters.AddWithValue("@CRC", val);
            cmd.Connection = connect;
            SqlDataReader de = cmd.ExecuteReader();
            string st = "";
            while (de.Read())
            {
                 st = de.GetString(0);
               
            }
            de.Close();
            cmd = new SqlCommand("Select Name From Sales.Currency Where CurrencyCode = @CC");

            cmd.Parameters.AddWithValue("@CC", st);
            cmd.Connection = connect;
            SqlDataReader de1 = cmd.ExecuteReader();
            while (de1.Read())
            {
                textBox1.Text = de1.GetString(0);
            }
            connect.Close();
        }
    }
}
