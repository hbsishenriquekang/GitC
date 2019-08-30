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
    public class PatinetesController : ApiController
    {
        private ContextDB db = new ContextDB();

        // GET: api/Patinetes
        public IQueryable<Patinete> GetPatinetes()
        {
            return db.Patinetes;
        }

        // GET: api/Patinetes/5
        [ResponseType(typeof(Patinete))]
        public async Task<IHttpActionResult> GetPatinete(int id)
        {
            Patinete patinete = await db.Patinetes.FindAsync(id);
            if (patinete == null)
            {
                return NotFound();
            }

            return Ok(patinete);
        }

        // PUT: api/Patinetes/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutPatinete(int id, Patinete patinete)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != patinete.Id)
            {
                return BadRequest();
            }

            db.Entry(patinete).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PatineteExists(id))
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

        // POST: api/Patinetes
        [ResponseType(typeof(Patinete))]
        public async Task<IHttpActionResult> PostPatinete(Patinete patinete)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Patinetes.Add(patinete);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = patinete.Id }, patinete);
        }

        // DELETE: api/Patinetes/5
        [ResponseType(typeof(Patinete))]
        public async Task<IHttpActionResult> DeletePatinete(int id)
        {
            Patinete patinete = await db.Patinetes.FindAsync(id);
            if (patinete == null)
            {
                return NotFound();
            }

            db.Patinetes.Remove(patinete);
            await db.SaveChangesAsync();

            return Ok(patinete);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PatineteExists(int id)
        {
            return db.Patinetes.Count(e => e.Id == id) > 0;
        }
    }
}