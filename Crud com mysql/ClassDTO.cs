using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud_com_mysql
{
    class ClassDTO
    {

        //get e set dos valores com o banco de dados

        public string nome
        {
            get => nome;
            set => nome = value;
        }
        public string idade
        {
            get => idade;
            set => idade = value;
        }
        public string sexo
        {
            get => sexo;
            set => sexo = value;
        }
        public string altura
        {
            get => altura;
            set => altura = value;
        }
        public string nacionalidade
        {
            get => nacionalidade;
            set => nacionalidade = value;
        }
        public string salario
        {
            get => salario;
            set => salario = value;
        }
        public string id
        {
            get => id;
            set => id = value;
        }

    }
}   
