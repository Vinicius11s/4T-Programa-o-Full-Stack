namespace Aula_Adoo
{
    public partial class Form1 : Form
    {
        MetodoPagamento metodo;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            try
            {
                List<int> list = new List<int>();

                int numero = int.Parse(txtnumero.Text);

                list.Add(numero);

                for (int i = 0; i < 5; i++)
                {
                    MessageBox.Show(list[i].ToString());
                }
                if (numero >= 18)
                {
                    MessageBox.Show("Maior de Idade !");

                }
                else
                    MessageBox.Show("Menor de Idade !");
            }

            catch (ArgumentOutOfRangeException)//(ArgumentOutOfRangeException)somente quando acessa
                                               //posi��o inesistente

            {
                MessageBox.Show("Acessou uma posi��o inexistente",
                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)//Sempre Ultimo, classe mais gen�rica, sempre precisa ser implementada
            {
                MessageBox.Show("Erro ao Efetuar C�lculo: " + ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            if(metodo == MetodoPagamento.Pix)
            {
                MessageBox.Show("Pagamento por Pix Confirmado! R$" 
                    + txtvalor.Text);
            }

            if(metodo == MetodoPagamento.Dinheiro)
            {
                MessageBox.Show("Pagamento em Dinheiro Confirmado! R$"
                    + txtvalor.Text);
            }

            if (metodo == MetodoPagamento.Cartao_debito)
            {
                MessageBox.Show("Pagamento por Cartao de d�bito Confirmado! R$"
                    + txtvalor.Text);
            }
            if (metodo == MetodoPagamento.Cartao_credito)
            {
                MessageBox.Show("Pagamento por Cartao de cr�dito Confirmado! R$"
                    + txtvalor.Text);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)//Boa pr�tica
            {
                case 0:
                    metodo = MetodoPagamento.Dinheiro;
                    break;

                case 1:
                    metodo = MetodoPagamento.Cartao_debito;
                    break;

                case 2:
                    metodo = MetodoPagamento.Cartao_credito;
                    break;
                case 3:
                    metodo = MetodoPagamento.Pix;
                    break;
            }
        }
    }
}

public enum MetodoPagamento
{
    //Boa pr�tica
    Dinheiro = 1,
    Cartao_debito = 2,
    Cartao_credito = 3,
    Pix = 4


}