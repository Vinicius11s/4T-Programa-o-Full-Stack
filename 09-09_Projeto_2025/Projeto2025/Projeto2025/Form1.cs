namespace Projeto2025
{
    using Entidades;
    using Infoestrutura;
    using Infoestrutura.Contexto;

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var contexto = new ContextoEmpresa())
            { }
        }
    }
}
