using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agosto31
{
  // clase de servicio
  // quiero funciones, no quiero campos 

  class ProductoServicio
  {
      public void Mostrar(ProductoModelo prod)
      {
          Debug.WriteLine(prod.Nombre);
      }
      public void Mostrar(string nombre,int precio,int categoria)
      {

      }
      public static void MostrarEstatico(ProductoModelo prod)
      {
        Debug.WriteLine(prod.Nombre);
      }

  }
}
