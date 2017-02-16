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
    public partial class frmAgenda : Form
    {
        public frmAgenda()
        {
            InitializeComponent();
        }

        private void btnCEP_Click(object sender, EventArgs e)
        {
            //chama o método PesquisarCEP
            PesquisarCEP(mskCEP.Text);
        }

        private void frmAgenda_KeyPress(object sender, KeyPressEventArgs e)
        {
            //envia TAB quando for pressionado enter
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void tstSair_Click(object sender, EventArgs e)
        {
            //fecha o formulário
            Close();
        }

        private void tstSalvar_Click(object sender, EventArgs e)
        {
            //validação do conteúdo
            if (txtNome.Text == "")
            {
                errErro.SetError(lblNome, "Campo Obrigatório");
                return;
            }
            else
            {
                errErro.SetError(lblNome, "");
            }
            //instancia a classe de negócio
            clCliente clClientes = new clCliente();
            //carrega as propriedades
            clClientes.cliNome = txtNome.Text;
            clClientes.cliEndereco = txtEndereco.Text;
            clClientes.cliNumero = txtNumero.Text;
            clClientes.cliBairro = txtBairro.Text;
            clClientes.cliCidade = txtCidade.Text;
            clClientes.cliCep = mskCEP.Text;
            clClientes.cliCelular = mskCelular.Text;
            clClientes.banco = Properties.Settings.Default.conexaoDB;
            MessageBox.Show("Cliente incluido com Sucesso", "atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            clClientes.Gravar();
        }

        //PesquisarCEP é um método
        //string CEP é o argumento
        //ou assinatura do método
        private void PesquisarCEP(string CEP)
        {
            //pesquisa de CEP
            DataSet ds = new DataSet();

            string xml = "http://cep.republicavirtual.com.br/web_cep.php?cep=@cep&formato=xml".Replace("@cep", CEP);
            ds.ReadXml(xml);
            if (ds.Tables[0].Rows[0]["resultado_txt"].ToString() == "sucesso - cep completo" || ds.Tables[0].Rows[0]["resultado_txt"].ToString() == "sucesso - cep único")
            {
                txtEndereco.Text = ds.Tables[0].Rows[0]["tipo_logradouro"].ToString() + " " + ds.Tables[0].Rows[0]["logradouro"].ToString();
                txtBairro.Text = ds.Tables[0].Rows[0]["bairro"].ToString();
                txtCidade.Text = ds.Tables[0].Rows[0]["cidade"].ToString();
                cboEstado.Text = ds.Tables[0].Rows[0]["uf"].ToString();
                txtNumero.Focus();
            }
            else
            {
                MessageBox.Show("CEP não Encontrado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frmAgenda_Load(object sender, EventArgs e)
        {

        }

        private void tstPesquisar_Click(object sender, EventArgs e)
        {
        }
    }
}
