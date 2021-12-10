
namespace Admin_App
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Choice = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.tb_Discri = new System.Windows.Forms.TextBox();
            this.tb_Prise = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_Image = new System.Windows.Forms.TextBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btn_Choice
            // 
            this.btn_Choice.Location = new System.Drawing.Point(87, 192);
            this.btn_Choice.Name = "btn_Choice";
            this.btn_Choice.Size = new System.Drawing.Size(75, 23);
            this.btn_Choice.TabIndex = 0;
            this.btn_Choice.Text = "Choice";
            this.btn_Choice.UseVisualStyleBackColor = true;
            this.btn_Choice.Click += new System.EventHandler(this.btn_Choice_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Discription";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Prise";
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(87, 20);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(205, 23);
            this.tb_Name.TabIndex = 4;
            // 
            // tb_Discri
            // 
            this.tb_Discri.Location = new System.Drawing.Point(87, 53);
            this.tb_Discri.Multiline = true;
            this.tb_Discri.Name = "tb_Discri";
            this.tb_Discri.Size = new System.Drawing.Size(205, 65);
            this.tb_Discri.TabIndex = 5;
            // 
            // tb_Prise
            // 
            this.tb_Prise.Location = new System.Drawing.Point(87, 130);
            this.tb_Prise.Name = "tb_Prise";
            this.tb_Prise.Size = new System.Drawing.Size(100, 23);
            this.tb_Prise.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Image";
            // 
            // tb_Image
            // 
            this.tb_Image.Location = new System.Drawing.Point(87, 163);
            this.tb_Image.Name = "tb_Image";
            this.tb_Image.Size = new System.Drawing.Size(205, 23);
            this.tb_Image.TabIndex = 8;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(217, 192);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 9;
            this.btn_Add.Text = "Add Chair";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 243);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.tb_Image);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_Prise);
            this.Controls.Add(this.tb_Discri);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Choice);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Choice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.TextBox tb_Discri;
        private System.Windows.Forms.TextBox tb_Prise;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_Image;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

