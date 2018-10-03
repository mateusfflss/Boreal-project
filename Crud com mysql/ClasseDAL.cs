using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Crud_com_mysql
{      //string de conexao com banco de dados
    class ClasseDAL
    {
        String conectabanco = "SERVER=localhost; DATABASE=cadastros;UID=root;PWD=1234";
        MySqlConnection conexao = null;
        MySqlCommand comando;

        public DataTable exibirDados()
        { //string de select para selexao no banco de dados
            try
            {
                conexao = new MySqlConnection(conectabanco);
                comando = new MySqlCommand("SELECT * FROM empregados", conexao);

                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = comando;
                DataTable dt = new DataTable();

                da.Fill(dt);

                return dt;

            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
        

        
        
          
            
               
            
        



    }


}
