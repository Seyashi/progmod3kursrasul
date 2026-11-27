using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rasuuulform
{
    public partial class Form2 : Form
    {
        public Form2(string login,string password)
        {
            InitializeComponent();
            lblLogin.Text = "Логин: " + login;
            lblPassword.Text = "Пароль: " + password;

        }
    }
}
