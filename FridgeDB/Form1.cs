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

namespace FridgeDB
{
    public partial class Form1 : Form
    {
        string connectionString;
        SqlConnection connection;
        public Form1()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["FridgeDB.Properties.Settings.FridgeConnectionString"].ConnectionString;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateFoodTypeTable();
        }

        private void PopulateFoodTypeTable()
        {
             using (connection = new SqlConnection(connectionString))
             using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM FoodInTheFridge", connection))
             {
                DataTable FoodTypeTable = new DataTable();
                adapter.Fill(FoodTypeTable);

                FoodInTheFridge.DisplayMember = "FoodTypeName";
                FoodInTheFridge.ValueMember = "Id";
                FoodInTheFridge.DataSource = FoodTypeTable;
             }
        }
    }
}
