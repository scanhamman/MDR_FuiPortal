using MDR_FuiPortal.Server;
using Microsoft.Fast.Components.FluentUI;
using System.Reflection;

using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.Extensions.FileProviders;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
builder.Services.AddFluentUIComponents();

/****************************************************************************************************
 * This service added to allow the host scheme (http or https) and host URL to be identified at
 * any point. It is used within a static helper method that creates URLs for paged request responses,
 * that identifies the URL for the first, last, previous and next page and returns them to the front
 * end as [art of the API response object.

****************************************************************************************************/

builder.Services.AddHttpContextAccessor();
builder.Services.AddSingleton<IUriService>(o =>
{
    var accessor = o.GetRequiredService<IHttpContextAccessor>();
    var request = accessor.HttpContext?.Request;
    var uri = string.Concat(request?.Scheme, "://", request?.Host.ToUriComponent());
    return new UriService(uri);
});

builder.Services.AddSingleton<ICreds, Creds>();
builder.Services.AddSingleton<ILookUpRepo, LookUpRepo>();
builder.Services.AddSingleton<ITreeRepo, TreeRepo>();

builder.Services.AddScoped<IObjectRepo, ObjectRepo>();
builder.Services.AddScoped<IStudyRepo, StudyRepo>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();


app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();
