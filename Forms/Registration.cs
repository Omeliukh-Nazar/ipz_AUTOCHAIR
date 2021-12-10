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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }


        private void bccancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            EnterWindow newForm = new EnterWindow();
            newForm.ShowDialog();
            this.Close();
        }

        Point lastPoint;
        private void Registration_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        private void Registration_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tb_name_TextChanged(object sender, EventArgs e)
        {
            if (tb_name.Text.Length < 5)
            {
                errorProvider1.SetError(tb_name, "Too short name!");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void tb_email_TextChanged(object sender, EventArgs e)
        {
            if (tb_email.Text.Length < 5)
            {
                errorProvider1.SetError(tb_email, "Too short e-mail!");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void tb_phone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (tb_phone.Text.Length < 12)
            {
                errorProvider1.SetError(tb_phone, "Too short number!");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void tb_login_TextChanged(object sender, EventArgs e)
        {
            if (tb_login.Text.Length < 5)
            {
                errorProvider1.SetError(tb_login, "Too short login!");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void tb_password_TextChanged(object sender, EventArgs e)
        {
            if (tb_password.Text.Length < 5)
            {
                errorProvider1.SetError(tb_password, "Too short password");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void bccreate_Click(object sender, EventArgs e)
        {
            try
            {
                Client _client = new Client();
                _client.SendCommand("[REGISTER]");
                User model = new User(
                    tb_name.Text,
                    tb_email.Text,
                    tb_phone.Text,
                    tb_login.Text,
                    tb_password.Text);
                RegisterService register = new RegisterService(_client.networkStream, _client.tcpClient);
                register.Registration(model);
                string responce = _client.GetResponce();
                if (responce.ToLower().Contains("error"))
                {
                    MessageBox.Show(responce);
                    _client.Close();
                    this.Update();
                }
                else
                {
                    MessageBox.Show(responce);
                    this.Hide();
                    Authorization newForm = new Authorization();
                    newForm.ShowDialog();
                    this.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lost connection with the server");
            }
            

                
        }
    }
}
