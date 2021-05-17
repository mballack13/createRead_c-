using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //instanciar a tela {FrmCadastroPessoa.cs}
            FrmCadastroPessoa telaPessoa = new FrmCadastroPessoa();

            //resolver problema de várias abertura de janela
            telaPessoa.MdiParent = this;

            //tela desta cadastro, já maximizada
            telaPessoa.WindowState = FormWindowState.Maximized;

            telaPessoa.Show();
            
            
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            //instanciar a tela {FrmCadastroProduto.cs}
            FrmCadastroProduto telaProduto = new FrmCadastroProduto();

            //resolver problema de várias abertura de janela
            telaProduto.MdiParent = this;

            telaProduto.Show();
        }
    }
}
