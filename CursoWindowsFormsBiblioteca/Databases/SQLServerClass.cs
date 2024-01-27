using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace CursoWindowsFormsBiblioteca.Databases
{
    public class SQLServerClass
    {
        public string stringConn;
        public SqlConnection connDB;

        public SQLServerClass()
        {
            try
            {
                stringConn = "DData Source=LUQUISINGER;Initial Catalog=ByteBank;Persist Security Info=True;User ID=sa;Password=12";
                connDB = new SqlConnection(stringConn);
                connDB.Open();
            } 
            catch (Exception ex) 
            {
                throw new Exception(ex.Message);
            }

        }
    }
}
