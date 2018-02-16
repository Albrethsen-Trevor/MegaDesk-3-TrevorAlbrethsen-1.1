namespace MegaDesk_3_TrevorAlbrethsen_1_1
{
    partial class SearchQuotes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cancelSearchQuoteButton = new System.Windows.Forms.Button();
            this.searchQuoteButton = new System.Windows.Forms.Button();
            this.viewQuotes = new System.Windows.Forms.DataGridView();
            this.DateOdered = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Drawers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rush = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.MaterialSearch = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.viewQuotes)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelSearchQuoteButton
            // 
            this.cancelSearchQuoteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelSearchQuoteButton.Location = new System.Drawing.Point(1023, 588);
            this.cancelSearchQuoteButton.Name = "cancelSearchQuoteButton";
            this.cancelSearchQuoteButton.Size = new System.Drawing.Size(324, 86);
            this.cancelSearchQuoteButton.TabIndex = 3;
            this.cancelSearchQuoteButton.Text = "Cancel";
            this.cancelSearchQuoteButton.UseVisualStyleBackColor = true;
            this.cancelSearchQuoteButton.Click += new System.EventHandler(this.cancelSearchQuoteButton_Click);
            // 
            // searchQuoteButton
            // 
            this.searchQuoteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchQuoteButton.Location = new System.Drawing.Point(569, 588);
            this.searchQuoteButton.Name = "searchQuoteButton";
            this.searchQuoteButton.Size = new System.Drawing.Size(324, 86);
            this.searchQuoteButton.TabIndex = 4;
            this.searchQuoteButton.Text = "Search Quotes";
            this.searchQuoteButton.UseVisualStyleBackColor = true;
            this.searchQuoteButton.Click += new System.EventHandler(this.searchQuoteButton_Click);
            // 
            // viewQuotes
            // 
            this.viewQuotes.AllowUserToAddRows = false;
            this.viewQuotes.AllowUserToDeleteRows = false;
            this.viewQuotes.AllowUserToResizeColumns = false;
            this.viewQuotes.AllowUserToResizeRows = false;
            this.viewQuotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewQuotes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DateOdered,
            this.Customer,
            this.Area,
            this.Drawers,
            this.Material,
            this.Rush,
            this.Price});
            this.viewQuotes.Location = new System.Drawing.Point(15, 194);
            this.viewQuotes.Margin = new System.Windows.Forms.Padding(6);
            this.viewQuotes.Name = "viewQuotes";
            this.viewQuotes.Size = new System.Drawing.Size(1402, 288);
            this.viewQuotes.TabIndex = 7;
            // 
            // DateOdered
            // 
            this.DateOdered.HeaderText = "Date Ordered";
            this.DateOdered.Name = "DateOdered";
            // 
            // Customer
            // 
            this.Customer.HeaderText = "Name";
            this.Customer.Name = "Customer";
            // 
            // Area
            // 
            this.Area.HeaderText = "Area";
            this.Area.Name = "Area";
            // 
            // Drawers
            // 
            this.Drawers.HeaderText = "Drawers";
            this.Drawers.Name = "Drawers";
            // 
            // Material
            // 
            this.Material.HeaderText = "Material";
            this.Material.Name = "Material";
            // 
            // Rush
            // 
            this.Rush.HeaderText = "Rush";
            this.Rush.Name = "Rush";
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 40);
            this.label1.TabIndex = 8;
            this.label1.Text = "Search material:";
            // 
            // MaterialSearch
            // 
            this.MaterialSearch.DisplayMember = "laminate";
            this.MaterialSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaterialSearch.FormattingEnabled = true;
            this.MaterialSearch.Items.AddRange(new object[] {
            "Oak",
            "Laminate",
            "Pine",
            "Rosewood",
            "Veneer"});
            this.MaterialSearch.Location = new System.Drawing.Point(295, 39);
            this.MaterialSearch.Margin = new System.Windows.Forms.Padding(6);
            this.MaterialSearch.Name = "MaterialSearch";
            this.MaterialSearch.Size = new System.Drawing.Size(276, 39);
            this.MaterialSearch.TabIndex = 10;
            this.MaterialSearch.SelectedIndexChanged += new System.EventHandler(this.MaterialSearch_SelectedIndexChanged);
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1598, 757);
            this.Controls.Add(this.MaterialSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.viewQuotes);
            this.Controls.Add(this.searchQuoteButton);
            this.Controls.Add(this.cancelSearchQuoteButton);
            this.Name = "SearchQuotes";
            this.Text = "SearchQuotes";
            this.Load += new System.EventHandler(this.SearchQuotes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewQuotes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cancelSearchQuoteButton;
        private System.Windows.Forms.Button searchQuoteButton;
        private System.Windows.Forms.DataGridView viewQuotes;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOdered;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Area;
        private System.Windows.Forms.DataGridViewTextBoxColumn Drawers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Material;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rush;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox MaterialSearch;
    }
}