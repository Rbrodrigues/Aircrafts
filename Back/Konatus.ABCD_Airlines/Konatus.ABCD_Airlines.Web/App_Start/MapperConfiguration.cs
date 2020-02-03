using Konatus.ABCD_Airlines.Core.Entity;
using Konatus.ABCD_Airlines.Web.Models;

namespace Konatus.ABCD_Airlines.Web.App_Start
{
    public class AutomapperWebProfile : AutoMapper.Profile
    {
        public AutomapperWebProfile()
        {
            CreateMap<ViewmodelAeronave, Aeronave>();
            CreateMap<Aeronave, ViewmodelAeronave>();

            CreateMap<ViewmodelModeloAeronave, ModeloAeronave>();
            CreateMap<ModeloAeronave, ViewmodelModeloAeronave>();
        }

        public static void Run()
        {
            AutoMapper.Mapper.Initialize(m =>
            {
                m.AddProfile<AutomapperWebProfile>();
            });
        }

    }
}