using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Ocelot.DependencyInjection;
using Ocelot.Middleware;
using IdentityServer4.AccessTokenValidation;
using Microsoft.Extensions.Configuration;

namespace APIGateway
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddOcelot();

            var builder = services.AddAuthentication(IdentityServerAuthenticationDefaults.AuthenticationScheme);
            IdentityServerConfig identityServerConfig = new IdentityServerConfig();
            Configuration.Bind("IdentityServerConfig", identityServerConfig);
            if (identityServerConfig != null && identityServerConfig.Resources != null)
            {
                foreach (var resource in identityServerConfig.Resources)
                {
                    builder.AddIdentityServerAuthentication(resource.Key, options =>
                    {
                        options.Authority = $"{identityServerConfig.Protocol}://{identityServerConfig.IP}:{identityServerConfig.Port}";
                        options.RequireHttpsMetadata = false; //TODO: turn on in prod
                        options.ApiName = resource.Name;
                      
                        //options.SupportedTokens = SupportedTokens.Reference;
                    });
                }
            }
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseRouting();

            app.UseOcelot().Wait();
        }
    }
}
