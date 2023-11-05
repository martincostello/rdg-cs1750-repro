using System.Text.Json;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHttpClient();

var app = builder.Build();

app.MapGet("/", (
    HttpClient client,
    CancellationToken cancellationToken = default) =>
{
    return client.GetFromJsonAsync<JsonDocument>("https://jsonplaceholder.typicode.com/comments", cancellationToken);
});

app.Run();
