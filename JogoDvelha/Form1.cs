using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDvelha
{
    public partial class Form1 : Form
    {
        //Variaveis globais
        string jogadaAtual = "X";
        public Form1()
        {
            InitializeComponent();
        }

        private void pibReiniciar_Click(object sender, EventArgs e)
        {
            jogadaAtual = "X";
            lblInfo.Text = $"É a vez do {jogadaAtual}";
            lblInfo.ForeColor = Color.Red;

            //Resetar os botãos:
            btn11.Enabled = true;
            btn11.Text = "";

            btn12.Enabled = true;
            btn12.Text = "";

            btn13.Enabled = true;
            btn13.Text = "";

            btn21.Enabled = true;
            btn21.Text = "";

            btn22.Enabled = true;
            btn22.Text = "";

            btn23.Enabled = true;
            btn23.Text = "";

            btn31.Enabled = true;
            btn31.Text = "";

            btn32.Enabled = true;
            btn32.Text = "";

            btn33.Enabled = true;
            btn33.Text = "";

        }


        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void jogada_Click(object sender, EventArgs e)
        {
            Button botaoClicado = (Button)sender;
            botaoClicado.Text = jogadaAtual;
            botaoClicado.Enabled = false;
            //Trocar de X para O e de O para X
            if (jogadaAtual == "X")
            {
                jogadaAtual = "O";
                lblInfo.ForeColor = Color.Green;
            }
            else
            {
                jogadaAtual = "X";
                lblInfo.ForeColor = Color.Red;
            }
            lblInfo.Text = $"É a vez do {jogadaAtual}";
            VerificarVencedor();
            }

        public void VerificarVencedor()
        {
            // Verificar linhas:
            if (btn11.Text == btn12.Text && btn12.Text == btn13.Text && btn11.Text != "")
            {
                /* ---
                 * zzz
                 * zzz
                 */
                lblInfo.Text = $"O vencedor é {btn11.Text}";
                DesabilitarTudo();
            }
            else if (btn21.Text == btn22.Text && btn22.Text == btn23.Text && btn21.Text != "")
            {
                /* zzz
                 * ---
                 * zzz
                 */
                lblInfo.Text = $"O vencedor é {btn21.Text}";
                DesabilitarTudo();
            }
            else if (btn31.Text == btn32.Text && btn32.Text == btn33.Text && btn31.Text != "")
            {
                /* zzz
                 * zzz
                 * ---
                 */
                lblInfo.Text = $"O vencedor é {btn31.Text}";
                DesabilitarTudo();
            }
            else if (btn11.Text == btn21.Text && btn21.Text == btn31.Text && btn11.Text != "")
            {
                /* -zz
                 * -zz
                 * -zz
                 */
                lblInfo.Text = $"O vencedor é {btn11.Text}";
                DesabilitarTudo();
            }
            else if (btn12.Text == btn22.Text && btn22.Text == btn32.Text && btn12.Text != "")
            {
                /* z-z
                 * z-z
                 * z-z
                 */
                lblInfo.Text = $"O vencedor é {btn12.Text}";
                DesabilitarTudo();
            }
            else if (btn13.Text == btn23.Text && btn23.Text == btn33.Text && btn13.Text != "")
            {
                /* zz-
                 * zz-
                 * zz-
                 */
                lblInfo.Text = $"O vencedor é {btn13.Text}";
                DesabilitarTudo();
            }
            else if (btn11.Text == btn22.Text && btn22.Text == btn33.Text && btn11.Text != "")
            {
                /* -zz
                 * z-z
                 * zz-
                 */
                lblInfo.Text = $"O vencedor é {btn11.Text}";
                DesabilitarTudo();
            }
            else if (btn13.Text == btn22.Text && btn22.Text == btn31.Text && btn13.Text != "")
            {
                /* zz-
                 * z-z
                 * -zz
                 */
                lblInfo.Text = $"O vencedor é {btn13.Text}";
                DesabilitarTudo();
            }
            //Verificar se deu empate:
            else if (!btn11.Enabled && !btn12.Enabled && !btn13.Enabled && !btn21.Enabled
                  && !btn22.Enabled && !btn23.Enabled && !btn31.Enabled && !btn32.Enabled && !btn33.Enabled)
            {
                lblInfo.Text = "Empate";
            }
        }
        
         public void DesabilitarTudo()
        {
            // Irá desabilitar todos os botões quando houver um vencedor.
            // Para impedir que o jogo continue.
            btn11.Enabled = false;
            btn12.Enabled = false;
            btn13.Enabled = false;
            btn21.Enabled = false;
            btn22.Enabled = false;
            btn23.Enabled = false;
            btn31.Enabled = false;
            btn32.Enabled = false;
            btn33.Enabled = false;
        }



    
    }
}
