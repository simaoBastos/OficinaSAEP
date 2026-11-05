namespace OficinaSAEP.Forms;

partial class MenuNavegacao
{
    /// <summary> 
    /// Variável de designer necessária.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Limpar os recursos que estão sendo usados.
    /// </summary>
    /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Código gerado pelo Designer de Componentes

    /// <summary> 
    /// Método necessário para suporte ao Designer - não modifique 
    /// o conteúdo deste método com o editor de código.
    /// </summary>
    private void InitializeComponent()
    {
        panel1 = new Panel();
        lblAgendar = new Label();
        lblInicio = new Label();
        lblSair = new Label();
        lblClientes = new Label();
        lblVeiculo = new Label();
        panel1.SuspendLayout();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.Controls.Add(lblAgendar);
        panel1.Controls.Add(lblInicio);
        panel1.Controls.Add(lblSair);
        panel1.Controls.Add(lblClientes);
        panel1.Controls.Add(lblVeiculo);
        panel1.Location = new Point(0, 16);
        panel1.Name = "panel1";
        panel1.Size = new Size(150, 204);
        panel1.TabIndex = 7;
        // 
        // lblAgendar
        // 
        lblAgendar.Font = new Font("Calibri", 15F, FontStyle.Bold);
        lblAgendar.ForeColor = SystemColors.ActiveCaptionText;
        lblAgendar.ImeMode = ImeMode.NoControl;
        lblAgendar.Location = new Point(3, 99);
        lblAgendar.Name = "lblAgendar";
        lblAgendar.Size = new Size(92, 29);
        lblAgendar.TabIndex = 6;
        lblAgendar.Text = "Agendar";
        lblAgendar.Click += lblAgendar_Click;
        // 
        // lblInicio
        // 
        lblInicio.Font = new Font("Calibri", 15F, FontStyle.Bold);
        lblInicio.ForeColor = SystemColors.ActiveCaptionText;
        lblInicio.ImeMode = ImeMode.NoControl;
        lblInicio.Location = new Point(3, 9);
        lblInicio.Name = "lblInicio";
        lblInicio.Size = new Size(92, 29);
        lblInicio.TabIndex = 4;
        lblInicio.Text = "Início";
        lblInicio.Click += lblInicio_Click;
        // 
        // lblSair
        // 
        lblSair.Font = new Font("Calibri", 15F, FontStyle.Bold);
        lblSair.ForeColor = Color.Firebrick;
        lblSair.ImeMode = ImeMode.NoControl;
        lblSair.Location = new Point(3, 171);
        lblSair.Name = "lblSair";
        lblSair.Size = new Size(92, 29);
        lblSair.TabIndex = 5;
        lblSair.Text = "Sair";
        lblSair.Click += lblSair_Click;
        // 
        // lblClientes
        // 
        lblClientes.Font = new Font("Calibri", 15F, FontStyle.Bold);
        lblClientes.ForeColor = SystemColors.ActiveCaptionText;
        lblClientes.ImeMode = ImeMode.NoControl;
        lblClientes.Location = new Point(3, 38);
        lblClientes.Name = "lblClientes";
        lblClientes.Size = new Size(92, 29);
        lblClientes.TabIndex = 1;
        lblClientes.Text = "Clientes";
        lblClientes.Click += lblClientes_Click;
        // 
        // lblVeiculo
        // 
        lblVeiculo.Font = new Font("Calibri", 15F, FontStyle.Bold);
        lblVeiculo.ForeColor = SystemColors.ActiveCaptionText;
        lblVeiculo.ImeMode = ImeMode.NoControl;
        lblVeiculo.Location = new Point(3, 67);
        lblVeiculo.Name = "lblVeiculo";
        lblVeiculo.Size = new Size(92, 32);
        lblVeiculo.TabIndex = 2;
        lblVeiculo.Text = "Veículos";
        lblVeiculo.Click += lblVeiculo_Click;
        // 
        // MenuNavegacao
        // 
        AutoScaleDimensions = new SizeF(7F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.Transparent;
        Controls.Add(panel1);
        Name = "MenuNavegacao";
        Size = new Size(150, 236);
        panel1.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private Panel panel1;
    private Label lblAgendar;
    private Label lblInicio;
    private Label lblSair;
    private Label lblClientes;
    private Label lblVeiculo;
}
