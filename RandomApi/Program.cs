var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/random", () =>
{
    // Returns a random integer greater than 10000
    return Random.Shared.Next(10001, int.MaxValue);
});

app.Run();
