// **************************************************
// Default
// **************************************************
using Microsoft.AspNetCore.Builder;

var builder = WebApplication.CreateBuilder(args: args);

var app = builder.Build();

app.MapGet(pattern: "/", handler: () => "Hello World!");

app.Run();
// **************************************************


// **************************************************
// Learn 1
// **************************************************
//using Microsoft.AspNetCore.Builder;
//using Microsoft.Extensions.Hosting;
//using Microsoft.Extensions.DependencyInjection;

//// NEW
//var webApplicationOptions = new WebApplicationOptions
//{
//	EnvironmentName = Environments.Development,
//	//EnvironmentName = Environments.Production,
//	//EnvironmentName = Environments.Staging, // می‌خواند Production اگر نباشد، از
//};

//// NEW
//var builder = WebApplication.CreateBuilder(options: webApplicationOptions);

//// NEW
//var password = builder.Configuration.GetSection(key: "password").Value;
//var emailAddress = builder.Configuration.GetSection(key: "EmailAddress").Value;

//builder.Services.AddRazorPages();

//var app = builder.Build();

//app.MapRazorPages();

//app.Run();
// **************************************************


// **************************************************
// Learn 2
// **************************************************
//using Microsoft.AspNetCore.Builder;
//using Microsoft.Extensions.Hosting;
//using Microsoft.Extensions.DependencyInjection;

//var webApplicationOptions = new WebApplicationOptions
//{
//	EnvironmentName = Environments.Development,
//};

//var builder = WebApplication.CreateBuilder(options: webApplicationOptions);

//// NEW
//var adminEmailAddress1 = builder.Configuration
//	.GetSection(key: "Admin").GetSection(key: "EmailAddress").Value;

//// NEW
//var adminEmailAddress2 =
//	builder.Configuration.GetSection(key: "Admin:EmailAddress").Value;

//builder.Services.AddRazorPages();

//var app = builder.Build();

//app.MapRazorPages();

//app.Run();
// **************************************************


// **************************************************
// Learn 3
// **************************************************
//using System;
//using Infrastructure.Settings;
//using Microsoft.AspNetCore.Builder;
//using Microsoft.Extensions.Hosting;
//using Microsoft.Extensions.DependencyInjection;

//var webApplicationOptions = new WebApplicationOptions
//{
//	EnvironmentName = Environments.Development,
//};

//var builder = WebApplication.CreateBuilder(options: webApplicationOptions);

//// **********
//// در نوشتن کلید بی‌دقتی می‌کنم
//// **********
////var adminSettingsFullName = builder.Configuration
////	.GetSection(key: "AdminSettings").GetSection(key: "FulName").Value;

////var adminSettingsAge = 0;
////var adminSettingsAgeString = builder.Configuration
////	.GetSection(key: "AdminSettings").GetSection(key: "Age").Value;
////if (string.IsNullOrWhiteSpace(value: adminSettingsAgeString) == false)
////{
////	try
////	{
////		adminSettingsAge = Convert.ToInt32(value: adminSettingsAgeString);
////	}
////	catch
////	{
////	}
////}

////builder.Services.Configure<AdminSettings>(builder.Configuration.GetSection(key: "AdminSeting"));
////builder.Services.Configure<AdminSettings>(builder.Configuration.GetSection(key: "AdminSettings"));
////builder.Services.Configure<AdminSettings>(builder.Configuration.GetSection(key: AdminSettings.KeyName));

//// Best Practice
//builder.Services.Configure<AdminSettings>(builder.Configuration.GetSection(key: nameof(AdminSettings)));
//// **********

//builder.Services.AddRazorPages();

//var app = builder.Build();

//app.MapRazorPages();

//app.Run();
// **************************************************


// **************************************************
// Learn 4
// **************************************************
// 1. Inject in View
// 2. در همین محل Strongly Typed Setting استفاده از شیء
// **************************************************
//using Infrastructure.Settings;
//using Microsoft.AspNetCore.Builder;
//using Microsoft.Extensions.Hosting;
//using Microsoft.Extensions.Configuration;
//using Microsoft.Extensions.DependencyInjection;

