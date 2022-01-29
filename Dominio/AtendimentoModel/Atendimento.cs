using Dominio.GeotecnologiaModel;
using Dominio.UsuarioModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.AtendimentoModel
{
    public class Atendimento : IClasseBase
    {
        public Atendimento(
            decimal valor,
            StatusProcessoEnum statusProcesso,
            DateTime dataHorarioAgendamento,
            int prestadorId,
            int conveniadoId,
            int associadoId,
            int cidadeId)
        {
            Valor = valor;
            StatusProcesso = statusProcesso;
            DataHorarioAgendamento = dataHorarioAgendamento;
            AssociadoId = associadoId;
            PrestadorId = prestadorId;
            ConveniadoId = conveniadoId;
            CidadeId = cidadeId;
        }

        public decimal Valor { get; private set; }
        public DateTime DataHorarioAgendamento { get; set; }
        public StatusProcessoEnum StatusProcesso { get; set; }
        public int CidadeId { get; set; }
        public Cidade Cidade { get; set; }
        public int AssociadoId { get; set; }
        public virtual Associado Associado { get; }
        public int ConveniadoId { get; private set; }
        public virtual Conveniado Conveniado { get; }
        public int PrestadorId { get; set; }
        public virtual Prestador Prestador { get; }
        public int Id { get; set; }
    }
}
