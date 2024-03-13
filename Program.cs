using Refit;
using ViaCep.integracao;
using ViaCep.integracao.Interface;
using ViaCep.integracao.Refit;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IViaCepIntegracao, ViaCepIntegracao>();

// Add services to the container.
builder.Services.AddRefitClient<IViaCepIntegracaoRefit>().ConfigureHttpClient(C =>
    {
    C.BaseAddress = new Uri("https://viacep.com.br");

});


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


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
