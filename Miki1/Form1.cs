namespace Miki1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int vara = int.Parse(VarA.Text);
            int varb = int.Parse(VarB.Text);
            int varc = int.Parse(VarC.Text);
            double delta = (Math.Pow(varb, 2)) - (4 * vara * varc);
            Delta.Text = "Delta:" + Convert.ToString(delta);
            if (delta < 0)
            {
                x1.Text = "brak x";
                    x2.Text = "brak x";
                wynik_D.Text = "Delta jest równa 0";
            }
            if (delta == 0)
            {
                double xfirst = ((-1)*varb) / (vara * 2);
                xfirst = Math.Round(xfirst, 1);
                x1.Text = "x: " + Convert.ToString(xfirst);
                x2.Text = "";
                wynik_D.Text = "Delta jest równa 0";
            }
            if (delta > 0)
            {
                double pdelta = Math.Sqrt(delta);
                double xfirst = ((-1) * varb - pdelta) / (vara * 2);
                double xsecond = ((-1) * varb + pdelta) / (vara * 2);
                xfirst = Math.Round(xfirst, 1);
                xsecond = Math.Round(xsecond, 1);
                x1.Text = "x1: " + Convert.ToString(xfirst);
                x2.Text = "x2: " + Convert.ToString(xsecond);
                wynik_D.Text = "Delta jest wiêksza od 0";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}