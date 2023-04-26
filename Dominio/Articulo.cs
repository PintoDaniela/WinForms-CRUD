using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Dominio
{
    internal class Articulo
    {
        public int id { set; get; }
        public string name { set; get; }
        public string descripcion { set; get; }
        public float precio { set; get; }
        public Marca marca { set; get; }
        public Categoria categoria { set; get; }
        // public Imagen imagen { set; get; }
        public bool estado { set; get; }

        public Articulo()
        {
            estado = true;
        }
    }
}

