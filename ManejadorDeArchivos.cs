using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace poo
{
    public class ManejadorDeArchivos
    {

        public static void GuardarArchivo(string nombre, Array arregloString)
        {
            FileStream stream = new FileStream(nombre, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter write = new StreamWriter(stream); 
            
            foreach(var arreglo in arregloString)
            {
                write.WriteLine(arreglo);
            }
            write.Close();
            Console.WriteLine("Se ha Guardado un Archivo correctamente... Presione cualquier tecla para terminar el programa.");
          
        }


        public static void CopiaArchivo(string RutaEntrada,string RutaSalida)
        {
            FileStream stream = new FileStream(RutaEntrada, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
            List<string> Listado = new List<string>();  
         

            while (reader.Peek()>-1)
            {


                Listado.Add(reader.ReadLine());
                
              
            }
           
            reader.Close();

            GuardarArchivo(RutaSalida, Listado.ToArray());

            Console.WriteLine("Se ha Creado una copia de  un Archivo correctamente... Presione cualquier tecla para terminar el programa.");


        }


    }
}
