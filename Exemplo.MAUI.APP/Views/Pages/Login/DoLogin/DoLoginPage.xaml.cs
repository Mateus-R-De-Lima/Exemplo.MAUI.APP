using System.Threading.Tasks;

namespace Exemplo.MAUI.APP.Views.Pages.Login.DoLogin;

public partial class DoLoginPage : ContentPage
{
	public DoLoginPage()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {

		await Shell.Current.GoToAsync("../..");
    }

  
}