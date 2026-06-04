var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
        policy.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
});

var app = builder.Build();
app.UseCors();

var team = new[]
{
    new { name = "Наумов Леонтий", role = "Tech Lead", fact = "Люблю C#" },
    new { name = "Наумов Леонтий", role = "Developer", fact = "Пишу на C# с 1 курса" },
    new { name = "Наумов Леонтий", role = "QA", fact = "Нахожу баги быстрее всех" },
};

app.MapGet("/api/team", () => Results.Ok(team));

app.MapGet("/api/team/{name}", (string name) =>
{
    var member = team.FirstOrDefault(m =>
        m.name.Contains(name, StringComparison.OrdinalIgnoreCase));
    return member is not null
        ? Results.Ok(member)
        : Results.NotFound(new { error = "Участник не найден" });
});

app.MapGet("/api/ping", () => Results.Ok(new
{
    status = "ok",
    time = DateTime.Now.ToString("HH:mm:ss"),
    team = "team3-devcard"
}));

app.Run();