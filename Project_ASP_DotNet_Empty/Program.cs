// Importando middlewares (opcional)
using Middlewares;
using Serilog;

// Configuração do Builder (obrigatório)
var builder = WebApplication.CreateBuilder(args);

//Configuração do Pipeline (opcional)
builder.AddSerilog();

// Configuração da App (obrigatório)
var app = builder.Build();
app.UseLogTime();

// Configuração de Comportamentos da App (opcional)
app.MapGet("/", () => "Hello World!");
app.MapGet("/teste", () => { Thread.Sleep(1500); return "Teste 2"; });

// Execução da App (obrigatório)
app.Run();