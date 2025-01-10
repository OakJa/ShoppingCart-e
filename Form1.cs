using System.Diagnostics.Eventing.Reader;

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
            string strTon = tbTon.Text;
            double iCoffeeprice = 0, iCoffeeQuanitity = 0, iMusshaprice = 0, iMusshaQuantity = 0, iNoodleprice = 0, iNoodleQuantity = 0, iHambergerprice = 0, iHambergerQuantity = 0, iCast = 0, iTon = 0;

            if (double.TryParse(strCast, out iCast))
            {
                double.TryParse(strCoffeeprice, out iCoffeeprice);
                double.TryParse(strCoffeeQunatity, out iCoffeeQuanitity);
                double.TryParse(strMusshaprice, out iMusshaprice);
                double.TryParse(strMusshaQuantity, out iMusshaQuantity);
                double.TryParse(strNoodleprice, out iNoodleprice);
                double.TryParse(strNoodleQuantity, out iNoodleQuantity);
                double.TryParse(strHambergerprice, out iHambergerprice);
                double.TryParse(strHambergerQuantity, out iHambergerQuantity);

                double isum1 = iCoffeeprice * iCoffeeQuanitity;
                double isum2 = iMusshaprice * iMusshaQuantity;
                double isum3 = iNoodleprice * iNoodleQuantity;
                double isum4 = iHambergerprice * iHambergerQuantity;
                double isumcast = iCast;
                double isumton = iTon;

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
                total.Text = totalSum.ToString("F2");

                tbprice_to_pay.Text = priceToPay.ToString("F2");
                

                double change = isumcast - priceToPay;
                double isumTon = change;
                tbTon.Text = isumTon.ToString("F2");



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
                    tbprice_to_pay.Text = finalPriceToPay.ToString("F2");
                    double finalChange = isumcast - finalPriceToPay;
                    tbTon.Text = finalChange.ToString("F2");
                }

                if (change > 0)
                {
                    double[] denominations = { 1000, 500, 100, 50, 20, 10, 5, 1, 0.50, 0.25, 0.10, 0.05, 0.01};
                    TextBox[] changeTextBoxes = { textBox1000, textBox500, textBox100, textBox50, textBox20, textBox10, textBox5, textBox_1, textBox0_50 ,textBox0_25,textBox0_10, textBox0_05, textBox0_01};

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

        private void label13_Click(object sender, EventArgs e)
        {

        }
        private void UpdateCheckboxStates()
        {
            if (chbCoffee.Checked)
            {
                chbMussha.Enabled = false;
                chbNoodle.Enabled = false;
                chbHamberger.Enabled = false;
            }
            else if (chbMussha.Checked)
            {
                chbCoffee.Enabled = false;
                chbNoodle.Enabled = false;
                chbHamberger.Enabled = false;
            }
            else if (chbNoodle.Checked)
            {
                chbCoffee.Enabled = false;
                chbMussha.Enabled = false;
                chbHamberger.Enabled = false;
            }
            else if (chbHamberger.Checked)
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
    }
}