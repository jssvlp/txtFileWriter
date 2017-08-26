using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace txtFileWriter
{
    public class FileWriter
    {
        private string path;
        private string texto;


        public FileWriter()
        {
            this.path = texto;
        }
        public void EscribirArchivo(string texto )
        {

            try {
                if (!File.Exists(path))
                {
                    File.Create(path);
                    StreamWriter sw = new StreamWriter(path);
                    sw.WriteLine(texto + " " + DateTime.Now);
                    Console.WriteLine("Archivo creado y escrito");
                    sw.Close();
                }
                else
                {
                    StreamWriter sw = File.AppendText(path);
                    sw.WriteLine(texto + " " + DateTime.Now);
                    sw.Close();
                }
                
            }
            catch (IOException ex) {
                throw ex;
            }
        }
    }
}
