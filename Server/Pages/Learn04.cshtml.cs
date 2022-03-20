namespace Server.Pages
{
	public class Learn04Model :
		Microsoft.AspNetCore.Mvc.RazorPages.PageModel
	{
		public Learn04Model
			(Microsoft.Extensions.Options
			.IOptions<Infrastructure.Settings.AdminSettings> adminSettingOptions,
			Microsoft.Extensions.Options
			.IOptions<Infrastructure.Settings.MyAdminSettings> myAdminSettingOptions) : base()
		{
			AdminSettings =
				adminSettingOptions.Value;

			MyAdminSettings =
				myAdminSettingOptions.Value;
		}

		public Infrastructure.Settings.AdminSettings AdminSettings { get; }

		public Infrastructure.Settings.MyAdminSettings MyAdminSettings { get; }

		public void OnGet()
		{
		}
	}
}
