using System;
using System.Reflection;

using FluentNHibernate.Cfg;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using NHibernate;

using Solution.Aplicacao.Faccoes.Profiles;
using Solution.Aplicacao.Faccoes.Servicos;
using Solution.Dominio.Faccoes.Services;
using Solution.Infra.Faccoes.Mapeamentos;
using Solution.Infra.Faccoes.Repositorios;
using Solution.Infra.Utils;

namespace Solution.IOC
{
    public class NativeInjectorBootStrapper
    {
        private static ISessionFactory CreateSession<T>(string connectionString)
        {
            return Fluently.Configure()
                .Database(FluentNHibernate.Cfg
                                       .Db
                                       .OracleManagedDataClientConfiguration
                                       .Oracle10
                                       .ConnectionString(connectionString)
                                       .FormatSql()
                                       .ShowSql()
                )
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<T>())
                .BuildConfiguration()
                .BuildSessionFactory(); ;
        }
        public static void InjectServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton(factory => CreateSession<FaccoesMap>(configuration.GetConnectionString("connection")));
            services.AddScoped<ISession>(factory =>
            {
                return factory.GetService<ISessionFactory>().OpenSession();
            });
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddAutoMapper(typeof(FaccoesProfile).GetTypeInfo().Assembly);

            services.Scan(scan => scan.
                                    FromAssemblyOf<FaccoesServicos>()
                                    .AddClasses()
                                    .AsImplementedInterfaces()
                                    .WithTransientLifetime());

            services.Scan(scan => scan.
                                    FromAssemblyOf<FaccoesAppServico>()
                                    .AddClasses()
                                    .AsImplementedInterfaces()
                                    .WithTransientLifetime());

            services.Scan(scan => scan.
                                    FromAssemblyOf<FaccoesRepositorio>()
                                    .AddClasses()
                                    .AsImplementedInterfaces()
                                    .WithTransientLifetime());

        }
    }
}
