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
    public partial class OrderList : Form
    {
        public OrderList()
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
