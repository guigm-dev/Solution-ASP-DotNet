using System.Diagnostics;
using Serilog;

namespace Middlewares
{
    public class TemplateMiddleware
    {
        private readonly RequestDelegate _next;

        public TemplateMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {
            // Faz algo antes.
            // ...

            // Chama o próximo middleware no pipeline.
            await _next(httpContext);

            // Faz algo depois.
            // ...
        }
    }

    public class LogTimeMiddleware
    {
        private readonly RequestDelegate _next;

        public LogTimeMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {
            // Faz algo antes.
            var sw = Stopwatch.StartNew();

            // Chama o próximo middleware no pipeline.
            await _next(httpContext);

            // Faz algo depois.
            sw.Stop();
            Log.Logger = new LoggerConfiguration().WriteTo.Console().CreateLogger();
            Log.Information($"A execução demorou {sw.Elapsed.TotalMilliseconds}ms ({sw.Elapsed.TotalSeconds} segundos)");
        }
    }

    public static class SerilogExtensions
    {
        public static void AddSerilog(this WebApplicationBuilder builder)
        {
            builder.Host.UseSerilog();
            //...
            //...
            //...
        }
    }

    public static class LogTimeMiddlewareExtensions
    {
        public static void UseLogTime(this WebApplication app)
        {
            app.UseMiddleware<LogTimeMiddleware>();
            //...
            //...
            //...
        }
    }
}