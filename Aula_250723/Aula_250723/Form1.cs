using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_250723
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            double gastos = Convert.ToDouble(txt_Gastos.Text);
            double acrescimo = gastos * 1.10;
            txt_Acrescimo.Text = acrescimo.ToString();

            txt_Acrescimo.Text = (Convert.ToDouble(txt_Gastos.Text) * 1.10).ToString();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                btn_Calcular_Click(sender, e);
            }
            if (e.KeyCode == Keys.F1)
            {
                txt_Acrescimo.Text = "F1";
            }
        }
    }
}
