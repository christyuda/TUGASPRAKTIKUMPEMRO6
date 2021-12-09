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
namespace P6_3_1204025
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            filldataset();
            numerictext1.MaxLength = 7;
            numerictext2.MaxLength = 7;
        }

        private string url = "server=localhost;userid=root;password=;database=p6_1204025";

        DataTable dataprodi = new DataTable();
        private void filldataset()

        {
            using (MySqlConnection myconn = new MySqlConnection(url))
            {
                MySqlCommand sqlCmd = new MySqlCommand("SELECT id_prodi, singkatan FROM msprodi", myconn);
                myconn.Open();
                MySqlDataAdapter sqlReader = new MySqlDataAdapter(sqlCmd);
                sqlReader.Fill(dataprodi);

                //while (sqlReader.Read())
                //{
                //    comboBox1.Items.Add(sqlReader["singkatan"].ToString());
                //    comboBox1.Items.Add(new List)
                //}
            }
            comboBox1.DataSource = dataprodi;
            comboBox1.DisplayMember = "singkatan";
            comboBox1.ValueMember = "id_prodi";
        }

        private void database(string cmd)
        {
            try
            {
                MySqlConnection myconnect = new MySqlConnection(url);
                myconnect.Open();

                MySqlCommand command = new MySqlCommand();
                command.Connection = myconnect;
                command.CommandText = cmd;
                command.ExecuteNonQuery();
                MessageBox.Show("Data has been Updated", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        

        private void button1_Click_1(object sender, EventArgs e)
        
            {
                string lbjk = "";
                if (pr.Checked) { lbjk = pr.Text; } else if (lk.Checked) { lbjk = lk.Text; }
                string sDate = tanggal.SelectionStart.ToString("yyyy\\/MM\\/dd");
                string cmdsave = "insert into MSMHS values('" + numerictext1.Text + "','" + cbnama.Text + "','" + sDate + "','" + lbjk + "','" + txtalamat.Text + "','" + numerictext2.Text + "','" + comboBox1.SelectedValue + "')";
                database(cmdsave);
                

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            cbnama.Text ="";
            numerictext1.Text ="";
            numerictext2.Text ="";
            txtalamat.Text = "";
            comboBox1.Text = "";
            pr.Checked = false;
            lk.Checked = false;

        }

        private void gakeror(Control control)
        {
            errorProvider1.SetError(control, "Harus diisi");
        }

        private void errorr()
        {
            errorProvider1.Clear();
        }

        private void tbnpm_Leave(object sender, EventArgs e)
        {
            if (numerictext1.Text == "")
            {
                gakeror(numerictext1);
            }
            else
            {
                errorr();
            }
        }

        private void tbnama_Leave(object sender, EventArgs e)
        {
            if (cbnama.Text == "")
            {
                gakeror(cbnama);
            }
            else
            {
                errorr();
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (txtalamat.Text == "")
            {
                gakeror(txtalamat);
            }
            else
            {
                errorr();
            }
        }

        private void tbtelp_Leave(object sender, EventArgs e)
        {
            if (numerictext2.Text == "")
            {
                gakeror(numerictext2);
            }
            else
            {
                errorr();
            }
        }
    }
}
