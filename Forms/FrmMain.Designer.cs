namespace OficinaSAEP.Forms;

partial class FrmMain
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
        components = new System.ComponentModel.Container();
        btnClientes = new Button();
        btnAgendar = new Button();
        btnVeiculos = new Button();
        contextMenuStrip1 = new ContextMenuStrip(components);
        menuNavegacao1 = new MenuNavegacao();
        SuspendLayout();
        // 
        // btnClientes
        // 
        btnClientes.Font = new Font("Calibri", 15F, FontStyle.Bold);
        btnClientes.Location = new Point(204, 153);
        btnClientes.Name = "btnClientes";
        btnClientes.Size = new Size(105, 43);
        btnClientes.TabIndex = 7;
        btnClientes.Text = "Clientes";
        btnClientes.UseVisualStyleBackColor = true;
        btnClientes.Click += btnClientes_Click;
        // 
        // btnAgendar
        // 
        btnAgendar.Font = new Font("Calibri", 15F, FontStyle.Bold);
        btnAgendar.Location = new Point(481, 153);
        btnAgendar.Name = "btnAgendar";
        btnAgendar.Size = new Size(105, 43);
        btnAgendar.TabIndex = 9;
        btnAgendar.Text = "Agendar";
        btnAgendar.UseVisualStyleBackColor = true;
        btnAgendar.Click += btnAgendar_Click;
        // 
        // btnVeiculos
        // 
        btnVeiculos.Font = new Font("Calibri", 15F, FontStyle.Bold);
        btnVeiculos.Location = new Point(343, 153);
        btnVeiculos.Name = "btnVeiculos";
        btnVeiculos.Size = new Size(105, 43);
        btnVeiculos.TabIndex = 10;
        btnVeiculos.Text = "Veiculos";
        btnVeiculos.UseVisualStyleBackColor = true;
        btnVeiculos.Click += btnVeiculos_Click;
        // 
        // contextMenuStrip1
        // 
        contextMenuStrip1.ImageScalingSize = new Size(18, 18);
        contextMenuStrip1.Name = "contextMenuStrip1";
        contextMenuStrip1.Size = new Size(61, 4);
        // 
        // menuNavegacao1
        // 
        menuNavegacao1.BackColor = Color.Transparent;
        menuNavegacao1.Location = new Point(12, 2);
        menuNavegacao1.Name = "menuNavegacao1";
        menuNavegacao1.Size = new Size(166, 261);
        menuNavegacao1.TabIndex = 11;
        // 
        // FrmMain
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.ActiveCaption;
        ClientSize = new Size(800, 397);
        Controls.Add(menuNavegacao1);
        Controls.Add(btnVeiculos);
        Controls.Add(btnAgendar);
        Controls.Add(btnClientes);
        Font = new Font("Calibri", 8.830189F);
        Name = "FrmMain";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Principal - Oficina";
        ResumeLayout(false);
    }

    #endregion
    private Label lblAgendamentos;
    private Button btnClientes;
    private Button button2;
    private Button btnAgendar;
    private Button btnVeiculos;
    private ContextMenuStrip contextMenuStrip1;
    private MenuNavegacao menuNavegacao1;
}