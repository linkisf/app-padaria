using App_Padaria.Infra;
using App_Padaria.Repositories;
using App_Padaria.Repositories.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddSqlServer<ApplicationDbContext>(builder.Configuration["ConnectionStrings:PadariaDb"]);


builder.Services.AddTransient<IPao, PaoRepository>();
builder.Services.AddTransient<ITipoMassa, TipoMassaRepository>();
builder.Services.AddTransient<ITipoPlaca, TipoPlacaRepository>();




var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/PaginaInicialController/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=PaginaInicial}/{action=Index}/{id?}"
    );



app.Run();
