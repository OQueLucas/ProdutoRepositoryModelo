using ProdutoRepositoryModelo.Data;
using ProdutoRepositoryModelo.Entities;
using ProdutoRepositoryModelo.Interfaces;

namespace ProdutoRepositoryModelo.Repositories
{
    public class ProdutoRepository : Repository<Produto>, IProdutoRepository
    {
        public ProdutoRepository(ProdutoContext context) : base(context)
        {
        }

        // Aqui pode implementar os métodos específicos se necessário
    }
}
