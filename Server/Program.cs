// **************************************************
// **************************************************
// **************************************************
// Default
// **************************************************
//using Microsoft.AspNetCore.Builder;

//var builder =
//	Microsoft.AspNetCore.Builder
//	.WebApplication.CreateBuilder(args);

//var app =
//	builder.Build();

//// MapGet() -> using Microsoft.AspNetCore.Builder;
//app.MapGet("/", () => "Hello World!");

//app.Run();
// **************************************************
// **************************************************
// **************************************************



// **************************************************
// **************************************************
// **************************************************
// Learn 1
// **************************************************
//using Microsoft.AspNetCore.Builder;
//using Microsoft.Extensions.DependencyInjection;

//// **************************************************
//var webApplicationOptions =
//	new Microsoft.AspNetCore.Builder.WebApplicationOptions
//	{
//		//EnvironmentName =
//		//	Microsoft.Extensions.Hosting.Environments.Production,

//		EnvironmentName =
//			Microsoft.Extensions.Hosting.Environments.Development,
//	};

//var builder =
//	Microsoft.AspNetCore.Builder
//	.WebApplication.CreateBuilder(options: webApplicationOptions);
//// **************************************************

//// **************************************************
//var password =
//	builder.Configuration
//	.GetSection(key: "password").Value;

//var emailAddress =
//	builder.Configuration
//	.GetSection(key: "EmailAddress").Value;
//// **************************************************

//// **************************************************
//var adminEmailAddress1 =
//	builder.Configuration
//	.GetSection(key: "Admin")
//	.GetSection(key: "EmailAddress").Value;

//var adminEmailAddress2 =
//	builder.Configuration
//	.GetSection(key: "Admin:EmailAddress").Value;
//// **************************************************

//// AddRazorPages() -> using Microsoft.Extensions.DependencyInjection;
//builder.Services.AddRazorPages();

//var app =
//	builder.Build();

//// MapRazorPages() -> using Microsoft.AspNetCore.Builder;
//app.MapRazorPages();

//app.Run();
// **************************************************
// **************************************************
// **************************************************



// **************************************************
// **************************************************
// **************************************************
// Learn 2
// **************************************************
//using Microsoft.AspNetCore.Builder;
//using Microsoft.Extensions.DependencyInjection;

//// **************************************************
//var webApplicationOptions =
//	new Microsoft.AspNetCore.Builder.WebApplicationOptions
//	{
//		EnvironmentName =
//			Microsoft.Extensions.Hosting.Environments.Development,
//	};

//var builder =
//	Microsoft.AspNetCore.Builder
//	.WebApplication.CreateBuilder(options: webApplicationOptions);
//// **************************************************

//// **************************************************
//// در نوشتن کلید بی‌دقتی می‌کنم
//// Configure() -> using Microsoft.Extensions.DependencyInjection;
////builder.Services.Configure
////	<Infrastructure.Settings.AdminSettings>
////	(builder.Configuration.GetSection(key: "AdminSetting"));

//// Configure() -> using Microsoft.Extensions.DependencyInjection;
////builder.Services.Configure
////	<Infrastructure.Settings.AdminSettings>
////	(builder.Configuration.GetSection(key: "AdminSettings"));

//// Configure() -> using Microsoft.Extensions.DependencyInjection;
//builder.Services.Configure
//	<Infrastructure.Settings.AdminSettings>
//	(builder.Configuration.GetSection(key: Infrastructure.Settings.AdminSettings.KeyName));
//// **************************************************

//// AddRazorPages() -> using Microsoft.Extensions.DependencyInjection;
//builder.Services.AddRazorPages();

//var app =
//	builder.Build();

//// MapRazorPages() -> using Microsoft.AspNetCore.Builder;
//app.MapRazorPages();

//app.Run();
// **************************************************
// **************************************************
// **************************************************



// **************************************************
// **************************************************
// **************************************************
// Learn 3
// **************************************************
// 1. Inject in View
// 2. در همین محل Strongly Typed Setting استفاده از شیء
// **************************************************
//using Microsoft.AspNetCore.Builder;
//using Microsoft.Extensions.Configuration;
//using Microsoft.Extensions.DependencyInjection;

//// **************************************************
//var webApplicationOptions =
//	new Microsoft.AspNetCore.Builder.WebApplicationOptions
//	{
//		EnvironmentName =
//			Microsoft.Extensions.Hosting.Environments.Development,
//	};

//var builder =
//	Microsoft.AspNetCore.Builder
//	.WebApplication.CreateBuilder(options: webApplicationOptions);
//// **************************************************

