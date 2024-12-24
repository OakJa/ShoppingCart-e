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

            int iCoffeeprice = int.Parse(strCoffeeprice);
            int iCoffeeQuanitity = int.Parse(strCoffeeQunatity);  // Corrected line
            int iMusshaprice = int.Parse(strMusshaprice);
            int iMusshaQuantity = int.Parse(strMusshaQuantity);

            double isum1 = iCoffeeprice * iCoffeeQuanitity;
            double isum2 = iMusshaprice * iMusshaQuantity;

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
    }
}
