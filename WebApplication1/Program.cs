var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSingleton<IMessage, MyDependency>();
var app = builder.Build();
app.MapGet("/", (IMessage message) =>
{
    message.ShowMessage("Hello World!");
    return Results.Ok("Hello World!");
});
app.Run();
