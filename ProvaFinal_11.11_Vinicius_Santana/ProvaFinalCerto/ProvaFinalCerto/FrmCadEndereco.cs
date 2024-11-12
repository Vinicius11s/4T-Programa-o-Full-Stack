using Entidades;
using Infraestrutura.Contexto;
using Interfaces;
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
    public partial class FrmCadEndereco : Form
    {
        private IEnderecoRepositorio repositorio;
        private IClienteRepositorio clienteRepositorio;
        public FrmCadEndereco(IEnderecoRepositorio repositorio, IClienteRepositorio clienteRepositorio)
        {
            InitializeComponent();
            this.repositorio = repositorio;
            this.clienteRepositorio = clienteRepositorio;
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            if (txtrua.Text != string.Empty)
            {
                Endereco endereco = carregaPropriedades();

                if (cbbclientes.SelectedItem != null)
                {
                    endereco.idCliente = (int)cbbclientes.SelectedValue;
                }
                else
                {
                    MessageBox.Show("Selecione um cliente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var contexto = Program.serviceProvider.GetRequiredService<ContextoSistema>();

                if (endereco.id == 0)
                {
                    contexto.Endereco.Add(endereco);
                }
              

                contexto.SaveChanges();

                MessageBox.Show("Endereço salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public Endereco carregaPropriedades()
        {
            Endereco endereco;

            if (!string.IsNullOrEmpty(txtid.Text))
            {
                // Verifica se existe uma entrada com o ID informado
                endereco = repositorio.Recuperar(c => c.id == int.Parse(txtid.Text)) ?? new Endereco();
            }
            else
            {
                endereco = new Endereco(); // Novo endereço
            }

            endereco.Rua = txtrua.Text;
            endereco.Cidade = txtcidade.Text;

            return endereco;
        }

        void limpar()
        {
            txtid.Text = "";
            txtrua.Text = "";
            txtcidade.Text = "";

        }

        private void FrmCadEndereco_Load(object sender, EventArgs e)
        {
            var clientes = clienteRepositorio.Listar(e => true);

            if (clientes != null && clientes.Any())
            {
                cbbclientes.DataSource = clientes;
                cbbclientes.DisplayMember = "Nome"; 
                cbbclientes.ValueMember = "Id";    
            }
            else
            {
                MessageBox.Show("Nenhum cliente encontrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
