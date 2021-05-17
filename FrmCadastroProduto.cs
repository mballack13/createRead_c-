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
    public partial class FrmCadastroProduto : Form
    {
        List<cProduto> listaDeProdutos = new List<cProduto>();

        public FrmCadastroProduto()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //fazendo objeto de classe, dentro de Pessoas
            cProduto crudingProduto = new cProduto();

            //buscando da os valores das textBox;
            crudingProduto.Nome = txtNome.Text;
            crudingProduto.Descricao = txtDescricao.Text;
            crudingProduto.ValorUnit = txtValorUnit.Text;
            crudingProduto.QuantEstoq = txtQuantEst.Text;
            crudingProduto.Fabricante = txtFabricante.Text;

            //colocando tudo na lista
            listaDeProdutos.Add(crudingProduto);

            //limpeza de campos, depois de add
            txtNome.Text        = "";
            txtDescricao.Text   = "";
            txtValorUnit.Text   = "";
            txtQuantEst.Text    = "";
            txtFabricante.Text  = "";

            //colocando na grid, todos os valores
            dtGridProduto.Rows.Add(crudingProduto.Nome, crudingProduto.Descricao, crudingProduto.ValorUnit, crudingProduto.QuantEstoq, crudingProduto.Fabricante);
        }
    }
}
