using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_3_TrevorAlbrethsen_1_1
{
    public partial class AddQuote : Form
    {
        int minWidth = 24;
        int maxWidth = 96;
        int minDepth = 12;
        int maxDepth = 48;
        int minDrawer = 1;
        int maxDrawer = 7;

        public AddQuote()
        {
            InitializeComponent();
            this.saveQuoteButton.Enabled = false;
        }

        private void saveQuoteButton_Click(object sender, EventArgs e)
        {
            DeskQuote deskQuote = new DeskQuote();
            deskQuote.saveQuote(this);
            this.saveQuoteButton.Enabled = false;
            MessageBox.Show("Quote has been saved.");
        }

        private void cancelQuoteButton_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void widthUpDown_ValueChanged(object sender, EventArgs e)
        {
            widthUpDown.Minimum = minWidth;
            widthUpDown.Maximum = maxWidth;
        }

        private void depthUpDown_ValueChanged(object sender, EventArgs e)
        {
            depthUpDown.Minimum = minDepth;
            depthUpDown.Maximum = maxDepth;
        }

        private void drawersUpDown_ValueChanged(object sender, EventArgs e)
        {
            drawersUpDown.Minimum = minDrawer;
            drawersUpDown.Maximum = maxDrawer;
        }

        private void surfMaterialBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rushOrderOptBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
