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

/***************************************************************
 *Hosted Blazor WebAssembly
If the app is a hosted Blazor WebAssembly app:

In the in the Server project (Program.cs):
Adjust the path of UseBlazorFrameworkFiles (for example, app.UseBlazorFrameworkFiles("/base/path");).
Configure calls to UseStaticFiles (for example, app.UseStaticFiles("/base/path");).
In the Client project:
Configure <StaticWebAssetBasePath> in the project file to match the path for serving static web assets (for example, <StaticWebAssetBasePath>base/path</StaticWebAssetBasePath> ).
Configure the <base> tag, per the guidance in the Configure the app base path section.
For an example of hosting multiple Blazor WebAssembly apps in a hosted Blazor WebAssembly solution, see Multiple hosted ASP.NET Core Blazor WebAssembly apps, where approaches are explained for domain/port hosting and subpath hosting of multiple Blazor WebAssembly client apps.
 * 
 ***************************************************************/

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();


app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();
