using Api.Data.Context;
using Api.Data.Implementations;
using Api.Data.Repository;
using Api.Domain.Interfaces;
using Api.Domain.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Api.CrossCutting.DependencyInjenction
{
    public class ConfigureRepository
    {
        public static void ConfigureDependenciesRepository(IServiceCollection serviceCollection){
            serviceCollection.AddScoped(typeof (IRepository<>), typeof(BaseRepository<>));
            serviceCollection.AddScoped<IUserRepository, UserImplementationcs>();
            serviceCollection.AddDbContext<MyContext>( options => options.UseSqlServer(
                "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=CSharpApi;Data Source=LAPTOP-BQIMSF2O\\SQLEXPRESS"));
        }
    }
}