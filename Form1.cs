using System.Diagnostics.Eventing.Reader;

namespace ShoppingCart_e
{
    public partial class Form1 : Form
    {
        item itemCoffee = new item();
        item itemMussha = new item();
        item itemNoodle = new item();
        item itemHamberger = new item();

        public Form1()
        {
            InitializeComponent();

            itemCoffee.name = "Coffee";
            itemCoffee.price = 50;
            itemCoffee.quantity = 0;

            tbCoffeeprice.Text =
                itemCoffee.price.ToString();
            tbCoffeeQunatity.Text =
                itemCoffee.quantity.ToString();

            itemMussha.name = "Mussha";
            itemMussha.price = 40;
            itemMussha.quantity = 0;

            tbMusshaprice.Text =
                itemMussha.price.ToString();
            tbMusshaQuantity.Text =
                itemMussha.quantity.ToString();

            itemNoodle.name = "Noodle";
            itemNoodle.price = 25;
            itemNoodle.quantity = 0;

            tbNoodleprice.Text =
                itemNoodle.price.ToString();
            tbNoodleQunatity.Text =
                itemNoodle.quantity.ToString();

            itemHamberger.name = "Hamberger";
            itemHamberger.price = 120;
            itemHamberger.quantity = 0;

            tbHambergerprice.Text =
                itemHamberger.price.ToString();
            tbHambergerQunatity.Text =
                itemHamberger.quantity.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShopShoplab();
        }

