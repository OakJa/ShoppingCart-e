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

            int iCoffeeprice = int.Parse(strCoffeeprice);
            int iCoffeeQuanitity = int.Parse(strCoffeeQunatity);  // Corrected line
            int iMusshaprice = int.Parse(strMusshaprice);
            int iMusshaQuantity = int.Parse(strMusshaQuantity);
            int iCast = int.Parse(strCast);

            double isum1 = iCoffeeprice * iCoffeeQuanitity;
            double isum2 = iMusshaprice * iMusshaQuantity;
            double isum3 = iCast;


            double totalSum = 0;

            if (chbCoffee.Checked)
            {
                totalSum += isum1;
            }

            if (chbMussha.Checked)
            {
                totalSum += isum2;
            }

            total.Text = totalSum.ToString();
            tbCast.Text = isum3.ToString();
            tbprice_to_pay.Text = (isum1 + isum2).ToString();
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
    }
}
