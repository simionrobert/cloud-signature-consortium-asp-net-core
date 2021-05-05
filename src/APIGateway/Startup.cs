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
            if (identityServerConfig != null && identityServerConfig.Resource != null)
            {
                builder.AddIdentityServerAuthentication(identityServerConfig.Resource.Key, options =>
                {
                    options.Authority = $"{identityServerConfig.Protocol}://{identityServerConfig.IP}:{identityServerConfig.Port}";
                    options.RequireHttpsMetadata = false; //TODO: turn on in prod
                    options.ApiSecret = "apisecret";
                    options.ApiName = identityServerConfig.Resource.Name;
                   
                });
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
