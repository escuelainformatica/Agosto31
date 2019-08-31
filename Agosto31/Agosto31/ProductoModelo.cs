using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agosto31
{
  // clase de modelo
  // clase de dominio anemico

  // quiero solo campos, no funcion
  class ProductoModelo
  {
    // campos
    private string nombre;


    // antigua
    public string Nombre
    {
      get { return nombre; }
      set { nombre = value; }
    }

    // propiedad
    public int Precio { set; get; }



  }
}
