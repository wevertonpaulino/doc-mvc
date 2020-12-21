using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DocMvc.UI.ViewModels
{
    public class DocumentoViewModel
    {
        [Key]
        [DisplayName("Código")]
        public int Codigo { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [StringLength(maximumLength: 100, MinimumLength = 2, ErrorMessage = "O campo {0} deve ter no mínimo {2} e no máximo {1} caracteres.")]
        [DisplayName("Título")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [MaxLength(1, ErrorMessage = "Máximo de {1} caractere.")]
        [MinLength(1, ErrorMessage = "Mínimo de {1} caractere.")]
        [DisplayName("Revisão")]
        public string Revisao { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [DisplayName("Data Planejada")]
        public DateTime DataPlanejada { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [DataType(DataType.Currency)]
        public decimal Valor { get; set; }
    }
}