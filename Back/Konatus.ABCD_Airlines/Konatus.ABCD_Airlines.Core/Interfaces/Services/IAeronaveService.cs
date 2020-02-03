using Konatus.ABCD_Airlines.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Konatus.ABCD_Airlines.Core.Interfaces.Services
{

    public interface IAeronaveService
    {
        Aeronave Adicionar(Aeronave entity);
        void Atualizar(Aeronave entity);
        IEnumerable<Aeronave> ObterTodos();
        Aeronave ObterPorId(int id);
        void Remover(int id);
    }
}