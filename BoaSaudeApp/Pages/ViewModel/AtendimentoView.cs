using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BoaSaudeApp.Pages.ViewModel
{
    public class AtendimentoView
    {
        [Required(ErrorMessage = "Campo associado é obrigatório")]
        public string AssociadoIdSelecionado { get; set; }

        [Required(ErrorMessage = "Campo procedimento é obrigatório!")]
        public string ProcedimentoId { get; set; }

        [Required(ErrorMessage = "Campo convênio é obrigatório")]
        public string ConveniadoIdSelecionado { get; set; }

        [Required(ErrorMessage = "Campo convênio é obrigatório")]
        public DateTime Data { get; set; }

        [Required(ErrorMessage = "Campo convênio é obrigatório")]
        public DateTime Horario { get; set; }

        [Required(ErrorMessage = "Campo convênio é obrigatório")]
        public decimal Valor { get; set; }
    }
}
