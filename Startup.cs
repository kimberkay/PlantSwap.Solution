using System.Reflection;
using System.IO;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using System;
using PlantSwap.Models;

namespace PlantSwap
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
        services.AddDbContext<PlantSwapContext>(opt =>
        opt.UseMySql(Configuration["ConnectionStrings:DefaultConnection"], ServerVersion.AutoDetect(Configuration["ConnectionStrings:DefaultConnection"])));
        services.AddControllers();

        services.AddCors(options =>
        {
         options.AddDefaultPolicy(builder=>builder.WithOrigins("Https://localhost:5002"));
         options.AddPolicy("outside", builder => builder.AllowAnyOrigin());
        });

        services.AddSwaggerGen(c => {
        c.SwaggerDoc("v1", new OpenApiInfo{
            Version = "v1",
            Title = "Plant Swap API",
            Description = "Collection of Plant Based Swaps",
            Contact = new OpenApiContact
            {
            Name = "Kim Brannian",
            Email = string.Empty,
            Url = new Uri("https://github.com/kimberkay")
            },
            License = new OpenApiLicense
            {
            Name = "Use under MIT",
            Url = new Uri("https://opensource.org/licenses/MIT")
            }
            });
        });
    }


    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
        app.UseDeveloperExceptionPage();
        }
        app.UseSwagger();
        app.UseSwaggerUI(c =>
        {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Plant Swap API V1");
        c.RoutePrefix = string.Empty;
        });

      // app.UseHttpsRedirection();

        app.UseRouting();

        app.UseCors();

        app.UseAuthorization();

        app.UseEndpoints(endpoints =>
        {
        endpoints.MapControllers();
        });
    }
  }
}
           
