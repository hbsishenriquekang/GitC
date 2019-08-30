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
    public class BicicletasController : ApiController
    {
        private ContextDB db = new ContextDB();

        // GET: api/Bicicletas
        public IQueryable<Bicicleta> GetBicicletas()
        {
            return db.Bicicletas;
        }

        // GET: api/Bicicletas/5
        [ResponseType(typeof(Bicicleta))]
        public async Task<IHttpActionResult> GetBicicleta(int id)
        {
            Bicicleta bicicleta = await db.Bicicletas.FindAsync(id);
            if (bicicleta == null)
            {
                return NotFound();
            }

            return Ok(bicicleta);
        }

        // PUT: api/Bicicletas/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutBicicleta(int id, Bicicleta bicicleta)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != bicicleta.Id)
            {
                return BadRequest();
            }

            db.Entry(bicicleta).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BicicletaExists(id))
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

        // POST: api/Bicicletas
        [ResponseType(typeof(Bicicleta))]
        public async Task<IHttpActionResult> PostBicicleta(Bicicleta bicicleta)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Bicicletas.Add(bicicleta);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = bicicleta.Id }, bicicleta);
        }

        // DELETE: api/Bicicletas/5
        [ResponseType(typeof(Bicicleta))]
        public async Task<IHttpActionResult> DeleteBicicleta(int id)
        {
            Bicicleta bicicleta = await db.Bicicletas.FindAsync(id);
            if (bicicleta == null)
            {
                return NotFound();
            }

            db.Bicicletas.Remove(bicicleta);
            await db.SaveChangesAsync();

            return Ok(bicicleta);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool BicicletaExists(int id)
        {
            return db.Bicicletas.Count(e => e.Id == id) > 0;
        }
    }
}