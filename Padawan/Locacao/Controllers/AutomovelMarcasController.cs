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
    public class AutomovelMarcasController : ApiController
    {
        private ContextDB db = new ContextDB();

        // GET: api/AutomovelMarcas
        public IQueryable<AutomovelMarca> GetAutomovelMarcas()
        {
            return db.AutomovelMarcas;
        }

        // GET: api/AutomovelMarcas/5
        [ResponseType(typeof(AutomovelMarca))]
        public async Task<IHttpActionResult> GetAutomovelMarca(int id)
        {
            AutomovelMarca automovelMarca = await db.AutomovelMarcas.FindAsync(id);
            if (automovelMarca == null)
            {
                return NotFound();
            }

            return Ok(automovelMarca);
        }

        // PUT: api/AutomovelMarcas/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutAutomovelMarca(int id, AutomovelMarca automovelMarca)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != automovelMarca.Id)
            {
                return BadRequest();
            }

            db.Entry(automovelMarca).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AutomovelMarcaExists(id))
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

        // POST: api/AutomovelMarcas
        [ResponseType(typeof(AutomovelMarca))]
        public async Task<IHttpActionResult> PostAutomovelMarca(AutomovelMarca automovelMarca)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.AutomovelMarcas.Add(automovelMarca);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = automovelMarca.Id }, automovelMarca);
        }

        // DELETE: api/AutomovelMarcas/5
        [ResponseType(typeof(AutomovelMarca))]
        public async Task<IHttpActionResult> DeleteAutomovelMarca(int id)
        {
            AutomovelMarca automovelMarca = await db.AutomovelMarcas.FindAsync(id);
            if (automovelMarca == null)
            {
                return NotFound();
            }

            db.AutomovelMarcas.Remove(automovelMarca);
            await db.SaveChangesAsync();

            return Ok(automovelMarca);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool AutomovelMarcaExists(int id)
        {
            return db.AutomovelMarcas.Count(e => e.Id == id) > 0;
        }
    }
}