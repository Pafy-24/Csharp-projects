using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeoLocalizare
{
    public partial class AdminMenu : Form
    {
        public AdminMenu()
        {
            InitializeComponent();
        }

        private void AdminMenu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_Birdie_DatabaseDataSet.Utilizatori' table. You can move, or remove it, as needed.
            this.utilizatoriTableAdapter.Fill(this._Birdie_DatabaseDataSet.Utilizatori);
            this.comboBox1.Text = "";


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ID.Text = "";
                username.Text = "";
                email.Text = "";
                tel.Text = "";
                rights.Text = "";
                string value = "0";
                //label5.Text = comboBox1.SelectedValue.ToString();
                try
                {
                    if (comboBox1.SelectedValue != null)
                        value = comboBox1.SelectedValue.ToString();
                } catch(Exception er)
                {

                }

                OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Birdie-Database.accdb");
                OleDbCommand sql = new OleDbCommand("SELECT * FROM Utilizatori WHERE ID = " + value + "", con);
                OleDbDataReader dataReader;
                con.Open();
                dataReader = sql.ExecuteReader();
                if (dataReader.Read())
                {
                    ID.Text = dataReader[0].ToString();
                    username.Text = dataReader[1].ToString();
                    email.Text = dataReader[3].ToString();
                    tel.Text = dataReader[4].ToString();
                    rights.Text = dataReader[5].ToString();
                }
                con.Close();
            } catch(Exception error)
            {
                MessageBox.Show(error.Message, "Error Occured!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rights_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "UPDATE Utilizatori "+
                "SET username='"+ username.Text+"', email = '"+email.Text.ToString()+"', phone = '"+tel.Text.ToString()+"', [access lvl] = '"+rights.Text.ToString()+"' "+
                "WHERE(ID = "+Convert.ToInt64(ID.Text)+")";
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Birdie-Database.accdb");
            OleDbCommand sql = new OleDbCommand(query, con);
            con.Open();
            sql.ExecuteNonQuery();

        }
    }
}
