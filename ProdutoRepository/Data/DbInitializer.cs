using ProdutoRepositoryModelo.Entities;

namespace ProdutoRepositoryModelo.Data
{
    public class DbInitializer
    {
        public static void Initialize(ProdutoContext context)
        {
            if (context.Produto.Any())
            {
                return; // DB has been seeded
            }

            Produto prod1 = new("Calça Skinners", "Calça extremamente apertada", 324.32m, 42, "Roupa", DateTime.Now.AddDays(-1));
            Produto prod2 = new("Calça Saruel", "Calça que parece uma fralda", 450.39m, 25, "Roupa", DateTime.Now.AddDays(-2));
            Produto prod3 = new("Camiseta Insider", "Camiseta que não amassa, não esquenta e confortável", 650.92m, 42, "Roupa", DateTime.Now.AddDays(-5));
            Produto prod4 = new("Camiseta básica", "Camiseta para qualquer estilo", 40.60m, 42, "Roupa", DateTime.Now.AddDays(-7));

            context.Produto.AddRange(prod1, prod2, prod3, prod4);

            context.SaveChanges();
        }
    }
}
