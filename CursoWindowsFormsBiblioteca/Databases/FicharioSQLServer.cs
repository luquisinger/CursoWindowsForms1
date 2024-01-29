using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoWindowsFormsBiblioteca.Databases
{
    public class FicharioSQLServer
    {
        public string mensagem;
        public bool status;
        public string tabela;
        public SQLServerClass db;

        public FicharioSQLServer(string Tabela)
        {
            status = true;
            try
            {
                db = new SQLServerClass();
                tabela = Tabela;
                mensagem = "sucesso na conexao ";
            }
            catch (Exception ex) 
            {
                status = false;
                mensagem = "Erro na conexao" + ex.Message;
            }
        }
        public void Incluir(string Id, string jsonUnit)
        {
            status = true;
            try
            {
                //INSERT INTO CLIENTE (ID, JSON) VALUES ('00001','{...}')
                var SQL = "INSERT INTO " + tabela + " (Id, JSON) VALUES ('" + Id + "', '" + jsonUnit + "')";
                db.SQLCommand(SQL);
                status = true;
                mensagem = "Inclusao efetuada com sucesso. ID: " + Id;
                
            }
            catch (Exception ex)
            {
                mensagem = "Conexão está: " + status + " porque:  " + ex.Message;
                status = false;
            }
        }
        public string Buscar(string Id)
        {
            status = true;
            try { 
            //SELECT ID, JSON FROM CLIENTE WHERE ID= '0001'
            var SQL = "SELECT Id, + JSON FROM " + tabela + " WHERE ID = '" + Id + "'";
            var dt = db.SQLQuery(SQL);
                if(dt.Rows.Count > 0)
                {
                
                        string conteudo = dt.Rows[0]["JSON"].ToString();
                        status = true;
                        mensagem = "Inclusao efetuada com sucesso. ID: " + Id;
                        return conteudo;


                }
                else
                {
                    status = false;
                    mensagem = "Id não existente: " + Id;
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
                //SELECT ID, JSON FROM CLIENTE'
                var SQL = "SELECT Id, + JSON FROM " + tabela;
                var dt = db.SQLQuery(SQL);
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i <= dt.Rows.Count - 1; i++)
                    {
                        string conteudo = dt.Rows[i]["JSON"].ToString();
                        List.Add(conteudo);
                    }
                    return List;
                }
                else
                {
                    status = false;
                    mensagem = "Não existente clientes na base de dados ";
                }
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
                var SQL = "SELECT Id, + JSON FROM " + tabela + " WHERE ID = '" + Id + "'";
                var dt = db.SQLQuery(SQL);
                if (dt.Rows.Count > 0)
                {
                    //DELETE FROM CLIETNE WHERE ID = '0001'

                    SQL = "DELETE FROM " + tabela + " WHERE ID = "+"'";
                    db.SQLCommand(SQL);
       
                    status = true;
                    mensagem = "Inclusao efetuada com sucesso. ID: " + Id;
                }
                else
                {
                    status = false;
                    mensagem = "Id não existente: " + Id;
                }    
            }
            catch (Exception ex)
            {
                status = false;
                mensagem = "Erro ao buscar o id do cliente: " + ex.Message;
            }

        }
        public void Alterar(string Id, string jsonUnit)
        {
            status = true;
            try
            {

                var SQL = "SELECT Id, + JSON FROM " + tabela + " WHERE ID = '" + Id + "'";
                var dt = db.SQLQuery(SQL);
                if (dt.Rows.Count > 0)
                {
                    // UPDATE CLIENTE SET JSON = '{..}' WHERE ID = '4544';

                    SQL = "UPDATE" + tabela + " SET JSON '" + jsonUnit + "' WHERE ID = '" + Id + "'";
                    db.SQLCommand(SQL);

                    status = true;
                    mensagem = "Alteracao efetuada com sucesso. ID: " + Id;
                }
                else
                {
                    status = false;
                    mensagem = "Alteração nao permitida pq o identificador já existe: " + Id;
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
