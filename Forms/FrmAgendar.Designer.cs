namespace OficinaSAEP.Forms;

partial class FrmAgendar
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        menuNavegacao1 = new MenuNavegacao();
        dgvAgendamentos = new DataGridView();
        txtCodigo = new TextBox();
        lblCodigo = new Label();
        lblNovaData = new Label();
        dtpData = new DateTimePicker();
        btnSalvarAlteracoes = new Button();
        ((System.ComponentModel.ISupportInitialize)dgvAgendamentos).BeginInit();
        SuspendLayout();
        // 
        // menuNavegacao1
        // 
        menuNavegacao1.BackColor = Color.Transparent;
        menuNavegacao1.Location = new Point(12, 12);
        menuNavegacao1.Name = "menuNavegacao1";
        menuNavegacao1.Size = new Size(166, 261);
        menuNavegacao1.TabIndex = 0;
        // 
        // dgvAgendamentos
        // 
        dgvAgendamentos.AllowUserToAddRows = false;
        dgvAgendamentos.AllowUserToDeleteRows = false;
        dgvAgendamentos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvAgendamentos.BackgroundColor = Color.LightBlue;
        dgvAgendamentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvAgendamentos.Location = new Point(200, 12);
        dgvAgendamentos.Margin = new Padding(2, 3, 2, 3);
        dgvAgendamentos.MultiSelect = false;
        dgvAgendamentos.Name = "dgvAgendamentos";
        dgvAgendamentos.ReadOnly = true;
        dgvAgendamentos.RowHeadersWidth = 45;
        dgvAgendamentos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvAgendamentos.Size = new Size(518, 261);
        dgvAgendamentos.TabIndex = 14;
        dgvAgendamentos.CellClick += dgvAgendamentos_CellClick;
        // 
        // txtCodigo
        // 
        txtCodigo.Font = new Font("Calibri", 12F);
        txtCodigo.Location = new Point(200, 301);
        txtCodigo.Margin = new Padding(2, 3, 2, 3);
        txtCodigo.Name = "txtCodigo";
        txtCodigo.ReadOnly = true;
        txtCodigo.Size = new Size(123, 29);
        txtCodigo.TabIndex = 16;
        // 
        // lblCodigo
        // 
        lblCodigo.AutoSize = true;
        lblCodigo.Font = new Font("Calibri", 12F, FontStyle.Bold);
        lblCodigo.Location = new Point(200, 276);
        lblCodigo.Margin = new Padding(2, 0, 2, 0);
        lblCodigo.Name = "lblCodigo";
        lblCodigo.Size = new Size(63, 22);
        lblCodigo.TabIndex = 15;
        lblCodigo.Text = "Código";
        // 
        // lblNovaData
        // 
        lblNovaData.AutoSize = true;
        lblNovaData.Font = new Font("Calibri", 12F, FontStyle.Bold);
        lblNovaData.Location = new Point(200, 333);
        lblNovaData.Margin = new Padding(2, 0, 2, 0);
        lblNovaData.Name = "lblNovaData";
        lblNovaData.Size = new Size(172, 22);
        lblNovaData.TabIndex = 17;
        lblNovaData.Text = "Nova Data do Serviço";
        // 
        // dtpData
        // 
        dtpData.Font = new Font("Calibri", 12F, FontStyle.Bold);
        dtpData.Location = new Point(200, 358);
        dtpData.Name = "dtpData";
        dtpData.Size = new Size(363, 29);
        dtpData.TabIndex = 18;
        // 
        // btnSalvarAlteracoes
        // 
        btnSalvarAlteracoes.Enabled = false;
        btnSalvarAlteracoes.Font = new Font("Calibri", 12F, FontStyle.Bold);
        btnSalvarAlteracoes.Location = new Point(200, 393);
        btnSalvarAlteracoes.Name = "btnSalvarAlteracoes";
        btnSalvarAlteracoes.Size = new Size(171, 31);
        btnSalvarAlteracoes.TabIndex = 19;
        btnSalvarAlteracoes.Text = "Salvar Nova Data";
        btnSalvarAlteracoes.UseVisualStyleBackColor = true;
        btnSalvarAlteracoes.Click += btnSalvarAlteracoes_Click;
        // 
        // FrmAgendar
        // 
        AutoScaleDimensions = new SizeF(7F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.ActiveCaption;
        ClientSize = new Size(800, 450);
        Controls.Add(btnSalvarAlteracoes);
        Controls.Add(dtpData);
        Controls.Add(lblNovaData);
        Controls.Add(txtCodigo);
        Controls.Add(lblCodigo);
        Controls.Add(dgvAgendamentos);
        Controls.Add(menuNavegacao1);
        Name = "FrmAgendar";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Agendamentos - Oficina";
        Load += FrmAgendar_Load;
        ((System.ComponentModel.ISupportInitialize)dgvAgendamentos).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private void lblID_Click(object sender, EventArgs e)
    {
        throw new NotImplementedException();
    }

    #endregion

    private MenuNavegacao menuNavegacao1;
    private DataGridView dgvAgendamentos;
    private TextBox txtCodigo;
    private TextBox txtID;
    private Label lblCodigo;
    private Label lblNovaData;
    private DateTimePicker dtpData;
    private Label label1;
    private DateTimePicker dateTimePicker1;
    private Button btnSalvarAlteracoes;
}