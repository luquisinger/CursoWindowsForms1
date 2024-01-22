using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static CursoWindowsFormsBiblioteca.Classes.Cliente;

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
        public void Incluir(string Id, string jsonUnit)
        {
            status = true;
            try
            {

            if(File.Exists(diretorio + "\\" + Id + ".json"))
            {
                status=false;
                mensagem = "inclusao nao permitida pq o identificador já existe: " +Id;
            }
            else
            {
                File.WriteAllText(diretorio + "\\" + Id + ".json", jsonUnit);
                status = true;
                mensagem = "Inclusao efetuada com sucesso. ID: " + Id;
            }
            } catch(Exception ex)
            {
                mensagem = "Conexão está: " + status + " porque:  " + ex.Message;
                status = false;
            }
        }
        public string Buscar(string Id)
        {
            status = true;
            try
            {
                if (!(File.Exists(diretorio + "\\" + Id + ".json")))
                {
                    status = false;
                    mensagem = "Id não existente: " + Id;
                }
                else
                {
                    string conteudo = File.ReadAllText(diretorio + "\\" + Id + ".json");
                    status = true;
                    mensagem = "Inclusao efetuada com sucesso. ID: " + Id;
                    return conteudo;
                }
            }
            catch (Exception ex)
            {
                status = false;
                mensagem = "Erro ao buscar o id do cliente: " + ex.Message;
            }
            return "";
        }
        public List<string> BuscarTodos()
        {
            status = true;
            List<string> List = new List<string>();
            try
            {
                var Arquivos = Directory.GetFiles(diretorio, "*.json");
                for(int i = 0;i <= Arquivos.Length -1; i++)
                {
                    string conteudo = File.ReadAllText(Arquivos[i]);
                    List.Add(conteudo);
                }
                return List;
            }
            catch (Exception ex)
            {
                status = false;
                mensagem = "Erro ao buscar o id do cliente: " + ex.Message;
            }
            return List;
        }
        public void Apagar(string Id)
        {
            status = true;
            try
            {
                if (!(File.Exists(diretorio + "\\" + Id + ".json")))
                {
                    status = false;
                    mensagem = "Id não existente: " + Id;
                }
                else
                {
                    File.Delete(diretorio + "\\" + Id + ".json");
                    status = true;
                    mensagem = "Exclusão efetuada com sucesso. ID: " + Id;
                    
                }
            }
            catch (Exception ex)
            {
                status = false;
                mensagem = "Erro ao buscar o id do cliente: " + ex.Message;
            }
           
        }
        public void Alterar (string Id, string jsonUnit)
        {
            status = true;
            try
            {

                if (File.Exists(diretorio + "\\" + Id + ".json"))
                {
                    status = false;
                    mensagem = "Alteração nao permitida pq o identificador já existe: " + Id;
                }
                else
                {
                    File.Delete(diretorio + "\\" + Id + ".json");
                    File.WriteAllText(diretorio + "\\" + Id + ".json", jsonUnit);
                    status = true;
                    mensagem = "Alteração efetuada com sucesso. Identificador: " + Id;
                }
            }
            catch (Exception ex)
            {
                mensagem = "Conexão está: " + status + " porque:  " + ex.Message;
                status = false;
            }
        }
    }
}
