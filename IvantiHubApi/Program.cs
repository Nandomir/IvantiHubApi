using FluentValidation;
using IvantiHubApi.Models.Validators;
using IvantiHubApi.Models;
using IvantiHubApi.Services.Triangle;
using System.Diagnostics.CodeAnalysis;

namespace IvantiHubApi
{
    /// <summary>
    /// Program.
    /// </summary>
    [ExcludeFromCodeCoverage(Justification = "Standard .NET classes without logic to test.")]
    public class Program
    {
        /// <summary>
        /// Main.
        /// </summary>
        /// <param name="args">Args.</param>
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddTransient<ITriangleService, TriangleService>();
            builder.Services.AddTransient<IValidator<TriangleVerticesModel>, TriangleVerticesModelValidator>();

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();
            app.UseStaticFiles();

            app.Run();
        }
    }
}