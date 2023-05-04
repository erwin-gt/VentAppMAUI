using SaleMAUI.Models;
using SaleMAUI.Pages.Usuario;
using SaleMAUI.Services;
using SaleMAUI.Services.Class;

namespace SaleMAUI;

public partial class LoginPage : ContentPage
{
    readonly ILoginRepositorio _loginRep = new LoginService();
	public LoginPage()
	{
		InitializeComponent();
	}

    private void Frame_Unfocused(object sender, FocusEventArgs e)
    {

    }

    private async void TapGestureRecognizer_Tapped_For_Registrarse(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//Registrarse");
    }

    //Evento de presionar ingresar luego de ingresar los datos
    private async void Button_Clicked(object sender, EventArgs e)
    {
        string correo = txtEmail.Text;
        string contra = txtContra.Text;
        //Validacion que se hayan ingresado los datos correctamente y que no esten en blanco
        if (correo == null || contra == null)
        {
            await DisplayAlert("Atencion", "Por favor ingrese los datos","OK");
            return;
        }
        UsuarioDatos usuarioDatos = await _loginRep.Login(correo, contra);
        if(usuarioDatos != null)
        {
            await Navigation.PushAsync(new HomePage());
            txtContra.Text = "";
            txtEmail.Text = "";

        }
        else
        {
            await DisplayAlert("Atencion", "Correo o Contraseña son Incorrectos", "OK");
            txtContra.Text = "";
            txtEmail.Text = "";
        }

    }
}