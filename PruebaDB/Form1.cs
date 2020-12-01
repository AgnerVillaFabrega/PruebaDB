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

namespace PruebaDB
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conexions = @"Server=(LocalDB)\MSSQLLocalDB;Database= master;Trusted_Connection=True;";
            using (SqlConnection sql= new SqlConnection (conexions))
            {
                try
                {
                    sql.Open();
                    MessageBox.Show("Conectado " + sql.DataSource + " Data base: " + sql.Database);
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message);

                } finally { sql.Close(); }
                
            }
        }
    }
}
