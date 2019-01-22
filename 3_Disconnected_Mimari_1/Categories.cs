using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_Disconnected_Mimari_1
{
    public partial class Categories : Form
    {
        public Categories()
        {
            InitializeComponent();
        }

        private SqlConnection con; 

        private void Categories_Load(object sender, EventArgs e)
        {
            CategoriesList();
        }

        public void CategoriesList()
        {
            
            con = new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True");
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = new SqlCommand("select * from Categories", con);
            DataTable dt = new DataTable();
            con.Open();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["CategoryID"].Visible = false;
           

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string categoryName = txtCatName.Text;
            string description = txtDesc.Text;         
            con = new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True");
            if (string.IsNullOrWhiteSpace(categoryName) || string.IsNullOrWhiteSpace(description))
            {
                MessageBox.Show("You entered wrong or empty values");
                return;
            }
            string query = "INSERT INTO Categories(CategoryName, Description) VALUES(@CategoryName, @Description)";
            try
            {
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.Add(new SqlParameter("CategoryName", categoryName));
                command.Parameters.Add(new SqlParameter("Description", description));

                con.Open();
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    CategoriesList();
                    MessageBox.Show("New row inserted successfully");
                }
            }
            finally
            {
                con.Close();
            }
        }
    }
}
