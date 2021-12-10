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
    public partial class EnterWindow : Form
    {
        public EnterWindow()
        {
            InitializeComponent();
        }

        private void bcAuthorization_Click(object sender, EventArgs e)
        {
            this.Hide();
            Authorization newForm = new Authorization();
            newForm.ShowDialog();
            this.Close();
        }

        private void bcRegistration_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration newForm = new Registration();
            newForm.ShowDialog();
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Point lastPoint;
        private void EnterWindow_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void EnterWindow_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
    }
}
