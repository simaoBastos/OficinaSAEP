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

public partial class MenuNavegacao : UserControl
{
    public MenuNavegacao()
    {
        InitializeComponent();
    }

    private void AbrirFormulario(Form novoFormulario)
    {
        Form formularioAtual = this.FindForm();
        novoFormulario.Show();
        formularioAtual.Close();
    }

    private void lblInicio_Click(object sender, EventArgs e)
    {
        AbrirFormulario(new FrmMain());

    }

    private void lblClientes_Click(object sender, EventArgs e)
    {
        AbrirFormulario(new FrmClientes());
    }

    private void lblVeiculo_Click(object sender, EventArgs e)
    {
        AbrirFormulario(new FrmVeiculos());

    }

    private void lblAgendar_Click(object sender, EventArgs e)
    {
        AbrirFormulario(new FrmAgendar());
    }

    private void lblSair_Click(object sender, EventArgs e)
    {
       FrmLogin frmLogin = Application.OpenForms.OfType<FrmLogin>().FirstOrDefault();
        frmLogin ??= new FrmLogin();
        frmLogin.LimparCampos();
        frmLogin.Show();
        this.FindForm().Close();
    }
}