//// **************************************************
//// Configure() -> using Microsoft.Extensions.DependencyInjection;
//builder.Services.Configure<Infrastructure.Settings.AdminSettings>
//	(builder.Configuration.GetSection(key: Infrastructure.Settings.AdminSettings.KeyName));
//// **************************************************

//// **************************************************
//// دستور ذیل کار نمی‌کند
////Infrastructure.Settings.AdminSettings? adminSettings = null;

//var adminSettings =
//	new Infrastructure.Settings.AdminSettings();

//// Bind() -> using Microsoft.Extensions.Configuration;
//builder.Configuration.GetSection
//	(key: Infrastructure.Settings.AdminSettings.KeyName)
//	.Bind(instance: adminSettings);

//int age =
//	adminSettings.Age;
//// **************************************************

//// AddRazorPages() -> using Microsoft.Extensions.DependencyInjection;
//builder.Services.AddRazorPages();

//var app =
//	builder.Build();

//// MapRazorPages() -> using Microsoft.AspNetCore.Builder;
//app.MapRazorPages();

//app.Run();
// **************************************************
// **************************************************
// **************************************************



// **************************************************
// **************************************************
// **************************************************
// Learn 4
// **************************************************
// 1) Learning ConfigureAppConfiguration
// **************************************************
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

// **************************************************
var webApplicationOptions =
	new Microsoft.AspNetCore.Builder.WebApplicationOptions
	{
		EnvironmentName =
			Microsoft.Extensions.Hosting.Environments.Development,
	};

var builder =
	Microsoft.AspNetCore.Builder
	.WebApplication.CreateBuilder(options: webApplicationOptions);
// **************************************************

builder.Host.ConfigureAppConfiguration((hostingContext, config) =>
{
	// **************************************************
	config.Sources.Clear();

	var env =
		hostingContext.HostingEnvironment;

	// AddJsonFile() -> using Microsoft.Extensions.Configuration;
	config.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

	// AddJsonFile() -> using Microsoft.Extensions.Configuration;
	config.AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true, reloadOnChange: true);
	// **************************************************

	// **************************************************
	// AddJsonFile() -> using Microsoft.Extensions.Configuration;
	config.AddJsonFile("mysettings.json", optional: true, reloadOnChange: true);

	// AddJsonFile() -> using Microsoft.Extensions.Configuration;
	config.AddJsonFile($"mysettings.{env.EnvironmentName}.json", optional: true, reloadOnChange: true);
	// **************************************************
});

// **************************************************
// Configure() -> using Microsoft.Extensions.DependencyInjection;
builder.Services.Configure
	<Infrastructure.Settings.AdminSettings>
	(builder.Configuration.GetSection(key: Infrastructure.Settings.AdminSettings.KeyName));

// Configure() -> using Microsoft.Extensions.DependencyInjection;
builder.Services.Configure
	<Infrastructure.Settings.MyAdminSettings>
	(builder.Configuration.GetSection(key: Infrastructure.Settings.MyAdminSettings.KeyName));
// **************************************************

// AddRazorPages() -> using Microsoft.Extensions.DependencyInjection;
builder.Services.AddRazorPages();

var app =
	builder.Build();

// MapRazorPages() -> using Microsoft.AspNetCore.Builder;
app.MapRazorPages();

app.Run();
// **************************************************
// **************************************************
// **************************************************



// **************************************************
// **************************************************
// **************************************************
// Learn 5
// **************************************************
// 1) Learning Nested Settings
// **************************************************
//using Microsoft.AspNetCore.Builder;
//using Microsoft.Extensions.DependencyInjection;

//// **************************************************
//var webApplicationOptions =
//	new Microsoft.AspNetCore.Builder.WebApplicationOptions
//	{
//		EnvironmentName =
//			Microsoft.Extensions.Hosting.Environments.Development,
//	};

//var builder =
//	Microsoft.AspNetCore.Builder
//	.WebApplication.CreateBuilder(options: webApplicationOptions);
//// **************************************************

//// **************************************************
//// Configure() -> using Microsoft.Extensions.DependencyInjection;
//builder.Services.Configure
//	<Infrastructure.Settings.ApplicationSettings>
//	(builder.Configuration.GetSection(key: Infrastructure.Settings.ApplicationSettings.KeyName));
//// **************************************************

//// AddRazorPages() -> using Microsoft.Extensions.DependencyInjection;
//builder.Services.AddRazorPages();

//var app =
//	builder.Build();

//// MapRazorPages() -> using Microsoft.AspNetCore.Builder;
//app.MapRazorPages();

//app.Run();
// **************************************************
// **************************************************
// **************************************************
