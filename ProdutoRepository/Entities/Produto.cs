using System.ComponentModel.DataAnnotations;

namespace ProdutoRepositoryModelo.Entities
{
    public class Produto
    {
        public Produto(string nome, string descricao, decimal preco, int estoque, string categoria, DateTime dataCadastro)
        {
            Nome = nome;
            Descricao = descricao;
            Preco = preco;
            Estoque = estoque;
            Categoria = categoria;
            DataCadastro = dataCadastro;
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Nome { get; set; }

        [StringLength(255)]
        public string Descricao { get; set; }

        [Range(0.01, 10000.00)]
        public decimal Preco { get; set; }

        [Range(0, int.MaxValue)]
        public int Estoque { get; set; }

        [StringLength(50)]
        public string Categoria { get; set; }

        [DataType(DataType.Date)]
        public DateTime DataCadastro { get; set; } = DateTime.Now;
    }
}
