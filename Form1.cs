namespace ShoppingCart_e
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShopShoplab();
        }

        private void ShopShoplab()
        {
            string strCoffeeprice = tbCoffeeprice.Text;
            string strCoffeeQunatity = tbCoffeeQunatity.Text;
            string strMusshaprice = tbMusshaprice.Text;
            string strMusshaQuantity = tbMusshaQuantity.Text;
            string strNoodleprice = tbNoodleprice.Text;
            string strNoodleQuantity = tbNoodleQunatity.Text;
            string strHambergerprice = tbHambergerprice.Text;
            string strHambergerQuantity = tbHambergerQunatity.Text;
            string strAll = tbAll.Text;
            string strFood = tbFood.Text;
            string strBeverage = tbBeverage.Text;
            string strCast = tbCast.Text;

            if (int.TryParse(strCast, out int iCast))
            {
                int.TryParse(strCoffeeprice, out int iCoffeeprice);
                int.TryParse(strCoffeeQunatity, out int iCoffeeQuanitity);
                int.TryParse(strMusshaprice, out int iMusshaprice);
                int.TryParse(strMusshaQuantity, out int iMusshaQuantity);
                int.TryParse(strNoodleprice, out int iNoodleprice);
                int.TryParse(strNoodleQuantity, out int iNoodleQuantity);
                int.TryParse(strHambergerprice, out int iHambergerprice);
                int.TryParse(strHambergerQuantity, out int iHambergerQuantity);

                double isum1 = iCoffeeprice * iCoffeeQuanitity;
                double isum2 = iMusshaprice * iMusshaQuantity;
                double isum3 = iNoodleprice * iNoodleQuantity;
                double isum4 = iHambergerprice * iHambergerQuantity;
                double isumcast = iCast;

                double priceToPay = 0;

                if (chbCoffee.Checked || chbMussha.Checked || chbNoodle.Checked || chbHamberger.Checked)
                {
                    if (chbCoffee.Checked)
                    {
                        priceToPay += isum1;
                    }

                    if (chbMussha.Checked)
                    {
                        priceToPay += isum2;
                    }
                    if (chbNoodle.Checked)
                    {
                        priceToPay += isum3;
                    }

                    if (chbHamberger.Checked)
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
                total.Text = totalSum.ToString();
                tbCast.Text = isumcast.ToString();

                tbprice_to_pay.Text = priceToPay.ToString();

                double change = isumcast - priceToPay;

                if (chbAll.Checked || chbBeverage.Checked || chbFood.Checked)
                {
                    double discountedTotal = totalSum;
                    if (chbAll.Checked)
                    {
                        if (double.TryParse(strAll, out double allDiscount))
                        {
                            discountedTotal = totalSum * (1 - allDiscount / 100);
                        }
                    }
                    else if (chbFood.Checked)
                    {
                        if (double.TryParse(strFood, out double foodDiscount))
                        {
                            discountedTotal = (isum3 + isum4) * (1 - foodDiscount / 100) + (isum1 + isum2);
                        }
                    }
                    else if (chbBeverage.Checked)
                    {
                        if (double.TryParse(strBeverage, out double beverageDiscount))
                        {
                            discountedTotal = (isum1 + isum2) * (1 - beverageDiscount / 100) + (isum3 + isum4);
                        }
                    }

                    double finalPriceToPay = discountedTotal;
                    tbprice_to_pay.Text = finalPriceToPay.ToString();
                }

                if (change >= 0)
                {
                    int[] denominations = { 1000, 500, 100, 50, 20, 10, 5, 1 };
                    TextBox[] changeTextBoxes = { textBox1000, textBox500, textBox100, textBox50, textBox20, textBox10, textBox5, textBox_1 };

                    for (int i = 0; i < denominations.Length; i++)
                    {
                        int count = (int)(change / denominations[i]);
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
            textBox1000.Clear();
            textBox500.Clear();
            textBox100.Clear();
            textBox50.Clear();
            textBox20.Clear();
            textBox10.Clear();
            textBox5.Clear();
            textBox_1.Clear();
            chbCoffee.Checked = false;
            chbMussha.Checked = false;
            chbNoodle.Checked = false;
            chbHamberger.Checked = false;
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
    }
}
