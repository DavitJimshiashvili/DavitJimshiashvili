using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using RealEstateW.PresistanceDB.Context;
using RealEstateW.PresistanceDB.Seed;
using RealEstateW.Services.JWT;
using RealEstateWeb.Infrastructure.Exstensions;
using RealEstateWeb.Infrastructure.Mappings;
using RealEstateWeb.Infrastructure.Middlewares;

namespace RealEstateWeb
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "RealEstate API",
                    Version = "v1"
                });
                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    In = ParameterLocation.Header,
                    Description = "Please insert JWT with Bearer into field - \"Bearer _token_\"",
                    Name = "Authorization",
                    Type = SecuritySchemeType.ApiKey
                });
                c.AddSecurityRequirement(new OpenApiSecurityRequirement {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = "Bearer"
                            }
                        },
                        new string[] { }
                    }
                });
            });



            services.AddServices();
            services.RegisterMaps();
            services.AddTokenAuthentication(Configuration);
            services.Configure<JWTConfiguration>(Configuration.GetSection(nameof(JWTConfiguration)));


            services.AddDbContext<RealEstateContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

        }


        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger();
            app.UseSwaggerUI();
            app.UseMiddleware<ExceptionHandlerMiddleware>();


            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            RealEstateSeed.Initialize(app.ApplicationServices);

        }
    }
}
