using System.ComponentModel.DataAnnotations;

namespace BrechoRamiresControle.Models
{
    public class Produto
    {
        [Key]
        public string Codigo { get; set; }

        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public string Marca { get; set; }     
        public string Categoria { get; set; }
        public string Cor { get; set; }
        public string Tamanho { get; set; }
        public decimal PrecoPago { get; set; }
        public decimal Preco { get; set; }
        public int Origem { get; set; }

    }
}