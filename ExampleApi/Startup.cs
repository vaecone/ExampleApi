using ExampleApi.Shared.Models;
using Microsoft.AspNetCore.OData;
using Microsoft.AspNetCore.OData.NewtonsoftJson;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using Microsoft.OData.ModelBuilder;

namespace ExampleApi
{
    public class Startup
    {

        public void ConfigureServices(IServiceCollection services)
        {
             
            services.AddControllers().AddApplicationPart(typeof(MetadataController).Assembly)
                .AddOData(options =>
                {
                    options.AddRouteComponents("api/odata", ConfigureOdataModels().GetEdmModel());
                })
                .AddODataNewtonsoftJson();

            services.AddSwaggerGen();
           
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory loggerFactory)
        {
            // var app = builder.Build();

            // Configure the HTTP request pipeline.
            app.UseSwagger();
            app.UseSwaggerUI();

            app.UseHttpsRedirection();

            // app.MapControllers();

            // listening address + /$odata
            app.UseODataRouteDebug();

            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });

            // app.Run();
        }

        public ODataConventionModelBuilder ConfigureOdataModels()
        {
            var modelBuilder = new ODataConventionModelBuilder();
            modelBuilder.EntitySet<Team>("Teams");
            return modelBuilder;
        }

    }
}
