using Bunifu.UI.WinForms;
using Bunifu.UI.WinForms.BunifuButton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventTrack
{
    internal class Support
    {
        public static void msi(string text)
        {
            MessageBox.Show(text, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void msw(string text)
        {
            MessageBox.Show(text, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void mse(string text)
        {
            MessageBox.Show(text, "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void enable(Control control)
        {
            foreach (var enable in control.Controls)
            {
                if (enable is BunifuTextBox)
                {
                    ((BunifuTextBox)enable).Enabled = true;
                }

                if (enable is BunifuButton)
                {
                    ((BunifuButton)enable).Enabled = false;
                }

                if (enable is BunifuButton)
                {
                    ((BunifuButton)enable).Enabled = true;
                }

                if (enable is BunifuPanel)
                {
                    ((BunifuPanel)enable).Enabled = false;
                }

                if (enable is BunifuPanel)
                {
                    ((BunifuPanel)enable).Enabled = true;
                }
            }
        }

        public static void clear(Control control)
        {
            foreach (var clear in control.Controls)
            {
                if (clear is BunifuTextBox)
                {
                    ((BunifuTextBox)clear).Text = string.Empty;
                }
            }
        }
    }
}
