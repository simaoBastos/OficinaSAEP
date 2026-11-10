using OficinaSAEP.Database;
using Microsoft.Data.Sqlite;
using System.Data;
using OficinaSAEP.Services;
namespace OficinaSAEP.Forms;


public partial class FrmClientes : Form
{
    public FrmClientes()
    {
        InitializeComponent();
        dgvClientes.AutoGenerateColumns = true;
    }

    private void FrmClientes_Load(object sender, EventArgs e)
    {
        CarregarClientes();

    }

    public void CarregarClientes(string pesquisa = "")
    {
        try
        {
            ConexaoSqLite conexao = new ConexaoSqLite();
            using var connection = conexao.ObterConexao();
            connection.Open();
            using var comando = connection.CreateCommand();

            comando.CommandText = @"
                                    SELECT id, nome, cpf, telefone
                                    FROM cliente
                                    WHERE nome LIKE @pesquisa
                                    OR telefone LIKE @pesquisa";

            comando.Parameters.AddWithValue("@pesquisa", $"%{pesquisa}%");

            using var reader = comando.ExecuteReader();

            DataTable tabela = new DataTable();
            tabela.Load(reader);
            dgvClientes.DataSource = tabela;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Erro ao carregar clientes: {ex.Message}");

        }
    }


    private void btnBuscacr_Click(object sender, EventArgs e)
    {
        CarregarClientes(txtBusca.Text);

    }

    private void btnLimpar_Click(object sender, EventArgs e)
    {
        txtBusca.Clear();
        CarregarClientes();
    }

    private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) return;

        var row = dgvClientes.Rows[e.RowIndex];
        txtID.Text = row.Cells["id"].Value.ToString();
        txtNome.Text = row.Cells["nome"].Value.ToString();
        txtTelefone.Text = row.Cells["telefone"].Value.ToString();
        string cpfCriptografado = row.Cells["cpf"].Value.ToString();
        string cpf = Criptografia.Descriptografar(cpfCriptografado);

        txtCPF.Text = $"***.***.***-{cpf.Substring(cpf.Length - 2)}";


        btnAtualizar.Enabled = true;
    }

    private void btnAtualizar_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtID.Text))
        {
            MessageBox.Show("Selecione um cliente para atualizar.");
            return;
        }
        try
        {
            ConexaoSqLite conexao = new ConexaoSqLite();
            using var connection = conexao.ObterConexao();
            connection.Open();
            using var comando = connection.CreateCommand();
            comando.CommandText = @"UPDATE cliente SET nome = @nome, telefone = @telefone WHERE id = @id";
            comando.Parameters.AddWithValue("@nome", txtNome.Text);
            comando.Parameters.AddWithValue("@telefone", txtTelefone.Text);
            comando.Parameters.AddWithValue("@id", txtID.Text);
            comando.ExecuteNonQuery();

            MessageBox.Show("Cliente atualizado com sucesso!");

            CarregarClientes();
            txtID.Clear();
            txtNome.Clear();
            txtTelefone.Clear();
            txtCPF.Clear();
            btnAtualizar.Enabled = false;

        }
        catch (Exception ex)
        {
            MessageBox.Show($"Erro ao atualizar cliente: {ex.Message}");
        }
    }
}
