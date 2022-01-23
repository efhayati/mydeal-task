using MyShop.Data;

namespace MyShop.Web;

public class Startup
{
    public void ConfigureServices(IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped(typeof(IRepository<>))
    }
}

