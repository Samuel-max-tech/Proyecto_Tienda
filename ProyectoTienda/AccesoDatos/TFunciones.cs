using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{ 
    public interface TFunciones
    {
        string Guardar(dynamic Entidad);
        DataSet Mostrar(string f);
        string Borrar(dynamic Entidad);
        void Modificar(dynamic Entidad);
    }
}
