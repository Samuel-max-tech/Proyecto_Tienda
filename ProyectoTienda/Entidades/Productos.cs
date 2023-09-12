using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Productos
    {
        public Productos(int idproductos, string nombre, string descripcion, double precio)
        {
            _Idproductos = idproductos;
            _Nombre = nombre;
            _Descripcion = descripcion;
            _Precio = precio;
        }

        public int _Idproductos { get; set; }
        public string _Nombre { get; set; }
        public string _Descripcion { get; set; }
        public double _Precio { get; set; }
    }
}
