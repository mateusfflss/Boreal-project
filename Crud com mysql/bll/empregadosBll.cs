using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Crud_com_mysql.model;
using Crud_com_mysql.dao;

namespace Crud_com_mysql.bll
{         //link da funsao do botao salvar
    public class empregadosBll
    {
        empregadosDal empregadosDal = new empregadosDal();

        public void salvar(empregados empregados)
        {
            try
            {
                empregadosDal.salvar(empregados);
            }
            catch (Exception erro)
            {
                throw erro;
            }

        }

        //conecxão de editor de dados 

        public void editar(empregados empregados)
        {
            try
            {
                empregadosDal.editar(empregados);
            }
             catch (Exception erro)
            {
                throw erro;
            }
            }

          //metodo de excluir 
          public void excluir(empregados empregados)
        {
            try
            {
                empregadosDal.excluir(empregados); //conexao com a camada dal para excluir dados
            }
            catch (Exception erro)
            {
                throw erro;
            }
            
            
            
            
            }
       




    }
}
