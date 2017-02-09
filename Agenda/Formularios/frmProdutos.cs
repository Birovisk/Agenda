using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace Agenda
{
    public partial class frmProdutos : Form
    {
        public frmProdutos()
        {
            InitializeComponent();
        }

        private void tstSalvar_Click(object sender, EventArgs e)
        {
            //validação do conteúdo
            if (txtDescricao.Text == "")
            {
                errErro.SetError(lblDescricao, "Campo Obrigatório");
                return;
            }
            else
            {
                errErro.SetError(lblDescricao, "");
            }
            //instancia a classe de negócio
            clProduto clProdutos = new clProduto();
            //carrega as propriedades
            clProdutos.proDescricao = txtDescricao.Text;
            clProdutos.proMarca = txtMarca.Text;
            clProdutos.proPreco = txtPreco.Text;
            clProdutos.proData = mskData.Text;
            clProdutos.banco = Properties.Settings.Default.conexaoDB;
            MessageBox.Show("Produto incluido com Sucesso", "atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            clProdutos.Gravar();
        }

        private void tstSair_Click(object sender, EventArgs e)
        {
            //fecha o formulário
            Close();
        }

        private void frmProdutos_Load(object sender, EventArgs e)
        {

        }
    }
}