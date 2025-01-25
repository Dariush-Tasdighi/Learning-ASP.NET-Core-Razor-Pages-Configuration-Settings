using Infrastructure.Settings;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Server.Pages;

public class Learn05Model : PageModel
{
	public Learn05Model(IOptions<ApplicationSettings> applicationSettingsOptions) : base()
	{
		ApplicationSettings = applicationSettingsOptions.Value;
	}

	public ApplicationSettings ApplicationSettings { get; init; }

	public void OnGet()
	{
	}
}
