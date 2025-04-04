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
    public partial class FormEditProfile : Form
    {
        public FormEditProfile()
        {
            InitializeComponent();
            KeyPreview = true;
            KeyDown += FormEditProfile_KeyDown;
        }

        private void FormEditProfile_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                btnSave.PerformClick();
            }

            if (e.Control && e.KeyCode == Keys.C)
            {
                btnCancel.PerformClick();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbusername.Text == string.Empty || tbfullname.Text == string.Empty
                || tbPassword.Text == string.Empty || tbAge.Text == string.Empty || tbAddress.Text == string.Empty)
            {
                Support.msw("All field must be filled");
                return;
            }

            if (!tbAge.Text.All(x => char.IsDigit(x)))
            {
                Support.msw("Age must be a number");
                return;
            }

            var db = new DataBaseDataContext();
            var query = db.users.FirstOrDefault(x => x.id == FormLogin.user.id);
            if (query != null)
            {
                query.username = tbusername.Text;
                query.fullname = tbfullname.Text;
                query.password = tbPassword.Text;
                query.age = tbAge.Text;
                query.address = tbAddress.Text;

                db.SubmitChanges();
                Support.msi("Insert data has been successfully");
                
                FormLogin.user = query;
                Hide();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormEditProfile_Load(object sender, EventArgs e)
        {
            Support.enable(this);
        }
    }
}
