using Konatus.ABCD_Airlines.Core.Entity;
using System.Collections.Generic;

namespace Konatus.ABCD_Airlines.Core.Interfaces.Services
{
    public interface IRelatorioService
    {
        IEnumerable<Aeronave> ObterTodasAeronavesAtivas();
    }
}
