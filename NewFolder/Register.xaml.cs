namespace firstMaui.NewFolder;

public partial class Register : ContentPage
{
	public Register()
	{
		InitializeComponent();
	}

    private void login_Clicked(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new LoginView());
    }
}