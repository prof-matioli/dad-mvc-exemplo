using AppMVC.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMVC.Controller
{
    public class ProdutoController
    {
        private readonly ProdutoRepository _repository;

        public ProdutoController()
        {
            _repository = new ProdutoRepository();
        }

        public List<Produto> ObterProdutos()
        {
            return _repository.ObterTodos();
        }

        public void AdicionarProduto(string nome, decimal preco, int quantidade)
        {
            // Ao criar o novo produto, passamos um Id temporário (ex: 0),
            // pois ele não será usado na inserção no banco de dados.
            var novoProduto = new Produto(0, nome, preco, quantidade);
            _repository.Adicionar(novoProduto);
        }

        public void RemoverProduto(int id)
        {
            _repository.Remover(id);
        }
    }
}
