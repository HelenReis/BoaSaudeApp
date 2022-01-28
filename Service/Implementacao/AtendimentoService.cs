using Dominio.AtendimentoModel;
using Repositorio.Interface;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service.Implementacao
{
    public class AtendimentoService : IAtendimentoService
    {
        private readonly IAtendimentoRepositorio _repositorio;

        public AtendimentoService(IAtendimentoRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public async Task<IEnumerable<Atendimento>> ListarAtendimentos()
        {
            return await _repositorio.GetAllAsync(
                "Associado",
                "Associado.Plano",
                "Conveniado",
                "Prestador",
                "Cidade");
        }

        public async Task NovoAtendimento(Atendimento atendimento)
        {
            await _repositorio.AddAsync(atendimento);
        }
    }
}