        private void ShopShoplab()
        {
            string strCast = tbCast.Text;
            double iCast = 0;

            if (double.TryParse(strCast, out iCast))
            {
                itemCoffee.price = double.Parse(tbCoffeeprice.Text);
                itemCoffee.quantity = int.Parse(tbCoffeeQunatity.Text);
                itemMussha.price = double.Parse(tbMusshaprice.Text);
                itemMussha.quantity = int.Parse(tbMusshaQuantity.Text);
                itemNoodle.price = double.Parse(tbNoodleprice.Text);
                itemNoodle.quantity = int.Parse(tbNoodleQunatity.Text);
                itemHamberger.price = double.Parse(tbHambergerprice.Text);
                itemHamberger.quantity = int.Parse(tbHambergerQunatity.Text);

                
                

                double isum1 = itemCoffee.price * itemCoffee.quantity;
                double isum2 = itemMussha.price * itemMussha.quantity;
                double isum3 = itemNoodle.price * itemNoodle.quantity;
                double isum4 = itemHamberger.price * itemHamberger.quantity;
                double isumcast = iCast;

                double priceToPay = 0;

                if (itemCoffee.Check || itemMussha.Check || itemNoodle.Check || itemHamberger.Check)
                {
                    if (itemCoffee.Check)
                    {
                        priceToPay += isum1;
                    }

                    if (itemMussha.Check)
                    {
                        priceToPay += isum2;
                    }
                    if (itemNoodle.Check)
                    {
                        priceToPay += isum3;
                    }

                    if (itemHamberger.Check)
                    {
                        priceToPay += isum4;
                    }
                }
                else
                {
                    MessageBox.Show("กรุณาเลือกอย่างน้อยหนึ่งรายการ.");
                    return;
                }

                double totalSum = isum1 + isum2 + isum3 + isum4;
                total.Text = totalSum.ToString("F2");

                tbprice_to_pay.Text = priceToPay.ToString("F2");

                double change = isumcast - priceToPay;
                tbTon.Text = change.ToString("F2");

                if (chbAll.Checked || chbBeverage.Checked || chbFood.Checked)
                {
                    double discountedTotal = totalSum;
                    if (chbAll.Checked)
                    {
                        if (double.TryParse(tbAll.Text, out double allDiscount))
                        {
                            discountedTotal = totalSum * (1 - allDiscount / 100);
                        }
                    }
                    else if (chbFood.Checked)
                    {
                        if (double.TryParse(tbFood.Text, out double foodDiscount))
                        {
                            discountedTotal = (isum3 + isum4) * (1 - foodDiscount / 100) + (isum1 + isum2);
                        }
                    }
                    else if (chbBeverage.Checked)
                    {
                        if (double.TryParse(tbBeverage.Text, out double beverageDiscount))
                        {
                            discountedTotal = (isum1 + isum2) * (1 - beverageDiscount / 100) + (isum3 + isum4);
                        }
                    }

                    double finalPriceToPay = discountedTotal;
                    tbprice_to_pay.Text = finalPriceToPay.ToString("F2");
                    double finalChange = isumcast - finalPriceToPay;
                    tbTon.Text = finalChange.ToString("F2");
                }

                if (change > 0)
                {
                    double[] denominations = { 1000, 500, 100, 50, 20, 10, 5, 1, 0.50, 0.25, 0.10, 0.05, 0.01 };
                    TextBox[] changeTextBoxes = { textBox1000, textBox500, textBox100, textBox50, textBox20, textBox10, textBox5, textBox_1, textBox0_50, textBox0_25, textBox0_10, textBox0_05, textBox0_01 };

                    for (int i = 0; i < denominations.Length; i++)
                    {
                        double count = (int)(change / denominations[i]);
                        changeTextBoxes[i].Text = count.ToString();

                        change -= count * denominations[i];
                    }
                }
                else
                {
                    MessageBox.Show("เกินวงเงิน.");
                }
            }
            else
            {
                MessageBox.Show("กรุณากรอกตัวเลขใน Cast ก่อน.");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            itemCoffee.Check = chbCoffee.Checked;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tbCoffeeprice_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbMusshaprice_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbCoffeeQunatity_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbMusshaQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void tbCast_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tbCoffeeprice.Clear();
            tbCoffeeQunatity.Clear();
            tbMusshaprice.Clear();
            tbMusshaQuantity.Clear();
            tbNoodleprice.Clear();
            tbNoodleQunatity.Clear();
            tbHambergerprice.Clear();
            tbHambergerQunatity.Clear();
            tbCast.Clear();
            total.Clear();
            tbprice_to_pay.Clear();
            tbTon.Clear();
            textBox1000.Clear();
            textBox500.Clear();
            textBox100.Clear();
            textBox50.Clear();
            textBox20.Clear();
            textBox10.Clear();
            textBox5.Clear();
            textBox_1.Clear();
            textBox0_50.Clear();
            textBox0_25.Clear();
            textBox0_10.Clear();
            textBox0_05.Clear();
            textBox0_01.Clear();

            itemCoffee.Check = false;
            itemMussha.Check = false;
            itemNoodle.Check = false;
            itemHamberger.Check = false;
        }

        private void textBox100_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
        private void UpdateCheckboxStates()
        {
            if (itemCoffee.Check)
            {
                chbMussha.Enabled = false;
                chbNoodle.Enabled = false;
                chbHamberger.Enabled = false;
            }
            else if (itemMussha.Check)
            {
                chbCoffee.Enabled = false;
                chbNoodle.Enabled = false;
                chbHamberger.Enabled = false;
            }
            else if (itemNoodle.Check)
            {
                chbCoffee.Enabled = false;
                chbMussha.Enabled = false;
                chbHamberger.Enabled = false;
            }
            else if (itemHamberger.Check)
            {
                chbCoffee.Enabled = false;
                chbMussha.Enabled = false;
                chbNoodle.Enabled = false;
            }
            else
            {
                chbCoffee.Enabled = true;
                chbMussha.Enabled = true;
                chbNoodle.Enabled = true;
                chbHamberger.Enabled = true;
            }
        }

        private void chbCoffee_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCheckboxStates();
        }

        private void chbMussha_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCheckboxStates();
        }

        private void chbNoodle_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCheckboxStates();
        }

        private void chbHamberger_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCheckboxStates();
        }

        private void chbMussha_CheckedChanged_1(object sender, EventArgs e)
        {
            itemMussha.Check = chbMussha.Checked;
        }

        private void chbNoodle_CheckedChanged_1(object sender, EventArgs e)
        {
            itemNoodle.Check = chbNoodle.Checked;
        }

        private void chbHamberger_CheckedChanged_1(object sender, EventArgs e)
        {
            itemHamberger.Check = chbHamberger.Checked;
        }

       

        private void chbAll_CheckedChanged(object sender, EventArgs e)
        {
         
        }
        

        private void chbBeverage_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}