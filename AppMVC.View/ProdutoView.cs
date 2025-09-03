using AppMVC.Controller;
using AppMVC.Model;

namespace AppMVC.View
{
    public partial class ProdutoView : Form
    {
        private readonly ProdutoController _controller;

        public ProdutoView()
        {
            InitializeComponent();
            _controller = new ProdutoController();
            CarregarProdutos();
        }

        private void CarregarProdutos()
        {
            var produtos = _controller.ObterProdutos();
            dgvProdutos.DataSource = produtos;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtPreco.Text, out decimal preco) &&
                int.TryParse(txtQuantidade.Text, out int quantidade))
            {
                string nome = txtNome.Text;
                _controller.AdicionarProduto(nome, preco, quantidade);
                LimparCampos();
                CarregarProdutos();
            }
            else
            {
                MessageBox.Show("Por favor, insira valores válidos.");
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (dgvProdutos.CurrentRow != null)
            {
                var produtoSelecionado = (Produto)dgvProdutos.CurrentRow.DataBoundItem;
                _controller.RemoverProduto(produtoSelecionado.Id);
                CarregarProdutos();
            }
        }

        private void LimparCampos()
        {
            txtNome.Clear();
            txtPreco.Clear();
            txtQuantidade.Clear();
        }
    }
}
