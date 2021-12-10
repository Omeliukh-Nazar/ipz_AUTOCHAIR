
namespace ipz_AUTOCHAIR
{
        partial class Registration
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.tb_phone = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_login = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bcback = new System.Windows.Forms.Button();
            this.bccreate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(214)))), ((int)(((byte)(171)))));
            this.label1.Location = new System.Drawing.Point(94, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please, create your account!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(24, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name(include first and last names):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(24, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "E-mail:";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(28, 114);
            this.tb_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_name.Multiline = true;
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(238, 26);
            this.tb_name.TabIndex = 5;
            this.tb_name.TextChanged += new System.EventHandler(this.tb_name_TextChanged);
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(27, 168);
            this.tb_email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_email.Multiline = true;
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(239, 26);
            this.tb_email.TabIndex = 6;
            this.tb_email.TextChanged += new System.EventHandler(this.tb_email_TextChanged);
            // 
            // tb_phone
            // 
            this.tb_phone.Location = new System.Drawing.Point(28, 226);
            this.tb_phone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_phone.Mask = "000000000000";
            this.tb_phone.Name = "tb_phone";
            this.tb_phone.Size = new System.Drawing.Size(107, 23);
            this.tb_phone.TabIndex = 8;
            this.tb_phone.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.tb_phone_MaskInputRejected);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(24, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Phone number:";
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(27, 339);
            this.tb_password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_password.Multiline = true;
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(239, 26);
            this.tb_password.TabIndex = 14;
            this.tb_password.TextChanged += new System.EventHandler(this.tb_password_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(24, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Create password";
            // 
            // tb_login
            // 
            this.tb_login.Location = new System.Drawing.Point(28, 278);
            this.tb_login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_login.Multiline = true;
            this.tb_login.Name = "tb_login";
            this.tb_login.Size = new System.Drawing.Size(238, 26);
            this.tb_login.TabIndex = 12;
            this.tb_login.TextChanged += new System.EventHandler(this.tb_login_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(24, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Create login:";
            // 
            // bcback
            // 
            this.bcback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(214)))), ((int)(((byte)(171)))));
            this.bcback.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bcback.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(133)))), ((int)(((byte)(91)))));
            this.bcback.Location = new System.Drawing.Point(316, 441);
            this.bcback.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bcback.Name = "bcback";
            this.bcback.Size = new System.Drawing.Size(98, 34);
            this.bcback.TabIndex = 15;
            this.bcback.Text = "back";
            this.bcback.UseVisualStyleBackColor = false;
            this.bcback.Click += new System.EventHandler(this.bccancel_Click);
            // 
            // bccreate
            // 
            this.bccreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(214)))), ((int)(((byte)(171)))));
            this.bccreate.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bccreate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(133)))), ((int)(((byte)(91)))));
            this.bccreate.Location = new System.Drawing.Point(410, 441);
            this.bccreate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bccreate.Name = "bccreate";
            this.bccreate.Size = new System.Drawing.Size(98, 34);
            this.bccreate.TabIndex = 16;
            this.bccreate.Text = "CREATE";
            this.bccreate.UseVisualStyleBackColor = false;
            this.bccreate.Click += new System.EventHandler(this.bccreate_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.DarkGray;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(497, -1);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(22, 20);
            this.btnClose.TabIndex = 18;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(133)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(518, 484);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.bccreate);
            this.Controls.Add(this.bcback);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_login);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_phone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoChair";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Registration_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Registration_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

            #endregion

            private System.Windows.Forms.Label label1;
            private System.Windows.Forms.Label label2;
            private System.Windows.Forms.Label label3;
            private System.Windows.Forms.TextBox tb_name;
            private System.Windows.Forms.TextBox tb_email;
            private System.Windows.Forms.MaskedTextBox tb_phone;
            private System.Windows.Forms.Label label4;
            private System.Windows.Forms.TextBox tb_password;
            private System.Windows.Forms.Label label6;
            private System.Windows.Forms.TextBox tb_login;
            private System.Windows.Forms.Label label5;
            private System.Windows.Forms.Button bccancel;
            private System.Windows.Forms.Button bccreate;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button bcback;
    }
}