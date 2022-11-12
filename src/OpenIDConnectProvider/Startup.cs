using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using IdentityServer4;

namespace OpenIDConnectProvider
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            var section = Configuration.GetSection("SSOConfig");
            services.AddControllersWithViews();
            services.AddIdentityServer(opts =>
            {
                opts.Endpoints.EnableDeviceAuthorizationEndpoint = false;
                opts.Endpoints.EnableUserInfoEndpoint = false;
                opts.Endpoints.EnableJwtRequestUri = false;
                opts.Endpoints.EnableDiscoveryEndpoint = false;
            })
                    .AddInMemoryApiResources(Config.GetApiResources(section))
                    .AddInMemoryApiScopes(Config.ApiScopes)
                    .AddInMemoryClients(Config.Clients)
                    .AddTestUsers(Config.Users)
                    .AddDeveloperSigningCredential();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();
            app.UseRouting();

            app.UseIdentityServer();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
            });
        }
    }
}
