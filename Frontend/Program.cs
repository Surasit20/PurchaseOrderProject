using Frontend.Data;
using Frontend.Services.OrderService;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Syncfusion.Blazor;
using static Frontend.Pages.CreateOrder;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSyncfusionBlazor();
builder.Services.AddDevExpressBlazor();
builder.Services.AddDevExpressServerSideBlazorReportViewer();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddScoped<IOrderService, OrderService>();
builder.Services.AddHttpClient<IOrderService, OrderService>(client =>
{
    client.BaseAddress = new Uri("https://localhost:7243/");
});

builder.WebHost.UseWebRoot("wwwroot");
builder.WebHost.UseStaticWebAssets();
var app = builder.Build();


Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MTg5MTkxMEAzMjMxMmUzMTJlMzMzNUpLMGRhTytyWVRDRHlzcXVUdFB3OVRCbHAvaElDQUorQ3hCaGdJRUtvWk09;Mgo+DSMBaFt+QHFqVkNrWU5NaV1CX2BZfVlzQmlafk4BCV5EYF5SRHNfQF1gTHlQd0RlUH8=;Mgo+DSMBMAY9C3t2VFhhQlJBfVpdVHxLflF1VWBTell6d1RWESFaRnZdQV1mSXxTdUBkWn5ccXVV;Mgo+DSMBPh8sVXJ1S0d+X1RPc0BLQmFJfFBmRmlceFRzdUU3HVdTRHRcQlhjS35Qc0JgWH1acHY=;MTg5MTkxNEAzMjMxMmUzMTJlMzMzNWg0VVlxR2phVW0wZ2ExN0VZRGpwbzJyUjBIL3hpRW9pSG9ZeWNRZ2hLMFk9;NRAiBiAaIQQuGjN/V0d+XU9Hc1RHQmpWfFN0RnNadVt3flZHcC0sT3RfQF5jTH5RdkZmXnxfcn1VRA==;ORg4AjUWIQA/Gnt2VFhhQlJBfVpdVHxLflF1VWBTell6d1RWESFaRnZdQV1mSXxTdUBkWn5dcHJX;MTg5MTkxN0AzMjMxMmUzMTJlMzMzNUdQY1MyQkRSbjlmMEVuK2tiV1VsN01uRDlsWTdnQmdFZVpnVk45cys0Z2M9;MTg5MTkxOEAzMjMxMmUzMTJlMzMzNVlibzBUMVlYbjFnSURvMzlWV0FFYzljR0lUY0ozOXNHM0l5bFNSUUpnM2c9;MTg5MTkxOUAzMjMxMmUzMTJlMzMzNVYrTEpDNXdPS1pMNERmcE40dUNRRUlTQ291VFB5S2t4blRlbUl2UHJSSEU9;MTg5MTkyMEAzMjMxMmUzMTJlMzMzNW1CUVpaSDhHdlk0ZnVZVWYvV1JMQXJ6cFFBKzVibm0wYzFoTHY4R2FHZ1E9;MTg5MTkyMUAzMjMxMmUzMTJlMzMzNUpLMGRhTytyWVRDRHlzcXVUdFB3OVRCbHAvaElDQUorQ3hCaGdJRUtvWk09");
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseDevExpressServerSideBlazorReportViewer();
app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");
app.MapControllers();
app.Run();
