using OficinaSAEP.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OficinaSAEP.Forms;

public partial class FrmVeiculos : Form
{
    public FrmVeiculos()
    {
        InitializeComponent();
        dgvVeiculos.AutoGenerateColumns = true;
    }

    public void FrmVeiculos_Load(object sender, EventArgs e)
    {
        CarregarVeiculos();
        CarregarClientesComboBox();
    }

    public void CarregarVeiculos(string pesquisa = "")
    {
        try
        {
            ConexaoSqLite conexao = new ConexaoSqLite();
            using var connection = conexao.ObterConexao();
            connection.Open();
            using var comando = connection.CreateCommand();
            comando.CommandText = @"
                SELECT v.id, v.placa, v.marca, v.modelo, v.ano, c.nome AS cliente_nome, c.id AS id_cliente
                FROM veiculo v
                JOIN cliente c ON v.id_cliente = c.id
                WHERE v.placa LIKE @pesquisa
                OR v.modelo LIKE @pesquisa";
            comando.Parameters.AddWithValue("@pesquisa", $"%{pesquisa}%");
            using var reader = comando.ExecuteReader();
            DataTable tabela = new DataTable();
            tabela.Load(reader);
            dgvVeiculos.DataSource = tabela;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Erro ao carregar veículos: {ex.Message}");
        }
    }

    private void CarregarClientesComboBox()
    {
        try
        {
            ConexaoSqLite conexao = new ConexaoSqLite();
            using var connection = conexao.ObterConexao();
            connection.Open();
            using var comando = connection.CreateCommand();
            comando.CommandText = "SELECT id, nome FROM cliente";
            using var reader = comando.ExecuteReader();
            DataTable tabela = new DataTable();
            tabela.Load(reader);
            cmbCliente.DataSource = tabela;
            cmbCliente.DisplayMember = "nome";
            cmbCliente.ValueMember = "id";
            cmbCliente.SelectedIndex = -1; // Nenhum cliente selecionado inicialmente
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Erro ao carregar clientes: {ex.Message}");
        }
    }

    private void btnCadastrarVeiculo_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtPlaca.Text) || string.IsNullOrWhiteSpace(txtModelo.Text) ||
            string.IsNullOrWhiteSpace(txtAno.Text) || string.IsNullOrWhiteSpace(txtMarca.Text) ||
            cmbCliente.SelectedItem == null)
        {
            MessageBox.Show("Por favor, preencha todos os campos.");
            return;
        }
        try
        {
            ConexaoSqLite conexao = new ConexaoSqLite();
            using var connection = conexao.ObterConexao();
            connection.Open();
            using var comando = connection.CreateCommand();
            comando.CommandText = @"
                INSERT INTO veiculo (placa, modelo, ano, marca, id_cliente)
                VALUES (@placa, @modelo, @ano, @marca, @id_cliente)";
            comando.Parameters.AddWithValue("@placa", txtPlaca.Text);
            comando.Parameters.AddWithValue("@modelo", txtModelo.Text);
            comando.Parameters.AddWithValue("@ano", txtAno.Text);
            comando.Parameters.AddWithValue("@marca", txtMarca.Text);
            comando.Parameters.AddWithValue("@id_cliente", cmbCliente.SelectedValue);
            comando.ExecuteNonQuery();
            MessageBox.Show("Veículo cadastrado com sucesso!");
            CarregarVeiculos();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Erro ao cadastrar veículo: {ex.Message}");
        }
    }

    private void FrmVeiculos_Load_1(object sender, EventArgs e)
    {

    }
}
