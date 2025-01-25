using Infrastructure.Settings;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Server.Pages;

public class Learn02Model : PageModel
{
	public Learn02Model(IOptions<AdminSettings> adminSettingsOptions) : base()
	{
		AdminSettings = adminSettingsOptions.Value;
	}

	public AdminSettings AdminSettings { get; init; }

	public void OnGet()
	{
	}
}
