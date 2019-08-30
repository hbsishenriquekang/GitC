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
    public class MotoMarcasController : ApiController
    {
        private ContextDB db = new ContextDB();

        // GET: api/MotoMarcas
        public IQueryable<MotoMarca> GetMotoMarcas()
        {
            return db.MotoMarcas;
        }

        // GET: api/MotoMarcas/5
        [ResponseType(typeof(MotoMarca))]
        public async Task<IHttpActionResult> GetMotoMarca(int id)
        {
            MotoMarca motoMarca = await db.MotoMarcas.FindAsync(id);
            if (motoMarca == null)
            {
                return NotFound();
            }

            return Ok(motoMarca);
        }

        // PUT: api/MotoMarcas/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutMotoMarca(int id, MotoMarca motoMarca)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != motoMarca.Id)
            {
                return BadRequest();
            }

            db.Entry(motoMarca).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MotoMarcaExists(id))
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

        // POST: api/MotoMarcas
        [ResponseType(typeof(MotoMarca))]
        public async Task<IHttpActionResult> PostMotoMarca(MotoMarca motoMarca)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.MotoMarcas.Add(motoMarca);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = motoMarca.Id }, motoMarca);
        }

        // DELETE: api/MotoMarcas/5
        [ResponseType(typeof(MotoMarca))]
        public async Task<IHttpActionResult> DeleteMotoMarca(int id)
        {
            MotoMarca motoMarca = await db.MotoMarcas.FindAsync(id);
            if (motoMarca == null)
            {
                return NotFound();
            }

            db.MotoMarcas.Remove(motoMarca);
            await db.SaveChangesAsync();

            return Ok(motoMarca);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool MotoMarcaExists(int id)
        {
            return db.MotoMarcas.Count(e => e.Id == id) > 0;
        }
    }
}