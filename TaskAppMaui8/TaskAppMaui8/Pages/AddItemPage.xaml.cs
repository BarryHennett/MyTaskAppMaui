using TaskAppMaui8.ViewModels;

namespace TaskAppMaui8.Pages;

public partial class AddItemPage : ContentPage
{
	public AddItemPage(AddTaskViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}