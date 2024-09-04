
namespace GeoLocalizare
{
    partial class Mamifere
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.specieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.denumirePopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eUNISDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.populatieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.popDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.izoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mamifereBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._Birdie_DatabaseDataSet = new WindowsFormsApp1._Birdie_DatabaseDataSet();
            this.mamifereTableAdapter = new WindowsFormsApp1._Birdie_DatabaseDataSetTableAdapters.MamifereTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Rights = new System.Windows.Forms.Label();
            this.SignUpbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mamifereBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Birdie_DatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LimeGreen;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.specieDataGridViewTextBoxColumn,
            this.denumirePopDataGridViewTextBoxColumn,
            this.eUNISDataGridViewTextBoxColumn,
            this.motivDataGridViewTextBoxColumn,
            this.populatieDataGridViewTextBoxColumn,
            this.popDataGridViewTextBoxColumn,
            this.consDataGridViewTextBoxColumn,
            this.izoDataGridViewTextBoxColumn,
            this.gloDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.mamifereBindingSource;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.GridColor = System.Drawing.Color.ForestGreen;
            this.dataGridView1.Location = new System.Drawing.Point(0, 108);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(904, 362);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // specieDataGridViewTextBoxColumn
            // 
            this.specieDataGridViewTextBoxColumn.DataPropertyName = "specie";
            this.specieDataGridViewTextBoxColumn.HeaderText = "Specie";
            this.specieDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.specieDataGridViewTextBoxColumn.Name = "specieDataGridViewTextBoxColumn";
            this.specieDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // denumirePopDataGridViewTextBoxColumn
            // 
            this.denumirePopDataGridViewTextBoxColumn.DataPropertyName = "denumire pop";
            this.denumirePopDataGridViewTextBoxColumn.HeaderText = "Denumire Populară";
            this.denumirePopDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.denumirePopDataGridViewTextBoxColumn.Name = "denumirePopDataGridViewTextBoxColumn";
            this.denumirePopDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eUNISDataGridViewTextBoxColumn
            // 
            this.eUNISDataGridViewTextBoxColumn.DataPropertyName = "EUNIS";
            this.eUNISDataGridViewTextBoxColumn.HeaderText = "Cod EUNIS";
            this.eUNISDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eUNISDataGridViewTextBoxColumn.Name = "eUNISDataGridViewTextBoxColumn";
            this.eUNISDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // motivDataGridViewTextBoxColumn
            // 
            this.motivDataGridViewTextBoxColumn.DataPropertyName = "Motiv";
            this.motivDataGridViewTextBoxColumn.HeaderText = "Motiv";
            this.motivDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.motivDataGridViewTextBoxColumn.Name = "motivDataGridViewTextBoxColumn";
            this.motivDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // populatieDataGridViewTextBoxColumn
            // 
            this.populatieDataGridViewTextBoxColumn.DataPropertyName = "populatie";
            this.populatieDataGridViewTextBoxColumn.HeaderText = "Populaţie";
            this.populatieDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.populatieDataGridViewTextBoxColumn.Name = "populatieDataGridViewTextBoxColumn";
            this.populatieDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // popDataGridViewTextBoxColumn
            // 
            this.popDataGridViewTextBoxColumn.DataPropertyName = "pop";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.popDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.popDataGridViewTextBoxColumn.HeaderText = "Pop";
            this.popDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.popDataGridViewTextBoxColumn.Name = "popDataGridViewTextBoxColumn";
            this.popDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // consDataGridViewTextBoxColumn
            // 
            this.consDataGridViewTextBoxColumn.DataPropertyName = "cons";
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.consDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.consDataGridViewTextBoxColumn.HeaderText = "Cons";
            this.consDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.consDataGridViewTextBoxColumn.Name = "consDataGridViewTextBoxColumn";
            this.consDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // izoDataGridViewTextBoxColumn
            // 
            this.izoDataGridViewTextBoxColumn.DataPropertyName = "izo";
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.izoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.izoDataGridViewTextBoxColumn.HeaderText = "Izo";
            this.izoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.izoDataGridViewTextBoxColumn.Name = "izoDataGridViewTextBoxColumn";
            this.izoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gloDataGridViewTextBoxColumn
            // 
            this.gloDataGridViewTextBoxColumn.DataPropertyName = "glo";
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gloDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.gloDataGridViewTextBoxColumn.HeaderText = "Glo";
            this.gloDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gloDataGridViewTextBoxColumn.Name = "gloDataGridViewTextBoxColumn";
            this.gloDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mamifereBindingSource
            // 
            this.mamifereBindingSource.DataMember = "Mamifere";
            this.mamifereBindingSource.DataSource = this._Birdie_DatabaseDataSet;
            // 
            // _Birdie_DatabaseDataSet
            // 
            this._Birdie_DatabaseDataSet.DataSetName = "_Birdie_DatabaseDataSet";
            this._Birdie_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mamifereTableAdapter
            // 
            this.mamifereTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Matura MT Script Capitals", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LimeGreen;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 53);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mamifere";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Matura MT Script Capitals", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 36);
            this.label2.TabIndex = 3;
            this.label2.Text = "Access level:";
            // 
            // Rights
            // 
            this.Rights.AutoSize = true;
            this.Rights.BackColor = System.Drawing.Color.Transparent;
            this.Rights.Font = new System.Drawing.Font("Matura MT Script Capitals", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rights.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Rights.Location = new System.Drawing.Point(187, 62);
            this.Rights.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Rights.Name = "Rights";
            this.Rights.Size = new System.Drawing.Size(0, 36);
            this.Rights.TabIndex = 4;
            // 
            // SignUpbtn
            // 
            this.SignUpbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SignUpbtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.SignUpbtn.FlatAppearance.BorderSize = 3;
            this.SignUpbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.SignUpbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.SignUpbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignUpbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpbtn.Location = new System.Drawing.Point(793, 10);
            this.SignUpbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SignUpbtn.Name = "SignUpbtn";
            this.SignUpbtn.Size = new System.Drawing.Size(102, 37);
            this.SignUpbtn.TabIndex = 11;
            this.SignUpbtn.Text = "Salvare";
            this.SignUpbtn.UseVisualStyleBackColor = true;
            this.SignUpbtn.Click += new System.EventHandler(this.SignUpbtn_Click);
            // 
            // Mamifere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(904, 470);
            this.Controls.Add(this.SignUpbtn);
            this.Controls.Add(this.Rights);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Mamifere";
            this.Text = "Mamifere";
            this.Load += new System.EventHandler(this.Mamifere_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mamifereBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Birdie_DatabaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private WindowsFormsApp1._Birdie_DatabaseDataSet _Birdie_DatabaseDataSet;
        private System.Windows.Forms.BindingSource mamifereBindingSource;
        private WindowsFormsApp1._Birdie_DatabaseDataSetTableAdapters.MamifereTableAdapter mamifereTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn specieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn denumirePopDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eUNISDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn motivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn populatieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn popDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn consDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn izoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gloDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Rights;
        private System.Windows.Forms.Button SignUpbtn;
    }
}