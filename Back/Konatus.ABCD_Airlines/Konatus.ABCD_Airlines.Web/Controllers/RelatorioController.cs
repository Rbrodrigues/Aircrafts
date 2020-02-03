using Konatus.ABCD_Airlines.Core.Entity;
using Konatus.ABCD_Airlines.Core.Interfaces.Services;
using Konatus.ABCD_Airlines.Web.Models;
using System.Collections.Generic;
using System.IO;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Konatus.ABCD_Airlines.Web.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class RelatorioController : ApiController
    {
        private readonly IRelatorioService _relatorioservice;

        public RelatorioController(IRelatorioService relatorioservice)
        {
            _relatorioservice = relatorioservice;
        }
        // GET api/<controller>
        [HttpGet]
        public IHttpActionResult RelatorioAeronavesAtivas()
        {
            try
            {
                var relatorio = AutoMapper.Mapper.Map<IEnumerable<Aeronave>, IEnumerable<ViewmodelAeronave>>(_relatorioservice.ObterTodasAeronavesAtivas());
                if (relatorio != null)
                {
                    return Ok(relatorio);
                }
                else
                {
                    return NotFound();
                }
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }




        [HttpPost]
        public IHttpActionResult RelatorioExcel()
        {
            return Ok();
        }


        public void Import(HttpPostedFileBase postedFile)
        {
            string filePath = string.Empty;
            if (postedFile != null)
            {
                string path = System.Web.HttpContext.Current.Server.MapPath("~/Uploads/");
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                filePath = path + Path.GetFileName(postedFile.FileName);
                string extension = Path.GetExtension(postedFile.FileName);
                postedFile.SaveAs(filePath);

                
                //string csvData = System.IO.File.ReadAllText(filePath);

                //foreach (string row in csvData.Split('\n'))
                //{
                //    if (!string.IsNullOrEmpty(row))
                //    {
                //        Aeronave.Add(new CustomerModel
                //        {
                //            CustomerId = Convert.ToInt32(row.Split(',')[0]),
                //            Name = row.Split(',')[1],
                //            Country = row.Split(',')[2]
                //        });
                //    }
                //}
            }
        }

    }
}
     