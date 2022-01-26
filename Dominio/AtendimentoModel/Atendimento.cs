using Dominio.Usuario;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.AtendimentoModel
{
    public class Atendimento : IClasseBase
    {
        public Atendimento(
            decimal valor,
            //StatusProcessoEnum statusProcesso,
            int prestadorId,
            int conveniadoId,
            DateTime dataHorarioAgendamento,
            int associadoId)
        {
            Valor = valor;
            //StatusProcesso = statusProcesso;
            DataHorarioAgendamento = dataHorarioAgendamento;
            AssociadoId = associadoId;
            PrestadorId = prestadorId;
            ConveniadoId = conveniadoId;
            /*CidadeId = cidadeId;*/
        }

        public decimal Valor { get; private set; }
        public DateTime DataHorarioAgendamento { get; set; }
        /*public StatusProcessoEnum StatusProcesso { get; private set; }
        public int CidadeId { get; set; }
        public Cidade Cidade { get; set; }*/
        public int AssociadoId { get; private set; }
        public virtual Associado Associado { get; }
        public int ConveniadoId { get; private set; }
        public virtual Conveniado Conveniado { get; }
        public int PrestadorId { get; private set; }
        public virtual Prestador Prestador { get; }
        public int Id { get; set; }
    }
}
