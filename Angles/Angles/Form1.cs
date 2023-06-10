using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace Angles
{
    public partial class Form1 : Form
    {
        int touche;
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

        private void Degre_change(object sender, EventArgs e)
        {
            if (degre_box.TextLength != 0)
            {
                float degre = float.Parse(degre_box.Text);
                float radian = (degre / 180) * (float)Math.PI;
                radian_box.TextChanged -= new EventHandler(radian_change);
                radian_box.Text = radian.ToString();
                radian_box.TextChanged += new EventHandler(radian_change);

            }

            else
            {
                radian_box.TextChanged -= new EventHandler(radian_change);
                radian_box.Text = "";
                radian_box.TextChanged += new EventHandler(radian_change);
            }
        }

        private void radian_change(object sender, EventArgs e)
        {
            if (radian_box.TextLength != 0)
            {
                float radian = float.Parse(radian_box.Text);
                float degre = (radian * 180) / (float)Math.PI;
                degre_box.TextChanged -= new EventHandler(Degre_change);
                degre_box.Text = degre.ToString();
                degre_box.TextChanged += new EventHandler(Degre_change);

            }

            else
            {
                degre_box.TextChanged -= new EventHandler(Degre_change);
                degre_box.Text = "";
                degre_box.TextChanged += new EventHandler(Degre_change);
            }
        }
    }
}