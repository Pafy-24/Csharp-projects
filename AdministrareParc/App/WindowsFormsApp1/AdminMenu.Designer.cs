
namespace GeoLocalizare
{
    partial class AdminMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.username = new System.Windows.Forms.TextBox();
            this.rights = new System.Windows.Forms.ComboBox();
            this.ID = new System.Windows.Forms.TextBox();
            this.tel = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.utilizatoriBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this._Birdie_DatabaseDataSet = new WindowsFormsApp1._Birdie_DatabaseDataSet();
            this.utilizatoriBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.utilizatoriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.utilizatoriTableAdapter = new WindowsFormsApp1._Birdie_DatabaseDataSetTableAdapters.UtilizatoriTableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.utilizatoriBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Birdie_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilizatoriBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilizatoriBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Berlin Sans FB", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.label5.ForeColor = System.Drawing.Color.DarkGreen;
            this.label5.Location = new System.Drawing.Point(9, 36);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Info despre:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.username, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.rights, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.ID, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.email, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 98);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(801, 292);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // username
            // 
            this.username.BackColor = System.Drawing.Color.PaleGreen;
            this.username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.username.Dock = System.Windows.Forms.DockStyle.Fill;
            this.username.Font = new System.Drawing.Font("Berlin Sans FB", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(2, 43);
            this.username.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(797, 37);
            this.username.TabIndex = 14;
            this.username.Enter += new System.EventHandler(this.rights_SelectedIndexChanged);
            this.username.Leave += new System.EventHandler(this.rights_SelectedIndexChanged);
            // 
            // rights
            // 
            this.rights.BackColor = System.Drawing.Color.PaleGreen;
            this.rights.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rights.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rights.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rights.Font = new System.Drawing.Font("Berlin Sans FB", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rights.FormattingEnabled = true;
            this.rights.Items.AddRange(new object[] {
            "member",
            "moderator",
            "admin"});
            this.rights.Location = new System.Drawing.Point(2, 166);
            this.rights.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rights.Name = "rights";
            this.rights.Size = new System.Drawing.Size(797, 38);
            this.rights.TabIndex = 13;
            this.rights.SelectedIndexChanged += new System.EventHandler(this.rights_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.BackColor = System.Drawing.Color.PaleGreen;
            this.ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ID.Font = new System.Drawing.Font("Berlin Sans FB", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.Location = new System.Drawing.Point(2, 2);
            this.ID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.ShortcutsEnabled = false;
            this.ID.Size = new System.Drawing.Size(797, 37);
            this.ID.TabIndex = 9;
            this.ID.Enter += new System.EventHandler(this.rights_SelectedIndexChanged);
            this.ID.Leave += new System.EventHandler(this.rights_SelectedIndexChanged);
            // 
            // tel
            // 
            this.tel.BackColor = System.Drawing.Color.PaleGreen;
            this.tel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tel.Font = new System.Drawing.Font("Berlin Sans FB", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tel.Location = new System.Drawing.Point(2, 125);
            this.tel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tel.Name = "tel";
            this.tel.Size = new System.Drawing.Size(797, 37);
            this.tel.TabIndex = 11;
            this.tel.Enter += new System.EventHandler(this.rights_SelectedIndexChanged);
            this.tel.Leave += new System.EventHandler(this.rights_SelectedIndexChanged);
            // 
            // email
            // 
            this.email.BackColor = System.Drawing.Color.PaleGreen;
            this.email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.email.Dock = System.Windows.Forms.DockStyle.Fill;
            this.email.Font = new System.Drawing.Font("Berlin Sans FB", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(2, 84);
            this.email.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(797, 37);
            this.email.TabIndex = 10;
            this.email.Enter += new System.EventHandler(this.rights_SelectedIndexChanged);
            this.email.Leave += new System.EventHandler(this.rights_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.BackColor = System.Drawing.Color.Honeydew;
            this.comboBox1.DataSource = this.utilizatoriBindingSource2;
            this.comboBox1.DisplayMember = "username";
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(109, 36);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(213, 32);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "ID";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // utilizatoriBindingSource2
            // 
            this.utilizatoriBindingSource2.DataMember = "Utilizatori";
            this.utilizatoriBindingSource2.DataSource = this._Birdie_DatabaseDataSet;
            // 
            // _Birdie_DatabaseDataSet
            // 
            this._Birdie_DatabaseDataSet.DataSetName = "_Birdie_DatabaseDataSet";
            this._Birdie_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // utilizatoriTableAdapter
            // 
            this.utilizatoriTableAdapter.ClearBeforeFill = true;
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(822, 399);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AdminMenu";
            this.Text = "AdminMenu";
            this.Load += new System.EventHandler(this.AdminMenu_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.utilizatoriBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Birdie_DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilizatoriBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilizatoriBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox tel;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.ComboBox rights;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource utilizatoriBindingSource;
        private System.Windows.Forms.BindingSource utilizatoriBindingSource1;
        private WindowsFormsApp1._Birdie_DatabaseDataSet _Birdie_DatabaseDataSet;
        private System.Windows.Forms.BindingSource utilizatoriBindingSource2;
        private WindowsFormsApp1._Birdie_DatabaseDataSetTableAdapters.UtilizatoriTableAdapter utilizatoriTableAdapter;
    }
}