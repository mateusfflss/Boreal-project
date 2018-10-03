using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; 

namespace Crud_com_mysql
{
    class ClasseBLL
    {
        ClasseDAL dal = null;

        public DataTable exibirdadosdal() //string de exibicao de dados
        {
            try
            {
                DataTable datat = new DataTable();
                dal = new ClasseDAL();

                datat = dal.exibirDados();

                return datat;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
    }
}
