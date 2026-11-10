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

public partial class FrmAgendar : Form
{
    public FrmAgendar()
    {
        InitializeComponent();
    }

    private void FrmAgendar_Load(object sender, EventArgs e)
    {
        CarregarDadosAgendamento();
    }

    private void dgvAgendamentos_CellClick(object sender, DataGridViewCellEventArgs e)
    {

        if (e.RowIndex < 0) return;

        var linhaSelecionada = dgvAgendamentos.Rows[e.RowIndex];
        var data = linhaSelecionada.Cells["data"].Value?.ToString();
        txtCodigo.Text = linhaSelecionada.Cells["id"].Value?.ToString();

        if (DateTime.TryParse(data, out DateTime dataConvertida))
        {
            dtpData.Value = dataConvertida;
            btnSalvarAlteracoes.Enabled = true;
        }
        else
        {
            MessageBox.Show("Data inválida no registro selecionado.");
        }
    }

    private void CarregarDadosAgendamento()
    {
        using var conexao = new ConexaoSqLite().ObterConexao();
        conexao.Open();
        using var comando = conexao.CreateCommand();
        comando.CommandText = @"
        SELECT a.id,
        a.data,
        a.hora,
        a.descricao,
        v.placa,
        v.modelo,
        v.ano,
        c.nome AS nome_cliente,
        c.cpf,
        c.telefone
        FROM agendamento a
        JOIN veiculo v ON a.veiculo_id = v.id
        JOIN cliente c ON v.id_cliente = c.id
        ORDER BY a.data";
        var reader = comando.ExecuteReader();
        DataTable tabela = new DataTable();
        tabela.Load(reader);
        dgvAgendamentos.DataSource = tabela;

    }

    private void btnSalvarAlteracoes_Click(object sender, EventArgs e)
    {
        using var conexao = new ConexaoSqLite().ObterConexao();
        conexao.Open();
        using var comando = conexao.CreateCommand();
        comando.CommandText = @"UPDATE agendamento SET data = @data WHERE id = @id";
        comando.Parameters.AddWithValue("@data", dtpData.Value.ToString("yyyy-MM-dd"));
        comando.Parameters.AddWithValue("@id", txtCodigo.Text);
        comando.ExecuteNonQuery();
        CarregarDadosAgendamento();

        MessageBox.Show("Data do serviço atualizada com sucesso!");
    }
}
