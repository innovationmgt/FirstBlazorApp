using FirstBlazorApp.Data;
using FirstBlazorApp.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

// Add services to the container.
builder.RootComponents.Add<App>('#app');
builder.RootComponents.Add<HeadOutlet>("head::after");
//builder.Services.AddRazorPages();
//builder.Services.AddServerSideBlazor();
//builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddScoped<IFileUploaded, FileUpload>();
//var app = builder.Build();
builder.Services.AddScoped(
    sp => new HttpClient
    {
        //BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)
        BaseAddress = new Uri("https://goweather.herokuapp.com/weather/")
    }
);

await builder.Build().RunAsync();

// Configure the HTTP request pipeline.
//if (!app.Environment.IsDevelopment())
//{
//    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see //https://aka.ms/aspnetcore-hsts.
//    app.UseHsts();
//}

//app.UseHttpsRedirection();

//app.UseStaticFiles();

//app.UseRouting();

//app.MapBlazorHub();
//app.MapFallbackToPage("/_Host");

//app.Run();
