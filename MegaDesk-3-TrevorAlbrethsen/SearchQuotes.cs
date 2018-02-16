using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MegaDesk_3_TrevorAlbrethsen_1_1
{
    public partial class SearchQuotes : Form
    {
        public string MaterialSearchList { get; set; }
        public SearchQuotes()
        {
            InitializeComponent();
        }

        private void cancelSearchQuoteButton_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void SearchQuotes_Load(object sender, EventArgs e)
        {
            var surfaceMaterials = new List<Desk.Materials>();
            surfaceMaterials = Enum.GetValues(typeof(Desk.Materials)).Cast<Desk.Materials>().ToList();
            MaterialSearch.DataSource = surfaceMaterials;
            MaterialSearch.SelectedIndex = -1;
        }

        private void MaterialSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            MaterialSearchList = MaterialSearch.Text;
        }

        private void searchQuoteButton_Click(object sender, EventArgs e)
        {
            viewQuotes.Rows.Clear();
            try
            {
                string[] lines = File.ReadAllLines(@"quotes.csv");

                for (int i = 0; i < lines.Length; i++)
                {
                    if (lines[i].Contains(MaterialSearchList))
                    {
                        string[] columns = lines[i].Split(',');
                        viewQuotes.Rows.Add(columns);
                    }
                }



                
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
        }
    }
}
