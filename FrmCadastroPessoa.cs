using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Classes; //esta WinFormsApp, é o nome do projeto

namespace WinFormsApp1
{
    public partial class FrmCadastroPessoa : Form
    {
        List<cPessoa> listaDePessoas = new List<cPessoa>();
        
        public FrmCadastroPessoa()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //fazendo objeto de classe, dentro de Pessoas
            cPessoa crudingPessoa = new cPessoa();

            //buscando da os valores das textBox;
            crudingPessoa.Nome      = txtNome.Text;
            crudingPessoa.Endereco  = txtEndereco.Text;
            crudingPessoa.Numero    = txtNumero.Text;
            crudingPessoa.Cidade    = txtCidade.Text;
            crudingPessoa.Estado    = txtEstado.Text;
            crudingPessoa.Cep       = txtCep.Text;
            crudingPessoa.Email     = txtEmail.Text;
            crudingPessoa.Ddd       = txtDdd.Text;
            crudingPessoa.Telefone  = txtTelefone.Text;

            //colocando tudo na lista
            listaDePessoas.Add(crudingPessoa);

            //limpeza de campos, depois de add
            txtNome.Text        = "";
            txtEndereco.Text    = "";
            txtNumero.Text      = "";
            txtCidade.Text      = "";
            txtEstado.Text      = "";
            txtCep.Text         = "";
            txtEmail.Text       = "";
            txtDdd.Text         = "";
            txtTelefone.Text    = "";

            //colocando na grid, todos os valores
            dtGridPessoa.Rows.Add(crudingPessoa.Nome, crudingPessoa.Endereco, crudingPessoa.Numero,crudingPessoa.Cidade, crudingPessoa.Estado, crudingPessoa.Cep, crudingPessoa.Email, crudingPessoa.Ddd, crudingPessoa.Telefone);
        }
    }
}
