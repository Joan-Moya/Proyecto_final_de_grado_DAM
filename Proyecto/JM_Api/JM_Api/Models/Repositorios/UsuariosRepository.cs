using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JM_Api.Models.Repositorios
{
    public class UsuariosRepository
    {
        /// <summary>
        /// Método que te devuelve una lista con todos los usuarios.
        /// </summary>
        /// <returns>Lista usuarios</returns>
        internal List<Usuario> Retrieve()
        {
            List<Usuario> arrayUs = new List<Usuario>();
            using (JMContext context = new JMContext())
            {
                arrayUs = context.Usuarios
                    .ToList();
            }
            return arrayUs;
        }
        /// <summary>
        /// Método que añade un usuario a la base de datos.
        /// </summary>
        /// <param name="us">Objeto Usuario</param>
        internal void Save(Usuario us)
        {
            JMContext context = new JMContext();
            context.Usuarios.Add(us);
            context.SaveChanges();
        }
    }
}