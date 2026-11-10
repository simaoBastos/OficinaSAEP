namespace OficinaSAEP.Forms;

partial class FrmVeiculos
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
        cmbCliente = new ComboBox();
        lblClienteAssociado = new Label();
        lblPlaca = new Label();
        txtPlaca = new TextBox();
        txtMarca = new TextBox();
        lblMarca = new Label();
        txtAno = new TextBox();
        label1 = new Label();
        btnCadastrarVeiculo = new Button();
        dgvVeiculos = new DataGridView();
        txtModelo = new TextBox();
        label2 = new Label();
        ((System.ComponentModel.ISupportInitialize)dgvVeiculos).BeginInit();
        SuspendLayout();
        // 
        // menuNavegacao1
        // 
        menuNavegacao1.BackColor = Color.Transparent;
        menuNavegacao1.Location = new Point(12, 11);
        menuNavegacao1.Name = "menuNavegacao1";
        menuNavegacao1.Size = new Size(166, 229);
        menuNavegacao1.TabIndex = 0;
        // 
        // cmbCliente
        // 
        cmbCliente.Font = new Font("Calibri", 12F);
        cmbCliente.FormattingEnabled = true;
        cmbCliente.Location = new Point(201, 41);
        cmbCliente.Name = "cmbCliente";
        cmbCliente.Size = new Size(258, 30);
        cmbCliente.TabIndex = 1;
        // 
        // lblClienteAssociado
        // 
        lblClienteAssociado.AutoSize = true;
        lblClienteAssociado.Font = new Font("Calibri", 12F, FontStyle.Bold);
        lblClienteAssociado.Location = new Point(201, 16);
        lblClienteAssociado.Margin = new Padding(2, 0, 2, 0);
        lblClienteAssociado.Name = "lblClienteAssociado";
        lblClienteAssociado.Size = new Size(142, 22);
        lblClienteAssociado.TabIndex = 4;
        lblClienteAssociado.Text = "Cliente Associado";
        // 
        // lblPlaca
        // 
        lblPlaca.AutoSize = true;
        lblPlaca.Font = new Font("Calibri", 12F, FontStyle.Bold);
        lblPlaca.Location = new Point(514, 16);
        lblPlaca.Margin = new Padding(2, 0, 2, 0);
        lblPlaca.Name = "lblPlaca";
        lblPlaca.Size = new Size(133, 22);
        lblPlaca.TabIndex = 5;
        lblPlaca.Text = "Placa do Veículo";
        // 
        // txtPlaca
        // 
        txtPlaca.Font = new Font("Calibri", 12F);
        txtPlaca.Location = new Point(520, 41);
        txtPlaca.Name = "txtPlaca";
        txtPlaca.PlaceholderText = "Ex: ABC1234";
        txtPlaca.Size = new Size(199, 29);
        txtPlaca.TabIndex = 6;
        // 
        // txtMarca
        // 
        txtMarca.Font = new Font("Calibri", 12F);
        txtMarca.Location = new Point(201, 99);
        txtMarca.Name = "txtMarca";
        txtMarca.PlaceholderText = "Ex: Fiat";
        txtMarca.Size = new Size(141, 29);
        txtMarca.TabIndex = 8;
        // 
        // lblMarca
        // 
        lblMarca.AutoSize = true;
        lblMarca.Font = new Font("Calibri", 12F, FontStyle.Bold);
        lblMarca.Location = new Point(201, 74);
        lblMarca.Margin = new Padding(2, 0, 2, 0);
        lblMarca.Name = "lblMarca";
        lblMarca.Size = new Size(141, 22);
        lblMarca.TabIndex = 7;
        lblMarca.Text = "Marca do Veículo";
        // 
        // txtAno
        // 
        txtAno.Font = new Font("Calibri", 12F);
        txtAno.Location = new Point(570, 99);
        txtAno.Name = "txtAno";
        txtAno.PlaceholderText = "Ex: 2026";
        txtAno.Size = new Size(149, 29);
        txtAno.TabIndex = 10;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Calibri", 12F, FontStyle.Bold);
        label1.Location = new Point(570, 73);
        label1.Margin = new Padding(2, 0, 2, 0);
        label1.Name = "label1";
        label1.Size = new Size(41, 22);
        label1.TabIndex = 9;
        label1.Text = "Ano";
        // 
        // btnCadastrarVeiculo
        // 
        btnCadastrarVeiculo.BackColor = Color.Honeydew;
        btnCadastrarVeiculo.Font = new Font("Calibri", 12F, FontStyle.Bold);
        btnCadastrarVeiculo.ForeColor = Color.DarkGreen;
        btnCadastrarVeiculo.Location = new Point(201, 134);
        btnCadastrarVeiculo.Name = "btnCadastrarVeiculo";
        btnCadastrarVeiculo.Size = new Size(258, 30);
        btnCadastrarVeiculo.TabIndex = 11;
        btnCadastrarVeiculo.Text = "Cadastrar e Vincular Veículo";
        btnCadastrarVeiculo.UseVisualStyleBackColor = false;
        btnCadastrarVeiculo.Click += btnCadastrarVeiculo_Click;
        // 
        // dgvVeiculos
        // 
        dgvVeiculos.AllowUserToAddRows = false;
        dgvVeiculos.AllowUserToDeleteRows = false;
        dgvVeiculos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvVeiculos.BackgroundColor = Color.LightBlue;
        dgvVeiculos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvVeiculos.Location = new Point(201, 170);
        dgvVeiculos.Margin = new Padding(2, 3, 2, 3);
        dgvVeiculos.MultiSelect = false;
        dgvVeiculos.Name = "dgvVeiculos";
        dgvVeiculos.ReadOnly = true;
        dgvVeiculos.RowHeadersWidth = 45;
        dgvVeiculos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvVeiculos.Size = new Size(518, 214);
        dgvVeiculos.TabIndex = 12;
        dgvVeiculos.CellClick += dgvVeiculos_CellClick;
        // 
        // txtModelo
        // 
        txtModelo.Font = new Font("Calibri", 12F);
        txtModelo.Location = new Point(373, 99);
        txtModelo.Name = "txtModelo";
        txtModelo.PlaceholderText = "Ex: Uno";
        txtModelo.Size = new Size(162, 29);
        txtModelo.TabIndex = 14;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Calibri", 12F, FontStyle.Bold);
        label2.Location = new Point(373, 73);
        label2.Margin = new Padding(2, 0, 2, 0);
        label2.Name = "label2";
        label2.Size = new Size(152, 22);
        label2.TabIndex = 13;
        label2.Text = "Modelo do Veículo";
        // 
        // FrmVeiculos
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.ActiveCaption;
        ClientSize = new Size(800, 396);
        Controls.Add(txtModelo);
        Controls.Add(label2);
        Controls.Add(dgvVeiculos);
        Controls.Add(btnCadastrarVeiculo);
        Controls.Add(txtAno);
        Controls.Add(label1);
        Controls.Add(txtMarca);
        Controls.Add(lblMarca);
        Controls.Add(txtPlaca);
        Controls.Add(lblPlaca);
        Controls.Add(lblClienteAssociado);
        Controls.Add(cmbCliente);
        Controls.Add(menuNavegacao1);
        Font = new Font("Calibri", 8.830189F);
        Name = "FrmVeiculos";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Veiculos - Oficina";
        Load += FrmVeiculos_Load;
        ((System.ComponentModel.ISupportInitialize)dgvVeiculos).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private void dgvVeiculos_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        throw new NotImplementedException();
    }

    private void label1_Click(object sender, EventArgs e)
    {
        throw new NotImplementedException();
    }

    #endregion

    private MenuNavegacao menuNavegacao1;
    private ComboBox cmbCliente;
    private Label lblClienteAssociado;
    private Label lblPlaca;
    private TextBox txtPlaca;
    private TextBox txtMarca;
    private Label lblMarca;
    private TextBox txtMarcaModelo;
    private Label lblMarcaModelo;
    private TextBox txtAno;
    private Label label1;
    private Button btnCadastrarVeiculo;
    private DataGridView dgvVeiculos;
    private TextBox txtModelo;
    private Label label2;
}