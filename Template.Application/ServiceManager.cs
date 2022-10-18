

using Template.Domain.DieselDomain;
using Template.Domain.ElectricDomain;
using Template.Domain.GasolineDomain;

namespace Template.WebAPI
{
    public static class ServiceManager
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddSingleton<IDieselDomain, DieselDomain>();
            services.AddSingleton<IElectricDomain, ElectricAdapter>();
            services.AddSingleton<IGasolineDomain, GasolineDomain>();
            return services;
        }
    }
}
