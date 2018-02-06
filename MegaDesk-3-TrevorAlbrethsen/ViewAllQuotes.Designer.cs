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
            this.SuspendLayout();
            // 
            // cancelViewQuoteButton
            // 
            this.cancelViewQuoteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelViewQuoteButton.Location = new System.Drawing.Point(45, 496);
            this.cancelViewQuoteButton.Name = "cancelViewQuoteButton";
            this.cancelViewQuoteButton.Size = new System.Drawing.Size(324, 86);
            this.cancelViewQuoteButton.TabIndex = 2;
            this.cancelViewQuoteButton.Text = "Cancel";
            this.cancelViewQuoteButton.UseVisualStyleBackColor = true;
            this.cancelViewQuoteButton.Click += new System.EventHandler(this.cancelViewQuoteButton_Click);
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 695);
            this.Controls.Add(this.cancelViewQuoteButton);
            this.Name = "ViewAllQuotes";
            this.Text = "ViewAllQuotes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cancelViewQuoteButton;
    }
}