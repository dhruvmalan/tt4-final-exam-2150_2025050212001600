builder.Services.AddDbContext<ExpenseDbContext>(options =>
    options.UseSqlite("Data Source=expenses.db"));

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy => policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
});

app.UseCors("AllowAll");
