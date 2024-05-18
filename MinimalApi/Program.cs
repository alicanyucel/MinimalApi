var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
var app=builder.Build();
app.UseHttpsRedirection();
app.MapControllers();
app.MapGet("/tests", () => "hello world");
app.MapGet("test2", () => "alican");
app.MapGet("test5", (int age) =>
{
    return "hello world" +  age;
});
app.MapGet("/get",(IConfiguration configuration) => "this is a get request");
app.MapPost("/post",() => "this is a post request");
app.MapPut("/put",() => "this is a put request");
app.MapDelete("/delete",() => "this is a delete request");
app.MapGet("/return-result", () =>
{
    return Results.Ok(new { Message = "Api is working" });
});
app.Run();