using CasaDoCodigo.Models;
using System.Collections.Generic;

namespace CasaDoCodigo.Repositories
{
    public interface IProdutoRepository
    {
        void SaveProtutos(List<Livro> livros);

        IList<Produto> GetProdutos();
    }
}