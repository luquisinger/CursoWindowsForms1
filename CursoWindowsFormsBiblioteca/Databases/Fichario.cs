using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CursoWindowsFormsBiblioteca.Databases
{
    
    public class Fichario
    {
        public string diretorio;
        public string mensagem;
        public bool status;
        public Fichario(string Diretorio) 
        {
            status = true; 
            
            try{                

                if(!(Directory.Exists( Diretorio)))
                {
                Directory.CreateDirectory(Diretorio);
                }
                mensagem = "Conexão está: " + status;
                diretorio=Diretorio;
            }
            catch(Exception ex)
            {
                mensagem = "Conexão está: " + status +" porque:  " +ex.Message;
                status=false;
            }
        }
    }
}
