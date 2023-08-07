using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro_atividade
{
    public partial class Form1 : Form
    {
        List<Produto> produtos = new List<Produto>();

        public Form1()
        {
            InitializeComponent();
            
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bt_cadastrar_Click(object sender, EventArgs e)
        {
            
            Produto produto = new Produto();

            produto.Codigo = tx_codigo.Text;
            produto.Descricao = tx_descricao.Text;
            produto.PrecoAquisicao= Convert.ToDouble(tx_preco.Text);
            produto.Lucro = Convert.ToDouble(tx_lucro.Text);

            produto.ValorVenda = produto.PrecoAquisicao + (produto.PrecoAquisicao * produto.Lucro / 100);

            tx_valorvenda.Text = produto.ValorVenda.ToString();
            produtos.Add(produto);

            dt_cadastro.DataSource = null;
            dt_cadastro.Refresh();
            dt_cadastro.DataSource = produtos;

        }

        private void bt_novo_Click(object sender, EventArgs e)
        {
            tx_codigo.Clear();
            tx_descricao.Clear();
            tx_lucro.Clear();
            tx_preco.Clear();
            tx_valorvenda.Text = "";
        }
    }
}
