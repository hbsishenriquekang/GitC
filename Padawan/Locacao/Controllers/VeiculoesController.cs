using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using Locacao.Models;

namespace Locacao.Controllers
{
    public class VeiculoesController : ApiController
    {
        private ContextDB db = new ContextDB();

        [AcceptVerbs("GET")]
        [Route("api/Locacoes/RelatorioMensal/{tipo}/{mes}/{ano}")]
        [ResponseType(typeof(Veiculo))]
        public IList<Veiculo> GetLocacao(int mes, int ano, int tipo)
        {
            var inicio = db.TipoVeiculos.Where(x => x.Id == mes);
            var final = db.TipoVeiculos.Where(x => x.Id == ano);
            var tipoV = db.TipoVeiculos.Where(x => x.Id == tipo);

            var usuarios = db.Veiculos.Include(x => x.UsuarioFK).ToList();
            var marca = db.Veiculos.Include(x => x.MarcaFK).Include(x => x.Modelo);
            var cor = db.Veiculos.Include(x => x.CorFK).ToList();


            var relatorioTemp =
                from VeiculoTemp in db.Veiculos
                join TipoVeiculoTemp in db.TipoVeiculos on VeiculoTemp.TipoFK equals TipoVeiculoTemp.Id
                join UsuarioTemp in db.Usuarios on VeiculoTemp.UsuarioFK equals UsuarioTemp.Id
                join MarcaTemp in db.AutomovelMarcas on VeiculoTemp.MarcaFK equals MarcaTemp.Id
                join ModeloTemp in db.AutomovelModelos on VeiculoTemp.Modelo equals ModeloTemp.Id



                select new Veiculo
                {


                };




        }


        // GET: api/Veiculoes
        public IQueryable<Veiculo> GetVeiculos()
        {
            return db.Veiculos;
        }

        // GET: api/Veiculoes/5
        [ResponseType(typeof(Veiculo))]
        public async Task<IHttpActionResult> GetVeiculo(int id)
        {
            Veiculo veiculo = await db.Veiculos.FindAsync(id);
            if (veiculo == null)
            {
                return NotFound();
            }

            return Ok(veiculo);
        }

        // PUT: api/Veiculoes/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutVeiculo(int id, Veiculo veiculo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != veiculo.Id)
            {
                return BadRequest();
            }

            db.Entry(veiculo).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VeiculoExists(id))
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

        // POST: api/Veiculoes
        [ResponseType(typeof(Veiculo))]
        public async Task<IHttpActionResult> PostVeiculo(Veiculo veiculo)
        {
            
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Veiculos.Add(veiculo);
            await db.SaveChangesAsync();

            return Ok("Sua intenção de locação foi realizada com sucesso! Entraremos em contato para confirmar e seguir com as orientações de acesso");
        }
        


        // DELETE: api/Veiculoes/5
        [ResponseType(typeof(Veiculo))]
        public async Task<IHttpActionResult> DeleteVeiculo(int id)
        {
            Veiculo veiculo = await db.Veiculos.FindAsync(id);
            if (veiculo == null )
            {
                return NotFound();
            }

            db.Veiculos.Remove(veiculo);
            await db.SaveChangesAsync();

            return Ok(veiculo);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool VeiculoExists(int id)
        {
            return db.Veiculos.Count(e => e.Id == id) > 0;
        }
    }
}