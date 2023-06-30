var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () =>
{
    return Results.Ok("");
});


app.MapGet("/{nome}", (string nome) =>
{
    return Results.Ok($"hELLO {nome}");
});

app.Run();


