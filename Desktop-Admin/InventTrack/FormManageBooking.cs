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
    public partial class FormManageBooking : Form
    {
        DataBaseDataContext db = new DataBaseDataContext();
        public FormManageBooking()
        {
            InitializeComponent();
        }

        public void showData()
        {
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.FlowDirection = FlowDirection.LeftToRight;
            
            var query = db.bookings.Where(x => x.product.user_id == FormLogin.user.id && x.status == "pending" && x.user.fullname.ToLower().Contains(tbsearch.Text.ToLower()));

            foreach (var i in query)
            {
                var f = new FormLayoutBooking(i, this);
                f.TopLevel = false;

                flowLayoutPanel1.Controls.Add(f);
                f.Show();
            }
        }
        private void FormManageBooking_Load(object sender, EventArgs e)
        {
            Support.enable(this);
            showData();
        }

        private void tbsearch_TextChanged(object sender, EventArgs e)
        {
            showData();
        }
    }
}
