using OficinaSAEP.Database;
using OficinaSAEP.Forms;
using OficinaSAEP.Services;
using System.Security.Cryptography;
using System.Text;

namespace OficinaSAEP;

public partial class FrmLogin : Form
{

    public FrmLogin()
    {
        InitializeComponent();
    }

    public void LimparCampos()
    {
        txtUsuario.Text = string.Empty;
        txtSenha.Text = string.Empty;
        txtUsuario.Focus();
    }

    private void btnLogar_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtSenha.Text))
        {
            MessageBox.Show("Por favor, preencha todos os campos.");
            return;
        }

        ConexaoSqLite conexaoSqLite = new();
        using var conexao = conexaoSqLite.ObterConexao();
        try
        {
            conexao.Open();
            using var comando = conexao.CreateCommand();
            comando.CommandText = "SELECT senha FROM usuario WHERE usuario = @usuario;";
            comando.Parameters.AddWithValue("@usuario", txtUsuario.Text);
            var resultado = comando.ExecuteScalar();
            if (resultado != null)
            {
                string senhaArmazenada = resultado.ToString() ?? string.Empty;
                if (Autenticacao.VerificarSenha(senhaArmazenada, txtSenha.Text))
                {
                    Console.WriteLine("Login bem-sucedido!");
                    FrmMain frmMain = new();
                    frmMain.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Senha incorreta.");
                }
            }
            else
            {
                MessageBox.Show("Usuário não encontrado.");
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Erro ao conectar ao banco de dados: {ex.Message}");
        }

    }

    private void FrmLogin_Load(object sender, EventArgs e)
    {
        ConexaoSqLite conexaoSqlite = new();

        using var conexao = conexaoSqlite.ObterConexao();
        try
        {
            conexao.Open();
            using var comando = conexao.CreateCommand();
            comando.CommandText = "SELECT name FROM sqlite_master WHERE type='table' AND name='usuario';";
            var resultado = comando.ExecuteScalar();
            if (resultado != null)
            {
                Console.WriteLine("Tabela 'usuario' já existe.");
                comando.CommandText = "SELECT usuario FROM usuario WHERE usuario = 'admin';";
                resultado = comando.ExecuteScalar();
                if (resultado != null)
                {
                    Console.WriteLine("Usuário 'admin' já existe.");
                }
                else
                {
                    string senhaPadrao = "admin123";
                    byte[] salt = RandomNumberGenerator.GetBytes(16);
                    int iteracoes = 600000;
                    byte[] hash = Rfc2898DeriveBytes.Pbkdf2(senhaPadrao, salt, iteracoes, HashAlgorithmName.SHA256, 32);
                    string senhaArmazenada = $"{iteracoes}:{Convert.ToBase64String(salt)}:{Convert.ToBase64String(hash)}";

                    comando.Parameters.Clear();
                    comando.CommandText = "INSERT INTO usuario (usuario, senha) VALUES ('admin', @senha);";
                    comando.Parameters.AddWithValue("@senha", senhaArmazenada);
                    comando.ExecuteNonQuery();

                    Console.WriteLine("Usuário 'admin' criado com sucesso.");
                }
            }
            else
            {
                MessageBox.Show("Tabela 'usuario' não existe.");
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Erro ao verificar/criar a tabela: {ex.Message}");
        }
    }
}
