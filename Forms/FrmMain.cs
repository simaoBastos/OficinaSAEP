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

public partial class FrmMain : Form
{
    public FrmMain()
    {
        InitializeComponent();
    }

    private void panel1_Paint(object sender, PaintEventArgs e)
    {

    }
    private void lblInicio_Click(object sender, EventArgs e)
    {
        FrmMain frmMain = new FrmMain();
        frmMain.Show();
        this.Hide();

    }

    private void lblClientes_Click(object sender, EventArgs e)
    {
        FrmClientes frmClientes = new FrmClientes();
        frmClientes.Show();
        this.Hide();
    }

    private void lblVeiculo_Click(object sender, EventArgs e)
    {
        FrmVeiculos frmVeiculos = new FrmVeiculos();
        frmVeiculos.Show();
        this.Hide();

    }

    private void lblAgendar_Click(object sender, EventArgs e)
    {
        FrmAgendar frmAgendar = new FrmAgendar();
        frmAgendar.Show();
        this.Hide();
    }

    private void lblSair_Click(object sender, EventArgs e)
    {
        FrmLogin frmLogin = new FrmLogin();
        frmLogin.Show();
        this.Hide();
    }
    private void btnClientes_Click(object sender, EventArgs e)
    {
        FrmClientes frmClientes = new FrmClientes();
        frmClientes.Show();
        this.Hide();
    }
    private void btnVeiculos_Click(object sender, EventArgs e)
    {
        FrmVeiculos frmVeiculos = new FrmVeiculos();
        frmVeiculos.Show();
        this.Hide();
    }

    private void btnAgendar_Click(object sender, EventArgs e)
    {
        FrmAgendar frmAgendar = new FrmAgendar();
        frmAgendar.Show();
        this.Hide();
    }

}
