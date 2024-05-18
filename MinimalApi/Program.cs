var builder = WebApplication.CreateBuilder(args);
var app=builder.Build();
app.UseHttpsRedirection();
app.MapGet("/tests", () => "hello world");
app.MapGet("test2", () => "alican");
app.Run();