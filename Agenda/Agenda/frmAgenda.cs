using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
namespace Agenda
{
    public partial class frmAgenda : Form
    {
        //string de conexão ATENÇÂO !!! substituir \ por \\ 
        static string strCn = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Aluno_2\Desktop\Agenda\Agenda\bin\Debug\bdAgenda.accdb";

        OleDbConnection conexao = new OleDbConnection(strCn);

        public frmAgenda()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            //instrução sql responsável por pesquisar o banco de dados (CRUD - Read)
            string pesquisa = "select * from Contatos where Id = " + txbId.Text;
            //criando um objeto de nome cmd tendo como modelo a classe OleDbCommand para executar a instrução sql
            OleDbCommand cmd = new OleDbCommand(pesquisa, conexao);
            // Atravé da classe OleDbDataReader que faz parte do SqlCliente, criamos uma //variável chamada DR que será usada na leitura dos dados (instrução select)
            OleDbDataReader DR;
            //tratamento de exceções: try - catch - finally (em caso de erro capturamos o //tipo do erro)

            try
            {
                // Abrindo a conexão com o banco
                conexao.Open();
                // Executando a instrução e armazenando o resultado no reader DR
                DR = cmd.ExecuteReader();
                // Se houver um registro correspondente ao Id
                if (DR.Read())
                {
                    // Exibe as informações nas caixas de texto (textBox) correspondentes (0) //corresponde ao Id, (1) ao Nome e assim sucessivamente 
                    txbId.Text = DR.GetValue(0).ToString();
                    txbNome.Text = DR.GetValue(1).ToString();
                    txbTelefone.Text = DR.GetValue(2).ToString();
                    txbEmail.Text = DR.GetValue(3).ToString();
                }

                // Senão, exibimos uma mensagem avisando e também limpamos os campos para uma //nova pesquisa 
                else
                {
                    MessageBox.Show("Registro não encontrado");
                    txbNome.Clear();
                    txbTelefone.Clear();
                    txbEmail.Clear();
                    txbId.Focus();

                } // Encerrando o uso do reader DR 
                DR.Close();

                // Encerrando o uso do cmd 
                cmd.Dispose();
            }

            //caso ocorra algum erro 
            catch (Exception ex)
            {

                //exiba qual é o erro 
                MessageBox.Show(ex.Message);
            }

            // de qualquer forma sempre fechar a conexão com o banco ("lembrar da porta da //geladeira rsrsrs") 
            finally
            {
                conexao.Close();
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            //instrução sql responsável por adicionar dados ao banco (CRUD - Create) 
            string adiciona = "insert into Contatos values (" +
            txbId.Text + ",'" +
            txbNome.Text + "','" +
            txbTelefone.Text + "','" +
            txbEmail.Text + "')";

            //criando um objeto de nome cmd tendo como modelo a classe OleDbCommand para //executar a instrução sql 
            OleDbCommand cmd = new OleDbCommand(adiciona, conexao);

            //tratamento de exceções: try - catch - finally (em caso de erro capturamos o //tipo do erro) 
            try
            {
                // Abrindo a conexão com o banco 
                conexao.Open();

                // Criando uma variável para adicionar e armazenar o resultado 
                int resultado;
                resultado = cmd.ExecuteNonQuery();

                // Verificando se o registro foi adicionado 
                // Caso o valor da variável resultado seja 1 
                // significa que o comando funcionou, neste caso limpar os campos e exibir uma //mensagem 
                if (resultado == 1)
                {
                    MessageBox.Show("Registro adicionado com sucesso");
                    txbId.Clear();
                    txbNome.Clear();
                    txbTelefone.Clear();
                    txbEmail.Clear();
                    txbId.Focus();
                }

                // Encerrando o uso do cmd 
                cmd.Dispose();
            }

            //caso ocorra algum erro 
            catch (Exception ex)
            {

                //exiba qual é o erro 
                MessageBox.Show(ex.Message);
            }

            // de qualquer forma sempre fechar a conexão com o banco ("lembrar da porta da //geladeira rsrsrs") 
            finally
            {
                conexao.Close();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            //instrução sql responsável por alterar um registro do banco (CRUD - Update) 
            string altera = "update Contatos set Nome= '" + txbNome.Text +
            "', Telefone= '" + txbTelefone.Text +
            "', Email= '" + txbEmail.Text +
            "' where Id= " + txbId.Text;

            //criando um objeto de nome cmd tendo como modelo a classe OleDbCommand para //executar a instrução sql 
            OleDbCommand cmd = new OleDbCommand(altera, conexao);

            //tratamento de exceções: try - catch - finally (em caso de erro capturamos o //tipo do erro) 
            try
            {
                // Abrindo a conexão com o banco 
                conexao.Open();

                // Criando uma variável para alterar e armazenar o resultado 
                int resultado;
                resultado = cmd.ExecuteNonQuery();
                // Verificando se o registro foi alterado 
                // Caso o valor da variável resultado seja 1 
                // significa que o comando funcionou, neste caso limpar os campos e exibir uma //mensagem 
                if (resultado == 1)
                {
                    txbId.Clear();
                    txbNome.Clear();
                    txbTelefone.Clear();
                    txbEmail.Clear();
                    txbId.Focus();
                    MessageBox.Show("Registro alterado com sucesso");
                }

                // Encerrando o uso do cmd 
                cmd.Dispose();
            }

            //caso ocorra algum erro 
            catch (Exception ex)
            {

                //exiba qual é o erro 
                MessageBox.Show(ex.Message);
            }

            // De qualquer forma sempre fechar a conexão com o banco 
            finally
            {
                conexao.Close();
            }

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //instrução sql responsável por remover um registro do banco (CRUD - Delete) 
            string remove = "delete from Contatos where Id= " + txbId.Text;

            //criando um objeto de nome cmd tendo como modelo a classe OleDbCommand para //executar a instrução sql 
            OleDbCommand cmd = new OleDbCommand(remove, conexao);

            //tratamento de exceções: try - catch - finally (em caso de erro capturamos o //tipo do erro) 
            try
            {

                // Abrindo a conexão com o banco 
                conexao.Open();

                // Criando uma variável para adicionar e armazenar o resultado 
                int resultado;
                if (MessageBox.Show("Tem certeza que deseja remover este registro ?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    resultado = cmd.ExecuteNonQuery();
                    // Verificando se o registro foi apagado 
                    // Caso o valor da variável resultado seja 1 
                    // significa que o comando funcionou, neste caso limpar os campos e exibir uma //mensagem 
                    if (resultado == 1)
                    {
                        txbId.Clear();
                        txbNome.Clear();
                        txbTelefone.Clear();
                        txbEmail.Clear();
                        txbId.Focus();
                        MessageBox.Show("Registro removido com sucesso");
                    }

                    // Encerrando o uso do cmd 
                    cmd.Dispose();
                }
            }

            //caso ocorra algum erro 
            catch (Exception ex)
            {

                //exiba qual é o erro 
                MessageBox.Show(ex.Message);
            }
            // de qualquer forma sempre fechar a conexão com o banco 
            finally
            {
                conexao.Close();
            }

        }

    }

}
