using Infraestrutura.Contexto;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProvaFinalCerto
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form2 = Program.serviceProvider.GetRequiredService<FrmCadCliente>();
            form2.ShowDialog();
        }

        private void endereçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form2 = Program.serviceProvider.GetRequiredService<FrmCadEndereco>();
            form2.ShowDialog();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            using (var contexto = new ContextoSistema()) { }
        }
    }
}
