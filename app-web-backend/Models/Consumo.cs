using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace app_web_backend.Models
{
    [Table("Consumos")]
    public class Consumo
    {
        [Key]
        public int Id { get; set; }

        [Display(Name ="Descrição")]
        [Required(ErrorMessage ="Ogrigatório informar a descrição!")]
        public int Descricao { get; set; }

        [Required(ErrorMessage = "Ogrigatório informar a data!")]
        public DateTime Data { get; set; }

        [Required(ErrorMessage = "Ogrigatório informar a Quilometragem!")]
        public int Km { get; set; }

        [Required(ErrorMessage = "Ogrigatório informar o valor!")]
        [Column(TypeName ="decimal(18,2)")]
        public decimal Valor { get; set; }

        [Display(Name = "Tipo de Combustível")]
        [Required(ErrorMessage = "Ogrigatório informar o tipo!")]
        public TipoCombustivel Tipo { get; set; }

        [Display(Name = "Veículo")]
        [Required(ErrorMessage = "Ogrigatório informar o tipo!")]
        public int VeiculoId { get; set; }

        [ForeignKey("VeiculoId")]
        public Veiculo Veiculo { get; set; }
    }

    public enum TipoCombustivel
    {
        Gasolina,
        Etanol
    }
}
