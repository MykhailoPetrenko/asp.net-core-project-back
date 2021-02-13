using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Party.DB;
using Party.WebApi.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Party.WebApi
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

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                    .AddScheme<AuthenticationSchemeOptions, JwtAuthHandler>(SchemeName.FirebaseAuthScheme, o => { })
                    .AddJwtBearer(JwtBearerDefaults.AuthenticationScheme, options =>
                    {
                        string authority = "https://securetoken.google.com/mas-project-ae223";
                        string audience = "mas-project-ae223";

                        options.Audience = audience;
                        options.Authority = authority;
                        options.TokenValidationParameters = new TokenValidationParameters
                        {
                            ValidateIssuer = true,
                            ValidIssuer = authority,
                            ValidateAudience = true,
                            ValidAudience = audience,
                            ValidateLifetime = true,
                        };
                    });
            services.AddDbContext<AppDbContext>(opt => opt.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=party;Integrated Security=True"));
            services.AddControllers();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseAuthentication();
             app.UseCors(corsPolicyBuilder => corsPolicyBuilder
                 .AllowAnyOrigin()
                 .AllowAnyMethod()
                 .AllowAnyHeader());
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
