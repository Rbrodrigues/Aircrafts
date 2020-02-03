using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Konatus.ABCD_Airlines.Core.Entity;
using Konatus.ABCD_Airlines.Core.Interfaces.Repository;
using Konatus.ABCD_Airlines.Core.Interfaces.Services;

namespace Konatus.ABCD_Airlines.Core.Services
{
    public class AeronaveService : IAeronaveService
    {
        private readonly IAeronaveRepository _aeronaveRepository;

        public AeronaveService(IAeronaveRepository aeronaveRepository)
        {
            _aeronaveRepository = aeronaveRepository;
        }

        public Aeronave Adicionar(Aeronave entity)
        {
            return _aeronaveRepository.Adicionar(entity);
        }

        public void Atualizar(Aeronave entity)
        {
            _aeronaveRepository.Atualizar(entity);
        }

        public Aeronave ObterPorId(int id)
        {
            return _aeronaveRepository.ObterPorId(id);
        }

        public IEnumerable<Aeronave> ObterTodos()
        {
            return _aeronaveRepository.ObterTodos();
        }

        public void Remover(int id)
        {
            _aeronaveRepository.Remover(id);
        }
    }
}
