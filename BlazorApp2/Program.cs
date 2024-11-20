using BlazorApp2.Components;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Cors.Infrastructure;
using MudBlazor.Services;
using SignIR;

namespace BlazorApp2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorComponents()
                .AddInteractiveServerComponents();
            builder.Services.AddMudServices();
            builder.Services.AddDbContext<DBSeat>();
            builder.Services.AddSignalR();

            builder.Services.AddTransient<ISeatRepo, SeatRepo>();
            builder.Services.AddSingleton<ICorsService, CorsService>();

            builder.Services.AddHttpContextAccessor(); // Service support cookie
            builder.Services.AddBlazoredLocalStorage(); // Blazored.LocalStorage library to manage cookie

            var app = builder.Build();
            
            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();
            
            app.UseRouting(); // Ensure routing middleware is used
            app.UseAuthorization();
            app.UseAntiforgery();
            app.MapHub<ChatHub>("/chatHub");
            app.MapHub<ChatHub>("/seathub");
            

            app.MapRazorComponents<App>()
                .AddInteractiveServerRenderMode();

            app.Run();
        }
    }
}
