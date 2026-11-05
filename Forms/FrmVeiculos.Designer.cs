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
        // FrmVeiculos
        // 
        AutoScaleDimensions = new SizeF(7F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.ActiveCaption;
        ClientSize = new Size(800, 450);
        Controls.Add(menuNavegacao1);
        Name = "FrmVeiculos";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Veiculos - Oficina";
        ResumeLayout(false);
    }

    #endregion

    private MenuNavegacao menuNavegacao1;
}