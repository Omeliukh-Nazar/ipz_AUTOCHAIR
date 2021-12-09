
namespace ipz_AUTOCHAIR
{
    partial class MainProgramWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainProgramWindow));
            this.logoutbutton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.OrderListBox = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.BucketBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderListBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BucketBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // logoutbutton
            // 
            this.logoutbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(214)))), ((int)(((byte)(171)))));
            this.logoutbutton.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.logoutbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(133)))), ((int)(((byte)(91)))));
            this.logoutbutton.Location = new System.Drawing.Point(468, 588);
            this.logoutbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logoutbutton.Name = "logoutbutton";
            this.logoutbutton.Size = new System.Drawing.Size(112, 46);
            this.logoutbutton.TabIndex = 0;
            this.logoutbutton.Text = "LogOut";
            this.logoutbutton.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(214)))), ((int)(((byte)(171)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.OrderListBox);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.BucketBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(594, 115);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(110, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Order LIst";
            // 
            // OrderListBox
            // 
            this.OrderListBox.ErrorImage = null;
            this.OrderListBox.Image = ((System.Drawing.Image)(resources.GetObject("OrderListBox.Image")));
            this.OrderListBox.InitialImage = null;
            this.OrderListBox.Location = new System.Drawing.Point(110, 6);
            this.OrderListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OrderListBox.Name = "OrderListBox";
            this.OrderListBox.Size = new System.Drawing.Size(90, 87);
            this.OrderListBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.OrderListBox.TabIndex = 5;
            this.OrderListBox.TabStop = false;
            this.OrderListBox.Click += new System.EventHandler(this.OrderListBox_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkGray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(569, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 26);
            this.button2.TabIndex = 21;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BucketBox1
            // 
            this.BucketBox1.ErrorImage = null;
            this.BucketBox1.Image = global::ipz_AUTOCHAIR.Properties.Resources.bucket;
            this.BucketBox1.InitialImage = null;
            this.BucketBox1.Location = new System.Drawing.Point(14, 6);
            this.BucketBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BucketBox1.Name = "BucketBox1";
            this.BucketBox1.Size = new System.Drawing.Size(90, 87);
            this.BucketBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BucketBox1.TabIndex = 1;
            this.BucketBox1.TabStop = false;
            this.BucketBox1.Click += new System.EventHandler(this.BucketBox_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(33, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "BUCKET";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(133)))), ((int)(((byte)(91)))));
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(214)))), ((int)(((byte)(171)))));
            this.label3.Location = new System.Drawing.Point(154, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(288, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "Please, choose chair!";
            // 
            // MainProgramWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(133)))), ((int)(((byte)(91)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(592, 645);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.logoutbutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "MainProgramWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoChair";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainProgramWindow_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainProgramWindow_MouseMove);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderListBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BucketBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button logoutbutton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox BucketBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox OrderListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

