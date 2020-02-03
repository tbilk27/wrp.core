using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using wrp.core.Application;
using wrp.core.Database;

namespace wrp.core
{
    public class Program
    {
        private static IServiceProvider _serviceProvider;
        private static IConfigurationRoot _configuration;

        public static void Main(string[] args)
        {
            BuildConfigurations();

            RegisterServices();

            Run(args);
        }

        private static void BuildConfigurations()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true);

            _configuration = builder.Build();
        }

        private static void RegisterServices()
        {
            var services = new ServiceCollection();

            services.AddSingleton(typeof(IConfigurationRoot), sp => _configuration);
            services.AddSingleton<IStartup, Startup>();
            IoC.Register(services, _configuration);
            _serviceProvider = services.BuildServiceProvider();
        }

        private static void Run(string[] args)
        {
            //TODO: verificar para recriar banco por parâmetro
            _serviceProvider.GetService<WrpContext>().RecriarBanco();
            _serviceProvider.GetService<IStartup>().Run();
        }
    }
}
