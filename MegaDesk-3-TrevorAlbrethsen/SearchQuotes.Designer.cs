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
            this.SuspendLayout();
            // 
            // cancelSearchQuoteButton
            // 
            this.cancelSearchQuoteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelSearchQuoteButton.Location = new System.Drawing.Point(75, 508);
            this.cancelSearchQuoteButton.Name = "cancelSearchQuoteButton";
            this.cancelSearchQuoteButton.Size = new System.Drawing.Size(324, 86);
            this.cancelSearchQuoteButton.TabIndex = 3;
            this.cancelSearchQuoteButton.Text = "Cancel";
            this.cancelSearchQuoteButton.UseVisualStyleBackColor = true;
            this.cancelSearchQuoteButton.Click += new System.EventHandler(this.cancelSearchQuoteButton_Click);
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 707);
            this.Controls.Add(this.cancelSearchQuoteButton);
            this.Name = "SearchQuotes";
            this.Text = "SearchQuotes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cancelSearchQuoteButton;
    }
}