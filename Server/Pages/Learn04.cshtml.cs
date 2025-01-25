using Infrastructure.Settings;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Options;

namespace Server.Pages;

public class Learn04Model : PageModel
{
	public Learn04Model
		(IOptions<AdminSettings> adminSettingsOptions,
		IOptions<MyAdminSettings> myAdminSettingsOptions) : base()
	{
		AdminSettings =
			adminSettingsOptions.Value;

		MyAdminSettings =
			myAdminSettingsOptions.Value;
	}

	public AdminSettings AdminSettings { get; }

	public MyAdminSettings MyAdminSettings { get; }

	public void OnGet()
	{
	}
}
