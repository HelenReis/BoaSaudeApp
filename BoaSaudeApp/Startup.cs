using Blazored.Modal;
using BoaSaudeApp.Areas.Identity;
using BoaSaudeApp.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Repositorio;
using Repositorio.Implementacao;
using Repositorio.Interface;
using Service.Implementacao;
using Service.Interface;
using Syncfusion.Blazor;

namespace BoaSaudeApp
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddSyncfusionBlazor(options => { options.IgnoreScriptIsolation = true; });

            services.AddSingleton<WeatherForecastService>();
            services.AddTransient<IAssociadoRepositorio, AssociadoRepositorio>();
            services.AddTransient<IConveniadoPrestadorRepositorio, ConveniadoPrestadorRepositorio>();
            services.AddTransient<IAtendimentoRepositorio, AtendimentoRepositorio>();
            services.AddTransient<IConveniadoRepositorio, ConveniadoRepositorio>();
            services.AddTransient<IPlanoRepositorio, PlanoRepositorio>();
            services.AddTransient<IPrestadorRepositorio, PrestadorRepositorio>();
            services.AddTransient<ICidadeRepositorio, CidadeRepositorio>();
            services.AddTransient<IPrestadorRepositorio, PrestadorRepositorio>();

            services.AddTransient<IAssociadoService, AssociadoService>();
            services.AddTransient<IAtendimentoService, AtendimentoService>();
            services.AddTransient<IConveniadoPrestadorService, ConveniadoPrestadorService>();
            services.AddTransient<ICidadeService, CidadeService>();
            services.AddTransient<IPrestadorService, PrestadorService>();
            services.AddBlazoredModal();

            services.AddScoped<AuthenticationStateProvider, CustomAuthenticatorStateProvider<IdentityUser>>();

            services
                .AddDbContext<DataContext>(
                    options => options.UseMySql(
                            Configuration.GetConnectionString("myConnection")));

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseMySql(
                    Configuration.GetConnectionString("myConnectionLogin")));

            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<ApplicationDbContext>();
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

            app.UsePathBase(new PathString("/login"));

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });

            using (var scope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                scope.ServiceProvider.GetService<DataContext>().Database.EnsureDeleted();
                scope.ServiceProvider.GetService<DataContext>().Database.Migrate();

                scope.ServiceProvider.GetService<ApplicationDbContext>().Database.EnsureDeleted();
                scope.ServiceProvider.GetService<ApplicationDbContext>().Database.Migrate();
            }
        }
    }
}