//var webApplicationOptions = new WebApplicationOptions
//{
//	EnvironmentName = Environments.Development,
//};

//var builder = WebApplication.CreateBuilder(options: webApplicationOptions);

//// دستور ذیل به درد دستورات بعد نمی‌خورد
//builder.Services.Configure<AdminSettings>(builder.Configuration.GetSection(key: nameof(AdminSettings)));

//// **********
//// دستور ذیل کار نمی‌کند
////AdminSettings? adminSettings = null;
//var adminSettings = new AdminSettings();

//builder.Configuration.GetSection(key: nameof(AdminSettings)).Bind(instance: adminSettings);

//var age = adminSettings.Age;
//// **********

//builder.Services.AddRazorPages();

//var app = builder.Build();

//app.MapRazorPages();

//app.Run();
// **************************************************


// **************************************************
// Learn 5
// **************************************************
// 1) Learning ConfigureAppConfiguration
// **************************************************
//using Infrastructure.Settings;
//using Microsoft.AspNetCore.Builder;
//using Microsoft.Extensions.Hosting;
//using Microsoft.Extensions.Configuration;
//using Microsoft.Extensions.DependencyInjection;

//var webApplicationOptions = new WebApplicationOptions
//{
//	EnvironmentName = Environments.Development,
//};

//var builder = WebApplication.CreateBuilder(options: webApplicationOptions);

//// **********
//builder.Configuration.Sources.Clear();

//var environment = webApplicationOptions.EnvironmentName;

//builder.Configuration.AddJsonFile(path: "mysettings.json", optional: true, reloadOnChange: true);
////builder.Configuration.AddJsonFile(path: $"mysettings.{environment.EnvironmentName}.json", optional: true, reloadOnChange: true);

////builder.Configuration.AddJsonFile(path: "appsettings.json", optional: true, reloadOnChange: true);
////builder.Configuration.AddJsonFile(path: $"appsettings.{environment.EnvironmentName}.json", optional: true, reloadOnChange: true);
//// **********

//// **********
//// باید به جای دستورات ذیل، از دستورات فوق استفاده نماییم
//// **********
////builder.Host.ConfigureAppConfiguration((hostingContext, config) =>
////{
////	config.Sources.Clear();

////	var environment = hostingContext.HostingEnvironment;

////	config.AddJsonFile(path: "appsettings.json", optional: true, reloadOnChange: true);
////	//config.AddJsonFile(path: $"appsettings.{environment.EnvironmentName}.json", optional: true, reloadOnChange: true);

////	config.AddJsonFile(path: "mysettings.json", optional: true, reloadOnChange: true);
////	//config.AddJsonFile(path: $"mysettings.{environment.EnvironmentName}.json", optional: true, reloadOnChange: true);
////});
//// **********

//// **********
//builder.Services.Configure<AdminSettings>(builder.Configuration.GetSection(key: nameof(AdminSettings)));
//builder.Services.Configure<MyAdminSettings>(builder.Configuration.GetSection(key: nameof(MyAdminSettings)));
//// **********

//builder.Services.AddRazorPages();

//var app = builder.Build();

//app.MapRazorPages();

//app.Run();
// **************************************************


// **************************************************
// Learn 6
// **************************************************
// 1) Learning Nested Settings
// **************************************************
//using Infrastructure.Settings;
//using Microsoft.AspNetCore.Builder;
//using Microsoft.Extensions.Hosting;
//using Microsoft.Extensions.DependencyInjection;

//var webApplicationOptions = new WebApplicationOptions
//{
//	EnvironmentName = Environments.Development,
//};

//var builder = WebApplication.CreateBuilder(options: webApplicationOptions);

//// **********
//builder.Services.Configure<ApplicationSettings>
//	(builder.Configuration.GetSection(key: nameof(ApplicationSettings)));
//// **********

//builder.Services.AddRazorPages();

//var app = builder.Build();

//app.MapRazorPages();

//app.Run();
// **************************************************
