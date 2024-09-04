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
    public partial class Mamifere : Form
    {
        public Mamifere()
        {
            InitializeComponent();
        }

        private void Mamifere_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_Birdie_DatabaseDataSet.Mamifere' table. You can move, or remove it, as needed.
            this.mamifereTableAdapter.Fill(this._Birdie_DatabaseDataSet.Mamifere);
            Rights.Text = globals.user_rights.ToString();
            if(Rights.Text == "moderator" || Rights.Text == "admin")
            {
                dataGridView1.AllowUserToAddRows = true;
                dataGridView1.AllowUserToDeleteRows = true;
                dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystrokeOrF2;
                dataGridView1.ReadOnly = false;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SignUpbtn_Click(object sender, EventArgs e)
        {


        }
    }
}
