namespace ShoppingCart_e
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbCoffeeprice = new TextBox();
            button1 = new Button();
            chbCoffee = new CheckBox();
            chbMussha = new CheckBox();
            tbMusshaprice = new TextBox();
            total = new TextBox();
            label1 = new Label();
            tbMusshaQuantity = new TextBox();
            tbCoffeeQunatity = new TextBox();
            SuspendLayout();
            // 
            // tbCoffeeprice
            // 
            tbCoffeeprice.Location = new Point(129, 46);
            tbCoffeeprice.Name = "tbCoffeeprice";
            tbCoffeeprice.Size = new Size(100, 23);
            tbCoffeeprice.TabIndex = 0;
            tbCoffeeprice.TextChanged += tbCoffeeprice_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(350, 37);
            button1.Name = "button1";
            button1.Size = new Size(113, 114);
            button1.TabIndex = 1;
            button1.Text = "Check out";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // chbCoffee
            // 
            chbCoffee.AutoSize = true;
            chbCoffee.Location = new Point(40, 48);
            chbCoffee.Name = "chbCoffee";
            chbCoffee.Size = new Size(61, 19);
            chbCoffee.TabIndex = 2;
            chbCoffee.Text = "Coffee";
            chbCoffee.UseVisualStyleBackColor = true;
            chbCoffee.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // chbMussha
            // 
            chbMussha.AutoSize = true;
            chbMussha.Location = new Point(40, 86);
            chbMussha.Name = "chbMussha";
            chbMussha.Size = new Size(67, 19);
            chbMussha.TabIndex = 5;
            chbMussha.Text = "Mussha";
            chbMussha.UseVisualStyleBackColor = true;
            // 
            // tbMusshaprice
            // 
            tbMusshaprice.Location = new Point(129, 84);
            tbMusshaprice.Name = "tbMusshaprice";
            tbMusshaprice.Size = new Size(100, 23);
            tbMusshaprice.TabIndex = 3;
            tbMusshaprice.TextChanged += tbMusshaprice_TextChanged;
            // 
            // total
            // 
            total.Location = new Point(235, 128);
            total.Name = "total";
            total.Size = new Size(100, 23);
            total.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(188, 131);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 7;
            label1.Text = "total";
            label1.Click += label1_Click;
            // 
            // tbMusshaQuantity
            // 
            tbMusshaQuantity.Location = new Point(235, 84);
            tbMusshaQuantity.Name = "tbMusshaQuantity";
            tbMusshaQuantity.Size = new Size(100, 23);
            tbMusshaQuantity.TabIndex = 9;
            tbMusshaQuantity.TextChanged += tbMusshaQuantity_TextChanged;
            // 
            // tbCoffeeQunatity
            // 
            tbCoffeeQunatity.Location = new Point(235, 46);
            tbCoffeeQunatity.Name = "tbCoffeeQunatity";
            tbCoffeeQunatity.Size = new Size(100, 23);
            tbCoffeeQunatity.TabIndex = 8;
            tbCoffeeQunatity.TextChanged += tbCoffeeQunatity_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 207);
            Controls.Add(tbMusshaQuantity);
            Controls.Add(tbCoffeeQunatity);
            Controls.Add(label1);
            Controls.Add(total);
            Controls.Add(chbMussha);
            Controls.Add(tbMusshaprice);
            Controls.Add(chbCoffee);
            Controls.Add(button1);
            Controls.Add(tbCoffeeprice);
            Name = "Form1";
            Text = "Pos1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbCoffeeprice;
        private Button button1;
        private CheckBox chbCoffee;
        private CheckBox chbMussha;
        private TextBox tbMusshaprice;
        private TextBox total;
        private Label label1;
        private TextBox tbMusshaQuantity;
        private TextBox tbCoffeeQunatity;
    }
}
