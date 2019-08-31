using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Nombres
// Clases deben partir en mayuscula
// Funciones deben partir en mayuscula
// Propiedades = funciones = parten en mayuscula
// Todo lo demas deberia partir en minuscula

// compuesto:
// Nombre_Apellido = Ok pero anticuado
// NombreApellido = camello ok
// Nombreapellido = no ok


namespace Agosto31
{
  class Program
  {
    static void Main(string[] args)
    {
      // primitivo
      int n1=20;
      string texto ="hola";
      double dec=20.5;
      float flotante=20.5f;
      decimal numDecimal=20.5M;

      bool boleano=true; // false;

      char caracter='a';

      Debug.WriteLine(n1);

      // arreglos es finito.
      int[] numeros=new int[10];
      numeros[0]=1;
      numeros[1]=3;

      Debug.WriteLine(numeros[0]);

     // listas
      List<int> listas=new List<int>();
      listas.Add(1);
      listas.Add(3);
      listas.Add(5);

      Debug.WriteLine(listas[0]);

      List<string> paises=new List<string>();
      paises.Add("chile");
      paises.Add("argentina");
      paises.Add("peru");
      Debug.WriteLine("numero de paises "+paises.Count());
     
      int numero5=222; // x 4 byte  = 20m x 4 = 80mb
      int numero6=22; // byte      =           20mb

      numero6 = numero5;




    } // muere n1
  }
}
