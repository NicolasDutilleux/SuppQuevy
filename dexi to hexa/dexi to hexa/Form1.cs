namespace dexi_to_hexa
{
    public partial class Form1 : Form
    {
        int touche = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void verif1(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != ',' && touche == 0)
            {
                e.Handled = true;
                touche = 1;
            }
        }

        private void verif2(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                touche = 1;
            }
            else
            {
                touche = 0;
            }
        }

        private void Deci_change(object sender, EventArgs e)
        {
            if (deci_box.Text != "")
            {
            long hexa = long.Parse(deci_box.Text);
            hexa_box.TextChanged -= new EventHandler(hexa_change);
            hexa_box.Text = Convert.ToString(hexa, 16);
            hexa_box.TextChanged += new EventHandler(hexa_change);

            }
            else
            {
                hexa_box.TextChanged -= new EventHandler(hexa_change);
                hexa_box.Text = "";
                hexa_box.TextChanged += new EventHandler(hexa_change);
            }
            
        }

        private void hexa_change(object sender, EventArgs e)
        {
            if(hexa_box.Text != "")
            { 
                long vdeci = Convert.ToInt64(hexa_box.Text, 16);
            deci_box.TextChanged -= new EventHandler(Deci_change);
            deci_box.Text = vdeci.ToString();
            deci_box.TextChanged += new EventHandler(Deci_change);

            }
            else
            {
                deci_box.TextChanged -= new EventHandler(Deci_change);
                deci_box.Text = "";
                deci_box.TextChanged += new EventHandler(Deci_change);
            }
          
        }
    }
}