var builder = WebApplication.CreateBuilder(args);

// Добавление служб MVC
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Настройка конвейера HTTP-запросов
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/UserInfo/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

// Маршрутизация
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=UserInfo}/{action=Index}/{id?}");

app.Run();
