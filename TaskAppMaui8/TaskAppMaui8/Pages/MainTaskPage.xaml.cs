namespace TaskAppMaui8.Pages;

public partial class MainTaskPage : ContentPage
{
	public MainTaskPage()
	{
		InitializeComponent();
	}

    private void Adding_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new AddItemPage());
    }
}