using Dominio.AtendimentoModel;
using Dominio.PlanoModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.UsuarioModel
{
    public class Associado : UsuarioBase, IClasseBase
    {
        public Associado(
            string nome,
            DateTime dataNascimento,
            StatusAssociadoEnum status,
            int planoId)
        {
            Nome = nome;
            DataNascimento = dataNascimento;
            Status = status;
            PlanoId = planoId;
        }
        private decimal _valorPlanoAdicional;
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public StatusAssociadoEnum Status { get; set; }
        public int PlanoId { get; set; }
        public int QuantidadeExamesAno { get; private set; }
        public bool PossuiOdontologico { get; private set; }
        public decimal ValorPlanoAdicional
        {
            get => CalcularValorPlanoPorIdade();
            private set
            {
                _valorPlanoAdicional = CalcularValorPlanoPorIdade();
            }
        }
        public virtual Plano Plano { get; set; }
        public virtual List<Atendimento> Atendimentos { get; set; }
        public int Id { get ; set; }

        public int CalcularIdade()
        {
            var idade = DateTime.Now.Year - DataNascimento.Year;

            if (DateTime.Now.DayOfYear < DataNascimento.DayOfYear)
                idade--;

            return idade;
        }

        private decimal CalcularValorPlanoPorIdade()
        {
            var idade = CalcularIdade();

            if (idade > 25 && idade < 30)
                return 50;

            if (idade > 30 && idade < 35)
                return 120;

            if (idade > 35 && idade < 40)
                return 180;

            if (idade > 40 && idade < 45)
                return 260;

            if (idade > 45 && idade < 55)
                return 400;

            if (idade > 55 && idade < 65)
                return 600;

            if (idade > 65)
                return 1000;

            return 0;
        }
    }
}
