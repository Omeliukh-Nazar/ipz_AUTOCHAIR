using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ipz_AUTOCHAIR
{
    public partial class MainProgramWindow : Form
    {
        public MainProgramWindow()
        {
            InitializeComponent();
        }
        private void BucketBox_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bucket newForm = new Bucket();
            newForm.ShowDialog();
            this.Close();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        Point lastPoint;
        private void MainProgramWindow_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void MainProgramWindow_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OrderListBox_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrderList newForm = new OrderList();
            newForm.ShowDialog();
            this.Close();
        }
    }
}
