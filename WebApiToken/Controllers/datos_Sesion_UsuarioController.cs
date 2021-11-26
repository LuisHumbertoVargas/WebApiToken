using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using WebApiToken.Models;
using WebApiToken.Services;

namespace WebApiToken.Controllers
{
    // [Authorize]
    [RoutePrefix("api/customers")]
    public class datos_Sesion_UsuarioController : ApiController
    {
        private Model1 db = new Model1();

        // GET: api/datos_Sesion_Usuario
        public IQueryable<datos_Sesion_Usuario> Getdatos_Sesion_Usuario()
        {
            return db.datos_Sesion_Usuario;
        }

        // GET: api/datos_Sesion_Usuario/5
        [ResponseType(typeof(datos_Sesion_Usuario))]
        public IHttpActionResult Getdatos_Sesion_Usuario(int id)
        {
            datos_Sesion_Usuario datos_Sesion_Usuario = db.datos_Sesion_Usuario.Find(id);
            if (datos_Sesion_Usuario == null)
            {
                return NotFound();
            }

            return Ok(datos_Sesion_Usuario);
        }

        // PUT: api/datos_Sesion_Usuario/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Putdatos_Sesion_Usuario(int id, datos_Sesion_Usuario datos_Sesion_Usuario)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != datos_Sesion_Usuario.id_usuario)
            {
                return BadRequest();
            }

            db.Entry(datos_Sesion_Usuario).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!datos_Sesion_UsuarioExists(id))
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

        // POST: api/datos_Sesion_Usuario
        [HttpPost]
        [ResponseType(typeof(datos_Sesion_Usuario))]
        public IHttpActionResult Postdatos_Sesion_Usuario(datos_Sesion_Usuario datos_Sesion_Usuario)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            datos_Sesion_Usuario.password_usuario = Encripted_SHA256.SHA256Encrypt(datos_Sesion_Usuario.password_usuario);
            db.datos_Sesion_Usuario.Add(datos_Sesion_Usuario);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (datos_Sesion_UsuarioExists(datos_Sesion_Usuario.id_usuario))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = datos_Sesion_Usuario.id_usuario }, datos_Sesion_Usuario);
        }

        // DELETE: api/datos_Sesion_Usuario/5
        [ResponseType(typeof(datos_Sesion_Usuario))]
        public IHttpActionResult Deletedatos_Sesion_Usuario(int id)
        {
            datos_Sesion_Usuario datos_Sesion_Usuario = db.datos_Sesion_Usuario.Find(id);
            if (datos_Sesion_Usuario == null)
            {
                return NotFound();
            }

            db.datos_Sesion_Usuario.Remove(datos_Sesion_Usuario);
            db.SaveChanges();

            return Ok(datos_Sesion_Usuario);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool datos_Sesion_UsuarioExists(int id)
        {
            return db.datos_Sesion_Usuario.Count(e => e.id_usuario == id) > 0;
        }
    }
}