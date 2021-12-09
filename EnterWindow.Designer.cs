
namespace ipz_AUTOCHAIR
{
    partial class EnterWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.bcAuthorization = new System.Windows.Forms.Button();
            this.bcRegistration = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(133)))), ((int)(((byte)(91)))));
            this.label1.Location = new System.Drawing.Point(33, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(543, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome to Internet-shop \"AutoChair\"!";
            // 
            // bcAuthorization
            // 
            this.bcAuthorization.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bcAuthorization.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(214)))), ((int)(((byte)(171)))));
            this.bcAuthorization.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.bcAuthorization.Font = new System.Drawing.Font("Showcard Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bcAuthorization.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(133)))), ((int)(((byte)(91)))));
            this.bcAuthorization.Location = new System.Drawing.Point(163, 312);
            this.bcAuthorization.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bcAuthorization.Name = "bcAuthorization";
            this.bcAuthorization.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bcAuthorization.Size = new System.Drawing.Size(269, 85);
            this.bcAuthorization.TabIndex = 3;
            this.bcAuthorization.Text = "AUTHORIZATION";
            this.bcAuthorization.UseVisualStyleBackColor = false;
            this.bcAuthorization.Click += new System.EventHandler(this.bcAuthorization_Click);
            // 
            // bcRegistration
            // 
            this.bcRegistration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bcRegistration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(214)))), ((int)(((byte)(171)))));
            this.bcRegistration.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.bcRegistration.Font = new System.Drawing.Font("Showcard Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bcRegistration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(133)))), ((int)(((byte)(91)))));
            this.bcRegistration.Location = new System.Drawing.Point(163, 403);
            this.bcRegistration.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bcRegistration.Name = "bcRegistration";
            this.bcRegistration.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bcRegistration.Size = new System.Drawing.Size(269, 85);
            this.bcRegistration.TabIndex = 4;
            this.bcRegistration.Text = "REGISTRATION";
            this.bcRegistration.UseVisualStyleBackColor = false;
            this.bcRegistration.Click += new System.EventHandler(this.bcRegistration_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.DarkGray;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(566, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 26);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(214)))), ((int)(((byte)(171)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(591, 115);
            this.panel1.TabIndex = 6;
            // 
            // EnterWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(133)))), ((int)(((byte)(91)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(592, 645);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bcRegistration);
            this.Controls.Add(this.bcAuthorization);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.SlateBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "EnterWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoChair";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.EnterWindow_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.EnterWindow_MouseMove);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bcAuthorization;
        private System.Windows.Forms.Button bcRegistration;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel1;
    }
}