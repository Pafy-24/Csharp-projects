using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeoLocalizare
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            MainFrame.Visible = true;
            elementHost1.Child = null;
            elementHost1.Visible = false;
            adminMenubtn.Visible = false;
         //  /*
            if(globals.userid != -1)
            {
                Accbtn.Visible = false;
                panel1.Visible = false;

                Infobtn.Visible = true;
                AccountMenubtn.Visible = true;

                //  Accountpanel.Visible = true;
                //  InfoPanel.Visible = true;

                // Accountpanel.Visible = false;
                //  InfoPanel.Visible = false;
                adminMenubtn.Visible = false;
                if (globals.user_rights == "admin") adminMenubtn.Visible = true;
            }
            else
            {
                Accbtn.Visible = true;
                AccountMenubtn.Visible = false;
                Accountpanel.Visible = false;
                Infobtn.Visible = false;
                InfoPanel.Visible = false;
                panel1.Visible = false;
            }//*/
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void AccountMenubtn_Click(object sender, EventArgs e)
        {
            if (this.Accountpanel.Visible == true)
                this.Accountpanel.Visible = false;
            else
                this.Accountpanel.Visible = true;
        }

        private void Infobtn_Click(object sender, EventArgs e)
        {
            if (this.InfoPanel.Visible == true)
                this.InfoPanel.Visible = false;
            else
                this.InfoPanel.Visible = true;

        }

        private void signup_Click(object sender, EventArgs e)
        {
            MainFrame.Controls.Clear();
            Sign_Up SignUp = new Sign_Up();
            SignUp.TopLevel = false;
            MainFrame.Controls.Add(SignUp);
            SignUp.FormBorderStyle = FormBorderStyle.None;
            SignUp.Dock = DockStyle.Fill;
            SignUp.Show();
        }

        private void signin_Click(object sender, EventArgs e)
        {
            MainFrame.Controls.Clear();
            Sign_In SignIn = new Sign_In();
            SignIn.TopLevel = false;
            MainFrame.Controls.Add(SignIn);
            SignIn.FormBorderStyle = FormBorderStyle.None;
            SignIn.Dock = DockStyle.Fill;
            SignIn.Show();
        }

        private void MainFrame_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainFrame_ChangeUICues(object sender, UICuesEventArgs e)
        {
            this.MainForm_Load(sender, e);
        }

        private void MainFrame_ControlAdded(object sender, ControlEventArgs e)
        {
            this.MainForm_Load(sender, e);
        }

        private void MainFrame_ControlRemoved(object sender, ControlEventArgs e)
        {
            this.MainForm_Load(sender, e);
        }

        private void InfoPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Accountpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.panel1.Visible == true)
                this.panel1.Visible = false;
            else
                this.panel1.Visible = true;

        }

        private void signout_Click(object sender, EventArgs e)
        {
            globals.userid = -1;
            globals.user = null;
            globals.user_email = null;
            globals.user_rights = null;
            this.MainForm_Load(sender, e);
            MainFrame.Controls.Clear();
        }

        private void adminMenubtn_Click(object sender, EventArgs e)
        {
            MainFrame.Controls.Clear();
            AdminMenu adminMenu = new AdminMenu();
            adminMenu.TopLevel = false;
            MainFrame.Controls.Add(adminMenu);
            adminMenu.FormBorderStyle = FormBorderStyle.None;
            adminMenu.Dock = DockStyle.Fill;
            adminMenu.Show();

        }

        private void GeoLocbtn_Click(object sender, EventArgs e)
        {
            MainFrame.Controls.Clear();
            MainFrame.Visible = false;
            elementHost1.Child = geoLocalizare1;
            
            elementHost1.Visible = true;
            elementHost1.BringToFront();
           // elementHost1.Dock = DockStyle.Fill;

           // elementHost1.Child = geoLocalizare1;

            // Add the ElementHost control to the form's
            // collection of child controls.
            this.Controls.Add(elementHost1);

        }

        private void mamiferebtn_Click(object sender, EventArgs e)
        {
            MainFrame.Controls.Clear();
            Mamifere mamifere = new Mamifere();
            mamifere.TopLevel = false;
            MainFrame.Controls.Add(mamifere);
            mamifere.FormBorderStyle = FormBorderStyle.None;
            mamifere.Dock = DockStyle.Fill;
            mamifere.Show();


        }

        private void LogoFrame_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
