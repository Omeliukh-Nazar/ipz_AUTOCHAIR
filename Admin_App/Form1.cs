using Admin_App.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Choice_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            tb_Image.Text = openFileDialog1.FileName;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Sender sender1 = new Sender();
            Chair chair = new Chair();
            chair.Name = tb_Name.Text;
            chair.Discription = tb_Discri.Text;
            chair.Prise = tb_Prise.Text;
            byte[] imgdata = System.IO.File.ReadAllBytes(tb_Image.Text);
            chair.Image = imgdata;
            sender1.SendCommand("[ADDCHAIR]");
            Thread.Sleep(200);
            sender1.SendSizeOfObject(sender1.GetSizeOfObject<Chair>(chair));
            Thread.Sleep(200);
            sender1.SendChair(chair);
            sender1.Close();
            MessageBox.Show("Added");
        }
    }
}
