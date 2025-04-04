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
    public partial class FormManageUser : Form
    {
        DataBaseDataContext db = new DataBaseDataContext();
        int user_id;
        string mode;
        public FormManageUser()
        {
            InitializeComponent();
            KeyPreview = true;
            KeyDown += FormManageUser_KeyDown;
        }

        private void FormManageUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.I)
            {
                btnInsert.PerformClick();
            }

            if (e.Control && e.KeyCode == Keys.U)
            {
                btnupdate.PerformClick();
            }

            if (e.Control && e.KeyCode == Keys.D)
            {
                btnDelete.PerformClick();
            }

            if (e.Control && e.KeyCode == Keys.S)
            {
                btnSave.PerformClick();
            }

            if (e.Control && e.KeyCode == Keys.C)
            {
                btnCancel.PerformClick();
            }
        }

        void enableField(bool e)
        {
            tbusername.Enabled = !e;
            tbFullname.Enabled = !e;
            tbPassword.Enabled = !e;
            tbAge.Enabled = !e;
            tbAddress.Enabled = !e;
            tbConfirmPassword.Enabled = !e;
        }

        void enableButton(bool e)
        {
            btnInsert.Visible = e;
            btnupdate.Visible = e;
            btnDelete.Visible = e;

            btnSave.Visible = !e;
            btnCancel.Visible = !e;
        }

        void enableFieldAndButton(bool e)
        {
            enableField(e);
            enableButton(e);
        }

        void showData()
        {
            dgvData.Columns.Clear();

            var query = db.users.Where(x => x.fullname.ToLower().Contains(tbsearch.Text.ToLower()) && x.isAdmin == "false").Select(x => new
            {
                x.id,
                Username = x.username,
                Fullname = x.fullname,
                Password = x.password,
                Age = x.age,
                Address = x.address,


            }).ToList();

            dgvData.DataSource = query;
            dgvData.Columns["id"].Visible = false;

        }

        void showDataBooking()
        {
            dgvDataBooking.Columns.Clear();

            var query = db.bookings.Where(x => x.user_id == user_id).ToList()
                .Select(x => new
                {
                    Product = x.product.name,
                    Admin = x.product.user.fullname,
                    Price = x.product.price,
                    Qty = x.qty,
                    Total = "Rp. " + x.total_price.ToString("N0").Replace(",", "."),
                    Date = x.date.ToString("dddd, dd MMMM yyyy"),
                    Status = x.status
                }).ToList();

            dgvDataBooking.DataSource = query;
        }

        private void FormManageUser_Load(object sender, EventArgs e)
        {
            Support.enable(this);
            enableFieldAndButton(true);
            showData();
        }

        private void tbsearch_TextChanged(object sender, EventArgs e)
        {
            showData();
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                user_id = (int)dgvData.Rows[e.RowIndex].Cells["id"].Value;
                tbusername.Text = dgvData.Rows[e.RowIndex].Cells["Username"].Value.ToString();
                tbFullname.Text = dgvData.Rows[e.RowIndex].Cells["Fullname"].Value.ToString();
                tbPassword.Text = dgvData.Rows[e.RowIndex].Cells["Password"].Value.ToString();
                tbAge.Text = dgvData.Rows[e.RowIndex].Cells["Age"].Value.ToString();
                tbAddress.Text = dgvData.Rows[e.RowIndex].Cells["Address"].Value.ToString();
                tbConfirmPassword.Text = tbPassword.Text;

                showDataBooking();

            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            mode = "insert";
            enableFieldAndButton(false);
            Support.clear(this);
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (tbFullname.Text == string.Empty)
            {
                Support.msw("Click row first!!!");
                return;
            }
            mode = "update";
            enableFieldAndButton(false);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbusername.Text == string.Empty || tbFullname.Text == string.Empty
                || tbPassword.Text == string.Empty || tbAge.Text == string.Empty || tbAddress.Text == string.Empty)
            {
                Support.msw("All field must be filled");
                return;
            }

            if (tbConfirmPassword.Text != tbPassword.Text)
            {
                Support.msw("Password and Confirm Password must be same");
                return;
            }

            if (!tbAge.Text.All(x => char.IsDigit(x)))
            {
                Support.msw("Age must be number");
                return;
            }

            try
            {
                if (mode == "insert")
                {
                    var query = new user();
                    query.username = tbusername.Text;
                    query.fullname = tbFullname.Text;
                    query.password = tbPassword.Text;
                    query.age = tbAge.Text;
                    query.address = tbAddress.Text;
                    query.isAdmin = "false";

                    db.users.InsertOnSubmit(query);
                    db.SubmitChanges();
                    Support.msi("Insert data has been successfully");
                    Support.clear(this);
                    showData();
                    showDataBooking();
                    enableFieldAndButton(true);

                }

                if (mode == "update")
                {
                    var query = db.users.FirstOrDefault(x => x.id == user_id);
                    query.username = tbusername.Text;
                    query.fullname = tbFullname.Text;
                    query.password = tbPassword.Text;
                    query.age = tbAge.Text;
                    query.address = tbAddress.Text;
                    db.SubmitChanges();
                    Support.msi("Update data has been successfully");
                    Support.clear(this);
                    showData();
                    showDataBooking();
                    enableFieldAndButton(true);
                }
            }
            catch (Exception ex)
            {
                Support.mse(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (tbFullname.Text == string.Empty)
            {
                Support.msw("Click row first!!!");
                return;
            }

            var dialogResult = MessageBox.Show("Are you sure to delete this data?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                var query = db.users.FirstOrDefault(x => x.id == user_id);

                var queryBooking = db.bookings.Where(x => x.user_id == user_id);

                foreach(var i in queryBooking)
                {
                    db.bookings.DeleteOnSubmit(i);
                    db.SubmitChanges();
                }

                db.users.DeleteOnSubmit(query);
                db.SubmitChanges();
                Support.msi("Delete data has been successfully");
                Support.clear(this);
                showData();
                showDataBooking();
                enableFieldAndButton(true);

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            enableFieldAndButton(true);
            Support.clear(this);
        }
    }
}
