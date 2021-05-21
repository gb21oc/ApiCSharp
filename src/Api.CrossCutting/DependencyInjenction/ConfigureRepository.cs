using Api.Data.Context;
using Api.Data.Repository;
using Api.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Api.CrossCutting.DependencyInjenction
{
    public class ConfigureRepository
    {
        public static void ConfigureDependenciesRepository(IServiceCollection serviceCollection){
            serviceCollection.AddScoped(typeof (IRepository<>), typeof(BaseRepository<>));
            serviceCollection.AddDbContext<MyContext>( options => options.UseSqlServer(
                "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=CSharpApi;Data Source=LAPTOP-BQIMSF2O\\SQLEXPRESS"));
        }
    }
}