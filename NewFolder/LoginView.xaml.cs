namespace firstMaui.NewFolder;

public partial class LoginView : ContentPage
{
	public LoginView()
	{
		InitializeComponent();
	}

    private void button1_Clicked(object sender, EventArgs e)
    {
        DisplayAlert("Message", "You have successfully logged in", "OK");
        
    }

    private void btnFgtPass_Clicked(object sender, EventArgs e)
    {

    }

    private void button2_Clicked(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new Register());
    }
}