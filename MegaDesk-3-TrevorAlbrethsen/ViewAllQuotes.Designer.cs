namespace MegaDesk_3_TrevorAlbrethsen_1_1
{
    partial class ViewAllQuotes
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
            this.cancelViewQuoteButton = new System.Windows.Forms.Button();
            this.viewQuoteButton = new System.Windows.Forms.Button();
            this.viewQuotes = new System.Windows.Forms.DataGridView();
            this.DateOdered = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Drawers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rush = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.viewQuotes)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelViewQuoteButton
            // 
            this.cancelViewQuoteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelViewQuoteButton.Location = new System.Drawing.Point(958, 670);
            this.cancelViewQuoteButton.Name = "cancelViewQuoteButton";
            this.cancelViewQuoteButton.Size = new System.Drawing.Size(324, 86);
            this.cancelViewQuoteButton.TabIndex = 2;
            this.cancelViewQuoteButton.Text = "Cancel";
            this.cancelViewQuoteButton.UseVisualStyleBackColor = true;
            this.cancelViewQuoteButton.Click += new System.EventHandler(this.cancelViewQuoteButton_Click);
            // 
            // viewQuoteButton
            // 
            this.viewQuoteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewQuoteButton.Location = new System.Drawing.Point(399, 670);
            this.viewQuoteButton.Name = "viewQuoteButton";
            this.viewQuoteButton.Size = new System.Drawing.Size(324, 86);
            this.viewQuoteButton.TabIndex = 5;
            this.viewQuoteButton.Text = "Veiw Quotes";
            this.viewQuoteButton.UseVisualStyleBackColor = true;
            this.viewQuoteButton.Click += new System.EventHandler(this.viewQuoteButton_Click);
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
            this.viewQuotes.Location = new System.Drawing.Point(15, 153);
            this.viewQuotes.Margin = new System.Windows.Forms.Padding(6);
            this.viewQuotes.Name = "viewQuotes";
            this.viewQuotes.Size = new System.Drawing.Size(1414, 288);
            this.viewQuotes.TabIndex = 6;
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
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1700, 791);
            this.Controls.Add(this.viewQuotes);
            this.Controls.Add(this.viewQuoteButton);
            this.Controls.Add(this.cancelViewQuoteButton);
            this.Name = "ViewAllQuotes";
            this.Text = "ViewAllQuotes";
            ((System.ComponentModel.ISupportInitialize)(this.viewQuotes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cancelViewQuoteButton;
        private System.Windows.Forms.Button viewQuoteButton;
        private System.Windows.Forms.DataGridView viewQuotes;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOdered;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Area;
        private System.Windows.Forms.DataGridViewTextBoxColumn Drawers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Material;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rush;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
    }
}