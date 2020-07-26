using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Area_de_un_circulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double radio = double.Parse(txtRadio.Text);
            double area = 0;

            area = (radio*radio) * Math.PI;

            txtArea.Text = Convert.ToString(String.Format("{0:n}" ,area));

            txtRadio.Focus();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtRadio.Text = String.Empty;
            txtArea.Text = String.Empty;
            txtRadio.Focus();
        }
    }
}
