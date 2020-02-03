using Konatus.ABCD_Airlines.Core.Entity;
using Konatus.ABCD_Airlines.Core.Interfaces.Services;
using Konatus.ABCD_Airlines.Web.Models;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Konatus.ABCD_Airlines.Web.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class AeronaveController : ApiController
    {
        private readonly IAeronaveService _aeronaveservice;

        public AeronaveController(IAeronaveService aeronaveservice)
        {
            _aeronaveservice = aeronaveservice;
        }
        // GET api/<controller>
        [HttpGet]
        public IHttpActionResult Get()
        {
            try
            {
                var aeronaves =  AutoMapper.Mapper.Map<IEnumerable<Aeronave>, IEnumerable<ViewmodelAeronave>>(_aeronaveservice.ObterTodos());
                if (aeronaves != null)
                {
                    return Ok(aeronaves);
                }
                return NotFound();
 
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
        }

        // GET api/<controller>/5
        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            try
            {
                var aeronave = AutoMapper.Mapper.Map<Aeronave, ViewmodelAeronave>(_aeronaveservice.ObterPorId(id));
                if (aeronave == null)
                {
                    return NotFound();
                }
                return Ok(aeronave);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST api/<controller>
        [HttpPost]
        public IHttpActionResult Post([FromBody]ViewmodelAeronave aeronave)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _aeronaveservice.Adicionar(AutoMapper.Mapper.Map<ViewmodelAeronave, Aeronave>(aeronave));
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

        // PUT api/<controller>/5
        [HttpPut]
        public IHttpActionResult Put(int id, [FromBody]ViewmodelAeronave aeronave)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _aeronaveservice.Atualizar(AutoMapper.Mapper.Map<ViewmodelAeronave, Aeronave>(aeronave));
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

        // DELETE api/<controller>/5
        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            try
            {
                _aeronaveservice.Remover(id);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return Ok();
        }
    }
}