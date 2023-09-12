using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manejador
{
    public class Complementos
    {
        public DataGridViewButtonColumn Boton(string t)
        {
            return new DataGridViewButtonColumn()
            {
                Text = t,
                UseColumnTextForButtonValue = true
            };
        }
    }
}
