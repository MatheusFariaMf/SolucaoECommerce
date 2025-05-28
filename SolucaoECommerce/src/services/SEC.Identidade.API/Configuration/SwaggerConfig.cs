using Microsoft.OpenApi.Models;

namespace SEC.Identidade.API.Configuration
{
    public static class SwaggerConfig
    {
        public static IServiceCollection AddSwaggerConfiguration(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "SolucaoECommerce Identity API",
                    Description = "Esta API é responsável pelo registro e login do usuário",
                    Contact = new OpenApiContact() { Name = "Matheus Faria", Email = "matheus@email.com" },
                    License = new OpenApiLicense() { Name = "MIT", Url = new Uri("https://opensource.org/licenses/MIT") }
                });
            }
);
            return services;
        }
    }
}
