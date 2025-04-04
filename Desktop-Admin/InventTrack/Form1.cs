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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += Form1_KeyDown;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.O)
            {
                bunifuButton1.PerformClick();
            }

            if (e.Control && e.KeyCode == Keys.E)
            {
                bunifuButton2.PerformClick();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Support.enable(this);
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            var dialog = MessageBox.Show("Are you sure want to delete this data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            new FormLogin().Show();
            Hide();
        }
    }
}
