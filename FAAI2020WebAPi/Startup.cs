namespace FAAI2020WebAPi
{
    using FAAI2020WebAPI_Contract.PersitentContract;
    using FAAI2020WebAPI_Contract.ServiceContract;
    using FAAI2020WebAPI_PersistentFile;
    using FAAI2020WebAPI_Services;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;
    using Microsoft.OpenApi.Models;

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
            services.AddAutoMapper(typeof(LineItemProfile));

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "FAAI2020WebAPi", Version = "v1" });
            });

            services.AddTransient<IPersonService, PersonService>();
            services.AddTransient<IPresitentContract, FileHandler>();
            services.AddTransient<IOrderService, OrderService>();
            services.AddTransient<IPersistentOrderContract, OrderFileHandler>();
            services.AddTransient<ILineItemService, LineItemService>();
            services.AddTransient<IPresistentLineItemContract, LineItemFileHandler>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "FAAI2020WebAPi v1"));
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
