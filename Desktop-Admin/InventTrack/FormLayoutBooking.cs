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

namespace InventTrack
{
    public partial class FormLayoutBooking : Form
    {   
        DataBaseDataContext db = new DataBaseDataContext();
        booking booking;
        FormManageBooking form;
        public FormLayoutBooking(booking booking, FormManageBooking form)
        {
            InitializeComponent();
            this.booking = booking;
            this.form = form;

            KeyPreview = true;
            KeyDown += FormLayoutBooking_KeyDown;
        }

        private void FormLayoutBooking_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.F)
            {
                btnDelete.PerformClick();
            }

            if (e.Control && e.KeyCode == Keys.C)
            {
                btnComplete.PerformClick();
            }
        }

        private void FormLayoutBooking_Load(object sender, EventArgs e)
        {
            Support.enable(this);
            if (booking.product.image != null)
            {
                var ms = new MemoryStream(booking.product.image.ToArray());
                pbImage.Image = Image.FromStream(ms);
            } else
            {
                pbImage.ImageLocation = "D:\\download\\Dinner Is Served.jpg";
            }

            lblProductName.Text = booking.product.name;
            lblUser.Text = booking.user.fullname;
            lblTotal.Text = $"Rp. {booking.total_price.ToString("N0").Replace(",", ".")} ({booking.qty})";
            lblDate.Text = booking.date.ToString("dddd, dd MMMM, yyyy");
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            var query = db.bookings.FirstOrDefault(x => x.id == booking.id);

            query.status = "completed";
            db.SubmitChanges();
            
            var queryProduct = db.products.FirstOrDefault(x => x.id == booking.product_id);

            if (queryProduct != null)
            {
                queryProduct.stock = queryProduct.stock - booking.qty;
                db.SubmitChanges();
            }

            Support.msi("The booking has been completed");
            form.showData();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var query = db.bookings.FirstOrDefault(x => x.id == booking.id);

            query.status = "failed";
            db.SubmitChanges();
            Support.msi("The booking has been faield");
            form.showData();
        }
    }
}
