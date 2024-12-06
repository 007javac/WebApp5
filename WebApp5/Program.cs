var builder = WebApplication.CreateBuilder(args);

// ���������� ����� MVC
builder.Services.AddControllersWithViews();

var app = builder.Build();

// ��������� ��������� HTTP-��������
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/UserInfo/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

// �������������
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=UserInfo}/{action=Index}/{id?}");

app.Run();
