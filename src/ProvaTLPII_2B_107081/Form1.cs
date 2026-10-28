using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProvaTLPII_2B_107081
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonVerificar_Click(object sender, EventArgs e)
        {
            // 1. Obter os dados da tela
            string nome = txtNome.Text;
            int palpite = (int)numericPalpite.Value; 

            // 2. Validar o nome
            if (string.IsNullOrWhiteSpace(nome))
            {
                MessageBox.Show("Por favor, digite um nome.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.Focus();
                return;
            }

            try // Usar try-catch para operações de banco de dados
            {
                // 3. Usar a lógica do jogo
                MovimentoJogo jogo = new MovimentoJogo();
                int numeroCorreto = jogo.CalcularNumeroCorreto(nome);
                bool acertou = (palpite == numeroCorreto);

                // 4. Criar o objeto Resultado
                Resultado novoResultado = new Resultado
                {
                    DataHora = DateTime.Now,
                    NomeInformado = nome,
                    NumeroGerado = palpite,
                    NumeroCorreto = numeroCorreto
                };

                // 5. Salvar no Banco de Dados
                JogoDAO dao = new JogoDAO();
                dao.Inserir(novoResultado);

                // 6. Dar feedback ao usuário
                if (acertou)
                {
                    MessageBox.Show("Parabéns, você acertou!", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Você errou! O número correto era {numeroCorreto}.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                // 7. Limpar campos e atualizar a grade
                txtNome.Clear();
                numericPalpite.Value = numericPalpite.Minimum;
                                                       
                txtNome.Focus();
                CarregarResultados();
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"Erro ao acessar o banco de dados: {sqlEx.Message}", "Erro de Banco", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro inesperado: {ex.Message}", "Erro Geral", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CarregarResultados()
        {
            try
            {
                JogoDAO dao = new JogoDAO();
                dgvResultados.DataSource = null;
                dgvResultados.DataSource = dao.ListarTodos();               
                //dgvResultados.Columns["ID"].Visible = true;
                //dgvResultados.Columns["DataHora"].HeaderText = "Data e Hora";
                //dgvResultados.Columns["NomeInformado"].HeaderText = "Nome";
                //dgvResultados.Columns["NumeroGerado"].HeaderText = "Palpite";
                //dgvResultados.Columns["NumeroCorreto"].HeaderText = "Número Correto";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar os resultados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CarregarResultados();
        }
    }
}
