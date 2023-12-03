using System.ComponentModel.DataAnnotations;

namespace BrechoRamiresControle.Models
{
    public class Venda
    {
        [Key]
        public int ID { get; set; }

        public DateTime DataVenda { get; set; }
        public decimal Valor { get; set; }
        public decimal Desconto { get; set; }
        public string FormaDePagamento { get; set; }
        public string Cliente { get; set; }
        public int Vendedor { get; set; }
        public List<Produto> Produtos { get; set; }

    }
}
