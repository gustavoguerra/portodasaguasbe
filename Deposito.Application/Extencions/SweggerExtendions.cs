using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.PlatformAbstractions;
using Microsoft.OpenApi.Models;
using System;
using System.IO;

namespace Deposito.Application.Extencions
{
    public static class SweggerExtendions
    {
        public static void SwaggerServices(this IServiceCollection services, IConfiguration configuration)
        {
            // Register the Swagger generator, defining 1 or more Swagger documents
            services.AddSwaggerGen(c =>
            {
                var securityScheme = new OpenApiSecurityScheme
                {
                    Name = "JWT Authentication",
                    Description = "Enter JWT Bearer token **_only_**",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.Http,
                    Scheme = "bearer", // must be lower case
                    BearerFormat = "JWT",
                    Reference = new OpenApiReference
                    {
                        Id = JwtBearerDefaults.AuthenticationScheme,
                        Type = ReferenceType.SecurityScheme
                    }
                };

                c.AddSecurityDefinition(securityScheme.Reference.Id, securityScheme);
                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {securityScheme, new string[] { }}
                });

                var basicSecurityScheme = new OpenApiSecurityScheme
                {
                    Type = SecuritySchemeType.Http,
                    Scheme = "basic",
                    Reference = new OpenApiReference { Id = "Login Auth", Type = ReferenceType.SecurityScheme }
                };

                c.AddSecurityDefinition(basicSecurityScheme.Reference.Id, basicSecurityScheme);
                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    { basicSecurityScheme , new  string[] { } }
                });

                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "Porto das Aguas",
                    Version = "v1",
                    Description = "Porto das Aguas",
                    Contact = new OpenApiContact
                    {
                        Name = "Only R - Only Research",
                        Email = "vilageportodasaguas@hotmail.com",
                        Url = new Uri("https://github.com/gustavoguerra/portodasaguasbe")
                    }
                });
                var caminhoAplicacao =
                PlatformServices.Default.Application.ApplicationBasePath;
                var caminhoXmlDoc =
                    Path.Combine(caminhoAplicacao, $"Deposito.Application.xml");
            });
        }

        public static void SwaggerApplication(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Porto das Aguas");
                c.RoutePrefix = "api/docs";
            });
        }
    }
}
