using CrudLuizFelipe.Repositories;
using CrudLuizFelipe.Repositories.Interface;
using CrudLuizFelipe.Services;
using CrudLuizFelipe.Services.Interface;

namespace CrudLuizFelipe
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddMemoryCache();

            //Repository Registry
            builder.Services.AddSingleton<IEnderecoRepository, EnderecoRepository>();
            builder.Services.AddSingleton<IFornecedorEnderecoRepository, FornecedorEnderecoRepository>();
            builder.Services.AddSingleton<IFornecedorRepository, FornecedorRepository>();


            //Service Registry
            builder.Services.AddSingleton<IEnderecoService, EnderecoService>();
            builder.Services.AddSingleton<IFornecedorEnderecoService, FornecedorEnderecoService>();
            builder.Services.AddSingleton<IFornecedorService, FornecedorService>();
            builder.Services.AddSingleton<IMemoryRepository, MemoryRepository>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}