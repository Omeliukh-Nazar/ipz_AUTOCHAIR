﻿using ipz_AUTOCHAIR.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ipz_AUTOCHAIR
{
    public partial class MainProgramWindow : Form
    {
        public List<Chair> Chairs { get; set; }
        public List<Order> Orders = new List<Order>(); 
        public MainProgramWindow()
        {
            Client client = new Client();
            client.SendCommand("[UPDATE]");
            int size = client.GetSize();
            Chairs = client.GetObject<List<Chair>>(size);
            InitializeComponent();
        }
        private void MainProgramWindow_Load(object sender, EventArgs e)
        {
            
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.ColumnCount = 2;
            int row = 0;
            int col = 0;
            foreach (var chair in Chairs)
            {
                MemoryStream ms = new MemoryStream(chair.Image);
                Image image = Image.FromStream(ms);

                TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();
                tableLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                tableLayoutPanel.ColumnCount = 1;
                tableLayoutPanel.RowCount = 5;
                tableLayoutPanel.Dock = DockStyle.Fill;
                tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
                tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
                tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
                tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
                tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));

                Label labelName = new Label() { TextAlign = ContentAlignment.MiddleCenter, Dock = DockStyle.Fill };
                labelName.Text = chair.Name;
                tableLayoutPanel.Controls.Add(labelName, 0, 0);
                Label labelDisc = new Label() { TextAlign = ContentAlignment.MiddleCenter, Dock = DockStyle.Fill };
                labelDisc.Text = chair.Discription;

                tableLayoutPanel.Controls.Add(labelDisc, 0, 1);
                Label labelPrise = new Label() { TextAlign = ContentAlignment.MiddleCenter, Dock = DockStyle.Fill };
                labelPrise.Text = chair.Prise + " $";
                tableLayoutPanel.Controls.Add(labelPrise, 0, 2);
                PictureBox picture = new PictureBox()
                {
                    Image = image,
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Dock = DockStyle.Fill
                    
                };
                tableLayoutPanel.Controls.Add(picture, 0, 3);


                TableLayoutPanel tableLayoutPanel2 = new TableLayoutPanel();
                tableLayoutPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                tableLayoutPanel2.ColumnCount = 3;
                tableLayoutPanel2.RowCount = 1;
                tableLayoutPanel2.Dock = DockStyle.Fill;
                tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
                tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
                tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));

                Button btn_Add = new Button() 
                {
                   Name = chair.Name,
                   Dock = DockStyle.Fill,
                   Text = "Add To Bucket"
                };
                btn_Add.Click += Btn_Add_Click;
                tableLayoutPanel2.Controls.Add(btn_Add, 0, 0);
                Label labelCount = new Label() 
                {
                    Text = "Count",
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleCenter
                    
                };
                tableLayoutPanel2.Controls.Add(labelCount, 1, 0);
                NumericUpDown upDown = new NumericUpDown()
                {
                    Dock = DockStyle.Fill,
                    
                    Minimum = 1,
                    Maximum = 100
                };
                tableLayoutPanel2.Controls.Add(upDown, 2, 0);

                tableLayoutPanel.Controls.Add(tableLayoutPanel2, 0, 4);

                tableLayoutPanel1.Controls.Add(tableLayoutPanel, col, row);
                col++;
                if (col == 2)
                {
                    row++;
                    col = 0;
                }

            }
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            string prise = (sender as Button).Parent.Parent.Controls[2].Text.Split().First();
            Chair chair = Chairs.Find(x => x.Name == (sender as Button).Name);
            Order order = new Order()
            {
                Chair = chair,
                Count = int.Parse((sender as Button).Parent.Controls[2].Text),
                Prise = int.Parse(prise),
                UserId = Client.ID
                
            };
            Orders.Add(order);
            MessageBox.Show($"{int.Parse((sender as Button).Parent.Controls[2].Text)} of {(sender as Button).Name} added to bucket!","Added to Bucket");
        }

        
        private void BucketBox_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bucket newForm = new Bucket(Orders);
            newForm.ShowDialog();
            this.Close();
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

        private void logoutbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            EnterWindow newForm = new EnterWindow();
            newForm.ShowDialog();
            this.Close();
        }
    }
}
