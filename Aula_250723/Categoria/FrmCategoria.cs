using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Categoria
{
    public partial class FrmCategoria : Form
    {
        public FrmCategoria()
        {
            InitializeComponent();
            

        }

        private void FrmCategoria_Load(object sender, EventArgs e)
        {
           txt_Nome.Focus();
        }

        private void txt_Nome_Enter(object sender, EventArgs e)
        {
            txt_Nome.BackColor = Color.LightYellow;

            
        }

        private void txt_Nome_Leave(object sender, EventArgs e)
        {
            txt_Nome.BackColor = SystemColors.Window;
        }

        private void txt_Nascimento_Enter(object sender, EventArgs e)
        {
            txt_Nascimento.BackColor = Color.LightYellow;
          
        }

        private void txt_Nascimento_Leave(object sender, EventArgs e)
        {
            txt_Nascimento.BackColor= SystemColors.Window;
        }

        private void txt_Aniversario_Enter(object sender, EventArgs e)
        {
            txt_Aniversario.BackColor = Color.LightYellow;

           
        }
       
        private void txt_Aniversario_Leave(object sender, EventArgs e)
        {
            txt_Aniversario.BackColor= SystemColors.Window;
        }

        private void btn_Categoria_Click(object sender, EventArgs e)
        {
            if (txt_Nascimento.Text.Trim().Length != 4)
            {
                MessageBox.Show("Ano de Nascimento deve ter 4 digitos",
                    "Atenção!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                txt_Nascimento.Focus();
            }
            if (txt_Aniversario.Text.Trim().Length != 4)
            {
                MessageBox.Show("Aniversario deve ter 4 digitos",
                    "Atenção!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                txt_Aniversario.Focus();
            }

        }
        
    }
}
