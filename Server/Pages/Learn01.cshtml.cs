using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Server.Pages;

public class Learn01Model : PageModel
{
	public Learn01Model(IConfiguration configuration) : base()
	{
		Configuration = configuration;

		AdminEmailAddress1 =
			Configuration
			.GetSection(key: "Admin")
			.GetSection(key: "EmailAddress").Value;

		AdminEmailAddress2 =
			Configuration
			.GetSection(key: "Admin:EmailAddress").Value;
	}

	public string? AdminEmailAddress1 { get; set; }

	public string? AdminEmailAddress2 { get; set; }

	private IConfiguration Configuration { get; init; }

	public void OnGet()
	{
		AdminEmailAddress1 =
			Configuration
			.GetSection(key: "Admin")
			.GetSection(key: "EmailAddress").Value;

		AdminEmailAddress2 =
			Configuration
			.GetSection(key: "Admin:EmailAddress").Value;
	}
}
