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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            KeyPreview = true;
            KeyDown += FormMain_KeyDown;
        }

        private void FormMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.U)
            {
                btnManageUser.PerformClick();
            }

            if (e.Control && e.KeyCode == Keys.B)
            {
                btnbooking.PerformClick();
            }

            if (e.Control && e.KeyCode == Keys.P)
            {
                btnproduct.PerformClick();
            }

            if (e.Control && e.KeyCode == Keys.R)
            {
                btnreport.PerformClick();
            }

            if (e.Control && e.KeyCode == Keys.E)
            {
                new FormEditProfile().ShowDialog();
                lbllfullname.Text = FormLogin.user.fullname;
                lblusername.Text = FormLogin.user.username;
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            lbllfullname.Text = FormLogin.user.fullname;
            lblusername.Text = FormLogin.user.username;
            Support.enable(this);
        }

        private void btnManageUser_Click(object sender, EventArgs e)
        {
            btnManageUser.ForeColor = Color.DodgerBlue;

            btnbooking.ForeColor = Color.FromArgb(73, 73, 73);
            btnproduct.ForeColor = Color.FromArgb(73, 73, 73);
            btnreport.ForeColor = Color.FromArgb(73, 73, 73);

            panelcontainer.Controls.Clear();

            var f = new FormManageUser();
            f.TopLevel = false;

            panelcontainer.Controls.Add(f);
            f.Show();
        }

        private void btnproduct_Click(object sender, EventArgs e)
        {
            btnproduct.ForeColor = Color.DodgerBlue;

            btnbooking.ForeColor = Color.FromArgb(73, 73, 73);
            btnManageUser.ForeColor = Color.FromArgb(73, 73, 73);
            btnreport.ForeColor = Color.FromArgb(73, 73, 73);

            panelcontainer.Controls.Clear();

            var f = new FormManageProduct();
            f.TopLevel = false;

            panelcontainer.Controls.Add(f);
            f.Show();

        }

        private void btnbooking_Click(object sender, EventArgs e)
        {
            btnbooking.ForeColor = Color.DodgerBlue;

            btnManageUser.ForeColor = Color.FromArgb(73, 73, 73);
            btnproduct.ForeColor = Color.FromArgb(73, 73, 73);
            btnreport.ForeColor = Color.FromArgb(73, 73, 73);

            panelcontainer.Controls.Clear();

            var f = new FormManageBooking();
            f.TopLevel = false;

            panelcontainer.Controls.Add(f);
            f.Show();
        }

        private void btnreport_Click(object sender, EventArgs e)
        {
            btnreport.ForeColor = Color.DodgerBlue;

            btnbooking.ForeColor = Color.FromArgb(73, 73, 73);
            btnproduct.ForeColor = Color.FromArgb(73, 73, 73);
            btnManageUser.ForeColor = Color.FromArgb(73, 73, 73);

            panelcontainer.Controls.Clear();

            var f = new FormReportBooking();
            f.TopLevel = false;

            panelcontainer.Controls.Add(f);
            f.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new FormEditProfile().ShowDialog();
            lbllfullname.Text = FormLogin.user.fullname;
            lblusername.Text = FormLogin.user.username;
        }
    }
}
