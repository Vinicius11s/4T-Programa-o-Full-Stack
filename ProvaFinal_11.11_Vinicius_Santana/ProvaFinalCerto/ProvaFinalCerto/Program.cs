using Infraestrutura.Contexto;
using InfraEstrutura.Repositorio;
using Microsoft.Extensions.DependencyInjection;
using Interfaces;
using System;
using Entidades;
using ProvaFinalCerto;
using Infraestrutura.Repositorio;

namespace ProvaFinalCerto
{
    internal static class Program
    {
        public static ServiceProvider serviceProvider;

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            var services = new ServiceCollection();
            ConfigureServices(services);

            using (serviceProvider = services.BuildServiceProvider())
            {
                var mainForm = serviceProvider.GetRequiredService
                                                <FrmPrincipal>();

                Application.Run(mainForm);
            }
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddDbContext<ContextoSistema>();
            services.AddScoped<FrmPrincipal>();
            services.AddScoped<FrmCadCliente>();
            services.AddScoped<FrmCadEndereco>();

            services.AddScoped<IClienteRepositorio, ClienteRepositorio>();
            services.AddScoped<IEnderecoRepositorio, EnderecoRepositorio>();


        }
    }
}