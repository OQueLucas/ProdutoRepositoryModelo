using System.ComponentModel.DataAnnotations;

namespace ProdutoRepositoryModelo.Entities
{
    public class BaseEntity
    {

        [Key]
        public int Id { get; set; }
    }
}
