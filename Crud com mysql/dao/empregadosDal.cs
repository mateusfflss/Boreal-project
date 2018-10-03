using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Crud_com_mysql.model;

namespace Crud_com_mysql.dao
{
    //classe de conexao
    public class empregadosDal : conecao
    {
        MySqlCommand comando = null;
        //metodo de salvar
        public void salvar(empregados empregados)
        {
            try
                //string de abrir conexao
            {
                abrirconexao();

                comando = new MySqlCommand("INSERT INTO empregados (nome, idade, sexo, altura, nacionalidade, salario) VALUES (@nome, @idade, @sexo, @altura, @nacionalidade, @salario)", conexao);

                comando.Parameters.AddWithValue("@nome", empregados.nome);
                comando.Parameters.AddWithValue("@idade", empregados.idade);
                comando.Parameters.AddWithValue("@sexo", empregados.sexo);
                comando.Parameters.AddWithValue("@altura", empregados.altura);
                comando.Parameters.AddWithValue("@nacionalidade", empregados.nacionalidade);
                comando.Parameters.AddWithValue("@salario", empregados.salario);
                

                comando.ExecuteNonQuery();
            }
            catch (Exception erro) //mensagem de erro caso o problema seja nessa parte do codigo
            {
                throw erro;
            }
            finally //fechamento da conexao
            {
                fecharconexao();
            }




        }

        //editor de dados  
        public void editar(empregados empregados)
        {
            try
            {
                abrirconexao();

                comando = new MySqlCommand("UPDATE empregados SET nome = @nome, idade = @idade, sexo = @sexo, altura = @altura, nacionalidade = @nacionalidade, salario = @salario WHERE id = @id", conexao);

                comando.Parameters.AddWithValue("@id", empregados.id);
                comando.Parameters.AddWithValue("@nome", empregados.nome);
                comando.Parameters.AddWithValue("@idade", empregados.idade);
                comando.Parameters.AddWithValue("@sexo", empregados.sexo);
                comando.Parameters.AddWithValue("@altura", empregados.altura);
                comando.Parameters.AddWithValue("@nacionalidade", empregados.nacionalidade);
                comando.Parameters.AddWithValue("@salario", empregados.salario);
                

                comando.ExecuteNonQuery();


            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                fecharconexao(); //conexao sendo fechada com banco de dados
            }
        }
        //metodo excluir 
        public void excluir(empregados empregados)
        {
            try
            {
                abrirconexao(); //comando e string de conexao

                comando = new MySqlCommand("DELETE FROM empregados WHERE id = @id", conexao);

                comando.Parameters.AddWithValue("@id", empregados.id);

                comando.ExecuteNonQuery();

            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                fecharconexao(); //fechando conexao
            }


        }



    }

  }






