using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_3_TrevorAlbrethsen
{
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
        }

        private void cancelQuoteButton_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void widthValueBox_TextChanged(object sender, EventArgs e)
        {
            int width = Convert.ToInt32(widthValueBox.Text);

            if (width < 24 || width > 96) MessageBox.Show("Width must be between 24 and 96.", "Error Title", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void heightValueBox_TextChanged(object sender, EventArgs e)
        {
            int height = Convert.ToInt32(heightValueBox.Text);

            if (height < 12 || height > 48) MessageBox.Show("Height must be between 12 and 48.", "Error Title", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
