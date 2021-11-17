using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControleLojasRede.Code.DTO;
using ControleLojasRede.Code.BLL;

namespace ControleLojasRede.Ui
{
    public partial class FrmProd : Form
    {
        ProdutoDTO prodDTO = new ProdutoDTO();
        ProdutoBLL prodBLL = new ProdutoBLL();
        public FrmProd()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            prodDTO.Nome = txtNome.Text;
            prodDTO.Categoria = txtCategoria.Text;
            prodDTO.Preco = double.Parse(txtPreco.Text);

            prodBLL.Inserir(prodDTO);

            MessageBox.Show("Produto cadastrado com sucesso!", "Produtos", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtNome.Clear();
            txtCategoria.Clear();
            txtPreco.Clear();

            dtgProdutos.DataSource = prodBLL.Listar();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            prodDTO.Id = int.Parse(txtCodigo.Text);
            prodDTO.Nome = txtNome.Text;
            prodDTO.Categoria = txtCategoria.Text;
            prodDTO.Preco = double.Parse(txtPreco.Text);

            prodBLL.Alterar(prodDTO);

            MessageBox.Show("Produto alterado com sucesso!", "Produtos", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtCodigo.Clear();
            txtNome.Clear();
            txtCategoria.Clear();
            txtPreco.Clear();

            dtgProdutos.DataSource = prodBLL.Listar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            prodDTO.Id = int.Parse(txtCodigo.Text);

            prodBLL.Excluir(prodDTO);

            MessageBox.Show("Produto excluído com sucesso!", "Produtos", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtCodigo.Clear();

            dtgProdutos.DataSource = prodBLL.Listar();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            dtgProdutos.DataSource = prodBLL.Listar();
        }

        private void dtgProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = dtgProdutos.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNome.Text = dtgProdutos.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtCategoria.Text = dtgProdutos.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtPreco.Text = dtgProdutos.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void FrmProd_Load(object sender, EventArgs e)
        {
            dtgProdutos.DataSource = prodBLL.Listar();
        }
    }
}
