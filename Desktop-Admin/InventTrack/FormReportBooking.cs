using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheArtOfDev.HtmlRenderer.Adapters;

namespace InventTrack
{
    public partial class FormReportBooking : Form
    {
        DataBaseDataContext db = new DataBaseDataContext();
        public FormReportBooking()
        {
            InitializeComponent();
        }

        void showData()
        {
            dgvData.Columns.Clear();

            var query = db.bookings.Where(x => x.product.user_id == FormLogin.user.id && x.user.fullname.ToLower().Contains(tbsearch.Text.ToLower())).ToList()
                .Select(x => new {
                    Product = x.product.name,
                    User = x.user.fullname,
                    Price = x.product.price,
                    Qty = x.qty,
                    Total = "Rp. " + x.total_price.ToString("N0").Replace(",", "."),
                    Date = x.date.ToString("dddd, dd MMMM yyyy"),
                    Status = x.status
                }).ToList();

            dgvData.DataSource = query;
        }

        private void FormReportBooking_Load(object sender, EventArgs e)
        {
            Support.enable(this);
            showData();
        }

        private void tbsearch_TextChanged(object sender, EventArgs e)
        {
            showData();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (dgvData.Rows.Count == 0)
            {
                Support.msw("Dgv is null!!");
                return;
            }

            //var xlApp = new Microsoft.Office.Interop.Excel.Application();

            //xlApp.Visible = true;
            //var xlWorkBook = xlApp.Workbooks.Add();
            //var xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Sheets[1];

            //var rowIndex = 1;
            //var colIndex = 1;

            //foreach (DataGridViewColumn column in dgvData.Columns)
            //{
            //    xlWorkSheet.Cells[rowIndex, colIndex] = column.HeaderText;
            //    colIndex++;
            //}

            //foreach (DataGridViewRow row in dgvData.Rows)
            //{
            //    colIndex = 1;

            //    foreach (DataGridViewCell cell in row.Cells)
            //    {
            //        xlWorkSheet.Cells[rowIndex, colIndex] = cell.Value?.ToString();
            //        colIndex++;
            //    }

            //    rowIndex++;
            //}

            //xlWorkSheet.Columns.AutoFit();
            //Support.msi("Create excel has been successfully!!");

            var xlApp = new Microsoft.Office.Interop.Excel.Application();
            xlApp.Visible = true;

            var xlWorkBook = xlApp.Workbooks.Add();
            var xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Sheets[1];

            var rowIndex = 1;
            var collIndex = 1;

            foreach(DataGridViewColumn col in dgvData.Columns)
            {
                xlWorkSheet.Cells[rowIndex, collIndex] = col.HeaderText;
                collIndex++;
            }

            rowIndex++;

            foreach(DataGridViewRow row in dgvData.Rows)
            {
                collIndex = 1;

                foreach(DataGridViewCell cell in row.Cells)
                {
                    xlWorkSheet.Cells[rowIndex, collIndex] = cell.Value?.ToString();
                    collIndex++;
                }
                rowIndex++;
            }

            xlWorkSheet.Columns.AutoFit();
            Support.msi("Create excel has been successfully!!");

        }
    }
}
