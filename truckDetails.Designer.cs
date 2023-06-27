namespace FleetSystem
{
    partial class truckDetails
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTruckID = new System.Windows.Forms.TextBox();
            this.txttruckName = new System.Windows.Forms.TextBox();
            this.txtkMmTravelled = new System.Windows.Forms.TextBox();
            this.txtManufacturer = new System.Windows.Forms.TextBox();
            this.txtmanufactureYear = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(324, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "TRUCK DETAILS";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(328, 469);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 43);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Truck ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Truck Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "kilometres travelled";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Manufacturer";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Manufactured Year";
            // 
            // txtTruckID
            // 
            this.txtTruckID.Location = new System.Drawing.Point(328, 74);
            this.txtTruckID.Name = "txtTruckID";
            this.txtTruckID.Size = new System.Drawing.Size(100, 26);
            this.txtTruckID.TabIndex = 8;
            // 
            // txttruckName
            // 
            this.txttruckName.Location = new System.Drawing.Point(328, 121);
            this.txttruckName.Name = "txttruckName";
            this.txttruckName.Size = new System.Drawing.Size(100, 26);
            this.txttruckName.TabIndex = 9;
            // 
            // txtkMmTravelled
            // 
            this.txtkMmTravelled.Location = new System.Drawing.Point(328, 218);
            this.txtkMmTravelled.Name = "txtkMmTravelled";
            this.txtkMmTravelled.Size = new System.Drawing.Size(100, 26);
            this.txtkMmTravelled.TabIndex = 11;
            // 
            // txtManufacturer
            // 
            this.txtManufacturer.Location = new System.Drawing.Point(328, 171);
            this.txtManufacturer.Name = "txtManufacturer";
            this.txtManufacturer.Size = new System.Drawing.Size(100, 26);
            this.txtManufacturer.TabIndex = 10;
            // 
            // txtmanufactureYear
            // 
            this.txtmanufactureYear.Location = new System.Drawing.Point(328, 276);
            this.txtmanufactureYear.Name = "txtmanufactureYear";
            this.txtmanufactureYear.Size = new System.Drawing.Size(100, 26);
            this.txtmanufactureYear.TabIndex = 13;
            // 
            // truckDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 599);
            this.Controls.Add(this.txtmanufactureYear);
            this.Controls.Add(this.txtkMmTravelled);
            this.Controls.Add(this.txtManufacturer);
            this.Controls.Add(this.txttruckName);
            this.Controls.Add(this.txtTruckID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label1);
            this.Name = "truckDetails";
            this.Text = "truckDetails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTruckID;
        private System.Windows.Forms.TextBox txttruckName;
        private System.Windows.Forms.TextBox txtkMmTravelled;
        private System.Windows.Forms.TextBox txtManufacturer;
        private System.Windows.Forms.TextBox txtmanufactureYear;
    }
}