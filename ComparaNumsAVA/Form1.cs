using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComparaNumsAVA
{
    public partial class FrmVerificaMaior : Form
    {
        public FrmVerificaMaior()
        {
            InitializeComponent();
        }

        // declaração e implementação da função
        int verificaMaior(int num1, int num2)
        {
            return num1 > num2 ? num1 : num2;
        }

        // declaração e implementação do procedimento para limpar os controles
        // o tipo de retorno é void, ou seja, não tem retorno
        void limparControles()
        {
            // limpa o conteúdos dos controles
            txtA.Clear();
            txtB.Clear();
            txtMaior.Clear();
            txtA.Focus();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            // declaração das variáveis
            int a, b;

            // entrada de dados para as variáveis
            a = Convert.ToInt32(txtA.Text);
            b = Convert.ToInt32(txtB.Text);

            /* chamando a função verificaMaior e passando
             *  os argumentos para os parâmetros num1 e num2
             * TextBox txtMaior recebe o retorno da função */
            txtMaior.Text = verificaMaior(a, b).ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparControles();
        }
    }
}
