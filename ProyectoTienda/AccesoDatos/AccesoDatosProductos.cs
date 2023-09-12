using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class AccesoDatosProductos
    {
        Base b = new Base();
        public string Borrar(dynamic Entidad)
        {
            return b.Comando(string.Format("delete from productos where idproductos={0}", Entidad._Idproductos));
        }

        public string Guardar(dynamic Entidad)
        {
            return b.Comando(string.Format("insert into productos values(null,'{0}','{1}',{2})",
            Entidad._Nombre,Entidad._Descripcion,Entidad._Precio));
        }

        public void Modificar(dynamic Entidad)
        {
            b.Comando(string.Format("update productos set nommbre='{1}',descripcion='{2}', precio={3}, where idproducto={0}",
             Entidad._Nombre, Entidad._Descripcion, Entidad._Precio, Entidad._Idproductos));
        }

        public DataSet Mostrar(string f)
        {
            return b.Mostrar(string.Format("select * from productos where nommbre like '%{0}%'", f), "productos");
        }
}
}
