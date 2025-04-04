using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventTrack
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            KeyPreview =true;
            KeyDown += FormLogin_KeyDown;
        }

        private void FormLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.L)
            {
                btnLogin.PerformClick();
            }
        }

        public static user user;
        private void FormLogin_Load(object sender, EventArgs e)
        {
            Support.enable(this);
            tbusername.Text = "admin";
            tbPassword.Text = "pandu123";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbusername.Text == string.Empty || tbPassword.Text == string.Empty)
            {
                Support.msw("All field must be filled");
                return;
            }

            var db = new DataBaseDataContext();
            var query = db.users.FirstOrDefault(x => x.username == tbusername.Text && x.password == tbPassword.Text && x.isAdmin == "true");

            if (query != null)
            {
                user = query;
                new FormMain().Show();
                Hide();
            } else
            {
                Support.msw("Your data is not valid, please try again!!");
            }
        }
    }
}
