using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Categoria
    {
        /// <summary>
        ///  ahre se agrega así el comentario
        /// </summary>
        public string Descripcion  { get; set; }

        public int  Id { get; set; }

        public override string ToString ()
        {
            return Descripcion;
        }

        public Categoria (int id, string desc)
        {
            Id = id;
            Descripcion = desc;

        }

        public Categoria() { }
    }
}
