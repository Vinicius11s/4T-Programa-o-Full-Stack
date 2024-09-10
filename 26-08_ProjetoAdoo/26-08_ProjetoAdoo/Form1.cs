using Entidades;

namespace _26_08_ProjetoAdoo
{
    public partial class Form1 : Form
    {
        Clientes cliente
            = new Clientes();//instanciado

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            gbdados.Enabled = false;
            btnnovo.Enabled = true;
            btnlocalizar.Enabled = true;
            btnexcluir.Enabled = false;
            btnsalvar.Enabled = false;
            btncancelar.Enabled = false;
            btnalterar.Enabled = false;

        }
        private void btnnovo_Click(object sender, EventArgs e)
        {
            gbdados.Enabled = true;
            btnnovo.Enabled = false;
            btnlocalizar.Enabled = false;
            btnexcluir.Enabled = false;
            btnsalvar.Enabled = true;
            btncancelar.Enabled = true;
            btnalterar.Enabled = false;
            limpar();
            txtnome.Focus();

        }
        void limpar()
        {
            txtid.Text = "";
            txtnome.Text = "";
        }

        private void btnalterar_Click(object sender, EventArgs e)
        {
            if (txtid.Text != "")
            {
                gbdados.Enabled = false;
                btnnovo.Enabled = false;
                btnlocalizar.Enabled = false;
                btnexcluir.Enabled = false;
                btnsalvar.Enabled = true;
                btncancelar.Enabled = true;
                btnalterar.Enabled = false;
                txtnome.Focus();
            }
            else
            {
                MessageBox.Show("Localize o cliente");
            }
        }
        public void carrega_propriedades()
        {
            cliente.nome = txtnome.Text;
            cliente.id = txtid.Text=="" ? 0 :int.Parse(txtid.Text);//se txtid.text for igual a ""
            cliente.datanascimento = txtdatanascimento.Value;     //ent o cliente.id = 0, senao recebe o o valor do txtid
        }
        private void btnsalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtnome.Text != String.Empty)//mesma coisa que diferente de vazio
                {
                    carrega_propriedades();

                    if(cliente.id == 0)
                    { //inserindo
                        new ClientesDAO().inserir(cliente);
                    }
                    

                    MessageBox.Show("Salvo com Sucesso.");

                    limpar();
                    gbdados.Enabled = false;
                    btnnovo.Enabled = true;
                    btnlocalizar.Enabled = true;
                    btnalterar.Enabled = false;
                    btncancelar.Enabled = false;
                    btnexcluir.Enabled = false;
                    btnsalvar.Enabled = false;
                }
                else MessageBox.Show("Preencha os campos.");

            }
            catch (Exception ex)//variavel ex para rec exexcao
            {

                MessageBox.Show("Erro ao Salvar ! " + ex.Message);
            }
        }
        private void btnexcluir_Click(object sender, EventArgs e)
        {
            if (txtid.Text != "")
            {
                MessageBox.Show("Excluido com Sucesso.");
                limpar();

                gbdados.Enabled = false;
                btnnovo.Enabled = true;
                btnlocalizar.Enabled = true;
                btnalterar.Enabled = false;
                btncancelar.Enabled = false;
                btnexcluir.Enabled = false;
                btnsalvar.Enabled = false;
            }
            else
            {
                MessageBox.Show("Localize o cliente");
            }
        }
        private void btncancelar_Click(object sender, EventArgs e)
        {
            limpar();
            gbdados.Enabled = false;
            btnnovo.Enabled = true;
            btnlocalizar.Enabled = true;
            btnalterar.Enabled = false;
            btncancelar.Enabled = false;
            btnexcluir.Enabled = false;
            btnsalvar.Enabled = false;
        }
        private void btnlocalizar_Click(object sender, EventArgs e)
        {
            limpar();
            gbdados.Enabled = false;
            btnnovo.Enabled = false;
            btnlocalizar.Enabled = false;
            btnalterar.Enabled = true;
            btncancelar.Enabled = true;
            btnexcluir.Enabled = true;
            btnsalvar.Enabled = false;
            txtnome.Focus();
        }
    }
}
