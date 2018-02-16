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
    public partial class AddQuote : Form
    {
        //const int rushOption3 = 3;
        //const int rushOption5 = 5;
        //const int rushOption7 = 7;

        string SurfaceMaterial = String.Empty;
        string RushOrderFinal = String.Empty;
        //private int RushDay = 0;

        private const int baseDeskPrice = 200;
        private int deskArea = 0;
        private int numOfDrawers = 0;
        private int surfMatCost = 0;
        private int rushOrderCost = 0;

        private int totalPriceCalculated()
        {
            return baseDeskPrice + deskArea + numOfDrawers
                + surfMatCost + rushOrderCost;
        }

        Desk desk = new Desk();
        DeskQuote quote = new DeskQuote();


        public AddQuote()
        {
            InitializeComponent();
            rushOrderOptBox.SelectedIndex = 3;
            temp_Price.Text = quote.FinalPrice.ToString();
            quote.Desk = desk;
            quote.Desk.Width = Convert.ToInt32(widthUpDown.Value);
            quote.Desk.Depth = Convert.ToInt32(depthUpDown.Value);
            quote.Desk.WidthDepth = (quote.Desk.Width * quote.Desk.Depth) * 1;
            deskArea = (quote.Desk.WidthDepth);
            quote.FinalPrice = totalPriceCalculated();
            temp_Price.Text = quote.CustomerPrice(quote.FinalPrice);
        }

        private void saveQuoteButton_Click(object sender, EventArgs e)
        {
            // check for required fields
            if (custNameBox.Text.Length == 0)
            {
                custNameBox.BackColor = Color.Red;
                string message = "You did not enter the customer's name.";
                string caption = "Enter Customer's Name";
                DialogResult result;
                result = MessageBox.Show(message, caption);
                return;
            }




            DateTime Quote_Date = DateTime.Now;
            string NewQuote = string.Format("{0},{1},{2},{3},{4},{5},{6}",
                Quote_Date.ToString(), quote.CustomerName, quote.Desk.WidthDepth.ToString(),
                quote.Desk.Drawers.ToString(), quote.Desk.SurfaceMaterials,
                rushOrderOptBox.SelectedItem.ToString(), quote.FinalPrice);
            using (StreamWriter sw = File.AppendText("quotes.csv"))
            {
                sw.WriteLine(NewQuote);
                sw.Close();
            }

            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void cancelQuoteButton_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void custNameBox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            quote.CustomerName = textBox.Text;
        }

        private void widthUpDown_ValueChanged(object sender, EventArgs e)
        {
            quote.Desk.Width = Convert.ToInt32(widthUpDown.Value);
            quote.Desk.WidthDepth = (quote.Desk.Width * quote.Desk.Depth) * 1;
            deskArea = (quote.Desk.WidthDepth);
            quote.FinalPrice = totalPriceCalculated();
            temp_Price.Text = quote.CustomerPrice(quote.FinalPrice);
        }

        private void depthUpDown_ValueChanged(object sender, EventArgs e)
        {
            quote.Desk.Depth = Convert.ToInt32(depthUpDown.Value);
            quote.Desk.WidthDepth = (quote.Desk.Width * quote.Desk.Depth) * 1;
            deskArea = (quote.Desk.WidthDepth);
            quote.FinalPrice = totalPriceCalculated();
            temp_Price.Text = quote.CustomerPrice(quote.FinalPrice);
            
        }

        //public decimal deskAreaCombo()
        //{
        //    decimal areaSurface = 0;
        //    if (deskArea > baseDeskPrice)
        //    {
        //        areaSurface = (deskArea - baseDeskPrice) * 1;
        //    }
        //    return areaSurface;
        //}

        private void drawersUpDown_ValueChanged(object sender, EventArgs e)
        {
            quote.Desk.Drawers = Convert.ToInt32(drawersUpDown.Value);
            numOfDrawers = quote.Desk.Drawers * 50;
            quote.FinalPrice = totalPriceCalculated();
            temp_Price.Text = quote.CustomerPrice(quote.FinalPrice);
        }

        private void surfMaterialBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            quote.Desk.SurfaceMaterials = surfMaterialBox.Text;
            switch (quote.Desk.SurfaceMaterials)
            {
                case "Oak":
                    surfMatCost = 200;
                    break;
                case "Laminate":
                    surfMatCost = 100;
                    break;
                case "Pine":
                    surfMatCost = 50;
                    break;
                case "Rosewood":
                    surfMatCost = 300;
                    break;
                case "Veneer":
                    surfMatCost = 125;
                    break;
            }
            quote.FinalPrice = totalPriceCalculated();
            temp_Price.Text = quote.CustomerPrice(quote.FinalPrice);
        }

        private void rushOrderOptBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int[,] RushOrderPrice = new int[,] {
            { 60, 70, 80},
            { 40, 50, 60 },
            { 30, 35, 40 } };

            rushOrderCost = 0;

            switch (rushOrderOptBox.SelectedItem.ToString())
            {
                case "3 Days":
                    if (deskArea < 1000)
                    {
                        rushOrderCost = RushOrderPrice[0, 0];
                    }
                    else if (deskArea >= 1000 && deskArea < 2000)
                    {
                        rushOrderCost = RushOrderPrice[0, 1];
                    }
                    else if (deskArea > 2000)
                    {
                        rushOrderCost = RushOrderPrice[0, 2];
                    }
                    break;
                case "5 Days":
                    if (deskArea < 1000)
                    {
                        rushOrderCost = RushOrderPrice[1, 0];
                    }
                    else if (deskArea >= 1000 && deskArea < 2000)
                    {
                        rushOrderCost = RushOrderPrice[1, 1];
                    }
                    else if (deskArea > 2000)
                    {
                        rushOrderCost = RushOrderPrice[1, 2];
                    }
                    break;
                case "7 Days":
                    if (deskArea < 1000)
                    {
                        rushOrderCost = RushOrderPrice[2, 0];
                    }
                    else if (deskArea >= 1000 && deskArea < 2000)
                    {
                        rushOrderCost = RushOrderPrice[2, 1];
                    }
                    else if (deskArea > 2000)
                    {
                        rushOrderCost = RushOrderPrice[2, 2];
                    }
                    break;
                default:
                    break;
            }

            //RushOrderFinal = rushOrderOptBox.SelectedItem.ToString();
            //switch (RushOrderFinal)
            //{
            //    case "3 Days":
            //        RushDay = 3;
            //        break;
            //    case "5 Days":
            //        RushDay = 5;
            //        break;
            //    case "7 Days":
            //        RushDay = 7;
            //        break;
            //    default:
            //        RushDay = 0;
            //        break;
            //}
            quote.FinalPrice = totalPriceCalculated();
            temp_Price.Text = quote.CustomerPrice(quote.FinalPrice);
        }

        private void AddQuote_Load(object sender, EventArgs e)
        {
            //Quote.Desk.Width = Convert.ToInt32(widthUpDown.Value.ToString());
            //Quote.Desk.Depth = Convert.ToInt32(depthUpDown.Value.ToString());
            //Quote.Desk.WidthDepth = Quote.Desk.Width * Quote.Desk.Depth;
            //Quote.Desk.Drawers = Convert.ToInt32(drawersUpDown.Value.ToString());

            var surfaceMaterials = new List<Desk.Materials>();
            surfaceMaterials = Enum.GetValues(typeof(Desk.Materials)).Cast<Desk.Materials>().ToList();
            surfMaterialBox.DataSource = surfaceMaterials;
            surfMaterialBox.SelectedIndex = 0;
        }
    }
}
