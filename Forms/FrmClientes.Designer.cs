namespace OficinaSAEP.Forms;

partial class FrmClientes
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
        dgvClientes = new DataGridView();
        txtBusca = new TextBox();
        lblBuscar = new Label();
        lblID = new Label();
        txtID = new TextBox();
        txtNome = new TextBox();
        lblNome = new Label();
        txtTelefone = new TextBox();
        lblTelefone = new Label();
        txtCPF = new TextBox();
        lblCPF = new Label();
        btnLimpar = new Button();
        btnBuscar = new Button();
        btnAtualizar = new Button();
        ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
        SuspendLayout();
        // 
        // menuNavegacao1
        // 
        menuNavegacao1.BackColor = Color.Transparent;
        menuNavegacao1.Location = new Point(12, 10);
        menuNavegacao1.Margin = new Padding(2, 3, 2, 3);
        menuNavegacao1.Name = "menuNavegacao1";
        menuNavegacao1.Size = new Size(166, 230);
        menuNavegacao1.TabIndex = 0;
        // 
        // dgvClientes
        // 
        dgvClientes.AllowUserToAddRows = false;
        dgvClientes.AllowUserToDeleteRows = false;
        dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvClientes.BackgroundColor = Color.LightBlue;
        dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvClientes.Location = new Point(201, 76);
        dgvClientes.Margin = new Padding(2, 3, 2, 3);
        dgvClientes.MultiSelect = false;
        dgvClientes.Name = "dgvClientes";
        dgvClientes.ReadOnly = true;
        dgvClientes.RowHeadersWidth = 45;
        dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvClientes.Size = new Size(462, 146);
        dgvClientes.TabIndex = 1;
        dgvClientes.CellClick += dgvClientes_CellClick;
        // 
        // txtBusca
        // 
        txtBusca.Font = new Font("Calibri", 12F);
        txtBusca.Location = new Point(201, 41);
        txtBusca.Margin = new Padding(2, 3, 2, 3);
        txtBusca.Name = "txtBusca";
        txtBusca.PlaceholderText = "(Nome, telefone, etc)";
        txtBusca.Size = new Size(285, 29);
        txtBusca.TabIndex = 2;
        // 
        // lblBuscar
        // 
        lblBuscar.AutoSize = true;
        lblBuscar.Font = new Font("Calibri", 12F, FontStyle.Bold);
        lblBuscar.Location = new Point(201, 16);
        lblBuscar.Margin = new Padding(2, 0, 2, 0);
        lblBuscar.Name = "lblBuscar";
        lblBuscar.Size = new Size(60, 22);
        lblBuscar.TabIndex = 3;
        lblBuscar.Text = "Buscar";
        // 
        // lblID
        // 
        lblID.AutoSize = true;
        lblID.Font = new Font("Calibri", 12F, FontStyle.Bold);
        lblID.Location = new Point(201, 231);
        lblID.Margin = new Padding(2, 0, 2, 0);
        lblID.Name = "lblID";
        lblID.Size = new Size(26, 22);
        lblID.TabIndex = 4;
        lblID.Text = "ID";
        // 
        // txtID
        // 
        txtID.Font = new Font("Calibri", 12F);
        txtID.Location = new Point(201, 256);
        txtID.Margin = new Padding(2, 3, 2, 3);
        txtID.Name = "txtID";
        txtID.ReadOnly = true;
        txtID.Size = new Size(115, 29);
        txtID.TabIndex = 5;
        // 
        // txtNome
        // 
        txtNome.Font = new Font("Calibri", 12F);
        txtNome.Location = new Point(320, 256);
        txtNome.Margin = new Padding(2, 3, 2, 3);
        txtNome.Name = "txtNome";
        txtNome.Size = new Size(343, 29);
        txtNome.TabIndex = 7;
        // 
        // lblNome
        // 
        lblNome.AutoSize = true;
        lblNome.Font = new Font("Calibri", 12F, FontStyle.Bold);
        lblNome.Location = new Point(320, 231);
        lblNome.Margin = new Padding(2, 0, 2, 0);
        lblNome.Name = "lblNome";
        lblNome.Size = new Size(56, 22);
        lblNome.TabIndex = 6;
        lblNome.Text = "Nome";
        // 
        // txtTelefone
        // 
        txtTelefone.Font = new Font("Calibri", 12F);
        txtTelefone.Location = new Point(201, 313);
        txtTelefone.Margin = new Padding(2, 3, 2, 3);
        txtTelefone.Name = "txtTelefone";
        txtTelefone.Size = new Size(229, 29);
        txtTelefone.TabIndex = 9;
        // 
        // lblTelefone
        // 
        lblTelefone.AutoSize = true;
        lblTelefone.Font = new Font("Calibri", 12F, FontStyle.Bold);
        lblTelefone.Location = new Point(201, 288);
        lblTelefone.Margin = new Padding(2, 0, 2, 0);
        lblTelefone.Name = "lblTelefone";
        lblTelefone.Size = new Size(74, 22);
        lblTelefone.TabIndex = 8;
        lblTelefone.Text = "Telefone";
        // 
        // txtCPF
        // 
        txtCPF.Font = new Font("Calibri", 12F);
        txtCPF.Location = new Point(434, 313);
        txtCPF.Margin = new Padding(2, 3, 2, 3);
        txtCPF.Name = "txtCPF";
        txtCPF.ReadOnly = true;
        txtCPF.Size = new Size(229, 29);
        txtCPF.TabIndex = 11;
        // 
        // lblCPF
        // 
        lblCPF.AutoSize = true;
        lblCPF.Font = new Font("Calibri", 12F, FontStyle.Bold);
        lblCPF.Location = new Point(434, 288);
        lblCPF.Margin = new Padding(2, 0, 2, 0);
        lblCPF.Name = "lblCPF";
        lblCPF.Size = new Size(38, 22);
        lblCPF.TabIndex = 10;
        lblCPF.Text = "CPF";
        // 
        // btnLimpar
        // 
        btnLimpar.Font = new Font("Calibri", 12F, FontStyle.Bold);
        btnLimpar.Location = new Point(580, 41);
        btnLimpar.Name = "btnLimpar";
        btnLimpar.Size = new Size(83, 29);
        btnLimpar.TabIndex = 12;
        btnLimpar.Text = "Limpar";
        btnLimpar.UseVisualStyleBackColor = true;
        btnLimpar.Click += btnLimpar_Click;
        // 
        // btnBuscar
        // 
        btnBuscar.Font = new Font("Calibri", 12F, FontStyle.Bold);
        btnBuscar.Location = new Point(491, 41);
        btnBuscar.Name = "btnBuscar";
        btnBuscar.Size = new Size(83, 29);
        btnBuscar.TabIndex = 13;
        btnBuscar.Text = "Buscar";
        btnBuscar.UseVisualStyleBackColor = true;
        btnBuscar.Click += btnBuscacr_Click;
        // 
        // btnAtualizar
        // 
        btnAtualizar.Enabled = false;
        btnAtualizar.Font = new Font("Calibri", 12F, FontStyle.Bold);
        btnAtualizar.Location = new Point(201, 348);
        btnAtualizar.Name = "btnAtualizar";
        btnAtualizar.Size = new Size(155, 29);
        btnAtualizar.TabIndex = 14;
        btnAtualizar.Text = "Salvar Alterações";
        btnAtualizar.UseVisualStyleBackColor = true;
        btnAtualizar.Click += btnAtualizar_Click;
        // 
        // FrmClientes
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.ActiveCaption;
        ClientSize = new Size(800, 397);
        Controls.Add(btnAtualizar);
        Controls.Add(btnBuscar);
        Controls.Add(btnLimpar);
        Controls.Add(txtCPF);
        Controls.Add(lblCPF);
        Controls.Add(txtTelefone);
        Controls.Add(lblTelefone);
        Controls.Add(txtNome);
        Controls.Add(lblNome);
        Controls.Add(txtID);
        Controls.Add(lblID);
        Controls.Add(lblBuscar);
        Controls.Add(txtBusca);
        Controls.Add(dgvClientes);
        Controls.Add(menuNavegacao1);
        Font = new Font("Calibri", 8.830189F, FontStyle.Bold);
        Margin = new Padding(2, 3, 2, 3);
        Name = "FrmClientes";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Clientes - Oficina";
        Load += FrmClientes_Load;
        ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private void label1_Click(object sender, EventArgs e)
    {
        throw new NotImplementedException();
    }

    #endregion

    private MenuNavegacao menuNavegacao1;
    private DataGridView dgvClientes;
    private TextBox txtBusca;
    private Label lblBuscar;
    private Label lblID;
    private TextBox txtID;
    private TextBox txtNome;
    private Label lblNome;
    private TextBox txtTelefone;
    private Label lblTelefone;
    private TextBox txtCPF;
    private Label lblCPF;
    private Button btnLimpar;
    private Button btnBuscar;
    private Button btnAtualizar;
}