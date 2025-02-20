﻿using Infrastructure.Settings;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.DataProtection.KeyManagement;

// **************************************************
// Default
// **************************************************
//var builder =
//	WebApplication.CreateBuilder(args: args);

//var app =
//	builder.Build();

//app.MapGet(pattern: "/", handler: () => "Hello World!");

//app.Run();
// **************************************************
// **************************************************
// **************************************************

// **************************************************
// Learn 1
// **************************************************
//var webApplicationOptions =
//	new WebApplicationOptions
//	{
//		EnvironmentName = Environments.Development,
//		//EnvironmentName = Environments.Staging,
//		//EnvironmentName = Environments.Production,
//	};

//var builder =
//	WebApplication.CreateBuilder
//	(options: webApplicationOptions);

//// **********
//var password =
//	builder.Configuration
//	.GetSection(key: "password").Value;

//var emailAddress =
//	builder.Configuration
//	.GetSection(key: "EmailAddress").Value;
//// **********

//// **********
//var adminEmailAddress1 =
//	builder.Configuration
//	.GetSection(key: "Admin")
//	.GetSection(key: "EmailAddress").Value;

//var adminEmailAddress2 =
//	builder.Configuration
//	.GetSection(key: "Admin:EmailAddress").Value;
//// **********

//builder.Services.AddRazorPages();

//var app =
//	builder.Build();

//app.MapRazorPages();

//app.Run();
// **************************************************
// **************************************************
// **************************************************

// **************************************************
// Learn 2
// **************************************************
//var webApplicationOptions =
//	new WebApplicationOptions
//	{
//		EnvironmentName = Environments.Development,
//	};

//var builder =
//	WebApplication.CreateBuilder
//	(options: webApplicationOptions);

//// **********
//// در نوشتن کلید بی‌دقتی می‌کنم
//// **********
////builder.Services.Configure<AdminSettings>
////	(builder.Configuration.GetSection(key: "AdminSeting"));

////builder.Services.Configure<AdminSettings>
////	(builder.Configuration.GetSection(key: "AdminSettings"));

////builder.Services.Configure<AdminSettings>
////	(builder.Configuration.GetSection(key: AdminSettings.KeyName));

//// Best Practice
//builder.Services.Configure<AdminSettings>
//	(builder.Configuration.GetSection(key: nameof(AdminSettings)));
//// **********

//builder.Services.AddRazorPages();

//var app =
//	builder.Build();

//app.MapRazorPages();

//app.Run();
// **************************************************
// **************************************************
// **************************************************

// **************************************************
// Learn 3
// **************************************************
// 1. Inject in View
// 2. در همین محل Strongly Typed Setting استفاده از شیء
// **************************************************
//var webApplicationOptions =
//	new WebApplicationOptions
//	{
//		EnvironmentName = Environments.Development,
//	};

//var builder =
//	WebApplication.CreateBuilder
//	(options: webApplicationOptions);

//builder.Services.Configure<AdminSettings>
//	(builder.Configuration.GetSection(key: nameof(AdminSettings)));

//// **********
//// دستور ذیل کار نمی‌کند
////AdminSettings? adminSettings = null;

//var adminSettings =
//	new AdminSettings();

//builder.Configuration.GetSection
//	(key: nameof(AdminSettings)).Bind(instance: adminSettings);

//var age =
//	adminSettings.Age;
//// **********

//builder.Services.AddRazorPages();

//var app =
//	builder.Build();

//app.MapRazorPages();

//app.Run();
// **************************************************
// **************************************************
// **************************************************

// **************************************************
// Learn 4
// **************************************************
// 1) Learning ConfigureAppConfiguration
// **************************************************
//var webApplicationOptions =
//	new WebApplicationOptions
//	{
//		EnvironmentName = Environments.Development,
//	};

//var builder =
//	WebApplication.CreateBuilder
//	(options: webApplicationOptions);

//builder.Host.ConfigureAppConfiguration((hostingContext, config) =>
//{
//	config.Sources.Clear();

//	var env = hostingContext.HostingEnvironment;

//	// **********
//	config.AddJsonFile
//		(path: "appsettings.json", optional: true, reloadOnChange: true);

//	config.AddJsonFile
//		(path: $"appsettings.{env.EnvironmentName}.json", optional: true, reloadOnChange: true);
//	// **********

//	// **********
//	config.AddJsonFile
//		(path: "mysettings.json", optional: true, reloadOnChange: true);

//	config.AddJsonFile
//		(path: $"mysettings.{env.EnvironmentName}.json", optional: true, reloadOnChange: true);
//	// **********
//});

//// **********
//builder.Services.Configure<AdminSettings>
//	(builder.Configuration.GetSection(key: nameof(AdminSettings)));

//builder.Services.Configure<MyAdminSettings>
//	(builder.Configuration.GetSection(key: nameof(MyAdminSettings)));
//// **********

//builder.Services.AddRazorPages();

//var app =
//	builder.Build();

//app.MapRazorPages();

//app.Run();
// **************************************************
// **************************************************
// **************************************************

// **************************************************
// Learn 5
// **************************************************
// 1) Learning Nested Settings
// **************************************************
var webApplicationOptions =
	new WebApplicationOptions
	{
		EnvironmentName = Environments.Development,
	};

var builder =
	WebApplication.CreateBuilder
	(options: webApplicationOptions);

// **********
builder.Services.Configure<ApplicationSettings>
	(builder.Configuration.GetSection(key: nameof(ApplicationSettings)));
// **********

builder.Services.AddRazorPages();

var app =
	builder.Build();

app.MapRazorPages();

app.Run();
// **************************************************
// **************************************************
// **************************************************
