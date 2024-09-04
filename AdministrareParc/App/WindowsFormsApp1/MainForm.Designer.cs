
namespace GeoLocalizare
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.LogoFrame = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Logopic = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MenuFrame = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.signup = new System.Windows.Forms.Button();
            this.signin = new System.Windows.Forms.Button();
            this.Accbtn = new System.Windows.Forms.Button();
            this.InfoPanel = new System.Windows.Forms.Panel();
            this.nevertebratebtn = new System.Windows.Forms.Button();
            this.ihtiofaunabtn = new System.Windows.Forms.Button();
            this.amfrepbtn = new System.Windows.Forms.Button();
            this.avifaunabtn = new System.Windows.Forms.Button();
            this.mamiferebtn = new System.Windows.Forms.Button();
            this.Infobtn = new System.Windows.Forms.Button();
            this.Accountpanel = new System.Windows.Forms.Panel();
            this.GeoLocbtn = new System.Windows.Forms.Button();
            this.adminMenubtn = new System.Windows.Forms.Button();
            this.signout = new System.Windows.Forms.Button();
            this.AccountMenubtn = new System.Windows.Forms.Button();
            this.MainFrame = new System.Windows.Forms.Panel();
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.geoLocalizare1 = new WindowsFormsApp1.GeoLocalizare();
            this.LogoFrame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logopic)).BeginInit();
            this.MenuFrame.SuspendLayout();
            this.panel1.SuspendLayout();
            this.InfoPanel.SuspendLayout();
            this.Accountpanel.SuspendLayout();
            this.MainFrame.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogoFrame
            // 
            this.LogoFrame.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogoFrame.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LogoFrame.BackColor = System.Drawing.Color.DarkGreen;
            this.LogoFrame.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LogoFrame.Controls.Add(this.label2);
            this.LogoFrame.Controls.Add(this.Logopic);
            this.LogoFrame.Controls.Add(this.label1);
            this.LogoFrame.Location = new System.Drawing.Point(0, 0);
            this.LogoFrame.Name = "LogoFrame";
            this.LogoFrame.Size = new System.Drawing.Size(1383, 99);
            this.LogoFrame.TabIndex = 0;
            this.LogoFrame.Paint += new System.Windows.Forms.PaintEventHandler(this.LogoFrame_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Matura MT Script Capitals", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(69, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 45);
            this.label2.TabIndex = 2;
            this.label2.Text = "DataBase";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Logopic
            // 
            this.Logopic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Logopic.Image = ((System.Drawing.Image)(resources.GetObject("Logopic.Image")));
            this.Logopic.InitialImage = ((System.Drawing.Image)(resources.GetObject("Logopic.InitialImage")));
            this.Logopic.Location = new System.Drawing.Point(1263, 3);
            this.Logopic.Name = "Logopic";
            this.Logopic.Size = new System.Drawing.Size(106, 89);
            this.Logopic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logopic.TabIndex = 1;
            this.Logopic.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Matura MT Script Capitals", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LimeGreen;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 67);
            this.label1.TabIndex = 0;
            this.label1.Text = "Birdie";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // MenuFrame
            // 
            this.MenuFrame.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.MenuFrame.AutoScroll = true;
            this.MenuFrame.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MenuFrame.BackColor = System.Drawing.Color.ForestGreen;
            this.MenuFrame.Controls.Add(this.panel1);
            this.MenuFrame.Controls.Add(this.Accbtn);
            this.MenuFrame.Controls.Add(this.InfoPanel);
            this.MenuFrame.Controls.Add(this.Infobtn);
            this.MenuFrame.Controls.Add(this.Accountpanel);
            this.MenuFrame.Controls.Add(this.AccountMenubtn);
            this.MenuFrame.Location = new System.Drawing.Point(0, 99);
            this.MenuFrame.Name = "MenuFrame";
            this.MenuFrame.Size = new System.Drawing.Size(239, 651);
            this.MenuFrame.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.signup);
            this.panel1.Controls.Add(this.signin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 564);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 100);
            this.panel1.TabIndex = 5;
            // 
            // signup
            // 
            this.signup.AutoSize = true;
            this.signup.BackColor = System.Drawing.Color.LimeGreen;
            this.signup.Dock = System.Windows.Forms.DockStyle.Top;
            this.signup.FlatAppearance.BorderSize = 0;
            this.signup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signup.Font = new System.Drawing.Font("Berlin Sans FB", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup.Location = new System.Drawing.Point(0, 50);
            this.signup.Name = "signup";
            this.signup.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.signup.Size = new System.Drawing.Size(218, 50);
            this.signup.TabIndex = 4;
            this.signup.Text = "Înregistrare";
            this.signup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.signup.UseVisualStyleBackColor = false;
            this.signup.Click += new System.EventHandler(this.signup_Click);
            // 
            // signin
            // 
            this.signin.AutoSize = true;
            this.signin.BackColor = System.Drawing.Color.LimeGreen;
            this.signin.Dock = System.Windows.Forms.DockStyle.Top;
            this.signin.FlatAppearance.BorderSize = 0;
            this.signin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signin.Font = new System.Drawing.Font("Berlin Sans FB", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signin.Location = new System.Drawing.Point(0, 0);
            this.signin.Name = "signin";
            this.signin.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.signin.Size = new System.Drawing.Size(218, 50);
            this.signin.TabIndex = 3;
            this.signin.Text = "Conectare";
            this.signin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.signin.UseVisualStyleBackColor = false;
            this.signin.Click += new System.EventHandler(this.signin_Click);
            // 
            // Accbtn
            // 
            this.Accbtn.AutoSize = true;
            this.Accbtn.BackColor = System.Drawing.Color.ForestGreen;
            this.Accbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Accbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Accbtn.Font = new System.Drawing.Font("Berlin Sans FB", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Accbtn.Location = new System.Drawing.Point(0, 514);
            this.Accbtn.Name = "Accbtn";
            this.Accbtn.Size = new System.Drawing.Size(218, 50);
            this.Accbtn.TabIndex = 4;
            this.Accbtn.Text = "Cont";
            this.Accbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Accbtn.UseVisualStyleBackColor = false;
            this.Accbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // InfoPanel
            // 
            this.InfoPanel.AutoSize = true;
            this.InfoPanel.Controls.Add(this.nevertebratebtn);
            this.InfoPanel.Controls.Add(this.ihtiofaunabtn);
            this.InfoPanel.Controls.Add(this.amfrepbtn);
            this.InfoPanel.Controls.Add(this.avifaunabtn);
            this.InfoPanel.Controls.Add(this.mamiferebtn);
            this.InfoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.InfoPanel.Location = new System.Drawing.Point(0, 250);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Size = new System.Drawing.Size(218, 264);
            this.InfoPanel.TabIndex = 3;
            this.InfoPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.InfoPanel_Paint);
            // 
            // nevertebratebtn
            // 
            this.nevertebratebtn.AutoSize = true;
            this.nevertebratebtn.BackColor = System.Drawing.Color.LimeGreen;
            this.nevertebratebtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.nevertebratebtn.FlatAppearance.BorderSize = 0;
            this.nevertebratebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nevertebratebtn.Font = new System.Drawing.Font("Berlin Sans FB", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nevertebratebtn.Location = new System.Drawing.Point(0, 214);
            this.nevertebratebtn.Name = "nevertebratebtn";
            this.nevertebratebtn.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.nevertebratebtn.Size = new System.Drawing.Size(218, 50);
            this.nevertebratebtn.TabIndex = 8;
            this.nevertebratebtn.Text = "Nevertebrate";
            this.nevertebratebtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.nevertebratebtn.UseVisualStyleBackColor = false;
            // 
            // ihtiofaunabtn
            // 
            this.ihtiofaunabtn.AutoSize = true;
            this.ihtiofaunabtn.BackColor = System.Drawing.Color.LimeGreen;
            this.ihtiofaunabtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ihtiofaunabtn.FlatAppearance.BorderSize = 0;
            this.ihtiofaunabtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ihtiofaunabtn.Font = new System.Drawing.Font("Berlin Sans FB", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ihtiofaunabtn.Location = new System.Drawing.Point(0, 164);
            this.ihtiofaunabtn.Name = "ihtiofaunabtn";
            this.ihtiofaunabtn.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.ihtiofaunabtn.Size = new System.Drawing.Size(218, 50);
            this.ihtiofaunabtn.TabIndex = 7;
            this.ihtiofaunabtn.Text = "IhtioFauna";
            this.ihtiofaunabtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ihtiofaunabtn.UseVisualStyleBackColor = false;
            // 
            // amfrepbtn
            // 
            this.amfrepbtn.AutoSize = true;
            this.amfrepbtn.BackColor = System.Drawing.Color.LimeGreen;
            this.amfrepbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.amfrepbtn.FlatAppearance.BorderSize = 0;
            this.amfrepbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.amfrepbtn.Font = new System.Drawing.Font("Berlin Sans FB", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amfrepbtn.Location = new System.Drawing.Point(0, 100);
            this.amfrepbtn.Name = "amfrepbtn";
            this.amfrepbtn.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.amfrepbtn.Size = new System.Drawing.Size(218, 64);
            this.amfrepbtn.TabIndex = 6;
            this.amfrepbtn.Text = "Amfibieni && Reptile";
            this.amfrepbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.amfrepbtn.UseVisualStyleBackColor = false;
            // 
            // avifaunabtn
            // 
            this.avifaunabtn.AutoSize = true;
            this.avifaunabtn.BackColor = System.Drawing.Color.LimeGreen;
            this.avifaunabtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.avifaunabtn.FlatAppearance.BorderSize = 0;
            this.avifaunabtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.avifaunabtn.Font = new System.Drawing.Font("Berlin Sans FB", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avifaunabtn.Location = new System.Drawing.Point(0, 50);
            this.avifaunabtn.Name = "avifaunabtn";
            this.avifaunabtn.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.avifaunabtn.Size = new System.Drawing.Size(218, 50);
            this.avifaunabtn.TabIndex = 5;
            this.avifaunabtn.Text = "AviFauna";
            this.avifaunabtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.avifaunabtn.UseVisualStyleBackColor = false;
            // 
            // mamiferebtn
            // 
            this.mamiferebtn.AutoSize = true;
            this.mamiferebtn.BackColor = System.Drawing.Color.LimeGreen;
            this.mamiferebtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.mamiferebtn.FlatAppearance.BorderSize = 0;
            this.mamiferebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mamiferebtn.Font = new System.Drawing.Font("Berlin Sans FB", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mamiferebtn.Location = new System.Drawing.Point(0, 0);
            this.mamiferebtn.Name = "mamiferebtn";
            this.mamiferebtn.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.mamiferebtn.Size = new System.Drawing.Size(218, 50);
            this.mamiferebtn.TabIndex = 4;
            this.mamiferebtn.Text = "Mamifere";
            this.mamiferebtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mamiferebtn.UseVisualStyleBackColor = false;
            this.mamiferebtn.Click += new System.EventHandler(this.mamiferebtn_Click);
            // 
            // Infobtn
            // 
            this.Infobtn.AutoSize = true;
            this.Infobtn.BackColor = System.Drawing.Color.ForestGreen;
            this.Infobtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Infobtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Infobtn.Font = new System.Drawing.Font("Berlin Sans FB", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Infobtn.Location = new System.Drawing.Point(0, 200);
            this.Infobtn.Name = "Infobtn";
            this.Infobtn.Size = new System.Drawing.Size(218, 50);
            this.Infobtn.TabIndex = 2;
            this.Infobtn.Text = "Info Parc";
            this.Infobtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Infobtn.UseVisualStyleBackColor = false;
            this.Infobtn.Click += new System.EventHandler(this.Infobtn_Click);
            // 
            // Accountpanel
            // 
            this.Accountpanel.AutoSize = true;
            this.Accountpanel.BackColor = System.Drawing.Color.ForestGreen;
            this.Accountpanel.Controls.Add(this.GeoLocbtn);
            this.Accountpanel.Controls.Add(this.adminMenubtn);
            this.Accountpanel.Controls.Add(this.signout);
            this.Accountpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Accountpanel.Location = new System.Drawing.Point(0, 50);
            this.Accountpanel.Name = "Accountpanel";
            this.Accountpanel.Size = new System.Drawing.Size(218, 150);
            this.Accountpanel.TabIndex = 1;
            this.Accountpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.Accountpanel_Paint);
            // 
            // GeoLocbtn
            // 
            this.GeoLocbtn.AutoSize = true;
            this.GeoLocbtn.BackColor = System.Drawing.Color.LimeGreen;
            this.GeoLocbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.GeoLocbtn.FlatAppearance.BorderSize = 0;
            this.GeoLocbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GeoLocbtn.Font = new System.Drawing.Font("Berlin Sans FB", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GeoLocbtn.Location = new System.Drawing.Point(0, 100);
            this.GeoLocbtn.Name = "GeoLocbtn";
            this.GeoLocbtn.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.GeoLocbtn.Size = new System.Drawing.Size(218, 50);
            this.GeoLocbtn.TabIndex = 5;
            this.GeoLocbtn.Text = "GeoLocalizare";
            this.GeoLocbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GeoLocbtn.UseVisualStyleBackColor = false;
            this.GeoLocbtn.Click += new System.EventHandler(this.GeoLocbtn_Click);
            // 
            // adminMenubtn
            // 
            this.adminMenubtn.AutoSize = true;
            this.adminMenubtn.BackColor = System.Drawing.Color.LimeGreen;
            this.adminMenubtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.adminMenubtn.FlatAppearance.BorderSize = 0;
            this.adminMenubtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminMenubtn.Font = new System.Drawing.Font("Berlin Sans FB", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminMenubtn.Location = new System.Drawing.Point(0, 50);
            this.adminMenubtn.Name = "adminMenubtn";
            this.adminMenubtn.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.adminMenubtn.Size = new System.Drawing.Size(218, 50);
            this.adminMenubtn.TabIndex = 4;
            this.adminMenubtn.Text = "Meniu Admin";
            this.adminMenubtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.adminMenubtn.UseVisualStyleBackColor = false;
            this.adminMenubtn.Visible = false;
            this.adminMenubtn.Click += new System.EventHandler(this.adminMenubtn_Click);
            // 
            // signout
            // 
            this.signout.AutoSize = true;
            this.signout.BackColor = System.Drawing.Color.LimeGreen;
            this.signout.Dock = System.Windows.Forms.DockStyle.Top;
            this.signout.FlatAppearance.BorderSize = 0;
            this.signout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signout.Font = new System.Drawing.Font("Berlin Sans FB", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signout.Location = new System.Drawing.Point(0, 0);
            this.signout.Name = "signout";
            this.signout.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.signout.Size = new System.Drawing.Size(218, 50);
            this.signout.TabIndex = 3;
            this.signout.Text = "Deconectare";
            this.signout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.signout.UseVisualStyleBackColor = false;
            this.signout.Click += new System.EventHandler(this.signout_Click);
            // 
            // AccountMenubtn
            // 
            this.AccountMenubtn.AutoSize = true;
            this.AccountMenubtn.BackColor = System.Drawing.Color.ForestGreen;
            this.AccountMenubtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.AccountMenubtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AccountMenubtn.Font = new System.Drawing.Font("Berlin Sans FB", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountMenubtn.Location = new System.Drawing.Point(0, 0);
            this.AccountMenubtn.Name = "AccountMenubtn";
            this.AccountMenubtn.Size = new System.Drawing.Size(218, 50);
            this.AccountMenubtn.TabIndex = 0;
            this.AccountMenubtn.Text = "Contul meu";
            this.AccountMenubtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AccountMenubtn.UseVisualStyleBackColor = false;
            this.AccountMenubtn.Click += new System.EventHandler(this.AccountMenubtn_Click);
            // 
            // MainFrame
            // 
            this.MainFrame.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainFrame.AutoScroll = true;
            this.MainFrame.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MainFrame.BackColor = System.Drawing.Color.Honeydew;
            this.MainFrame.Controls.Add(this.elementHost1);
            this.MainFrame.Location = new System.Drawing.Point(238, 99);
            this.MainFrame.Name = "MainFrame";
            this.MainFrame.Size = new System.Drawing.Size(1145, 651);
            this.MainFrame.TabIndex = 2;
            this.MainFrame.Visible = false;
            this.MainFrame.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.MainFrame_ControlAdded);
            this.MainFrame.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.MainFrame_ControlRemoved);
            this.MainFrame.Paint += new System.Windows.Forms.PaintEventHandler(this.MainFrame_Paint);
            this.MainFrame.ChangeUICues += new System.Windows.Forms.UICuesEventHandler(this.MainFrame_ChangeUICues);
            // 
            // elementHost1
            // 
            this.elementHost1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.elementHost1.Location = new System.Drawing.Point(237, 84);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(1144, 659);
            this.elementHost1.TabIndex = 0;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = this.geoLocalizare1;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1382, 746);
            this.Controls.Add(this.MainFrame);
            this.Controls.Add(this.MenuFrame);
            this.Controls.Add(this.LogoFrame);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(700, 400);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Birdie Base";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.LogoFrame.ResumeLayout(false);
            this.LogoFrame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logopic)).EndInit();
            this.MenuFrame.ResumeLayout(false);
            this.MenuFrame.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.InfoPanel.ResumeLayout(false);
            this.InfoPanel.PerformLayout();
            this.Accountpanel.ResumeLayout(false);
            this.Accountpanel.PerformLayout();
            this.MainFrame.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LogoFrame;
        private System.Windows.Forms.Panel MenuFrame;
        private System.Windows.Forms.Panel MainFrame;
        private System.Windows.Forms.PictureBox Logopic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel Accountpanel;
        private System.Windows.Forms.Button AccountMenubtn;
        private System.Windows.Forms.Button signout;
        private System.Windows.Forms.Button Infobtn;
        private System.Windows.Forms.Button adminMenubtn;
        private System.Windows.Forms.Panel InfoPanel;
        private System.Windows.Forms.Button nevertebratebtn;
        private System.Windows.Forms.Button ihtiofaunabtn;
        private System.Windows.Forms.Button amfrepbtn;
        private System.Windows.Forms.Button avifaunabtn;
        private System.Windows.Forms.Button mamiferebtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button signup;
        private System.Windows.Forms.Button signin;
        private System.Windows.Forms.Button Accbtn;
        private System.Windows.Forms.Button GeoLocbtn;
        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private WindowsFormsApp1.GeoLocalizare geoLocalizare1;
    }
}

