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
            string strCoffeeprice = tbCoffeeprice.Text;
            string strCoffeeQunatity = tbCoffeeQunatity.Text;
            string strMusshaprice = tbMusshaprice.Text;
            string strMusshaQuantity = tbMusshaQuantity.Text;
            string strCast = tbCast.Text;

            if (int.TryParse(strCast, out int iCast))
            {
                int.TryParse(strCoffeeprice, out int iCoffeeprice);
                int.TryParse(strCoffeeQunatity, out int iCoffeeQuanitity);
                int.TryParse(strMusshaprice, out int iMusshaprice);
                int.TryParse(strMusshaQuantity, out int iMusshaQuantity);

                double isum1 = iCoffeeprice * iCoffeeQuanitity;
                double isum2 = iMusshaprice * iMusshaQuantity;
                double isum3 = iCast;

                double totalSum = 0;

                if (chbCoffee.Checked || chbMussha.Checked)
                {
                    if (chbCoffee.Checked)
                    {
                        totalSum += isum1;
                    }

                    if (chbMussha.Checked)
                    {
                        totalSum += isum2;
                    }
                }
                else
                {
                    MessageBox.Show("กรุณาเลือกอย่างน้อยหนึ่งรายการ.");
                    return;
                }
              

                total.Text = totalSum.ToString();
                tbCast.Text = isum3.ToString();
                double priceToPay = isum1 + isum2;
                tbprice_to_pay.Text = priceToPay.ToString();

                double change = isum3 - priceToPay;

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
            {



            }
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
        }
    }
}
