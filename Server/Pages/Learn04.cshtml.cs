using Infrastructure.Settings;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Server.Pages;

public class Learn04Model : PageModel
{
	public Learn04Model(IOptions<AdminSettings> adminSettingsOptions,
		IOptions<MyAdminSettings> myAdminSettingsOptions) : base()
	{
		AdminSettings = adminSettingsOptions.Value;
		MyAdminSettings = myAdminSettingsOptions.Value;
	}

	public AdminSettings AdminSettings { get; init; }
	public MyAdminSettings MyAdminSettings { get; init; }

	public void OnGet()
	{
	}
}
