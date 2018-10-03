using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Crud_com_mysql.model;
using Crud_com_mysql.bll;

namespace Crud_com_mysql
{
    public partial class crud : Form
    {
        public crud()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedDialog;
        }
        //limpador de tabelas
        private void limparcampo()
        {
            txtID.Clear();
            txtNome.Clear();
            txtIdade.Clear();
            txtSexo.Clear();
            txtAltura.Clear();
            txtNacionalidade.Clear();
            txtSalario.Clear();
            //para voltar a cor normal caso erro
            txtNome.BackColor = Color.White;
            txtSalario.BackColor = Color.White;
            txtSexo.BackColor = Color.White;
            txtNacionalidade.BackColor = Color.White;
        }


        private void salvar(empregados empregados)
        { //dados a serem salvos no banco de dados
            empregadosBll empregadosBll = new empregadosBll();
            if (txtNome.Text.Trim() == string.Empty || txtNacionalidade.Text.Trim() == string.Empty || txtSalario.Text.Trim() == string.Empty)
            {  //notificação de erro
                MessageBox.Show("Campos obrigatorios vazios", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNome.BackColor = Color.Red;
                txtSalario.BackColor = Color.Red;
                txtSexo.BackColor = Color.Red;
                txtNacionalidade.BackColor = Color.Red;
            }
            else
            {
             empregados.nome = txtNome.Text;
             empregados.idade = txtIdade.Text;
             empregados.sexo = txtSexo.Text;
             empregados.altura = txtAltura.Text;
             empregados.nacionalidade = txtNacionalidade.Text;
             empregados.salario = txtSalario.Text;

             empregadosBll.salvar(empregados);

             MessageBox.Show("funcionario salvo com sucesso");
             limparcampo();

            }

            
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnExibir_Click(object sender, EventArgs e) //funcao do botao exibir 
        {
            ClasseBLL bll = new ClasseBLL();

            try
            {
                dataGridView1.DataSource = bll.exibirdadosdal();
            }
            catch(Exception erro)
            {
                MessageBox.Show("erro ao exibir os dados" + erro); //mensagem de erro caso o problema seja nesse setor
            }
        
        }
        // conexao das funcoes de salvar editar e etc..
        private void btnSalvar_Click(object sender, EventArgs e)
        {

            empregados empregados = new empregados();
            salvar(empregados);


        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            empregados empregados = new empregados();
            editar(empregados);
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            empregados empregados = new empregados();
            excluir(empregados);
        }
        // Editor de dados metodo 

            private void editar(empregados empregados)
        {
            if (txtNome.Text.Trim() == string.Empty || txtNacionalidade.Text.Trim() == string.Empty || txtSalario.Text.Trim() == string.Empty)
            {  //notificação de erro
                MessageBox.Show("Campos obrigatorios vazios", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNome.BackColor = Color.Red;
                txtSalario.BackColor = Color.Red;
                txtSexo.BackColor = Color.Red;
                txtNacionalidade.BackColor = Color.Red;
            }
            else
            {



                empregadosBll empregadosBll = new empregadosBll();
                empregados.id = txtID.Text;
                empregados.nome = txtNome.Text;
                empregados.idade = txtIdade.Text;
                empregados.sexo = txtSexo.Text;
                empregados.altura = txtAltura.Text;
                empregados.nacionalidade = txtNacionalidade.Text;
                empregados.salario = txtSalario.Text;


                empregadosBll.editar(empregados);

                MessageBox.Show("funcionario editado com sucesso!");
                limparcampo();
            }
            

        }

        // metodo exluir ou apagar 
        private void excluir(empregados empregados)
        {
            empregadosBll empregadosBll = new empregadosBll();

            if (txtID.Text.Trim() == string.Empty)
            {
                MessageBox.Show("selecione um empregado para ser apagado.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (MessageBox.Show("Tem certeza?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
            }else
            { empregados.id = txtID.Text;

                empregadosBll.excluir(empregados);

                MessageBox.Show("funcionario excluido com sucesso");
                limparcampo();
            }
        }





        //evento de puxar os dados para o esqueleto
        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNome.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtIdade.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            
            txtSexo.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtAltura.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtNacionalidade.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            
            txtSalario.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
           
            
            
            txtID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparcampo();
        }

        private void crud_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
