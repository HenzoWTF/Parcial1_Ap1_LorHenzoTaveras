using Microsoft.EntityFrameworkCore;
using Parcial1_Ap1_LorHenzoTaveras.Components;
using Parcial1_Ap1_LorHenzoTaveras.DAL;
using Parcial1_Ap1_LorHenzoTaveras.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();



builder.Services.AddDbContext<Context>(options => options.UseSqlite("Data Source=Metas.db"));
builder.Services.AddScoped<MetasService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
