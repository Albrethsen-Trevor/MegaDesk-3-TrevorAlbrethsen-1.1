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

namespace MegaDesk_3_TrevorAlbrethsen_1_1
{
    public partial class ViewAllQuotes : Form
    {
        public ViewAllQuotes()
        {
            InitializeComponent();
        }

        private void cancelViewQuoteButton_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void viewQuoteButton_Click(object sender, EventArgs e)
        {
            try
            {
                string[] lines = File.ReadAllLines(@"quotes.csv");

                for (int i = 0; i < lines.Length; i++)
                {
                    string[] line = lines[i].Split(',');
                    viewQuotes.Rows.Add(line);
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
        }
    }
}
