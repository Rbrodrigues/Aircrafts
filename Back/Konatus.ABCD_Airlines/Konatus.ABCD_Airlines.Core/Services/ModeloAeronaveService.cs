using Konatus.ABCD_Airlines.Core.Entity;
using Konatus.ABCD_Airlines.Core.Interfaces.Repository;
using Konatus.ABCD_Airlines.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Konatus.ABCD_Airlines.Core.Services
{
    public class ModeloAeronaveService : IModeloAeronaveService
    {
        private readonly IModeloAeronaveRepository _modeloAeronaveRepository;

        public ModeloAeronaveService(IModeloAeronaveRepository modeloAeronaveRepository)
        {
            _modeloAeronaveRepository = modeloAeronaveRepository;
        }

        public ModeloAeronave Adicionar(ModeloAeronave entity)
        {
            return _modeloAeronaveRepository.Adicionar(entity);
        }

        public void Atualizar(ModeloAeronave entity)
        {
            _modeloAeronaveRepository.Atualizar(entity);
        }

        public ModeloAeronave ObterPorId(int id)
        {
            return _modeloAeronaveRepository.ObterPorId(id);
        }

        public IEnumerable<ModeloAeronave> ObterTodos()
        {
            return _modeloAeronaveRepository.ObterTodos();
        }

        public void Remover(int id)
        {
            _modeloAeronaveRepository.Remover(id);
        }
    }
}
