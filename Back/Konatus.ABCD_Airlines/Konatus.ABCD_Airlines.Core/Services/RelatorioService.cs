using System.Collections.Generic;
using Konatus.ABCD_Airlines.Core.Entity;
using Konatus.ABCD_Airlines.Core.Interfaces.Repository;
using Konatus.ABCD_Airlines.Core.Interfaces.Services;

namespace Konatus.ABCD_Airlines.Core.Services
{
    public class RelatorioService : IRelatorioService
    {
        private readonly IRelatorioRepository _relatorioRepository;

        public RelatorioService(IRelatorioRepository relatorioRepository)
        {
            _relatorioRepository = relatorioRepository;
        }

        public IEnumerable<Aeronave> ObterTodasAeronavesAtivas()
        {
            return _relatorioRepository.ObterTodasAeronavesAtivas();
        }
    }
}
