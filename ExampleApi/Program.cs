using ExampleApi.Shared.EF;
using ExampleApi.Shared.Models;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.OData;
using Microsoft.AspNetCore.OData.NewtonsoftJson;
using Microsoft.OData.ModelBuilder;


namespace ExampleApi
{
    public class Program
    {

        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
        WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();

        //public static void Main2(string[] args)
        //{

        //    // WebHost.CreateDefaultBuilder(args);
        //    var builder = WebApplication.CreateBuilder(args);

        //    // Add services to the container.

        //    builder.Services.AddControllers();
        //    // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        //    // builder.Services.AddEndpointsApiExplorer();
            
        //    builder.Services.AddControllers()
        //        .AddOData(options =>
        //        {
        //            options.AddRouteComponents("api/odata", ConfigureOdataModels().GetEdmModel());
        //        })
        //        .AddODataNewtonsoftJson();

        //    builder.Services.AddSwaggerGen();

        //    var app = builder.Build();

        //    // Configure the HTTP request pipeline.
        //    if (app.Environment.IsDevelopment())
        //    {
        //        app.UseSwagger();
        //        app.UseSwaggerUI();
        //    }

        //    app.UseHttpsRedirection();
           
        //    // app.MapControllers();
        //    app.UseODataRouteDebug();
        //    app.UseRouting();
        //    app.UseAuthorization();
        //    app.UseEndpoints(endpoints => { endpoints.MapControllers(); });

        //    app.Run();
        //}

        public static ODataConventionModelBuilder ConfigureOdataModels()
        {
            var modelBuilder = new ODataConventionModelBuilder();
            modelBuilder.EntitySet<Team>("Teams");
            return modelBuilder;
        }
    }
}