using Konatus.ABCD_Airlines.Core.Entity;
using Konatus.ABCD_Airlines.Core.Interfaces.Services;
using Konatus.ABCD_Airlines.Web.Models;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Konatus.ABCD_Airlines.Web.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ModeloAeronaveController : ApiController
    {
        private readonly IModeloAeronaveService _modeloaeronaveservice;

        public ModeloAeronaveController(IModeloAeronaveService modeloAeronaveService)
        {
            _modeloaeronaveservice = modeloAeronaveService;
        }

        // GET: api/ModeloAeronave
        [HttpGet]
        public IHttpActionResult Get()
        {
            try
            {
                var modelos = AutoMapper.Mapper.Map<IEnumerable<ModeloAeronave>, IEnumerable<ViewmodelModeloAeronave>>(_modeloaeronaveservice.ObterTodos());
                if (modelos != null)
                {
                    return Ok(modelos);
                }
                return NotFound();
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET: api/ModeloAeronave/5
        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            try
            {
                var aeronave = AutoMapper.Mapper.Map<ModeloAeronave, ViewmodelModeloAeronave>(_modeloaeronaveservice.ObterPorId(id));
                if (aeronave != null)
                {
                    return Ok(aeronave);
                }
                return NotFound();
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST: api/ModeloAeronave
        [HttpPost]
        public IHttpActionResult Post([FromBody]ViewmodelModeloAeronave modeloaeronave)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _modeloaeronaveservice.Adicionar(AutoMapper.Mapper.Map<ViewmodelModeloAeronave, ModeloAeronave>(modeloaeronave));
                }
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return Ok();
        }

        // PUT: api/ModeloAeronave/5
        [HttpPut]
        public IHttpActionResult Put(int id, [FromBody]ViewmodelModeloAeronave modeloaeronave)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _modeloaeronaveservice.Atualizar(AutoMapper.Mapper.Map<ViewmodelModeloAeronave, ModeloAeronave>(modeloaeronave));
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return Ok();
        }

        // DELETE: api/ModeloAeronave/5
        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            try
            {
                _modeloaeronaveservice.Remover(id);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return Ok();
        }
    }
}
