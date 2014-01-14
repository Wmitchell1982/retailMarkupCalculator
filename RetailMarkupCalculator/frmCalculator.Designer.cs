namespace RetailMarkupCalculator
{
    partial class frmCalculator
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
            this.tbMarkup = new System.Windows.Forms.TextBox();
            this.tbWholsale = new System.Windows.Forms.TextBox();
            this.lblWholsale = new System.Windows.Forms.Label();
            this.lblMarkup = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblResults = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbMarkup
            // 
            this.tbMarkup.Location = new System.Drawing.Point(135, 94);
            this.tbMarkup.Name = "tbMarkup";
            this.tbMarkup.Size = new System.Drawing.Size(100, 20);
            this.tbMarkup.TabIndex = 0;
            // 
            // tbWholsale
            // 
            this.tbWholsale.Location = new System.Drawing.Point(135, 12);
            this.tbWholsale.Name = "tbWholsale";
            this.tbWholsale.Size = new System.Drawing.Size(100, 20);
            this.tbWholsale.TabIndex = 1;
            // 
            // lblWholsale
            // 
            this.lblWholsale.AutoSize = true;
            this.lblWholsale.Location = new System.Drawing.Point(16, 16);
            this.lblWholsale.Name = "lblWholsale";
            this.lblWholsale.Size = new System.Drawing.Size(81, 13);
            this.lblWholsale.TabIndex = 2;
            this.lblWholsale.Text = "Wholesale Cost";
            // 
            // lblMarkup
            // 
            this.lblMarkup.AutoSize = true;
            this.lblMarkup.Location = new System.Drawing.Point(16, 97);
            this.lblMarkup.Name = "lblMarkup";
            this.lblMarkup.Size = new System.Drawing.Size(101, 13);
            this.lblMarkup.TabIndex = 3;
            this.lblMarkup.Text = "Markup Percentage";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(8, 226);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(264, 23);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate Retail Price";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Location = new System.Drawing.Point(16, 175);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(0, 13);
            this.lblResults.TabIndex = 5;
            // 
            // frmCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblMarkup);
            this.Controls.Add(this.lblWholsale);
            this.Controls.Add(this.tbWholsale);
            this.Controls.Add(this.tbMarkup);
            this.Name = "frmCalculator";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbMarkup;
        private System.Windows.Forms.TextBox tbWholsale;
        private System.Windows.Forms.Label lblWholsale;
        private System.Windows.Forms.Label lblMarkup;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblResults;
    }
}

