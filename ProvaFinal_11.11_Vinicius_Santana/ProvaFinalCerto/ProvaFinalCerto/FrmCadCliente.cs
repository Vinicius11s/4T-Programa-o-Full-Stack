using Entidades;
using Infraestrutura.Contexto;
using Infraestrutura.Repositorio;
using Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProvaFinalCerto
{
    public partial class FrmCadCliente : Form
    {
        private IClienteRepositorio repositorio;
        private IEnderecoRepositorio reposositorioEndereco;
        public FrmCadCliente(IClienteRepositorio repositorio, IEnderecoRepositorio repositorioEndereco)
        {
            InitializeComponent();
            this.repositorio = repositorio;
            this.reposositorioEndereco = repositorioEndereco;
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtnome.Text != String.Empty)
                {
                    Cliente cliente = carregaPropriedades();

                    if (cliente.id == 0)
                    {
                        repositorio.Inserir(cliente);
                    }
                    Program.serviceProvider.
                        GetRequiredService<ContextoSistema>().SaveChanges();
                    MessageBox.Show("Salvo com sucesso");

                    limpar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar" + ex.Message);

                throw;
            }
        }
        public Cliente carregaPropriedades()
        {
            Cliente cliente;
            if (txtid.Text != "")
            {
                cliente = repositorio.Recuperar(c => c.id == int.Parse(txtid.Text));
            }
            else cliente = new Cliente(); //inserir

            cliente.id = txtid.Text == "" ? 0 : int.Parse(txtid.Text);
            cliente.Nome = txtnome.Text;
            cliente.Email = txtemail.Text;

            return cliente;
        }
        void limpar()
        {
            txtid.Text = "";
            txtnome.Text = "";
            txtemail.Text = "";

        }


    }
}
