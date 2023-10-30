using TaskAppMaui8.Pages;

namespace TaskAppMaui8;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(AddItemPage), typeof(AddItemPage));
	}
}