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

public partial class FrmVeiculos : Form
{
    public FrmVeiculos()
    {
        InitializeComponent();
    }

    private void lblSair_Click(object sender, EventArgs e)
    {
        FrmLogin frmLogin = new FrmLogin();
        frmLogin.Show();
        this.Hide();
    }
}
