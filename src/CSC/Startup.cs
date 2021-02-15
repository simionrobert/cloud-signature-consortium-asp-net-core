/*
 * CSC Api
 *
 * This document contains the API descriprion
 *
 * OpenAPI spec version: 1.0.3.0
 * Contact: info@cloudsignatureconsortium.org
 */
using System;
using System.IO;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.SwaggerGen;
using CSC.Filters;
using CSC.Security;

namespace CSC
{
    /// <summary>
    /// Startup
    /// </summary>
    public class Startup
    {
        private readonly IWebHostEnvironment _hostingEnv;

        private IConfiguration Configuration { get; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="env"></param>
        /// <param name="configuration"></param>
        public Startup(IWebHostEnvironment env, IConfiguration configuration)
        {
            _hostingEnv = env;
            Configuration = configuration;
        }

        /// <summary>
        /// This method gets called by the runtime. Use this method to add services to the container.
        /// </summary>
        /// <param name="services"></param>
        public void ConfigureServices(IServiceCollection services)
        {
            // Add framework services.
            services
                .AddMvc(options =>
                {
                    options.InputFormatters.RemoveType<Microsoft.AspNetCore.Mvc.Formatters.SystemTextJsonInputFormatter>();
                    options.OutputFormatters.RemoveType<Microsoft.AspNetCore.Mvc.Formatters.SystemTextJsonOutputFormatter>();
                })
                .AddNewtonsoftJson(opts =>
                {
                    opts.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
                    opts.SerializerSettings.Converters.Add(new StringEnumConverter(new CamelCaseNamingStrategy()));
                })
                .AddXmlSerializerFormatters();

            services.AddAuthentication(BasicAuthenticationHandler.SchemeName)
                .AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>(BasicAuthenticationHandler.SchemeName, null);

            services.AddAuthentication(BearerAuthenticationHandler.SchemeName)
                .AddScheme<AuthenticationSchemeOptions, BearerAuthenticationHandler>(BearerAuthenticationHandler.SchemeName, null);


            services
                .AddSwaggerGen(c =>
                {
                    c.SwaggerDoc("1.0.3.0", new OpenApiInfo
                    {
                        Version = "1.0.3.0",
                        Title = "CSC Api",
                        Description = "CSC Api (ASP.NET Core 3.1)",
                        Contact = new OpenApiContact()
                        {
                            Name = "Cloud Signature Consortium",
                            Url = new Uri("https://cloudsignatureconsortium.org/"),
                            Email = "info@cloudsignatureconsortium.org"
                        },
                        TermsOfService = new Uri("")
                    });
                    c.CustomSchemaIds(type => type.FullName);
                    c.IncludeXmlComments($"{AppContext.BaseDirectory}{Path.DirectorySeparatorChar}{_hostingEnv.ApplicationName}.xml");
                    // Sets the basePath property in the Swagger document generated
                    c.DocumentFilter<BasePathFilter>("/csc/v1/");

                    // Include DataAnnotation attributes on Controller Action parameters as Swagger validation rules (e.g required, pattern, ..)
                    // Use [ValidateModelState] on Actions to actually validate it in C# as well!
                    c.OperationFilter<GeneratePathParamsValidationFilter>();
                });
        }

        /// <summary>
        /// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        /// </summary>
        /// <param name="app"></param>
        /// <param name="env"></param>
        /// <param name="loggerFactory"></param>
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory loggerFactory)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                //TODO: Enable production exception handling (https://docs.microsoft.com/en-us/aspnet/core/fundamentals/error-handling)
                app.UseExceptionHandler("/Error");

                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();
            //TODO: Uncomment this if you need wwwroot folder
            // app.UseStaticFiles();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                //TODO: Either use the SwaggerGen generated Swagger contract (generated from C# classes)
                c.SwaggerEndpoint("/swagger/1.0.3.0/swagger.json", "CSC Api");

                //TODO: Or alternatively use the original Swagger contract that's included in the static files
                // c.SwaggerEndpoint("/swagger-original.json", "CSC Api Original");
            });
        }
    }
}
