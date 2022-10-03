using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System.IO;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.AspNetCore.Identity;
using System.Text;
// using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Options;
// using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text.Json.Serialization;
using Newtonsoft.Json.Linq;
using api_purdelivery.Repository;
using Microsoft.AspNet.OData.Extensions;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using System.IdentityModel.Tokens.Jwt;

namespace api_purdelivery
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
            // Service 109\cpttest
            services.AddDbContext<ApplicationDbContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("ConnStr109")));

            services.AddScoped<IRepository, Repository<ApplicationDbContext>>();

            services.AddControllersWithViews()
                .AddJsonOptions(opts => opts.JsonSerializerOptions.PropertyNamingPolicy = null)
                .AddNewtonsoftJson();

            services.AddControllers().AddNewtonsoftJson(x =>
                x.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);

            services.AddControllers().AddJsonOptions(opt =>
            {
                opt.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
            });

            services.AddControllers(options => options.SuppressAsyncSuffixInActionNames = false);

            // services.AddCors();
            
            
            services.AddControllers();
            
            services.AddCors();
            
            services.AddMvc(setupAction =>
            {
                setupAction.EnableEndpointRouting = false;
            }).AddJsonOptions(jsonOptions =>
            {
                jsonOptions.JsonSerializerOptions.PropertyNamingPolicy = null;
            })
                .SetCompatibilityVersion(CompatibilityVersion.Version_3_0);

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "api_purdelivery", Version = "v1" });
                // To Enable authorization using Swagger (JWT)  
                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
                {
                    Name = "Authorization",
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "Bearer",
                    BearerFormat = "JWT",
                    In = ParameterLocation.Header,
                    Description = "JWT Authorization header using the Bearer scheme. \r\n\r\n Enter 'Bearer' [space] and then your token in the text input below.\r\n\r\nExample: \"Bearer 12345abcdef\"",
                });
                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                          new OpenApiSecurityScheme
                            {
                                Reference = new OpenApiReference
                                {
                                    Type = ReferenceType.SecurityScheme,
                                    Id = "Bearer"
                                }
                            },
                            new string[] {}

                    }
                }); 
            });

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(option =>
            {
                option.RequireHttpsMetadata = false;
                option.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = Configuration["Jwt:ValidIssuer"],
                    ValidAudience = Configuration["Jwt:ValidAudience"],
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["Jwt:Secret"]))
                };
                option.Events = new JwtBearerEvents
                {
                    OnAuthenticationFailed = context =>
                    {
                        if (context.Exception.GetType() == typeof(SecurityTokenExpiredException))
                        {
                            context.Response.Headers.Add("Token-Expired", "true");
                        }
                        return Task.CompletedTask;
                    },
                    OnTokenValidated = context =>
                    {
                        JwtSecurityToken accessToken = context.SecurityToken as JwtSecurityToken;
                        if (accessToken != null)
                        {
                            ClaimsIdentity identity = context.Principal.Identity as ClaimsIdentity;
                            if (identity != null)
                            {
                                var handler = new JwtSecurityTokenHandler();
                                if (handler.CanReadToken(accessToken.RawData))
                                {
                                    var jwtToken = handler.ReadJwtToken(accessToken.RawData);
                                    var claimed = jwtToken.Claims.FirstOrDefault(claim => claim.Type == "user");

                                    JObject data = JObject.Parse("{" + claimed.ToString() + "}");
                                    Console.WriteLine(data);
                                    var username = data["user"]["username"];
                                    var name = data["user"]["name"];
                                    var email = data["user"]["email"];

                                    identity.AddClaim(new Claim("username", username.ToString()));
                                    identity.AddClaim(new Claim("name", name.ToString()));
                                    identity.AddClaim(new Claim("email", email.ToString()));
                                }
                            }
                        }
                        return Task.CompletedTask;
                    }
                };
            });
            // End Adding Authentication 

            services.AddOData();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "api_purdelivery v1"));
            }
            
            app.UseDeveloperExceptionPage();
            
            app.UseCors(option => 
                option.WithOrigins("*").AllowAnyOrigin()
                                    .AllowAnyHeader()
                                    .AllowAnyMethod()
            );

            app.UseHttpsRedirection();

            app.UseRouting();

             app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

             app.UseMvc(routeBuilder =>
            {
                routeBuilder.EnableDependencyInjection();
                routeBuilder.Select().OrderBy().Filter();
            });
        }
    }
}
