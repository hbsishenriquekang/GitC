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
using LocacaoGaragem.Models;

namespace LocacaoGaragem.Controllers
{
    public class AutomovelModeloesController : ApiController
    {
        private ContextDB db = new ContextDB();

        // GET: api/AutomovelModeloes
        public IQueryable<AutomovelModelo> GetAutomovelModelos()
        {
            return db.AutomovelModelos;
        }

        // GET: api/AutomovelModeloes/5
        [ResponseType(typeof(AutomovelModelo))]
        public async Task<IHttpActionResult> GetAutomovelModelo(int id)
        {
            AutomovelModelo automovelModelo = await db.AutomovelModelos.FindAsync(id);
            if (automovelModelo == null)
            {
                return NotFound();
            }

            return Ok(automovelModelo);
        }

        // PUT: api/AutomovelModeloes/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutAutomovelModelo(int id, AutomovelModelo automovelModelo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != automovelModelo.Id)
            {
                return BadRequest();
            }

            db.Entry(automovelModelo).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AutomovelModeloExists(id))
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

        // POST: api/AutomovelModeloes
        [ResponseType(typeof(AutomovelModelo))]
        public async Task<IHttpActionResult> PostAutomovelModelo(AutomovelModelo automovelModelo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.AutomovelModelos.Add(automovelModelo);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = automovelModelo.Id }, automovelModelo);
        }

        // DELETE: api/AutomovelModeloes/5
        [ResponseType(typeof(AutomovelModelo))]
        public async Task<IHttpActionResult> DeleteAutomovelModelo(int id)
        {
            AutomovelModelo automovelModelo = await db.AutomovelModelos.FindAsync(id);
            if (automovelModelo == null)
            {
                return NotFound();
            }

            db.AutomovelModelos.Remove(automovelModelo);
            await db.SaveChangesAsync();

            return Ok(automovelModelo);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool AutomovelModeloExists(int id)
        {
            return db.AutomovelModelos.Count(e => e.Id == id) > 0;
        }
    }
}