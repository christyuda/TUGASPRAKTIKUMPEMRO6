using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace P6_2_1204025
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string url = "server=localhost;userid=root;password=;database=p6_1204025";
        private DataSet dsProdi;
        public DataSet CreateProdiDataSet()
        {
            DataSet myDataSet = new DataSet();

            try
            {
                
                MySqlConnection myconn = new MySqlConnection(url);
                myconn.Open();
                MySqlCommand command = new MySqlCommand();
                command.Connection = myconn;
                command.CommandText = "SELECT * FROM msprodi";
                command.CommandType = CommandType.Text;

                MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
                myDataAdapter.SelectCommand = command;
                myDataAdapter.TableMappings.Add("Table", "Prodi");
                myDataAdapter.Fill(myDataSet);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
            return myDataSet; 
        }
        private void RefreshDataset()
        {
            dsProdi = CreateProdiDataSet();
            dgProdi.DataSource = dsProdi.Tables["Prodi"];
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshDataset();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string url = "server=localhost;userid=root;password=;database=p6_1204025";
            string myConnectionString = "integrated security=true;datasource=localhost;initial catalog=p6_1204025";
            MySqlConnection myconn = new MySqlConnection(url);
            myconn.Open();

            MySqlDataAdapter myAdapter = new MySqlDataAdapter("select * from msprodi", myconn);
            MySqlCommandBuilder myCmdBuilder = new MySqlCommandBuilder(myAdapter);

            myAdapter.InsertCommand = myCmdBuilder.GetInsertCommand();
            myAdapter.UpdateCommand = myCmdBuilder.GetUpdateCommand();
            myAdapter.DeleteCommand = myCmdBuilder.GetDeleteCommand();

            MySqlTransaction myTransaction;
            myTransaction = myconn.BeginTransaction();
            myAdapter.DeleteCommand.Transaction = myTransaction;
            myAdapter.UpdateCommand.Transaction = myTransaction;
            myAdapter.InsertCommand.Transaction = myTransaction;

            try
            {
                int rowsUpdated = myAdapter.Update(dsProdi, "Prodi");
                myTransaction.Commit();
                MessageBox.Show(rowsUpdated.ToString() + " baris diperbarui", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                RefreshDataset();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to update: " + ex.Message);
                myTransaction.Rollback();
            }

            MessageBox.Show(myAdapter.InsertCommand.CommandText);
            MessageBox.Show(myAdapter.UpdateCommand.CommandText);
            MessageBox.Show(myAdapter.DeleteCommand.CommandText);

        }
    }
}
