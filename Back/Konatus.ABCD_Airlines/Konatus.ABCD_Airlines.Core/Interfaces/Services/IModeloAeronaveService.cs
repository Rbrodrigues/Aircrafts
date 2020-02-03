using Konatus.ABCD_Airlines.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Konatus.ABCD_Airlines.Core.Interfaces.Services
{
    public interface IModeloAeronaveService
    {
        ModeloAeronave Adicionar(ModeloAeronave entity);
        void Atualizar(ModeloAeronave entity);
        IEnumerable<ModeloAeronave> ObterTodos();
        ModeloAeronave ObterPorId(int id);
        void Remover(int id);
    }
}
