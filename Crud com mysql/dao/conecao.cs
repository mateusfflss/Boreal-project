using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Crud_com_mysql.dao
{
    public class conecao
    {
        string conecta = "DATABASE=cadastros; SERVER=localhost; UID=root; PWD=1234";
        protected MySqlConnection conexao = null;
        

        //conector do banco de dados

        public void abrirconexao()
        {
            try
            {
                conexao = new MySqlConnection(conecta);
                conexao.Open();
            }
            catch (Exception erro)
            {
                throw erro;
            }
            
            }


            
            
        // desconexao 
        public void fecharconexao()
        {
            try
            {
                conexao = new MySqlConnection(conecta);
                conexao.Close();
            }
            catch (Exception erro)
            {
                throw erro;
            }
            
        }
    }

}        
