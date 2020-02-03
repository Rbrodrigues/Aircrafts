using Konatus.ABCD_Airlines.Core.Entity;
using System.Collections.Generic;

namespace Konatus.ABCD_Airlines.Core.Interfaces.Repository
{
    public interface IRelatorioRepository
    {
        IEnumerable<Aeronave> ObterTodasAeronavesAtivas();
    }
}
