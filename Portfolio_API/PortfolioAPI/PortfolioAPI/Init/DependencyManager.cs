using ApplicationServices.Mappers;
using ApplicationServices.Services.CVService;
using ApplicationServices.Services.CVService.Operations;
using Data.EF.Contexts.Portfolio;
using Data.EF.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Entity = Domain.Entities;
using Dto = Contracts.DTOs;

namespace PortfolioAPI.Init
{
    public static class DependencyManager
    {
        public static void InitializeDependencies(IServiceCollection services, IConfiguration configuration)
        {
            RegisterWebComponents(services);
            RegisterEfContexts(services, configuration);
            RegisterRepositories(services);
            RegisterServiceOperations(services);
            RegisterMappers(services);
            RegisterServices(services);
        }

        private static void RegisterWebComponents(IServiceCollection services)
        {
            services.AddMvc();
        }

        private static void RegisterEfContexts(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<PortfolioContext>(options => options.UseSqlServer(configuration.GetConnectionString("PortfolioDatabase")));
        }

        private static void RegisterRepositories(IServiceCollection services)
        {
            services.AddScoped<ICVRepository, CVRepository>();
        }

        private static void RegisterServiceOperations(IServiceCollection services)
        {
            services.AddTransient<IGetAllCVsOperation, GetAllCVsOperation>();
            services.AddTransient<IGetCvByIdOperation, GetCvByIdOperation>();
        }

        private static void RegisterMappers(IServiceCollection services)
        {
            services.AddTransient<IMapper<Entity.CV, Dto.CV>, CVMapper>();
            services.AddTransient<IMapper<Entity.CVEntry, Dto.CVEntry>, CVEntryMapper>();
        }

        private static void RegisterServices(IServiceCollection services)
        {
            services.AddTransient<ICVService, CVService>();
        }
    }
}
