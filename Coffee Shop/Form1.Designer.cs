namespace Coffee_Shop
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.customerPhoneNoTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addressRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.coffeeNameComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.order = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(313, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Coffee Shop";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(54, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Customer Phone No";
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.Location = new System.Drawing.Point(190, 105);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(154, 20);
            this.customerNameTextBox.TabIndex = 3;
            // 
            // customerPhoneNoTextBox
            // 
            this.customerPhoneNoTextBox.Location = new System.Drawing.Point(190, 154);
            this.customerPhoneNoTextBox.Name = "customerPhoneNoTextBox";
            this.customerPhoneNoTextBox.Size = new System.Drawing.Size(154, 20);
            this.customerPhoneNoTextBox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Address";
            // 
            // addressRichTextBox
            // 
            this.addressRichTextBox.Location = new System.Drawing.Point(190, 205);
            this.addressRichTextBox.Name = "addressRichTextBox";
            this.addressRichTextBox.Size = new System.Drawing.Size(154, 96);
            this.addressRichTextBox.TabIndex = 4;
            this.addressRichTextBox.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(442, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Coffee Name";
            // 
            // coffeeNameComboBox
            // 
            this.coffeeNameComboBox.FormattingEnabled = true;
            this.coffeeNameComboBox.Items.AddRange(new object[] {
            "Cafe Mocha",
            "Coffee Milk",
            "Iced Coffee ",
            "Instant coffee",
            "Turkish coffee"});
            this.coffeeNameComboBox.Location = new System.Drawing.Point(535, 105);
            this.coffeeNameComboBox.Name = "coffeeNameComboBox";
            this.coffeeNameComboBox.Size = new System.Drawing.Size(156, 21);
            this.coffeeNameComboBox.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(445, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Quantity";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(535, 158);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(156, 20);
            this.quantityTextBox.TabIndex = 8;
            // 
            // order
            // 
            this.order.Location = new System.Drawing.Point(535, 226);
            this.order.Name = "order";
            this.order.Size = new System.Drawing.Size(156, 23);
            this.order.TabIndex = 9;
            this.order.Text = "Order";
            this.order.UseVisualStyleBackColor = true;
            this.order.Click += new System.EventHandler(this.order_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(773, 450);
            this.Controls.Add(this.order);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.coffeeNameComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.addressRichTextBox);
            this.Controls.Add(this.customerPhoneNoTextBox);
            this.Controls.Add(this.customerNameTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Coffee Shop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.TextBox customerPhoneNoTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox addressRichTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox coffeeNameComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Button order;
    }
}

