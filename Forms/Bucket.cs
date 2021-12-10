using ipz_AUTOCHAIR.Models;
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

        public Bucket(List<Order> orders)
        {
            Orders = orders;
            InitializeComponent();
        }

        public List<Order> Orders { get; set; }

        private void bcgotomainmenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainProgramWindow newForm = new MainProgramWindow();
            newForm.ShowDialog();
            this.Close();
        }

        private void bcorder_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            client.SendCommand("[ADDORDER]");
            int size = client.GetSizeOfObject<List<Order>>(Orders);
            client.SendSizeOfObject(size);
            client.SendObject<List<Order>>(Orders);
            MessageBox.Show("Added");
            this.Hide();
            OrderList newForm = new OrderList();
            newForm.ShowDialog();
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Bucket_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (from d in Orders orderby d.Chair.Name select new { d.Chair.Name, d.Prise, d.Count }).ToList();
            dataGridView1.Columns[0].HeaderCell.Value = "Name";
            dataGridView1.Columns[1].HeaderCell.Value = "Prise";
            dataGridView1.Columns[2].HeaderCell.Value = "Count";
            dataGridView1.Columns.Add("Full Prise", "Full Prise");
            int i = 0;
            foreach (var item in Orders)
            {
                dataGridView1.Rows[i].Cells[3].Value = int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString()) * int.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString());
                i++;
            }
        }


    }
}
