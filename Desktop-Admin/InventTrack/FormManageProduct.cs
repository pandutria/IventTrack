using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventTrack
{
    public partial class FormManageProduct : Form
    {
        DataBaseDataContext db = new DataBaseDataContext();
        int product_id;
        string mode;

        public FormManageProduct()
        {
            InitializeComponent();
            KeyPreview = true;
            KeyDown += FormManageProduct_KeyDown;
        }

        private void FormManageProduct_KeyDown(object sender, KeyEventArgs e)
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

            if (e.Control && e.KeyCode == Keys.F)
            {
                btnCancel.PerformClick();
            }
        }

        void enableField(bool e)
        {
            tbName.Enabled = !e;
            tbPrice.Enabled = !e;
            tbStock.Enabled = !e;
            cboCategory.Enabled = !e;
            tbDescription.Enabled = !e;
            btnSelectFile.Enabled = !e;
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
            enableButton(e);
            enableField(e);
        }

        void showData()
        {
            dgvData.Columns.Clear();

            var query = db.products.Where(x => x.name.ToLower().Contains(tbsearch.Text.ToLower())).ToList()
                .Select(x => new
                {
                    Name = x.name,
                    Description = x.description,
                    Category = x.category.name,
                    Price = "Rp. " + x.price.ToString("N0").Replace(",", "."),
                    Stock = x.stock,
                    x.id

                }).ToList();

            dgvData.DataSource = query;
            dgvData.Columns["id"].Visible = false;
        }

        private void FormManageProduct_Load(object sender, EventArgs e)
        {
            Support.enable(this);
            enableFieldAndButton(true);
            tbImage.Enabled = false;
            showData();

            cboCategory.DataSource = db.categories;
            cboCategory.ValueMember = "id";
            cboCategory.DisplayMember = "name";
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            var open = new OpenFileDialog();

            if (open.ShowDialog() == DialogResult.OK)
            {
                tbImage.Text = open.FileName;
                pbImage.Image = Image.FromFile(open.FileName);
            }
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                product_id = (int) dgvData.Rows[e.RowIndex].Cells["id"].Value;
                tbName.Text = dgvData.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                tbDescription.Text = dgvData.Rows[e.RowIndex].Cells["Description"].Value.ToString();
                tbPrice.Text =  dgvData.Rows[e.RowIndex].Cells["Price"].Value.ToString().Replace("Rp. ", "").Replace(".", "");
                tbStock.Text = dgvData.Rows[e.RowIndex].Cells["Stock"].Value.ToString();
                cboCategory.Text = dgvData.Rows[e.RowIndex].Cells["Category"].Value.ToString();

                var queryImage = db.products.FirstOrDefault(x => x.id == product_id);

                if (queryImage != null)
                {
                    if (queryImage.image != null)
                    {
                        var ms = new MemoryStream(queryImage.image.ToArray());
                        pbImage.Image = Image.FromStream(ms);
                    } else
                    {
                        pbImage.ImageLocation = "C:\\Users\\PANDU\\Pictures\\Screenshots\\Screenshot 2024-11-15 074533.png";
                    }
                    
                }
            }
        }

        private void tbsearch_TextChanged(object sender, EventArgs e)
        {
            showData();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            mode = "insert";
            enableFieldAndButton(false);
            Support.clear(this);
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (tbName.Text == string.Empty)
            {
                Support.msw("Click row first!!!");
                return;
            }
            mode = "update";
            enableFieldAndButton(false);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbName.Text == string.Empty || tbDescription.Text == string.Empty ||
                tbPrice.Text == string.Empty || tbStock.Text == string.Empty )
            {
                Support.mse("All field must be filled");
                return;
            }

            if (!tbPrice.Text.All(x => char.IsDigit(x)))
            {
                Support.mse("Field price must be filled");
                return;
            }

            if (!tbStock.Text.All(x => char.IsDigit(x)))
            {
                Support.mse("Field price must be filled");
                return;
            }

            try
            {
                if (mode == "insert")
                {
                    var query = new product();
                    query.name = tbName.Text;
                    query.description = tbDescription.Text;
                    query.category_id = Convert.ToInt32(cboCategory.SelectedValue);
                    query.price = Convert.ToInt32(tbPrice.Text);
                    query.stock = Convert.ToInt32(tbStock.Text);

                    if (tbImage.Text != string.Empty)
                    {
                        query.image = File.ReadAllBytes(tbImage.Text);
                    }
                    query.user_id = FormLogin.user.id;

                    db.products.InsertOnSubmit(query);
                    db.SubmitChanges();
                    Support.msi("Insert data has been successfully");
                    Support.clear(this);
                    showData();
                    enableFieldAndButton(true);
                } 

                if (mode == "update")
                {
                    var query = db.products.FirstOrDefault(x => x.id == product_id);
                    query.name = tbName.Text;
                    query.description = tbDescription.Text;
                    query.category.name = cboCategory.Text;
                    query.price = Convert.ToInt32(tbPrice.Text);
                    query.stock = Convert.ToInt32(tbStock.Text);

                    if (tbImage.Text != string.Empty)
                    {
                        query.image = File.ReadAllBytes(tbImage.Text);
                    }

                    db.SubmitChanges();
                    Support.msi("Update data has been successfully");
                    Support.clear(this);
                    showData();
                    enableFieldAndButton(true);
                }

            } catch (Exception ex)
            {
                Support.mse(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (tbName.Text == string.Empty)
            {
                Support.msw("Click row first!!!");
                return;
            }

            var dialog = MessageBox.Show("Are you sure want to delete this data!", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                var query = db.products.FirstOrDefault( x=> x.id == product_id);

                var queryBooking = db.bookings.Where(x => x.product_id == product_id);

                foreach (var i in queryBooking)
                {
                    db.bookings.DeleteOnSubmit(i);
                    db.SubmitChanges();
                }

                db.products.DeleteOnSubmit(query);
                db.SubmitChanges();
                Support.msi("Delete data has been successfully");
                Support.clear(this);
                showData();
                enableFieldAndButton(true);
            }
        }
    }
}
