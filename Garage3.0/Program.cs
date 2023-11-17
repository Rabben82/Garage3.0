﻿using Garage.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Garage3._0.Data;
namespace Garage3._0
{
	public class Program
	{
		public static async Task Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);
			builder.Services.AddDbContext<Garage3_0Context>(options =>
			    options.UseSqlServer(builder.Configuration.GetConnectionString("Garage3_0Context") ?? throw new InvalidOperationException("Connection string 'Garage3_0Context' not found.")));

			// Add services to the container.
			builder.Services.AddControllersWithViews();

			var app = builder.Build();

			using (var scope = app.Services.CreateScope())
			{
				var serviceProvider = scope.ServiceProvider;
				var db = serviceProvider.GetRequiredService<Garage3_0Context>();
				
				//erases the database everytime i run the application
				await db.Database.EnsureDeletedAsync();
				//run all the migrations, if the database doesnt exist create it, if it exist, just update the database
				await db.Database.MigrateAsync();

				try
				{
					await SeedData.InitAsync(db);
				}
				catch (Exception e)
				{
					Console.WriteLine(e.Message);
					throw;
				}
			}

			// Configure the HTTP request pipeline.
			if (!app.Environment.IsDevelopment())
			{
				app.UseExceptionHandler("/Home/Error");
				// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
				app.UseHsts();
			}

			app.UseHttpsRedirection();
			app.UseStaticFiles();

			app.UseRouting();

			app.UseAuthorization();

			app.MapControllerRoute(
				name: "default",
				pattern: "{controller=Home}/{action=Index}/{id?}");

			app.Run();
		}
	}
}