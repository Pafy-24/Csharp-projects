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
    public partial class Sign_In : Form
    {
        public Sign_In()
        {
            InitializeComponent();
        }

        private void SignInbtn_Click(object sender, EventArgs e)
        {
            try
            {

                OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Birdie-Database.accdb");
                con.Open();
                if (emailText.Text.Contains('@'))
                {
                    OleDbCommand sql = new OleDbCommand("SELECT id, email, username, [access lvl], password FROM Utilizatori WHERE email LIKE '" + emailText.Text + "'", con);
                    OleDbDataReader dataReader = sql.ExecuteReader();
                    if (dataReader.Read())
                    {
                        if (emailText.Text.ToString() == dataReader[1].ToString() && pwdText.Text.ToString() == dataReader[4].ToString())
                        {
                            globals.userid = Convert.ToInt64(dataReader[0]);
                            globals.user = dataReader[2].ToString();
                            globals.user_email = dataReader[1].ToString();
                            globals.user_rights = dataReader[3].ToString();
                            throw new Exception("Logged in");
                        }
                    }
                    throw new Exception("none");

                }
                else
                {
                    OleDbCommand sql = new OleDbCommand("SELECT id, email, username, [access lvl], password FROM Utilizatori WHERE username LIKE '"+emailText.Text+"'", con);
                    OleDbDataReader dataReader = sql.ExecuteReader();
                if (dataReader.Read())
                {
                    if (emailText.Text.ToString() == dataReader[2].ToString() && pwdText.Text.ToString() == dataReader[4].ToString())
                    {
                        globals.userid = Convert.ToInt64(dataReader[0]);
                        globals.user = dataReader[2].ToString();
                        globals.user_email = dataReader[1].ToString();
                        globals.user_rights = dataReader[3].ToString();
                            throw new Exception("Logged in");
                        }
                }
                    throw new Exception("none");

                }
            } catch(Exception error)
            {
                if (error.Message == "none")
                {
                    label6.Text = "Utilizatorul sau parola sunt greșite!!";
                }
                else //if(error.Message == "Logged in")
                {
                    label6.Text = error.Message + "\n";
                //    label6.Text += globals.user.ToString() + "\n";
                //    label6.Text += globals.user_email.ToString() + "\n";
                 //   label6.Text += globals.user_rights.ToString() ;

                    this.Close();

                }
                 //  label6.Text = error.Message;
            }
        }

        private void Sign_In_Load(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(button1.ForeColor == System.Drawing.Color.Red)
            {
                button1.ForeColor = System.Drawing.Color.Aquamarine;
                pwdText.UseSystemPasswordChar = false;
                pwdText.PasswordChar = '\0';
            } else
            {
                button1.ForeColor = System.Drawing.Color.Red;
                pwdText.UseSystemPasswordChar = true;
                pwdText.PasswordChar = '•';
            }
         //   label6.Text = pwdText.UseSystemPasswordChar.ToString() + " " + pwdText.PasswordChar;
        }
    }
}
