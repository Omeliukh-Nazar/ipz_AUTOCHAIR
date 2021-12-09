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
    public partial class Bucket : Form
    {
        public Bucket()
        {
            InitializeComponent();
        }

        private void bcgotomainmenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainProgramWindow newForm = new MainProgramWindow();
            newForm.ShowDialog();
            this.Close();
        }

        private void bcorder_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrderList newForm = new OrderList();
            newForm.ShowDialog();
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
