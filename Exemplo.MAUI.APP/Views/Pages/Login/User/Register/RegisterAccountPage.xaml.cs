using Exemplo.MAUI.APP.ViewModels.Pages.Login.User.Register;

namespace Exemplo.MAUI.APP.Views.Pages.Login.User.Register;

public partial class RegisterAccountPage : ContentPage
{
	public RegisterAccountPage()
	{
		InitializeComponent();

		BindingContext = new RegisterAccountViewModel();
	}

}