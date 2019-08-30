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
    public class AutomovelsController : ApiController
    {
        private ContextDB db = new ContextDB();

        // GET: api/Automovels
        public IQueryable<Automovel> GetAutomoveis()
        {
            return db.Automoveis;
        }

        // GET: api/Automovels/5
        [ResponseType(typeof(Automovel))]
        public async Task<IHttpActionResult> GetAutomovel(int id)
        {
            Automovel automovel = await db.Automoveis.FindAsync(id);
            if (automovel == null)
            {
                return NotFound();
            }

            return Ok(automovel);
        }

        // PUT: api/Automovels/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutAutomovel(int id, Automovel automovel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != automovel.Id)
            {
                return BadRequest();
            }

            db.Entry(automovel).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AutomovelExists(id))
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

        // POST: api/Automovels
        [ResponseType(typeof(Automovel))]
        public async Task<IHttpActionResult> PostAutomovel(Automovel automovel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Automoveis.Add(automovel);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = automovel.Id }, automovel);
        }

        // DELETE: api/Automovels/5
        [ResponseType(typeof(Automovel))]
        public async Task<IHttpActionResult> DeleteAutomovel(int id)
        {
            Automovel automovel = await db.Automoveis.FindAsync(id);
            if (automovel == null)
            {
                return NotFound();
            }

            db.Automoveis.Remove(automovel);
            await db.SaveChangesAsync();

            return Ok(automovel);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool AutomovelExists(int id)
        {
            return db.Automoveis.Count(e => e.Id == id) > 0;
        }
    }
}