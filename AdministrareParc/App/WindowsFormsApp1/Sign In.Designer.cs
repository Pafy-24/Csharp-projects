
namespace GeoLocalizare
{
    partial class Sign_In
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
            this.label3 = new System.Windows.Forms.Label();
            this.emailText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pwdText = new System.Windows.Forms.TextBox();
            this.SignInbtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Berlin Sans FB", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.label3.ForeColor = System.Drawing.Color.DarkGreen;
            this.label3.Location = new System.Drawing.Point(200, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 26);
            this.label3.TabIndex = 9;
            this.label3.Text = "Email/Username:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // emailText
            // 
            this.emailText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.emailText.BackColor = System.Drawing.Color.PaleGreen;
            this.emailText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailText.Font = new System.Drawing.Font("Berlin Sans FB", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailText.Location = new System.Drawing.Point(409, 109);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(328, 33);
            this.emailText.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(305, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 26);
            this.label1.TabIndex = 11;
            this.label1.Text = "Parola:";
            // 
            // pwdText
            // 
            this.pwdText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pwdText.BackColor = System.Drawing.Color.PaleGreen;
            this.pwdText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pwdText.Font = new System.Drawing.Font("Berlin Sans FB", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwdText.Location = new System.Drawing.Point(409, 180);
            this.pwdText.Name = "pwdText";
            this.pwdText.PasswordChar = '●';
            this.pwdText.Size = new System.Drawing.Size(328, 33);
            this.pwdText.TabIndex = 10;
            // 
            // SignInbtn
            // 
            this.SignInbtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SignInbtn.AutoSize = true;
            this.SignInbtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SignInbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignInbtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.SignInbtn.FlatAppearance.BorderSize = 3;
            this.SignInbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.SignInbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.SignInbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignInbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignInbtn.Location = new System.Drawing.Point(472, 301);
            this.SignInbtn.Name = "SignInbtn";
            this.SignInbtn.Size = new System.Drawing.Size(156, 47);
            this.SignInbtn.TabIndex = 12;
            this.SignInbtn.Text = "Conectare";
            this.SignInbtn.UseVisualStyleBackColor = true;
            this.SignInbtn.Click += new System.EventHandler(this.SignInbtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(452, 400);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 33);
            this.label6.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(744, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 33);
            this.button1.TabIndex = 14;
            this.button1.Text = "👁";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Sign_In
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1121, 579);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SignInbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pwdText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.emailText);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "Sign_In";
            this.Text = "Sign_In";
            this.Load += new System.EventHandler(this.Sign_In_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox emailText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pwdText;
        private System.Windows.Forms.Button SignInbtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}