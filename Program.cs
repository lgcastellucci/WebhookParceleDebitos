var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

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

app.UseAuthorization();

app.MapControllers();

if (!app.Environment.IsDevelopment())
{
    // Mapeia a rota padr�o para a p�gina desejada
    app.MapGet("/", async context =>
    {
        // Escreve o conte�do da p�gina
        await context.Response.WriteAsync("<h1><center>Bem-vindo a minha API</center></h1>");
    });
}

app.Run();
