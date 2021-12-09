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
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
            tb_Login.Validating += Login_Validating;
            tb_Password.Validating += Password_Validating;
        }


        private void Login_Validating(object sender, EventArgs e)
        {
            if (tb_Login.Text.Length < 5)
            {
                errorProvider1.SetError(tb_Login, "Login too short!");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void Password_Validating(object sender, EventArgs e)
        {
            if (tb_Password.Text.Length < 5)
            {
                
                errorProvider1.SetError(tb_Password, "Password too short!");
            }
            else
            {
                errorProvider1.Clear();
            }
        }


        private void bcgoback_Click(object sender, EventArgs e)
        {
            this.Hide();
            EnterWindow newForm = new EnterWindow();
            newForm.ShowDialog();
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Point lastPoint;
        private void Authorization_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Authorization_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void bclog_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                try
                {
                    Client _client = new Client();
                    _client.SendCommand("[LOGIN]");
                    User model = new User();
                    model.Login = tb_Login.Text;
                    model.Password = tb_Password.Text;
                    LoginService login = new LoginService(_client.networkStream, _client.tcpClient);
                    login.Login(model);
                    string responce = _client.GetResponce();
                    if (responce.ToLower().Contains("error"))
                    {
                        MessageBox.Show(responce);
                        _client.Close();
                        this.Update();
                    }
                    else
                    {
                        this.Hide();
                        Client.ID = int.Parse(responce);
                        MainProgramWindow newForm = new MainProgramWindow();
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
}
