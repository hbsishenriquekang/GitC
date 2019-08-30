using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using Locacao.Models;

namespace Locacao.Controllers
{
    public class MotoModeloesController : ApiController
    {
        private ContextDB db = new ContextDB();

        // GET: api/MotoModeloes
        [Route("Api/MotoModeloes/{codigo}/GetTermoByCodigo")]
        [HttpGet]
        public IEnumerable<MotoModelo> GetTermoByTipo(int codigo)
        {

            return db.MotoModelos.Where(x => x.CodigoFK == codigo);

        }
        public IQueryable<MotoModelo> GetMotoModelos()
        {
            return db.MotoModelos;
        }

        // GET: api/MotoModeloes/5
        [ResponseType(typeof(MotoModelo))]
        public async Task<IHttpActionResult> GetMotoModelo(int id)
        {
            MotoModelo motoModelo = await db.MotoModelos.FindAsync(id);
            if (motoModelo == null)
            {
                return NotFound();
            }

            return Ok(motoModelo);
        }

        // PUT: api/MotoModeloes/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutMotoModelo(int id, MotoModelo motoModelo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != motoModelo.Id)
            {
                return BadRequest();
            }

            db.Entry(motoModelo).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MotoModeloExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/MotoModeloes
        [ResponseType(typeof(MotoModelo))]
        public async Task<IHttpActionResult> PostMotoModelo(MotoModelo motoModelo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.MotoModelos.Add(motoModelo);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = motoModelo.Id }, motoModelo);
        }

        // DELETE: api/MotoModeloes/5
        [ResponseType(typeof(MotoModelo))]
        public async Task<IHttpActionResult> DeleteMotoModelo(int id)
        {
            MotoModelo motoModelo = await db.MotoModelos.FindAsync(id);
            if (motoModelo == null)
            {
                return NotFound();
            }

            db.MotoModelos.Remove(motoModelo);
            await db.SaveChangesAsync();

            return Ok(motoModelo);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool MotoModeloExists(int id)
        {
            return db.MotoModelos.Count(e => e.Id == id) > 0;
        }
    }
}