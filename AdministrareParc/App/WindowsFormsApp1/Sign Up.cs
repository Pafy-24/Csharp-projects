using LanguageExt;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
//using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace GeoLocalizare
{
    public partial class Sign_Up : Form
    {
        public Sign_Up()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SignUpbtn_Click(object sender, EventArgs e)
        {
                string usrnmver = " SELECT username FROM Utilizatori WHERE username like '" + this.usernameText.Text + "'";
                string emailver = " SELECT email FROM Utilizatori WHERE email like '" + this.emailText.Text + "'";
                try
                {

            
                    if (usernameText.Text.Length < 1 || usernameText.Text == null)
                        throw new Exception("user");
                    if (emailText.Text.Length < 1)
                        throw new Exception("email");
                    if (pwdText.Text.Length < 1)
                        throw new Exception("pwd");
                    if (phoneText.Text.Length < 1)
                        throw new Exception("tel");

                    if (usernameText.Text.Length < 3)
                        throw new Exception("Numele de utilizator trebuie sa conțină cel puțin 3 caractere");
                    if(pwdText.Text != pwdText.Text)
                        throw new Exception("Parolele nu se potrivesc!");
                    if (!emailText.Text.Contains('@') && !emailText.Text.Contains('.'))
                        throw new Exception("Introduceți un email valid!");



                    string conString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Birdie-Database.accdb";
                    OleDbConnection con = new OleDbConnection(conString);
                    OleDbCommand sql = new OleDbCommand("", con);
                    con.Open();
                    sql.CommandText = usrnmver;
                    OleDbDataReader data = sql.ExecuteReader();
                    if (data.HasRows)
                    {
                        usernameText.BackColor = System.Drawing.Color.Pink;
                        throw new Exception("Numele a fost deja luat!");
                    }
                    data.Close();
                    OleDbDataReader data1; 
                    sql.CommandText = emailver;
                    data1 = sql.ExecuteReader();
                    if (data1.HasRows)
                    {
                        usernameText.BackColor = System.Drawing.Color.Pink;
                        throw new Exception("Email-ul a fost deja folosit!");
                    }
                data1.Close();

                string insert = "INSERT INTO Utilizatori"+
                 " (username, [password], email, phone, [access lvl])"+
                 " VALUES('"+usernameText.Text+ "', '" + pwdText.Text + "', '" + emailText.Text + "', '" + phoneText.Text + "', 'member')";

                sql.CommandText = insert;
                sql.ExecuteNonQuery();

                con.Close();
                this.Close();
                    

                }
                catch (Exception error)
                {
                    if(error.Message == "user" )
                    {
                        usernameText.BackColor = System.Drawing.Color.Pink;
                        label6.Text = "Toate spațiile trebuiesc completate";
                    }
                    else if(error.Message == "email" )
                    {
                        emailText.BackColor = System.Drawing.Color.Pink;
                        label6.Text = "Toate spațiile trebuiesc completate";
                    }
                    else if(  error.Message == "tel")
                    {
                        emailText.BackColor = System.Drawing.Color.Pink;
                        label6.Text = "Toate spațiile trebuiesc completate";
                    }
                    else if(error.Message == "pwd")
                    {
                        pwdText.BackColor = System.Drawing.Color.Pink;
                        label6.Text = "Toate spațiile trebuiesc completate";
                    }
                    else if (error.Message == "Introduceți un email valid!")
                    {
                        emailText.BackColor = System.Drawing.Color.Pink;
                        label6.Text = error.Message;
                    }
                    else if (error.Message == "Parolele nu se potrivesc!")
                    {
                        pwdText.BackColor = System.Drawing.Color.Pink;
                        pwdConfirm.BackColor = System.Drawing.Color.Pink;
                        label6.Text = error.Message;
                    }
                    else if (error.Message == "Numele de utilizator trebuie sa conțină cel puțin 3 caractere")
                    {
                        usernameText.BackColor = System.Drawing.Color.Pink;
                        label6.Text = error.Message;
                    }
                    else
                    {
                        label6.Text =  error.Message;

                    }
                }
            
        }


        private void TextBox_Enter(object sender, EventArgs e)
        {
            TextBox element = sender as TextBox;
            element.BackColor = Color.PaleGreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (button1.ForeColor == System.Drawing.Color.Red)
            {
                button1.ForeColor = System.Drawing.Color.Aquamarine;
                pwdText.UseSystemPasswordChar = false;
                pwdText.PasswordChar = '\0';
                pwdConfirm.UseSystemPasswordChar = false;
                pwdConfirm.PasswordChar = '\0';
            }
            else
            {
                button1.ForeColor = System.Drawing.Color.Red;
                pwdText.UseSystemPasswordChar = true;
                pwdText.PasswordChar = '•';
                pwdConfirm.UseSystemPasswordChar = true;
                pwdConfirm.PasswordChar = '•';
            }
        }
    }
}
