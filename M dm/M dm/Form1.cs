using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace M_dm
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

        private void Metre_change(object sender, EventArgs e)
        {
            if (MetreBox.TextLength != 0)
            {
                float Metre = float.Parse(MetreBox.Text);
                float DMetre = Metre * 10;
                DMetreBox.TextChanged -= new EventHandler(DMetre_change);
                DMetreBox.Text = DMetre.ToString();
                DMetreBox.TextChanged += new EventHandler(DMetre_change);
                float CMetre = DMetre * 10;
                CMetreBox.TextChanged -= new EventHandler(CMetre_change);
                CMetreBox.Text = CMetre.ToString();
                CMetreBox.TextChanged += new EventHandler(CMetre_change);
            }

            else
            {
                DMetreBox.TextChanged -= new EventHandler(DMetre_change);
                DMetreBox.Text = "";
                DMetreBox.TextChanged += new EventHandler(DMetre_change);
                CMetreBox.TextChanged -= new EventHandler(CMetre_change);
                CMetreBox.Text = "";
                CMetreBox.TextChanged += new EventHandler(CMetre_change);
            }
        }

        private void DMetre_change(object sender, EventArgs e)
        {
            if (DMetreBox.TextLength != 0)
            {
                float DMetre = float.Parse(DMetreBox.Text);
                float Metre = DMetre /10;
                MetreBox.TextChanged -= new EventHandler(Metre_change);
                MetreBox.Text = Metre.ToString();
                MetreBox.TextChanged += new EventHandler(Metre_change);
                float CMetre = DMetre * 10;
                CMetreBox.TextChanged -= new EventHandler(CMetre_change);
                CMetreBox.Text = CMetre.ToString();
                CMetreBox.TextChanged += new EventHandler(CMetre_change);
            }

            else
            {
                MetreBox.TextChanged -= new EventHandler(DMetre_change);
                MetreBox.Text = "";
                MetreBox.TextChanged += new EventHandler(DMetre_change);
                CMetreBox.TextChanged -= new EventHandler(CMetre_change);
                CMetreBox.Text = "";
                CMetreBox.TextChanged += new EventHandler(CMetre_change);
            }
        }

        private void CMetre_change(object sender, EventArgs e)
        {
            if (CMetreBox.TextLength != 0)
            {
                float CMetre = float.Parse(CMetreBox.Text);
                float DMetre = CMetre / 10;
                DMetreBox.TextChanged -= new EventHandler(DMetre_change);
                DMetreBox.Text = DMetre.ToString();
                DMetreBox.TextChanged += new EventHandler(DMetre_change);
                float Metre = DMetre / 10;
                MetreBox.TextChanged -= new EventHandler(Metre_change);
                MetreBox.Text = Metre.ToString();
                MetreBox.TextChanged += new EventHandler(Metre_change);
            }

            else
            {
                MetreBox.TextChanged -= new EventHandler(DMetre_change);
                MetreBox.Text = "";
                MetreBox.TextChanged += new EventHandler(DMetre_change);
                DMetreBox.TextChanged -= new EventHandler(DMetre_change);
                DMetreBox.Text = "";
                DMetreBox.TextChanged += new EventHandler(DMetre_change);
            }
        }
    }
}