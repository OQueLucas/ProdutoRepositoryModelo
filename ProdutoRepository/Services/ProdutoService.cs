using ProdutoRepositoryModelo.Entities;
using ProdutoRepositoryModelo.Interfaces;
using ProdutoRepositoryModelo.Services.Interfaces;

namespace ProdutoRepositoryModelo.Services
{
    public class ProdutoService : Service<Produto>, IProdutoService
    {
        public ProdutoService(IProdutoRepository produtoRepository) : base(produtoRepository)
        {
        }

        // Aqui pode implementar os métodos específicos se necessário
    }
}
