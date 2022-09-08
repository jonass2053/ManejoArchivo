using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace poo
{
    public class TestManejador
    {

        static void  Main(string[] args)
        {


            //string NombreArchivo = "c:\\io\\file.txt";
            //FileStream strean = new FileStream(NombreArchivo, FileMode.Open, FileAccess.Read);
            //StreamReader reader =new StreamReader(strean);
            //while(reader.Read()>-1)
            //{
            //    Console.WriteLine(reader.ReadLine()); 
            //}
            //reader.Close();


            //string NombreArchivo = "c:\\io\\archivosalida.txt";
            //FileStream stream = new FileStream(NombreArchivo, FileMode.Append, FileAccess.Write);
            //StreamWriter write = new StreamWriter(stream);
            //write.WriteLine("Este documento funsiona?");
            //write.Close();
            string Ruta = "c:\\io\\"; 
            string NombreArchivo = "myfamily.txt";
            string NombreCompleto = Ruta + NombreArchivo;
            string[] contenido = {"Jonas Dias Duran", "Dianelis Nivar Matos", "Alaia Silena Diaz Nivar"};
            ManejadorDeArchivos.GuardarArchivo(NombreCompleto, contenido);
            string NombreCompletoCopia = Ruta +"Copia"+NombreArchivo;
            ManejadorDeArchivos.CopiaArchivo(NombreCompleto,  NombreCompletoCopia);
            
        }

    }
}
