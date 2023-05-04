namespace SaleMAUI;

public partial class Registrarse : ContentPage
{
	public Registrarse()
	{
		InitializeComponent();
	}

    private async void TapGestureRecognizer_Tapped_For_Login(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//Login");
    }
}