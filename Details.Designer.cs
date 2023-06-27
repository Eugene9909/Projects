namespace FleetSystem
{
    partial class Details
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
            this.cbDetails = new System.Windows.Forms.ComboBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // cbDetails
            // 
            this.cbDetails.FormattingEnabled = true;
            this.cbDetails.Location = new System.Drawing.Point(478, 56);
            this.cbDetails.Name = "cbDetails";
            this.cbDetails.Size = new System.Drawing.Size(121, 28);
            this.cbDetails.TabIndex = 0;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(478, 330);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(187, 44);
            this.btnShow.TabIndex = 1;
            this.btnShow.Text = "SHOW DETAILS";
            this.btnShow.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(167, 115);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(797, 197);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.cbDetails);
            this.Name = "Details";
            this.Text = "Details";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbDetails;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}